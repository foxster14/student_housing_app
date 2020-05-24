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
using System.Windows.Shapes;

namespace Project_Three_GUI
{
    /// <summary>
    /// Interaction logic for SelectionPage.xaml
    /// </summary>
    public partial class SelectionPage : Window
    {
        public SelectionPage()
        {
            InitializeComponent();
        }

        private void resident_btn(object sender, RoutedEventArgs e)
        {
            AddResident openResidentPage = new AddResident();
            openResidentPage.Show();
            this.Close();
        }

        private void Exit_Button(object sender, RoutedEventArgs e)
        {
           
            this.Close();
        }

        private void search_btn(object sender, RoutedEventArgs e)
        {
            SearchPage openSearchPage = new SearchPage();
            openSearchPage.Show();
            this.Close();
        }
    }
}
