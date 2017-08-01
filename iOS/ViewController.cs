using System;

using UIKit;
using static System.Diagnostics.Debug;
using System.Threading.Tasks;
using System.Net;

namespace timyao.iOS
{
    public partial class ViewController : UIViewController
    {


        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

			// Event
			var workerEvent = new EventWebWorker();

			workerEvent.HtmlStringReceived += async (object sender, HtmlReceivedEventArgs e) =>
			{
				WriteLine($"event html:{ e.Html }");

				await Task.Delay(2000);

				await Task.Run(() => { MoveToNextView(); });

			};

			workerEvent.DownloadHtmlStringWithEvent("https://www.stackoverflow.com");
        }

        private async Task MoveToNextView(){

            InvokeOnMainThread(() =>
            {
                this.PerformSegue("moveToMasterViewSegue", this);
            });

        }

        public override void PrepareForSegue(UIStoryboardSegue segue, Foundation.NSObject sender)
        {
            base.PrepareForSegue(segue, sender);

            switch( segue.Identifier ){

                case "moveToMasterViewSegue" :{

                        if (segue.DestinationViewController is MasterViewController)
                        {

                            var next = segue.DestinationViewController as MasterViewController;
                            next.HelloMessage = "message from ViewController.";

                        }
                    }
                    break;
                default:{
                    }
                    break;
            }



        }


        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.     
        }

        public class EventWebWorker
        {
            private WebClient MyWebClient { get; set; }

            public EventWebWorker()
            {
                MyWebClient = new WebClient();
            }

            public void DownloadHtmlStringWithEvent(string url)
            {
                var html = MyWebClient.DownloadString(url);

                EventHandler<HtmlReceivedEventArgs> handler = HtmlStringReceived;
                var args = new HtmlReceivedEventArgs { Html = html };
                if (null != handler)
                {
                    handler(this, args);
                }
            }
            public event EventHandler<HtmlReceivedEventArgs> HtmlStringReceived;
        }
        public class HtmlReceivedEventArgs : EventArgs
        {
            public string Html { get; set; }
        }


    }
}
