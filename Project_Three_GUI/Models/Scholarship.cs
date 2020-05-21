using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Three_GUI.Models
{
    class Scholarship : Resident
    {
		public int BoardingFee { get; set; } = 100;
		

		//Note here how we still have to add name & email which are inherited from resident
		public Scholarship(int ID, string name, string type, int fee, int floor, int room)
		{
			StudentID = ID;
			Name = name;
			Type = type;
			BoardingFee = fee;
			Floor = floor;
			Room = room;
			
			/*
			void ScholarshipFloorNum (int determinent)
			{
				if (determinent == 7)
				{
					Floor = 7;
				}
				else if (determinent == 8)
				{
					Floor = 8;
				}
				else
				{
					Console.WriteLine("Error Message");
					Floor = 7; //This will be our default value
				}
			}//end of method
			*/
		
		}//end of scholarship class

		public override string ToString()
		{
			return String.Format($"{StudentID},{Name},{Type},{BoardingFee},{Floor}");
		}
	}
}
