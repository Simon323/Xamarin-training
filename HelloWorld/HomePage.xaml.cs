using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HelloWorld
{
	public partial class HomePage : ContentPage
	{
		public HomePage()
		{
			InitializeComponent();
		}

		void Handle_Clicked(object sender, System.EventArgs e)
		{
			string text = MainEntry.Text;
			MainLabel.Text = "Hello " + text;
		}

		async void NavigationButton_Clicked(object sender, System.EventArgs e)
		{
			await Navigation.PushAsync(new FirstPage(MainEntry.Text));
		}
	}
}
