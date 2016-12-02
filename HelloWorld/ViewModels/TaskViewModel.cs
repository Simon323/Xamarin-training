using System;
using HelloWorld.Models;

namespace HelloWorld.ViewModels
{
	public class TaskViewModel
	{
		public TaskModel Task { get; set; }

		public TaskViewModel()
		{
			Task = new TaskModel
			{
				Title = "Creating UI",
				Duration = 2
			};
		}
	}
}
