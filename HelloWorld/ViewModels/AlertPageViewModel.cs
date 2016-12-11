using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Acr.UserDialogs;
using HelloWorld.ViewModels.Services;
using Xamarin.Forms;

namespace HelloWorld.ViewModels
{
	public class AlertPageViewModel : BaseViewModel
	{
		private string _name;
		private readonly IMessageService _messageService;

		public string Name
		{
			get
			{
				return _name;
			}

			set
			{
				_name = value;
				OnPropertyChanged("Name");
			}
		}

		public ICommand ShowAlertCommand { get; set; }

	

		public AlertPageViewModel()
		{
			Name = "Jay Garrick";
			ShowAlertCommand = new Command(ShowAlert);
			_messageService = DependencyService.Get<IMessageService>();
		}

		private void ShowAlert()
		{
			_messageService.ShowAsync("to jest super fajne");
		}
	}
}
