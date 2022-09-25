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
        public MainWindow()
        {
            InitializeComponent();                 
        }
        public static string choosenReg1 = "";
        public static string choosenReg2 = "";

        public static Dictionary<string, string> regs = new Dictionary<string, string>() {
                { "al", ""},
                { "ah", ""},
                { "bl", ""},
                { "bh", ""},
                { "cl", ""},
                { "ch", ""},
                { "dl", ""},
                { "dh", ""}
        };

        public void Render()
        {
            alValue.Text = regs["al"];
            ahValue.Text = regs["ah"];
            blValue.Text = regs["bl"];
            bhValue.Text = regs["bh"];
            clValue.Text = regs["cl"];
            chValue.Text = regs["ch"];
            dlValue.Text = regs["dl"];
            dhValue.Text = regs["dh"];
        }

        private void mov_Click(object sender, RoutedEventArgs e)
        {                   
                regs[choosenReg2] = regs[choosenReg1];
                Render();                         
        }

        private void XCHG_Click(object sender, RoutedEventArgs e)
        {
            string temp = regs[choosenReg1];
            regs[choosenReg1] = regs[choosenReg2];
            regs[choosenReg2] = temp;
            Render();
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

                    regs["al"] = alValue.Text.ToLower();
                    regs["ah"] = ahValue.Text.ToLower();
                    regs["bl"] = blValue.Text.ToLower();
                    regs["bh"] = bhValue.Text.ToLower();
                    regs["cl"] = clValue.Text.ToLower();
                    regs["ch"] = chValue.Text.ToLower();
                    regs["dl"] = dlValue.Text.ToLower();
                    regs["dh"] = dhValue.Text.ToLower();

                    alValue.Text = regs["al"];
                    ahValue.Text = regs["ah"];
                    blValue.Text = regs["bl"];
                    bhValue.Text = regs["bh"];
                    clValue.Text = regs["cl"];
                    chValue.Text = regs["ch"];
                    dlValue.Text = regs["dl"];
                    dhValue.Text = regs["dh"];




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
        private void checked_event(object sender, RoutedEventArgs e)
        {
            choosenReg1 = (sender as RadioButton)?.Content.ToString();
        }

        private void checked_event2(object sender, RoutedEventArgs e)
        {
            choosenReg2 = (sender as RadioButton)?.Content.ToString();
        }
    }
}
