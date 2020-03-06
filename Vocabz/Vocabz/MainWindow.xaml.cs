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

namespace Vocabz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Binding bindingGer = new Binding();
            lblGer.SetBinding(Label.ContentProperty, bindingGer);

            Binding bindingBttn1 = new Binding();
            bttnOne.SetBinding(Button.ContentProperty, bindingBttn1);

            Binding bindingBttn2 = new Binding();
            bttnTwo.SetBinding(Button.ContentProperty, bindingBttn2);

            Binding bindingBttn3 = new Binding();
            bttnThree.SetBinding(Button.ContentProperty, bindingBttn3);

            Binding bindingBttn4 = new Binding();
            bttnFour.SetBinding(Button.ContentProperty, bindingBttn4);


        }

        private void BttnOne_Click(object sender, RoutedEventArgs e)
        {
            //if (bttnOne.Content.ToString() == )
            //{

            //}
        }

        private void BttnTwo_Click(object sender, RoutedEventArgs e)
        {
            //if (bttnTow.Content.ToString() == )
            //{

            //}
        }

        private void BttnThree_Click(object sender, RoutedEventArgs e)
        {
            //if (bttnThree.Content.ToString() == )
            //{

            //}
        }

        private void BttnFour_Click(object sender, RoutedEventArgs e)
        {
            //if (bttnFourContent.ToString() == )
            //{

            //}
        }
    }
}
