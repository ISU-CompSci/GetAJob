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
                //d = a + int.MaxValue;
                // recursion
                d = a + b;
                d = AddTheseTogether(25, 325);
                //throw new MyException("This is an error");
                MessageBox.Show(d.ToString());
            } catch (DivideByZeroException ex) {
                MessageBox.Show("Dude, you can't do that.");
            } catch (OverflowException ex) {
                MessageBox.Show("The number is way too big, man.");
            } catch (MyException ex) {
                MessageBox.Show(ex.Message);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {

            }

        }
                                       //a, // b
                                       //5, // 3
                                       //6, // 2
                                       //7, // 1
                                       //8, // 0 
        private int AddTheseTogether(int a, int b) {
            //throw new NotImplementedException();
            //for (int i = b; i > 0; i--) {
            //    a++;
            //}
            if (b <= 0)
                return a;
            else
                return AddTheseTogether(a+1,b-1) ;

            int g = 6;
            
            
        }

        private void btnMoveDuck_Click(object sender, RoutedEventArgs e)
        {
            double left = (double) canDuck.GetValue(Canvas.LeftProperty);
            canDuck.SetValue(Canvas.LeftProperty, left + 100.0);
        }

        private void btnMoveDuckback_Click(object sender, RoutedEventArgs e)
        {
            double left = (double)canDuck.GetValue(Canvas.LeftProperty);
            canDuck.SetValue(Canvas.LeftProperty, left - 100.0);
        }
    }
}
