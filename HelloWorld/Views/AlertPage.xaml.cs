using System;
using System.Collections.Generic;
using Acr.UserDialogs;
using HelloWorld.ViewModels;
using Xamarin.Forms;

namespace HelloWorld.Views
{
	public partial class AlertPage : ContentPage
	{
		public AlertPage()
		{
			InitializeComponent();
			BindingContext = new AlertPageViewModel();
		}
	}
}
