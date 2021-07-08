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

        CalendarNote note = new CalendarNote("Enter title", "Enter text", "test");

        public AddSettings()
        {
            InitializeComponent();
           
        }

        private void accBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Добавить эту замтеку на {dateTimePicker1.Text}","",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
              
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AddSettings_Load(object sender, EventArgs e)
        {
            CalendarNote note = new CalendarNote("Enter title", "Enter text", "test");
         
            this.Controls.Add(note);
           
        }
    }
}
