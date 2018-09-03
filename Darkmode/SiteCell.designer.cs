// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Darkmode
{
    [Register ("SiteCell")]
    partial class SiteCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel SiteLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISwitch SiteSwitch { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel StatusLabel { get; set; }

        [Action ("ChangeSiteState:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void ChangeSiteState (UIKit.UISwitch sender);

        void ReleaseDesignerOutlets ()
        {
            if (SiteLabel != null) {
                SiteLabel.Dispose ();
                SiteLabel = null;
            }

            if (SiteSwitch != null) {
                SiteSwitch.Dispose ();
                SiteSwitch = null;
            }

            if (StatusLabel != null) {
                StatusLabel.Dispose ();
                StatusLabel = null;
            }
        }
    }
}