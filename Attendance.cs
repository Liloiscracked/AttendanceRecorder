#pragma warning disable IDE0005 // Using directive is unnecessary.
using System;
#pragma warning restore IDE0005 // Using directive is unnecessary.
namespace Attendance_System
{
	public class Attendance
	{
		private string Tin;
		private string Tout;
		private string date;

		public Attendance(string Tin , string Tout,string date)
		{
			this.date = date;
			this.Tin = Tin;
			this.Tout = Tout;
		}
		public string getTimeIn()
        {
            return Tin;
        }
        public string getTimeOut()
        {
            return Tout;
        }
        public string getDate()
        {
            return date;
        }

        public  TimeSpan CalculateTimeDifference()
        {
            if (Tin.Equals("-") || Tout.Equals("-"))
            {
                return new TimeSpan();
            }
            TimeSpan endTime = TimeSpan.Parse(Tout);
            TimeSpan startTime = TimeSpan.Parse(Tin);
            // Calculate the time difference
            TimeSpan timeDifference = endTime - startTime;
             return timeDifference;
            
           
        }
    }
}

