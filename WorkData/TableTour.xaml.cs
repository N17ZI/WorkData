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

namespace WorkData
{
    /// <summary>
    /// Логика взаимодействия для TableTour.xaml
    /// </summary>
    public partial class TableTour : Page
    {
        public TableTour()
        {
            InitializeComponent();
            DGridTour.ItemsSource = Database_circusEntities.GetContext().tour_schedule.ToList();
        }

        private void BAdd_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddEditPageT(null));
        }

        private void BRemove_Click(object sender, RoutedEventArgs e)
        {
            var tourRemove = DGridTour.SelectedItems.Cast<tour_schedule>().ToList();
            if(MessageBox.Show($"Are really want delete {tourRemove.Count}?","Warn",
                MessageBoxButton.YesNo,MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    Database_circusEntities.GetContext().tour_schedule.RemoveRange(tourRemove);
                    Database_circusEntities.GetContext().SaveChanges();
                    MessageBox.Show("Removed");
                    DGridTour.ItemsSource = Database_circusEntities.GetContext().tour_schedule.ToList(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        private void BEdit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddEditPageT((sender as Button).DataContext as tour_schedule));
        }
    }
}
