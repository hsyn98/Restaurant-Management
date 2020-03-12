using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static KeygenLibrary.CSecurity;
using KeygenLibrary;

namespace Restaurant.Forms
{
    public partial class Registrations : Form
    {
        private readonly   CSecurity _security = new CSecurity();
 
        public Registrations()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Pk_test = ProductKey.Text.Replace("-", "");
            string license_test = License.Text.Replace("-", "");

             if (_security.CheckKeys(Branches.Text, Pk_test, license_test))
            {
                MessageBox.Show("Program qeydiyyata alinib...");
                // _security.WriteRegInfo(Branches.Text, ProductKey.Text.Replace("-", ""), License.Text.Replace("-", ""));
                Close();
            }
            else
            {
                MessageBox.Show("Yeniden yoxlayin ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Pk_test = ProductKey.Text.Replace("-", "");
            string license_test = License.Text.Replace("-", "");
            TXT_DATE.Text = _security.GetFileDecrypt(license_test, Pk_test);
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            if (_security.IsRegistered())
            {
                MessageBox.Show("Siz artiq reqistrasiya olunmusuz");
            }
            else
            {
                Registration RG = new Registration();
                RG = _security.GetRegistration();
                PID.Text = RG.ID;
                TSerial.Text = RG.Serial;
            }
        }
    }
}
