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

namespace NeedAJob {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void btnMagic_Click(object sender, RoutedEventArgs e) {

            int a = 2, b = 5, c = 0, d;
            try {
                //d = a / c;
                d = a + int.MaxValue;
            } catch (DivideByZeroException ex) {
                MessageBox.Show("Dude, you can't do that.");
            } catch (OverflowException ex) {
                MessageBox.Show("The number is way too big, man.");
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {

            }

        }
    }
}
