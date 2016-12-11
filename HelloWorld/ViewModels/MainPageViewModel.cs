using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace HelloWorld.ViewModels
{
	public class MainPageViewModel : BaseViewModel
	{
		private string _helloMessage;
		public string Name { get; set; }

		public string HelloMessage { 
			get 
			{
				return _helloMessage;
			} 
			set 
			{
				_helloMessage = value;
				OnPropertyChanged();
			} 
		}

		public Command SayHelloCommand { 
			get
			{
				return new Command(() =>
				{
					HelloMessage = String.Concat("Hello ", Name);
				});
			}
		}
	}
}
