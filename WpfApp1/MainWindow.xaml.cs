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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Model.tb = TBCount;
            Model.tbznak = TBznak;
            Model.firstNum = firstNum;
            Model.secomdNum = secondNum;
            Model.tbResult = TbResult;
            CBSurname.ItemsSource = Model.datalist;
            TbResult.IsReadOnly = true;

        }
        //ТОЛЬКО ЦИФРЫ  И ЗАПЯТАЯ
       
        private void OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = "0123456789,".IndexOf(e.Text) < 0;
        }
        private void BtnCount_Click(object sender, RoutedEventArgs e)
        {
            Model.operations(CBSurname.SelectedIndex);
        }

        private void CBSurname_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Model.Combo = CBSurname.SelectedIndex;

        }

    }
}
