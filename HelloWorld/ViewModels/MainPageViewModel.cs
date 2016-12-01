using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace HelloWorld.ViewModels
{
	public class MainPageViewModel : INotifyPropertyChanged
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

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
