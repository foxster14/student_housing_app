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
		ObservableCollection<Resident> StudentCollection { get; set; }

		public ObservableCollection<Resident> readData()
		{
			string primer;
			string[] studentData;
			ObservableCollection<Resident> StudentCollection = null; //Local
			//need to change this to resident
			try
			{
				infile = new FileStream(PATH, FileMode.Open, FileAccess.Read);
				read = new StreamReader(infile);
				primer = read.ReadLine(); //primer
				StudentCollection = new ObservableCollection<Resident>();

				//Looping structure that's going to read in all of my records
				while (!read.EndOfStream)
				{
					//Read in the records and create generic student object instances
					studentData = read.ReadLine().Split(',');
					
					//Add decision making logic to add specific students to worker, athelete & scholarship

					//StudentCollection.Add(new Student(Convert.ToInt32(studentData[0]), studentData[1], studentData[2], Convert.ToInt32(studentData[3]), Convert.ToInt32(studentData[4]), Convert.ToInt32(studentData[5]),Convert.ToInt32(studentData[6]), Convert.ToInt32(studentData[7]), Convert.ToInt32(studentData[8])));
					StudentCollection.Add(new Student(Convert.ToInt32(studentData[0]), studentData[1], studentData[2], Convert.ToInt32(studentData[3]), Convert.ToInt32(studentData[4]), Convert.ToInt32(studentData[5])));

					//Console.WriteLine(StudentCollection[StudentCollection.Count - 1]);

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
			return StudentCollection;

		}//End of readData() method

		public void writeData(ObservableCollection<Resident> data)
		{
			try
			{
				FileStream outFile = new FileStream(PATH, FileMode.Create, FileAccess.Write);
				StreamWriter writer = new StreamWriter(outFile);

				//Write out the heading
				writer.WriteLine("Student ID,Name,Student Type,Boarding Fee,Floor Number, Room Number");
				foreach (Student x in data) 
				{
					//Write out each record
					//writer.WriteLine($"{x.StudentID},{x.Name},{x.Type},{x.BoardingFee.ToString()},{x.Floor.ToString()},{x.Room.ToString()},{x.HrlyWage.ToString()},{x.HrsWorked.ToString()},{x.Earnings.ToString()}");
					writer.WriteLine($"{x.StudentID},{x.Name},{x.Type},{x.BoardingFee.ToString()},{x.Floor.ToString()},{x.Room.ToString()}");
					
				}

				//Close the files
				writer.Dispose();
				outFile.Dispose();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}//End of WriteData() Method
	}
}

