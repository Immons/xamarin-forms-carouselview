using System;
using Xamarin.Forms;
using CustomLayouts.ViewModels;
using System.Diagnostics;

namespace CustomLayouts
{
	public class HomeView : ContentView
	{
        public static readonly BindableProperty BackgroundImageProperty = BindableProperty.Create<HomeView, ImageSource>(p => p.BackgroundImage, null);
        private Image backgroundImage;

	    public HomeView()
		{
			BackgroundColor = Color.White;

            backgroundImage = new Image();
            this.SetBinding(BackgroundImageProperty, "BackgroundImage");

			Content = new StackLayout {
				VerticalOptions = LayoutOptions.CenterAndExpand,
				Children = {
					backgroundImage
				}
			};
		}

        public ImageSource BackgroundImage
	    {
            get { return (ImageSource)GetValue(BackgroundImageProperty); }
            set { SetValue(BackgroundImageProperty, value); backgroundImage.Source = value; }
	    }

        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);

            if (BindingContext != null)
            {
                BackgroundImage = ((HomeViewModel)BindingContext).BackgroundImage;
            }
        }
	}
}

