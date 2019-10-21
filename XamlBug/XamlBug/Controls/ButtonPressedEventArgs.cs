namespace XamlBug.Controls
{
	public class ButtonPressedEventArgs<T>
	{
		public T Value { get; }

		public ButtonPressedEventArgs(T value)
		{
			Value = value;
		}
	}
}
