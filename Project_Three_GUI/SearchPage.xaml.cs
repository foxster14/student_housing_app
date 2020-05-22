using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Project_Three_GUI.Models;


namespace Project_Three_GUI
{
    /// <summary>
    /// Interaction logic for SearchPage.xaml
    /// </summary>
    public partial class SearchPage : Window
    {
        //This brings in the datasource class which allows us to read and write data 
        DataSource source = new DataSource(); //we need to create an object instacne of data source
        ObservableCollection<Resident> studentList = null; //now any changes made to this list will be updated automatically due to the observable list
        Resident aStudent;

        public SearchPage()
        {
            InitializeComponent();
            this.DataContext = source.readData();
            student_grid.ItemsSource = source.readData();

            studentList = source.readData();

            try
            {
                var scholarshipCount = studentList.Where(x => x.Type.Contains("Scholarship"));
                scholarship_box.Text = scholarshipCount.Count().ToString();

                var athleteCount = studentList.Where(x => x.Type.Contains("Athlete"));
                athlete_box.Text = athleteCount.Count().ToString();

                var workerCount = studentList.Where(x => x.Type.Contains("Student Worker"));
                worker_box.Text = workerCount.Count().ToString();

                var floor1Count = studentList.Where(x => x.Floor.Equals(1) || x.Floor.Equals(2) || x.Floor.Equals(3));
                floor1_box.Text = floor1Count.Count().ToString();

                var floor2Count = studentList.Where(x => x.Floor.Equals(4) || x.Floor.Equals(5) || x.Floor.Equals(6));
                floor2_box.Text = floor2Count.Count().ToString();

                var floor3Count = studentList.Where(x => x.Floor.Equals(7) || x.Floor.Equals(8));
                floor3_box.Text = floor3Count.Count().ToString();

            }
            catch
            {

            }
        }

        private void selected_student(object sender, SelectionChangedEventArgs e)
        {

        }

        private void resident_btn(object sender, RoutedEventArgs e)
        {
            AddResident openResidentPage = new AddResident();
            openResidentPage.Show();
            this.Close();
        }

        private void search_btn(object sender, RoutedEventArgs e)
        {
            SearchPage openSearchPage = new SearchPage();
            openSearchPage.Show();
            this.Close();
        }

        private void Exit_Button(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void search_student_ID(object sender, TextChangedEventArgs e)
        {
            if (studentID_name_search.Text != null)
            {
                student_grid.ItemsSource = studentList.Where(x => x.StudentID.ToString().Contains(studentID_name_search.Text));
            }
            else
            {
                student_grid.ItemsSource = studentList;
            }
        }

        private void search_name(object sender, TextChangedEventArgs e)
        {
            if (name_search.Text != null)
            {
                student_grid.ItemsSource = studentList.Where(x => x.Name.ToString().Contains(name_search.Text));
            }
            else
            {
                student_grid.ItemsSource = studentList;
            }
        }

        //public void studentCount(ObservableCollection<Resident> studentTotal, ObservableCollection<Resident>studentList, string type, TextBox box )
        //{
        //    studentTotal = studentList.Where(x => x.Type.Contains(type));
        //    box.Text = studentTotal.Count().ToString();


        //}

    }//End of partial class
}
