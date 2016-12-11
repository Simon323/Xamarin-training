using System;
using System.Threading.Tasks;
using HelloWorld.ViewModels.Services;

namespace HelloWorld.Views.Services
{
	public class MessageService : IMessageService
	{
		public MessageService()
		{
		}

		public async Task ShowAsync(string message)
		{
			await HelloWorld.App.Current.MainPage.DisplayAlert("MVVM", message, "ok");
		}
	}
}
