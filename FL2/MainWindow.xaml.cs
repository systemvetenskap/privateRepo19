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

namespace FL2
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

        private void BtnOK_Click(object sender, RoutedEventArgs e)
        {
            string firstName;
            int birthYear;
            // variabel <-- värde
            firstName = txtFirstName.Text;
            // får inte stoppa in strängar i datatypen int
            // birthYear = txtFirstName.Text;
            birthYear = int.Parse(txtBirthYear.Text);


            int age;
            DateTime date = DateTime.Now;
            int year = date.Year;

            age = year - birthYear;

            //txtBirthYear.Text = age.ToString();
            txtBirthYear.Text = $"Hej {firstName}. Du är {age} år gammal";
            // MessageBox.Show($"Hej {firstName}. Du är {age} år gammal");
            // MessageBox.Show(age.ToString());









            //    // deklarerar en variabel av datatypen string
            //    string message;
            //    // tilldelar värde till variabeln
            //    //  variabel <-- värde
            //    message = "Hej, vad glad du ser ut";
            //    message += ". "+ "Det var kul att se";



            //    string message1 = "Start";
            //    string message2 = "Slut";
            //    string message3 = $"{message1} {message2}";

            //    int myNumber = 100;

            //    myNumber += 50;
            //    // synonymt med
            //    //myNumber = myNumber + 50;


            //    message3 = $"Hej, du har vunnit: 100 kronor";
            //    message3 = "Hej, du har vunnit:" +" " + myNumber + "kronor";
            //    //MessageBox.Show(message1+message2);
            //    //MessageBox.Show(message3);

            //    int age;
            //    DateTime date = DateTime.Now;
            //    int birthYear = 2000;
            //    int year = date.Year;

            //    age = year - birthYear;
            //    string firstName = "Erik", lastName = "Öberg";
            //    string fullName = $"{firstName} {lastName} och jag är {age} år gammal";
            //    MessageBox.Show(fullName);
        }
    }
}
