using System.Xml.Linq;

namespace Attendance_System
{
	public class Employee 
	{
		private int ID;
		private List<Attendance> attendances = new List<Attendance>();
		public Employee(int ID)
		{
			this.ID = ID;
		}
		public int getID()
		{
			return this.ID;
		}
		public void AddAtt(string tin , string tout , string date)
		{
			attendances.Add(new Attendance(tin,tout,date));
		}
		public List<Attendance> GetAttendances()
		{
			return this.attendances;
		}
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Employee other = (Employee)obj;
            return this.ID == other.ID;
        }
        public TimeSpan getTotalHours()
		{
			Attendance_Colllection record = new Attendance_Colllection(attendances);
			return record.CalculateTotal();
		}
        public override int GetHashCode()
        {
            // Combine hash codes of individual properties
            return ID.GetHashCode();
        }
    }
}
