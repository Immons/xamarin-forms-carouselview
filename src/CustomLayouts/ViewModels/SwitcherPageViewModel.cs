using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace CustomLayouts.ViewModels
{
	public class SwitcherPageViewModel : BaseViewModel
	{
		public SwitcherPageViewModel()
		{
			Pages = new List<HomeViewModel>() {
				new HomeViewModel { Title = "1", BackgroundImage = ImageSource.FromFile("icon.png"), ImageSource = "icon.png" },
				new HomeViewModel { Title = "2", BackgroundImage = ImageSource.FromFile("icon.png"), ImageSource = "icon.png" },
				new HomeViewModel { Title = "3", BackgroundImage = ImageSource.FromFile("icon.png"), ImageSource = "icon.png" },
				new HomeViewModel { Title = "4", BackgroundImage = ImageSource.FromFile("icon.png"), ImageSource = "icon.png" },
			};

			CurrentPage = Pages.First();
		}

		IEnumerable<HomeViewModel> _pages;
		public IEnumerable<HomeViewModel> Pages {
			get {
				return _pages;
			}
			set {
				SetObservableProperty (ref _pages, value);
				CurrentPage = Pages.FirstOrDefault ();
			}
		}

		HomeViewModel _currentPage;
		public HomeViewModel CurrentPage {
			get {
				return _currentPage;
			}
			set {
				SetObservableProperty (ref _currentPage, value);
			}
		}
	}

	public class HomeViewModel : BaseViewModel, ITabProvider
	{
		public HomeViewModel() {}

		public string Title { get; set; }
		public ImageSource BackgroundImage { get; set; }
		public string ImageSource { get; set; }
	}
}

