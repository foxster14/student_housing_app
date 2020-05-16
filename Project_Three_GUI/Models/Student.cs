using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Three_GUI.Models
{
    class Student : Resident
    {
        public int HourlyWage { get; set; }
        public int HoursWorked { get; set; }
        public int Wage { get; set; }

    }

	//Note here how we still have to add name & email which are inherited from resident
	public Student(int ID, string name, int fee, int floor, int wage, int hrs, int wage)
	{
		StudentID = ID;
		Name = name;
		BoardingFee = fee;
		FloorNumber = floor;
		HourlyWage = wage;
		HoursWorked = hrs;
		Wage = wage;
	}
}
