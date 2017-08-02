// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace timyao.iOS
{
    [Register ("MyTableViewCell")]
    partial class MyTableViewCell
    {
        [Outlet]
        UIKit.UILabel lbDescription { get; set; }


        [Outlet]
        UIKit.UILabel lbName { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (lbDescription != null) {
                lbDescription.Dispose ();
                lbDescription = null;
            }

            if (lbName != null) {
                lbName.Dispose ();
                lbName = null;
            }
        }
    }
}