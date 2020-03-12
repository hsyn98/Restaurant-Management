using Restaurant.AppCode;
using System;
using System.Windows.Forms;

namespace Restaurant.Forms
{
    public partial class Msg : Form
    {
        private string msgtext { get; set; }
        
        public Msg(string strmsg,Int32 iconum)
        {
            //221 -OK
            //237 -Error

            InitializeComponent();
            this.Icon = IconExtractor.Extract("shell32.dll", 144, true);

            lblMsgText.Text = msgtext = strmsg;
            lblMsgText.Image =IconExtractor.Extract("shell32.dll", iconum, true).ToBitmap(); 
            btnOK.Image = IconExtractor.Extract("shell32.dll",176, false).ToBitmap();
        }

       

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
