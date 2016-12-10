using System;

using Xamarin.Forms;

namespace HelloWorld
{
	public class OrdersPage : ContentPage
	{
		public OrdersPage()
		{
			Content = new StackLayout
			{
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
		}
	}
}

