using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Three_GUI.Models
{
    class Athlete : Resident
    {
		public int BoardingFee { get; set; } = 1200;


		//Note here how we still have to add ID, name, floor & room which are inherited from Resident
		public Athlete(int ID, string name, string type, int fee, int floor, int room)
		{
			StudentID = ID;
			Name = name;
			BoardingFee = fee;
			Floor = floor;
			Room = room;

		}


	}
}
