using System;

namespace XamlBug.Controls
{
	public class TimeSpanControl : BaseControl<TimeSpan>
	{
		public TimeSpanControl() : base(DateTime.Now.TimeOfDay) { }
	}
}
