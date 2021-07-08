using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterGUI
{
    public partial class Form1 : Form
    {
        private List<CalendarNote> notes = new List<CalendarNote>();
        public Form1()
        {
            InitializeComponent();
            panel3.Controls.Add(new CalendarNote("test", "test",DateTime.Now));
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Form form = new AddSettings();
            this.Visible = false;
            form.ShowDialog();
            this.Visible = true;
        }
    }
}
