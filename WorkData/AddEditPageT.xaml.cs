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
    /// Логика взаимодействия для AddEditPageT.xaml
    /// </summary>
    public partial class AddEditPageT : Page
    {
        private tour_schedule _currentTour = new tour_schedule();
        public AddEditPageT(tour_schedule selectedTour)
        {
            InitializeComponent();
            
            if (selectedTour != null)
                _currentTour = selectedTour;
            DataContext = _currentTour;
            //ComboPres.ItemsSource = Database_circusEntities.GetContext().presentation.ToList();
        }

        private void BSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrEmpty(Convert.ToString(_currentTour.data_start)))
                errors.AppendLine("Заполните ячейку");
            if (string.IsNullOrEmpty(Convert.ToString(_currentTour.data_end)))
                errors.AppendLine("Заполните ячейку");
            if (string.IsNullOrEmpty(Convert.ToString(_currentTour.Place_spot)))
                errors.AppendLine("Заполните ячейку");
            if (_currentTour.presentation == null)
                errors.AppendLine("Заполните ячейку");

            if(errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            if(_currentTour.Id_schedule == 0)
                Database_circusEntities.GetContext().tour_schedule.Add(_currentTour);
            try
            {
                Database_circusEntities.GetContext().SaveChanges();
                MessageBox.Show("Saved");
                NavigationService.Navigate(new TableTour());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
