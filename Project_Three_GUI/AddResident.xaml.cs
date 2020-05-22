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
                    new int[] {1,2,3,4,5,6,7,8},
                    new int[] {1,2,3},
                    new int[] {4,5,6},
                    new int[] {7,8}
                };

        public AddResident()
        {
            InitializeComponent();
            studentList = source.readData();
            //name_box.Text = "something";
            floor_drop_down.ItemsSource = floorNumList[0];

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

        private void student_type_changed(object sender, SelectionChangedEventArgs e)
        {
             //ComboBoxItem studentType = (ComboBoxItem)student_type_drop_down.SelectedItem;
            floor_drop_down.ItemsSource = floorNumList[student_type_drop_down.SelectedIndex + 1]; //same thing as floorNumList[1]
            hours_box.Text = "";

            //Here is where decision logic goes
            if (student_type_drop_down.SelectedIndex == 0) //This is Student Worker
            {
                hours_box.IsEnabled = true;
            }
            else
            {
                hours_box.IsEnabled = false;
            }
        }

        private void ID_box_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void submit_btn_Click(object sender, RoutedEventArgs e)
        {
            //Example of casting
            ComboBoxItem studentType = (ComboBoxItem)student_type_drop_down.SelectedItem; //now we have a name for the term item in our combobox (dropdown) 
            ComboBoxItem room = (ComboBoxItem)room_drop_down.SelectedItem;
            var prevStudID = studentList[studentList.Count - 1].StudentID;

            try
            {
                if (studentType.Content.ToString() == "Athlete")
                {
                    BoardingFee = 1200;
                    var floor = floor_drop_down.SelectedItem.ToString();
                    //MessageBox.Show(prevStudID.ToString());
                    aStudent = new Student(prevStudID += 1, name_box.Text, studentType.Content.ToString(), BoardingFee, Convert.ToInt32(floor), Convert.ToInt32(room.Content.ToString()));
                    //Adding new student to List
                    studentList.Add(aStudent);
                    //Writing new data to CSV file
                    source.writeData(studentList);
                }
                else if (studentType.Content.ToString() == "Scholarship Recipient")
                {
                    BoardingFee = 100;
                    var floor = floor_drop_down.SelectedItem.ToString();
                    //MessageBox.Show(floor.Content.ToString());
                    aStudent = new Student(prevStudID += 1, name_box.Text, studentType.Content.ToString(), BoardingFee, Convert.ToInt32(floor), Convert.ToInt32(room.Content.ToString()));
                    //Adding new student to List
                    studentList.Add(aStudent);
                    //Writing new data to CSV file
                    source.writeData(studentList);
                }
                else if (studentType.Content.ToString() == "Student Worker")
                {
                    int wage = 14 * Convert.ToInt32(hours_box.Text);
                    BoardingFee = 1245 - wage;
                    var floor = floor_drop_down.SelectedItem.ToString();
                    aStudent = new Student(prevStudID += 1, name_box.Text, studentType.Content.ToString(), BoardingFee, Convert.ToInt32(floor), Convert.ToInt32(room.Content.ToString()));
                    //Adding new student to the master list that holds ALL students
                    studentList.Add(aStudent);
                    //Writing new data to CSV file
                    source.writeData(studentList);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                SearchPage openSearchPage = new SearchPage();
                openSearchPage.Show();
                this.Close();
            }
        }

        private void monthly_hrs_enabled(object sender, DependencyPropertyChangedEventArgs e)
        {

        }

    }
}
