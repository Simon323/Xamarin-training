﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HelloWorld.Views
{
	public partial class FirstPage : ContentPage
	{
		public FirstPage(string param)
		{
			InitializeComponent();
			MainLabel.Text = param;
		}
	}
}
