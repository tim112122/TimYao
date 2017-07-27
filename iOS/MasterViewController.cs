using System;

using UIKit;

namespace timyao.iOS
{
    public partial class MasterViewController : UIViewController
    {

        public string HelloMessage { get; internal set; }


        public MasterViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            this.lbMessage.Text = HelloMessage;
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

