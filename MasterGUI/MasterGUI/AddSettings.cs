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
using NoteDLL;
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
                if (note.Boxtext.Text.Length != 0 && note.Boxtitle.Text.Length!=0)
                {
                    Manager.CreateNote(File.ReadAllText("TmpTitle.txt"), File.ReadAllText("TmpText.txt"), dateTimePicker1.Value.Date);
                  
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Невозможно создать пустую заметку");
                }
           
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
