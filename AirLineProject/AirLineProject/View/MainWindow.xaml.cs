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
using AirLineProject.Model;
using AirLineProject;
using System.Xaml;


namespace AirLineProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Database database = new Database();

            DataContext = database;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            FileWriter filewriter = new FileWriter();
            int textBoxCharacterCount;

            textBoxCharacterCount = this.textBox.GetLineLength(0);  

            if (textBoxCharacterCount == 0 || this.listBox.SelectedItem == null || this.listBox1.SelectedItem == null)
            {
                MessageBox.Show("Please Select a flight, seat, and enter your name prior to submitting this form.");
            }
            else
            {
                string PassengerInfo = (Environment.NewLine + this.textBox.Text + " is on flight " + this.listBox.SelectedItem.ToString() + " and is assigned to seat " + this.listBox1.SelectedItem.ToString());
                filewriter.Print(PassengerInfo, "PassengerInfo.txt");
                this.Close();
                MessageBox.Show(PassengerInfo);
            }

                  
    }

    }
}
