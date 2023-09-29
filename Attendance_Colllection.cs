#pragma warning disable IDE0005 // Using directive is unnecessary.
using Attendance_System;
#pragma warning restore IDE0005 // Using directive is unnecessary.
namespace Attendance_System
{
    public class Attendance_Colllection
	{
		private List<Attendance> collection;
		public Attendance_Colllection(List<Attendance> l)
		{
			this.collection = l;
		}
		public  TimeSpan CalculateTotal()
		{
			TimeSpan result = new TimeSpan();
			for(int i = 0; i < collection.Capacity; i++)
			{
				result += collection[i].CalculateTimeDifference();
			}
			return result;
		}

	}
}

