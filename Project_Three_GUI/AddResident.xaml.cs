using System;
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
    /// Interaction logic for AddResident.xaml
    /// </summary>
    public partial class AddResident : Window
    {
        DataSource source = new DataSource(); //we need to create an object instacne of data source
        ObservableCollection<Resident> studentList = null; //now any changes made to this list will be updated automatically due to the observable list
        Resident aStudent;
        int BoardingFee;
        List<int[]> floorNumList = new List<int[]>
                {
                    new int[] {1,2,3,4,5,6,7},
                    new int[] {1,2,3},
                    new int[] {4,5,6},
                    new int[] {7,8}

                };


        public AddResident()
        {
            InitializeComponent();
            studentList = source.readData();
            name_box.Text = "something";
            //floor_drop_down.ItemsSource = floorNumList[0];

        }

        private void student_type_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void name_box_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void hours_box_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void resident_btn(object sender, RoutedEventArgs e)
        {

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

        //private void student_type_changed(object sender, SelectionChangedEventArgs e)
        //{
             //ComboBoxItem studentType = (ComboBoxItem)student_type_drop_down.SelectedItem;
     
            
            //Here is where decision logic goes
            //if (studentType.Content.ToString() == "Student Worker")
            //{
                //Assign floor numbers to the other combobox, now give values for floor combo box
                //name_box.Text = "Hello";
                //floor_drop_down.ItemsSource = floorNumList[1]; //Same thing as saying floorNumList[0]
                //hours_box.IsEnabled = true;

            //}
           //else if (studentType.Content.ToString() == "Athlete")
           // {
           //     floor_drop_down.ItemsSource = floorNumList[2];
           //     //hours_box.IsEnabled = true;
           // }
           //else //This is the athlete selection 
           // {
           //     floor_drop_down.ItemsSource = floorNumList[3];
           //     //hours_box.IsReadOnly = false;

           // }
        //}

        private void ID_box_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void submit_btn_Click(object sender, RoutedEventArgs e)
        {
            //add a submit button that adds an object instance of classes & adds them to a list 
            //Example of casting
            ComboBoxItem studentType = (ComboBoxItem)student_type_drop_down.SelectedItem; //now we have a name for the term item in our combobox (dropdown)
            ComboBoxItem floor = (ComboBoxItem)floor_drop_down.SelectedItem;
            ComboBoxItem room = (ComboBoxItem)room_drop_down.SelectedItem;
            

            if (studentType.Content.ToString() == "Athlete")
            {
                BoardingFee = 1200;
                aStudent = new Student(Convert.ToInt32(ID_box.Text), name_box.Text, studentType.Content.ToString(), BoardingFee, Convert.ToInt32(floor.Content.ToString()), Convert.ToInt32(room.Content.ToString()));
                //Adding new student to List
                studentList.Add(aStudent);
                //Writing new data to CSV file
                source.writeData(studentList);
            }
            else if (studentType.Content.ToString() == "Scholarship Recipient")
            {
                BoardingFee = 100;
                aStudent = new Student(Convert.ToInt32(ID_box.Text), name_box.Text, studentType.Content.ToString(), BoardingFee, Convert.ToInt32(floor.Content.ToString()), Convert.ToInt32(room.Content.ToString()));
                studentList.Add(aStudent);
                //Writing new data to CSV file
                source.writeData(studentList);
            }
            else if (studentType.Content.ToString() == "Student Worker")
            {
                int wage = 14 * Convert.ToInt32(hours_box.Text);
                BoardingFee = 1245 - wage;
                aStudent = new Student(Convert.ToInt32(ID_box.Text), name_box.Text, studentType.Content.ToString(), BoardingFee, Convert.ToInt32(floor.Content.ToString()), Convert.ToInt32(room.Content.ToString()));
                studentList.Add(aStudent);
                //Writing new data to CSV file
                source.writeData(studentList);
            }

            try
            {
                //Why isn't my boarding fee logic working?
                //aStudent = new Student(Convert.ToInt32(ID_box.Text), name_box.Text, studentType.Content.ToString(), BoardingFee, Convert.ToInt32(floor.Content.ToString()), Convert.ToInt32(room.Content.ToString()));

                //Adding new student to List
                //studentList.Add(aStudent);
                //Writing new data to CSV file
                //source.writeData(studentList);

                SearchPage openSearchPage = new SearchPage();
                openSearchPage.Show();
                this.Close();
            }
            catch (Exception ex)
            {

            }
        }

        private void monthly_hrs_enabled(object sender, DependencyPropertyChangedEventArgs e)
        {

        }

        private void student_type_changed(object sender, SelectionChangedEventArgs e)
        {
            name_box.Text = "Hello";
        }
    }
}
