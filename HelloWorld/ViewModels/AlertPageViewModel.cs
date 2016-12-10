using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Acr.UserDialogs;
using Xamarin.Forms;

namespace HelloWorld.ViewModels
{
	public class AlertPageViewModel : INotifyPropertyChanged
	{
		private string _name;

		public AlertPageViewModel()
		{
			Name = "Jay Garrick";
		}

		public string Name
		{
			get
			{
				return _name;
			}

			set
			{
				_name = value;
				OnPropertyChanged();
			}
		}

		public Command ShowAlert
		{
			get
			{
				return new Command(() =>
				{
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
