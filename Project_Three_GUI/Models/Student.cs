using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Three_GUI.Models
{
    class Student : Resident
    {
		public double BoardingFee { get; set; }
		public int HrlyWage { get; set; }
        public int HrsWorked { get; set; }
        public int Earnings { get; set; }

		//Note here how we still have to add name & email which are inherited from resident
		public Student(int ID, string name, string type, double fee, int floor, int room, int hrlywage, int hrs, int earnings)
		{
			StudentID = ID;
			Name = name;
			Type = type;
			BoardingFee = fee;
			Floor = floor;
			Room = room;
			HrlyWage = hrlywage;
			HrsWorked = hrs;
			Earnings = earnings;
		}

		//Overloaded student method (polymorphism_
		public Student(int ID, string name, string type, int fee, int floor, int room)
		{
			StudentID = ID;
			Name = name;
			Type = type;
			BoardingFee = fee;
			Floor = floor;
			Room = room;
			
		}

		public override string ToString()
		{
			return String.Format($"{StudentID},{Name},{Type},{BoardingFee},{Floor},{HrlyWage},{HrsWorked},{Earnings}");
		}
	}
}
