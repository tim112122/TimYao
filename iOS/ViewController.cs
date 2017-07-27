using System;

using UIKit;

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

            // Perform any additional setup after loading the view, typically from a nib.
            Button.AccessibilityIdentifier = "myButton";
            Button.TouchUpInside += delegate
            {
                //

                this.PerformSegue("moveToMasterViewSegue", this);

            };
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.		
        }


        public override void PrepareForSegue(UIStoryboardSegue segue, Foundation.NSObject sender)
        {
            base.PrepareForSegue(segue, sender);

            switch(segue.Identifier){
                case "moveToMasterViewSegue" :{
                        if(  segue.DestinationViewController is MasterViewController){

                            var next = segue.DestinationViewController as MasterViewController;

                            next.HelloMessage = "Hello message from ViewController";
                                
                        }
                    }
                    break;

                default:{
                        
                    }
                    break;
            }

        }

    }
}
