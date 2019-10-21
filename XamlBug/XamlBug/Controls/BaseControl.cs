using System;
using Xamarin.Forms;

namespace XamlBug.Controls
{
	public abstract class BaseControl<T> : StackLayout
	{
		Label _lblText;
		Button _btnTest;

		T _value;

		public event EventHandler<ButtonPressedEventArgs<T>> ButtonPressed;

		protected BaseControl(T value)
		{
			_value = value;

			_lblText = new Label
			{
				Text = "Hello Xaml bug"
			};

			_btnTest = new Button
			{
				Text = "Fire event"
			};

			_btnTest.Clicked += _btnTest_Clicked;

			Children.Add(_lblText);
			Children.Add(_btnTest);
		}

		private void _btnTest_Clicked(object sender, EventArgs e)
		{
			ButtonPressed?.Invoke(this, new ButtonPressedEventArgs<T>(_value));
		}
	}
}
