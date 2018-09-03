using Foundation;
using System;
using UIKit;

namespace Darkmode
{
    public partial class SiteCell : UITableViewCell
    {


        public SiteCell (IntPtr handle) : base (handle)
        {
            
        }

        internal void UpdateSite(Site site)
        {
            SiteLabel.Text = site.Name;
            StatusLabel.Text = site.Enabled.ToString();
            SiteSwitch.On = site.Enabled;
        }
        partial void ChangeSiteState(UISwitch sender)
        {
            SitesTableViewSource.UpdateSites(SiteLabel.Text, sender.Enabled);
            StatusLabel.Text = sender.On.ToString();
        }
    }
}