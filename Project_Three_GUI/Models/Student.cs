using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Three_GUI.Models
{
    class Student : Resident
    {
		public int BoardingFee { get; set; }
		public int Floor { get; set; }
		public int HrlyWage { get; set; }
        public int HrsWorked { get; set; }
        public int Earnings { get; set; }

		//Note here how we still have to add name & email which are inherited from resident
		public Student(int ID, string name, string type, int fee, int floor, int hrlywage, int hrs, int earnings)
		{
			StudentID = ID;
			Name = name;
			Type = type;
			BoardingFee = fee;
			Floor = floor;
			HrlyWage = hrlywage;
			HrsWorked = hrs;
			Earnings = earnings;
		}

		//Overloaded student method (polymorphism_
		public Student(int ID, string name, int fee, int floor)
		{
			StudentID = ID;
			Name = name;
			BoardingFee = fee;
			Floor = floor;
			
		}

		public override string ToString()
		{
			return String.Format($"{StudentID},{Name},{Type},{BoardingFee},{Floor},{HrlyWage},{HrsWorked},{Earnings}");
		}
	}
}
