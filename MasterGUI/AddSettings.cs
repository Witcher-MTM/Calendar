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

        CalendarNote note = new CalendarNote("Enter title", "Enter text");
       
        public AddSettings()
        {
            InitializeComponent();
            File.WriteAllText("TmpTitle.txt", "NULL");
            File.WriteAllText("TmpText.txt", "NULL");
        }

      
        private void accBtn_Click(object sender, EventArgs e)
        {

            var a = Manager.notes.Find(x => x.NoteName.Equals(File.ReadAllText("TmpTitle.txt")));
            if (a == null) 
            {
                if (File.ReadAllText("TmpText.txt") == "NULL" || File.ReadAllText("TmpTitle.txt") == "NULL")
                {
                        MessageBox.Show("Невозможно создать пустую заметку");
                }
                else
                {
                    if (MessageBox.Show($"Добавить эту замтеку на {dateTimePicker1.Text}", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Manager.CreateNote(File.ReadAllText("TmpTitle.txt"), File.ReadAllText("TmpText.txt"), dateTimePicker1.Value.Date);
                        this.Dispose();
                    }
                }
            }
            else
            {
                MessageBox.Show("Такая заметка есть!");
            }
        }
        private void AddSettings_Load(object sender, EventArgs e)
        {
            this.Controls.Add(note);
        }
    }
}
