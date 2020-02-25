/*
 * Ian McTavish
 * Feb 7, 2019
 * Example program for boolean variables
 */
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

namespace booleanExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Button click - read values of check boxes and set output
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnProcess_Click(object sender, RoutedEventArgs e)
        {
            //declare boolean variables
            bool boolHappy;//declare variable
            boolHappy = false;//assign value
            bool boolKnowIt = false;//declare and assign in one line

            //assign values based on the checked status
            boolHappy = (bool)chkHappy.IsChecked;
            boolKnowIt = (bool)chkKnowIt.IsChecked;

            //show user the output
            txtOutput.Text = "The users happy status is: " + boolHappy.ToString() + System.Environment.NewLine +
                " &#10; Do they know it? " + boolKnowIt.ToString();
            //set checkboxes based on variables
            chkHappyStatus.IsChecked = chkHappy.IsChecked;
            chkKnowItStatus.IsChecked = chkKnowIt.IsChecked;

        }
    }
}
