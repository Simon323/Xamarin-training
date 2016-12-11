using System;
using System.Threading.Tasks;

namespace HelloWorld.ViewModels.Services
{
	public interface IMessageService
	{
		Task ShowAsync(string message);
	}
}
