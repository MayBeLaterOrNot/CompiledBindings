﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using WPFTest.ViewModels;

#nullable enable

namespace WPFTest.Views
{
	partial class Page1
	{
		private Page1ViewModel _viewModel;

		private ListView listView;

		public string? Title { get; set; }
	}

	static partial class UIElementExtensions
	{
		public static void SetVisible(this UIElement element, bool isVisible) { }
	}

	public class InverseBooleanConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}