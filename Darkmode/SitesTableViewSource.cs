using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using UIKit;

namespace Darkmode
{
    internal class SitesTableViewSource : UITableViewSource
    {
        private static List<Site> Sites { get; } = new List<Site>();

        public SitesTableViewSource(List<Site> sites)
        {
            Sites.AddRange(sites);
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = (SiteCell)tableView.DequeueReusableCell("SiteCellView",indexPath);
            var site = Sites[indexPath.Row];
            cell.UpdateSite(site);
            return cell;
        }

        internal static void UpdateSites(string name, bool status)
        {
            Sites.Where(x => x.Equals(name)).All(x => x.Enabled = status);

        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return Sites.Count;
        }
    }
}