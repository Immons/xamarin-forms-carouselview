using System;
using Xamarin.Forms;

namespace CustomLayouts
{
	public class HomeView : ContentView
	{
        public static readonly BindableProperty BackgroundImageProperty = BindableProperty.Create<HomeView, ImageSource>(p => p.BackgroundImage, string.Empty);

	    public HomeView()
		{
			BackgroundColor = Color.White;

	        var backgroundImage = new Image {WidthRequest = this.ParentView.Width, HeightRequest = this.ParentView.Height};
            backgroundImage.SetBinding(BackgroundImageProperty, "BackgroundImage");

			Content = new StackLayout {
				VerticalOptions = LayoutOptions.CenterAndExpand,
				Children = {
					backgroundImage
				}
			};
		}

        public ImageSource BackgroundImage
	    {
	        get { return (string)GetValue(BackgroundImageProperty); }
            set { SetValue(BackgroundImageProperty, value); }
	    }
	}
}

