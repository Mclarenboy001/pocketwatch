using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_date_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            
            
        }

        private void btnShowDateTime_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            string dateTimeString = now.ToString("dd:MM:yyyy HH:mm:ss");
            MessageBox.Show(dateTimeString, "Current Date and Time", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
