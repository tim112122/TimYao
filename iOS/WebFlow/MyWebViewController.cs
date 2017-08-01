using System;

using UIKit;
using Foundation;
using static System.Diagnostics.Debug;

namespace timyao.iOS.WebFlow
{
    public partial class MyWebViewController : UIViewController
    {
        public MyWebViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            btnGO.TouchUpInside += (sender, e) =>
            {
                var urlString = txtUrl.Text;

                myWebview.LoadRequest(
                    new NSUrlRequest(new NSUrl("https://www.google.com"))

                );

                if (txtUrl.IsFirstResponder)
                {
                    txtUrl.BecomeFirstResponder();

                    txtUrl.ResignFirstResponder();
                }
                btnGoBottomConstraint.Constant = 20;

                ShowAlert("Alert", "url", (UIAlertAction obj) => {
                    WriteLine("finish");
                });
            
            };

			UIKeyboard.Notifications.ObserveWillChangeFrame((sender, e) =>
			{

				var beginRect = e.FrameBegin;
				var endRect = e.FrameEnd;

				WriteLine($"ObserveWillChangeFrame endRect:{endRect.Height}");

				btnGoBottomConstraint.Constant = endRect.Height + 5;

			});



		}

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }


		public void ShowAlert(string title, string message, Action<UIAlertAction> action)
		{


			//Create Alert
			var confirmAlertController = UIAlertController.Create(title, message, UIAlertControllerStyle.Alert);

			//Add Actions
			confirmAlertController.AddAction(UIAlertAction.Create("Confirm", UIAlertActionStyle.Default, action));

			PresentViewController(confirmAlertController, true, null);

		}

    }
}

