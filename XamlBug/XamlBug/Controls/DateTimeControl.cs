using System;

namespace XamlBug.Controls
{
	public class DateTimeControl : BaseControl<DateTime>
	{
		public DateTimeControl() : base(DateTime.Now) { }
	}
}
