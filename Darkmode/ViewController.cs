using System;
using System.Collections.Generic;
using SafariServices;
using UIKit;

namespace Darkmode
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            var sites = new List<Site>(){
                new Site(){
                    Name = "Test 1",
                    Enabled = true
                },
                new Site(){
                    Name = "Test 2",
                    Enabled = false
                },
            };
        SitesTableView.Source = new SitesTableViewSource(sites);
        }

        private SFAuthenticationError test = new SFAuthenticationError();

        
        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
