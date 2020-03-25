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

namespace ExpenseTrackerApp
{
    /// <summary>
    /// Interaction logic for ExpenseTrackerHome.xaml
    /// </summary>
    public partial class ExpenseTrackerHome : Page
    {
        public ExpenseTrackerHome()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender , RoutedEventArgs args)
        {
            ExpenseReportPage reportPage = new ExpenseReportPage(peopleListBox.SelectedItem);
            NavigationService.Navigate(reportPage);
        }
    }
}
