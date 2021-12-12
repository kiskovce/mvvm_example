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

namespace mvvm_example
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            var viewModel = new ViewModel();
            viewModel.test_string = " Toto ide ";

            List<string> temp_list = new List<string>();

            temp_list.Add("List 1");
            temp_list.Add("List 2");
            temp_list.Add("List 3");

            viewModel.test_list = temp_list;
            InitializeComponent();
            DataContext = viewModel;
        }
    }

    public class ViewModel
    {
        public string test_string { get; set; }
        public List<string> test_list{get; set; }
    }
}
