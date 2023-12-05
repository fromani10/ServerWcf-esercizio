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
using WpfApp1.ViewModel;

namespace WpfApp1
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ViewModel.VievModelConvert vm;

        

        public MainWindow()
        {
            
            InitializeComponent();
            vm= new ViewModel.VievModelConvert();
            DataContext = vm;
        }

        private void ComboBoxItem_DEM(object sender, RoutedEventArgs e)
        {
            
        }

        private void omboBoxItem_ITL(object sender, RoutedEventArgs e)
        {
           
        }

        private void ComboBoxItem_FRF(object sender, RoutedEventArgs e)
        {
          
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            vm.Converti();
        }
    }
}
