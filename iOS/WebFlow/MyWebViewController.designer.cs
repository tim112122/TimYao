// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace timyao.iOS.WebFlow
{
	[Register ("MyWebViewController")]
	partial class MyWebViewController
	{
		[Outlet]
		UIKit.UIButton btnGO { get; set; }

		[Outlet]
		UIKit.NSLayoutConstraint btnGoBottomConstraint { get; set; }

		[Outlet]
		UIKit.UIWebView myWebview { get; set; }

		[Outlet]
		UIKit.UITextField txtUrl { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (btnGoBottomConstraint != null) {
				btnGoBottomConstraint.Dispose ();
				btnGoBottomConstraint = null;
			}

			if (btnGO != null) {
				btnGO.Dispose ();
				btnGO = null;
			}

			if (myWebview != null) {
				myWebview.Dispose ();
				myWebview = null;
			}

			if (txtUrl != null) {
				txtUrl.Dispose ();
				txtUrl = null;
			}
		}
	}
}
