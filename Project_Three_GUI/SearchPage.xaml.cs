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

            var scholarshipCount = studentList.Where(x => x.Type.Contains("Scholarship"));
            scholarship_box.Text = scholarshipCount.ToString();
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
    }
}
