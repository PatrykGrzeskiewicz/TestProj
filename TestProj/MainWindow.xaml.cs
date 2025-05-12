using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TestProj
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ShowMsgBox(string msg)
        {
            MessageBox.Show(msg, "Test", MessageBoxButton.OK, MessageBoxImage.Information);

            int i = 0;
        }

        private void Podziel(decimal num, decimal div)
        {
            if (div > 0)
            {
                decimal Res = Math.Round(num / div, 2);

                Console.WriteLine(Res);
            }
        }
    }
}