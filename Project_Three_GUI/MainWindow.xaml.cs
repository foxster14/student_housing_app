using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Project_Three_GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Exit_Button(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void submit_btn(object sender, RoutedEventArgs e)
        {
            if (password_box.Text == "1234" && username_box.Text == "home")
            {
                SelectionPage openSelectionPage = new SelectionPage();
                openSelectionPage.Show();
                this.Close();
            }
            else
            {
                error_msg.Visibility = Visibility.Visible;

            }
        }
            

        private void username(object sender, TextChangedEventArgs e)
        {



        }

        private void password(object sender, TextChangedEventArgs e)
        {

        }

        public void show_error_msg(object sender, EventArgs e)
        {
            error_msg.Visibility = Visibility.Hidden;
        }
    }
}
