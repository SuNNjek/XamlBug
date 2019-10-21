using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace XamlBug
{
	// Learn more about making custom code visible in the Xamarin.Forms previewer
	// by visiting https://aka.ms/xamarinforms-previewer
	[DesignTimeVisible(false)]
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		private void DateTimeControl_ButtonPressed(object sender, Controls.ButtonPressedEventArgs<DateTime> e)
		{
			Console.WriteLine("Hello from DateTime control");
		}

		private void TimeSpanControl_ButtonPressed(object sender, Controls.ButtonPressedEventArgs<TimeSpan> e)
		{
			Console.WriteLine("Hello from TimeSpan control");
		}
	}
}
