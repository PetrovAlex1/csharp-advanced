

namespace CarManufacturer
{
	public class Tire
	{
		public Tire(int year, double presure)
		{
			this.Year = year;
			this.Presure = presure;
		}

		private int year;
		private double presure;

		public int Year
		{
			get
			{
				return this.year;
			}
			set
			{
				this.year = value;
			}
		}

		public double Presure
		{
			get
			{
				return this.presure;
			}
			set
			{
				this.presure = value;
			}
		}
	}
}
