﻿using System;
using System.Globalization;
using Xamarin.Forms;

namespace HelloWorld.Converters
{
	public class TextToColorConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (value != null)
			{
				var text = value.ToString();

				if (text.Contains("UI"))
				{
					return Color.Fuchsia;
				}
			}

			return Color.White;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
