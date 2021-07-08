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
    public partial class Form1 : Form
    {
        private List<CalendarNote> notes = new List<CalendarNote>();
        public Form1()
        {
            InitializeComponent();
           
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Form form = new AddSettings();
            this.Visible = false;
            form.ShowDialog();
            this.Visible = true;
            if (Manager.notes.Count != 0)
            {
                notes.Add(new CalendarNote(Manager.notes.Last().Text, Manager.notes.Last().NoteName, Manager.notes.Last().CreationData));
            }

            panel3.Controls.Add(notes.Last());
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("AllNotes.txt"))
            {
                Manager.ReadNotesFromFile("AllNotes.txt");
                for (int i = 0; i < Manager.notes.Count; i++)
                {
                    this.notes.Add(new CalendarNote(Manager.notes[i].Text, Manager.notes[i].NoteName, Manager.notes[i].CreationData));
                }
                panel3.Controls.AddRange(notes.ToArray());
                for (int i = 0; i < notes.Count; i++)
                {
                    notes[i].Visible = false;
                }
                notes.First().Visible = true;
            }
            else
            {

            }
           
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (notes.Find(x => x.BoxTime.Text == monthCalendar1.SelectionStart.ToString()) == null)
            {
                MessageBox.Show("Not found");
            }
            else
            {
                notes.All(x => x.Visible = false);
                notes.Find(x => x.BoxTime.Text.Equals(monthCalendar1.SelectionRange.End.ToString())).Visible = true;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Manager.SaveAllNotes("AllNotes.txt");
        }

        private void PrevBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < notes.Count; i++)
            {
                if (notes[i].Visible)
                {
                    if (i != 0)
                    {
                     notes[i].Visible = false;
                     notes[i - 1].Visible = true;
                        return;
                    }
                }
            }
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < notes.Count; i++)
            {
                if (notes[i].Visible)
                {
                    if (i != notes.Count-1)
                    {
                        notes[i].Visible = false;
                        notes[i + 1].Visible = true;
                        return;
                    }
                }
            }
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {

        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox1.Focus();
            textBox1.KeyDown += TextBox1_KeyDown;
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(notes.Find(x => x.Boxtitle.Text.Equals(textBox1.Text)) != null)
                {
                    panel3.Controls.Remove(notes.Find(x => x.Boxtitle.Text.Equals(textBox1.Text)));
                    Manager.DeleteNote(notes.Find(x => x.Boxtitle.Text.Equals(textBox1.Text)).Boxtitle.Text);
                    notes.Remove(notes.Find(x => x.Boxtitle.Text.Equals(textBox1.Text)));
                    textBox1.Visible = false;
                }
                if (notes.Count != 0)
                    notes.First().Visible = true;



              
               
            }
        }
    }
}
