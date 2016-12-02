using System;
using System.Collections.Generic;
using HelloWorld.ViewModels;
using Xamarin.Forms;

namespace HelloWorld.Views
{
	public partial class TaskPage : ContentPage
	{
		public TaskPage()
		{
			InitializeComponent();
			BindingContext = new TaskViewModel();
		}
	}
}
