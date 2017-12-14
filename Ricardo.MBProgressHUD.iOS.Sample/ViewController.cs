using System;

using UIKit;

namespace Ricardo.RMBProgressHUD.iOS.Sample
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
            MBProgressHUD hud = MBProgressHUD.ShowHUD(View, true);

            hud.Label.Text = "Loading...";

            hud.Show(true);
            hud.Hide(true, 3.0f);
        }
    }
}
