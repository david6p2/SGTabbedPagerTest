using DK.Ostebaronen.Touch.SGTabbedPager;
using ObjCRuntime;
using System;
using System.Collections.Generic;
using UIKit;

namespace SGTabbedPagerTest
{
	public partial class ProfilePagerTabVC : SGTabbedPager, ISGTabbedPagerDatasource
	{
		public static UIStoryboard storyboard = UIStoryboard.FromName("Main", null);

		public List<UIViewController> Pages;

		public ProfilePagerTabVC(List<UIViewController> PagesVCs)
		{
			if (Pages != null)
			{
				Pages = PagesVCs;
			}
		}

		public ProfilePagerTabVC(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			OnShowViewController += OnPageShowing;

			if (RespondsToSelector(new Selector("setEdgesForExtendedLayout:")))
				EdgesForExtendedLayout = UIRectEdge.None;

			View.BackgroundColor = UIColor.White;
			Datasource = this;
			TabColor = UIColor.Green;
			HeaderFont = UIFont.SystemFontOfSize(20);
			HeaderColor = UIColor.DarkGray;
			SelectedHeaderFont = UIFont.SystemFontOfSize(20);
			SelectedHeaderColor = UIColor.Black;
			IconSpacing = 20;
			BottomLineColor = UIColor.White;
		}

		public override void ViewWillAppear(bool animated)
		{
			base.ViewWillAppear(animated);
			//ReloadData():
		}

		public override void ViewDidUnload()
		{
			base.ViewDidUnload();
			OnShowViewController -= OnPageShowing;
		}

		public int NumberOfViewControllers => Pages.Count;

		public UIViewController GetViewController(int page)
		{
			return Pages[page];
		}

		public string GetViewControllerTitle(int page)
		{
			return Pages[page].Title;
		}

		private void OnPageShowing(object sender, int page)
		{
			Console.WriteLine($"Did show {page}");
		}

		private Random _rand = new Random();

		public UIImage GetViewControllerIcon(int page)
		{
			//var index = _rand.Next(0, 3);
			//return TitleImages[index];
			return null;
		}
	}
}