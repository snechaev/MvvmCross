// WARNING
//
// This file has been generated automatically by Rider IDE
//   to store outlets and actions made in Xcode.
// If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Playground.Mac
{
	[Register ("WindowView")]
	partial class WindowView
	{
		[Outlet]
		AppKit.NSButton btnClose { get; set; }

		[Outlet]
		AppKit.NSButton gcButton { get; set; }

		[Outlet]
		AppKit.NSButton testButton { get; set; }

		[Action ("TestButtonAction:")]
		partial void TestButtonAction (Foundation.NSObject sender);

        [Action ("GCAction:")]
        partial void GCAction (Foundation.NSObject sender);

        void ReleaseDesignerOutlets ()
		{
			if (btnClose != null) {
				btnClose.Dispose ();
				btnClose = null;
			}

			if (testButton != null) {
				testButton.Dispose ();
				testButton = null;
			}

			if (gcButton != null) {
				gcButton.Dispose ();
				gcButton = null;
			}

		}
	}
}
