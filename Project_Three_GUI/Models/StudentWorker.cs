using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Three_GUI.Models
{
    class StudentWorker : Resident
	{
		public double HRLY_WAGE = 14;
		public static int HrsWorked { get; set; }
		public static double Earnings = 14 * HrsWorked;
		public double BoardingFee = 1245 - Earnings;
		//public int Earnings { get; set; }

		//Note here how we still have to add name & email which are inherited from resident
		public StudentWorker(int ID, string name, string type, int fee, int floor, int hrs, int earnings)
		{
			StudentID = ID;
			Name = name;
			Type = type;
			BoardingFee = fee;
			Floor = floor;
			HrsWorked = hrs;
			Earnings = earnings;
		}

		//Overloaded student method (polymorphism)
		public StudentWorker(int ID, string name, int fee, int floor)
		{
			StudentID = ID;
			Name = name;
			BoardingFee = fee;
			Floor = floor;

		}

		public void rentCalc(int hrsWorked)
		{
			int earnings = hrsWorked * 14;
			var rent = 1245 - earnings;

			
		}


	}
}
