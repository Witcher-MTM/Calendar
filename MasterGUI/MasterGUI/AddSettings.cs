using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLL;

namespace MasterGUI
{
    public partial class AddSettings : Form
    {
        public AddSettings()
        {
            InitializeComponent();
            this.Controls.Add(new CalendarNote("Enter title", "Enter text","test"));
        }

        private void accBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Добавить эту замтеку на {dateTimePicker1.Value}","",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
               
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
