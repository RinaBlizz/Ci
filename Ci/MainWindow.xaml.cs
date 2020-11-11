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

namespace Ci
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double x0 = double.Parse(X0.Text);
                double y0 = double.Parse(Y0.Text);
                double dx = double.Parse(Dx.Text);
                double a = double.Parse(A.Text);
                double b = double.Parse(B.Text);
                int N = (int)((y0 - x0) / dx)+1;
                double x = x0;
                string res = "";
                for(int i=1;i<=N;i++)
                {
                    double y = a * x * x * x + Math.Cos(x * x * x - b) * Math.Cos(x * x * x - b);
                    res +=String.Format("x={0} y={1:F2}\n",x,y);
                    x += dx;
                }
                Result.Text = res;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
