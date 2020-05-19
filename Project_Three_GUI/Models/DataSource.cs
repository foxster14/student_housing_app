using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Project_Three_GUI.Models
{
	class DataSource
	{
		//Global Declarations 
		const string PATH = @"C:\Users\foxsarh\Desktop\Residents.csv";

		//Reading in the file
		FileStream infile;
		StreamReader read;

		//Writing out to the file
		//FileStream outFile;
		//StreamWriter writer;
		List<Student> StudentList; //Global

		public ObservableCollection<Student> readData()
		{
			string primer;
			string[] studentData;
			ObservableCollection<Student> StudentList = null; //Local
			try
			{
				infile = new FileStream(PATH, FileMode.Open, FileAccess.Read);
				read = new StreamReader(infile);
				primer = read.ReadLine(); //primer
				StudentList = new ObservableCollection<Student>();

				//Looping structure that's going to read in all of my records
				while (!read.EndOfStream)
				{
					//Read in the records and create generic student object instances
					studentData = read.ReadLine().Split(',');
					StudentList.Add(new Student(Convert.ToInt32(studentData[0]), studentData[1], studentData[2], Convert.ToInt32(studentData[3]), Convert.ToInt32(studentData[4]), Convert.ToInt32(studentData[5]), Convert.ToInt32(studentData[6]), Convert.ToInt32(studentData[7])));
					Console.WriteLine(StudentList[StudentList.Count - 1]);

				}

				//Close the file
				read.Dispose();
				infile.Dispose();

			}
			//Exception handling
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}

			//This method needs to return something, it will return the list of Student objects
			return StudentList;

		}//End of readData() method

		public void writeData(List<Student> data, string determinant)
		{
			FileStream outFile = new FileStream(PATH, FileMode.Create, FileAccess.Write);
			StreamWriter writer = new StreamWriter(outFile);

			///// MAY NEED TO DELETE THIS LOGIC... DEPENDS....
			if (determinant == "workers")
			{
				foreach (Student x in data)
				{
					//writer.WriteLine(x.outputWinner());
				}
			}

			//Write out the heading
			writer.WriteLine("Student ID,Name,Student Type,Boarding Fee,Floor Number,Hourly Wage,Monthly Hrs Worked,Monthly Wage");

			foreach (Student x in data)
			{
				//Write out each record
				writer.WriteLine($"{x.StudentID},{x.Name},{x.Type},{x.BoardingFee.ToString()},{x.Floor.ToString()},{x.HrlyWage.ToString()},{x.HrsWorked.ToString()},{x.Earnings.ToString()}");
				writer.WriteLine(ToString());
			}

			//Close the files
			writer.Dispose();
			outFile.Dispose();
		}
	}
}

