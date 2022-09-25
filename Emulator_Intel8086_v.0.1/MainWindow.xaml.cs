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
using System.Text.RegularExpressions;
using System.Reflection.Emit;


namespace Emulator_Intel8086_v._0._1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static string al = "";
        public static string ah = "";
        public static string bl = "";
        public static string bh = "";
        public static string cl = "";
        public static string ch = "";
        public static string dl = "";
        public static string dh = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void mov_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void XCHG_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            alValue.Clear();
            ahValue.Clear();
            blValue.Clear();
            bhValue.Clear();
            clValue.Clear();
            chValue.Clear();
            dlValue.Clear();
            dhValue.Clear();
            alValue.IsReadOnly = false;
            ahValue.IsReadOnly = false;
            blValue.IsReadOnly = false;
            bhValue.IsReadOnly = false;
            clValue.IsReadOnly = false;
            chValue.IsReadOnly = false;
            dlValue.IsReadOnly = false;
            dhValue.IsReadOnly = false;
        }

        private void addValue_Click(object sender, RoutedEventArgs e)
        {
            if (Cheker(alValue.Text) && Cheker(ahValue.Text) && Cheker(blValue.Text) && Cheker(bhValue.Text) && Cheker(clValue.Text) && Cheker(chValue.Text) && Cheker(dlValue.Text) && Cheker(dhValue.Text))
            {
                if (Cheker2(alValue.Text) && Cheker2(ahValue.Text) && Cheker2(blValue.Text) && Cheker2(bhValue.Text) && Cheker2(clValue.Text) && Cheker2(chValue.Text) && Cheker2(dlValue.Text) && Cheker2(dhValue.Text))
                {
                    alValue.IsReadOnly = true;
                    ahValue.IsReadOnly = true;
                    blValue.IsReadOnly = true;
                    bhValue.IsReadOnly = true;
                    clValue.IsReadOnly = true;
                    chValue.IsReadOnly = true;
                    dlValue.IsReadOnly = true;
                    dhValue.IsReadOnly = true;

                    al = alValue.Text.ToLower();
                    ah = ahValue.Text.ToLower();
                    bl = blValue.Text.ToLower();
                    bh = bhValue.Text.ToLower();
                    cl = clValue.Text.ToLower();
                    ch = chValue.Text.ToLower();
                    dl = dlValue.Text.ToLower();
                    dh = dhValue.Text.ToLower();

                    alValue.Text = al;
                    ahValue.Text = ah;
                    blValue.Text = bl;
                    bhValue.Text = bh;
                    clValue.Text = cl;
                    chValue.Text = ch;
                    dlValue.Text = dl;
                    dhValue.Text = dh;



                    MessageBox.Show("Success");
                }
                else
                    MessageBox.Show("You entered invalid values");
            }
            else
                MessageBox.Show("Some inputs are empty or incorrect");
            
        }
        public bool Cheker(string x)
        {
            if (x.Length == 2)
                return true;
            else
                return false;
        }
        public bool Cheker2(string y)
        {
            string a = y.ToLower();
            Regex r = new Regex(@"[ghigklmnopqrstuvwxyz]");
            Match m = r.Match(a);
            if (m.Success)
                return false;
            else
                return true;

        }
        public string MOV(string a, string b)
        {
            b = a;
            return b;
        }
    }
    
}
