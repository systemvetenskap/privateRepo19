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

namespace FL5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        int sum = 0;
        int[] values = new int[5];
        int[] result;

        string[] weekdays = new string[]
            {
                "Måndag", "Tisdag", "Onsdag", "Torsdag", "Fredag"
            };

        int index = 0;

        // Det här är min konstruktor
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // svårt

            // men det är viktigt
            // vad är en array?
            // = en samling av flera värden av samma datatyp

            // typ, många variabler av samma sort

            // en variabel kan hålla ett och endast ett värde
            // oerhört tight kopplad till en loop

            // målbild

            // 12    23     55    67    100
            int test1, test2, test3, test4, test5;

            

            // i en array
            //   0    1    2    3    4
            // [12] [23] [55] [67] [100]

            // varje fack har ett index

            int value = int.Parse(txtValue.Text);

           // test1 = value;

            values[index] = value;
            index++;


            // foreach   smart när vi vill titta igenom en lista eller array
            foreach (int val in values) // val kommer hålla vårt värde, fack för fack
            {
                if (val > 0)
                {
                    MessageBox.Show(val.ToString());
                }
            }
            // datatyp mellanslag = värde --> variabel

            // boolskt uttryck --> sant / falskt

            // hur ska  variabeln räknas upp?
            // for-loop   kan användas till allt
            for (int i = 0; i < values.Length; i++)
            {
                // använd variabeln i som indexuppräknare
                int val = values[i];
                val += 10;
                values[i] = val;
                MessageBox.Show(val.ToString());

            }
           
            // sum += value;





        }


        private void UpdateListbox()
        {
            lstWeekDays.ItemsSource = null;
            lstWeekDays.ItemsSource = weekdays;
        }

        private void ClearTextboxes()
        {

        }






        private void Button1_Click(object sender, RoutedEventArgs e)
        {

            UpdateListbox();
            index = 3;
            weekdays[index] = "Monday";
            string name = "Erik";

            UpdateListbox();
            ClearTextboxes();


            //MessageBox.Show(name[0].ToString());

            //foreach (char c in name)
            //{
            //    MessageBox.Show(c.ToString());
            //}

            string edited = "";
            char[] nameArray = name.ToCharArray();
            nameArray[2] = 'B';



            for (int i = 0; i < name.Length; i++)
            {
                if (name[i].Equals('r'))
                {
                    edited += 'p';
                }
                else
                {
                    edited += name[i];
                }
               // MessageBox.Show(name[i].ToString());
            }
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            int price = int.Parse(txtValue.Text);

            if (price.ToString().Length <= 4)
            {
                price *= 1000;
            }

            txtValue.Text = $"{price:C0}";
            string name = "Erik";
            foreach (char c in name)
            {
                
            }

            // [E] [r]
        }
    }
}
