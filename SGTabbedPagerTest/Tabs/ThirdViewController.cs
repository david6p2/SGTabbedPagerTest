using Foundation;
using System;
using UIKit;
using System.Collections.Generic;

namespace SGTabbedPagerTest
{
    public partial class ThirdViewController : UIViewController
    {
		
		private ProfilePagerTabVC profilePagerTabViewController;
		public static UIStoryboard storyboard = UIStoryboard.FromName("Main", null);

		public ThirdViewController (IntPtr handle) : base (handle)
        {
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void PrepareForSegue(UIStoryboardSegue segue, Foundation.NSObject sender)
		{
			if (segue.Identifier == "ContainerViewSegue")
			{
				var aboutTableViewController = storyboard.InstantiateViewController("AboutTableViewController") as AboutTableViewController;
				var colleaguesViewController = storyboard.InstantiateViewController("ColleaguesViewController") as ColleaguesViewController;
				var availabilityViewController = storyboard.InstantiateViewController("AvailabilityViewController") as AvailabilityViewController;

				var pages = new List<UIViewController> {
					aboutTableViewController,
					colleaguesViewController,
					availabilityViewController
				};
				profilePagerTabViewController = (ProfilePagerTabVC)segue.DestinationViewController;
				profilePagerTabViewController.Pages = pages;
			}
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void ViewWillAppear(bool animated)
		{
			base.ViewWillAppear(animated);
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
    }
}