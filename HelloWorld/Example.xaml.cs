using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HelloWorld
{
	public partial class Example : ContentPage
	{
		public Example()
		{
			InitializeComponent();
		}

		void Handle_Clicked(object sender, System.EventArgs e)
		{
			string text = MainEntry.Text;
			MainLabel.Text = "Hello" + text;
		}
	}
}
