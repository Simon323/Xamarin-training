using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using HelloWorld.Models;
using Xamarin.Forms;

namespace HelloWorld.ViewModels
{
	public class TaskViewModel : INotifyPropertyChanged
	{
		private TaskModel _task;
		private string _message;

		public TaskModel Task
		{
			get
			{
				return _task;
			}

			set
			{
				_task = value;
				OnPropertyChanged();
			}
		}

		public string Message
		{
			get
			{
				return _message;
			}

			set
			{
				_message = value;
				OnPropertyChanged();
			}
		}

		public TaskViewModel()
		{
			Task = new TaskModel
			{
				Title = "Creating UI",
				Duration = 2
			};
			Message = "Panta rej";
		}

		public Command SaveCommand
		{
			get
			{
				return new Command(() =>
				{
					Message = String.Concat("Yout task ", Task.Title, " ,", Task.Duration, " was successfully saved !");  
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
