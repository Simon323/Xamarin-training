using System;
using System.Collections.Generic;
using HelloWorld.Models;
using Xamarin.Forms;

namespace HelloWorld.Views
{
	public partial class ListViewPage : ContentPage
	{
		public ListViewPage()
		{
			InitializeComponent();

			MainListView.ItemsSource = new List<Person>
			{
				new Person {
					Age = 23,
					Name = "Harrison Wells"
				},
				new Person() {
					Name = "Barry Allen",
					Age = 30
				},
				new Person {
					Name = "Martin",
					Age = 54
				}
			};
		}
	}
}
