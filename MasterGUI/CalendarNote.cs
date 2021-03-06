using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterGUI
{
    class CalendarNote:Control
    {

        public TextBox Boxtitle;
        public TextBox Boxtext;
        public TextBox BoxTime;
        public CalendarNote()
        {

        }
        public CalendarNote(string text,string name,DateTime time):base()
        {
            Boxtext = new TextBox();
            Boxtitle = new TextBox();
            BoxTime = new TextBox();

            Name = "rec";
            this.BackColor = Color.Gray;
            this.Location = new Point(10,20);
            this.Size = new Size(170, 140);
            this.Visible = true;

            Boxtitle.Text = name;
            Boxtitle.Font = new Font("Times New Roman", 10, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            Boxtitle.Multiline = true;
            Boxtitle.Size = new Size(this.Width, 40);
            Boxtitle.Location = new Point(0, 0);
            Boxtitle.Visible = true;

            Boxtext.Text = text;
            Boxtext.Font = new Font("Times New Roman", 10, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            Boxtext.Multiline = true;
            Boxtext.Size = new Size(this.Width, 80);
            Boxtext.Location = new Point(0, 40);
            Boxtext.Visible = true;
           

            BoxTime.Text = time.ToString();
            BoxTime.Font = new Font("Times New Roman", 8, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            BoxTime.Multiline = true;
            BoxTime.Size = new Size(this.Width, 20);
            BoxTime.Location = new Point(0, 120);
            BoxTime.Visible = true;
            Boxtitle.ReadOnly = true;
            Boxtext.ReadOnly = true;
            BoxTime.ReadOnly = true;
            this.Controls.Add(Boxtext);
            this.Controls.Add(Boxtitle);
            this.Controls.Add(BoxTime);
          
        }
        public CalendarNote(string text, string name) : base()
        {
          
            Boxtext = new TextBox();
            Boxtitle = new TextBox();
           

            Name = "rec";
            this.BackColor = Color.Gray;
            this.Location = new Point(10, 20);
            this.Size = new Size(170, 140);
            this.Visible = true;

            Boxtitle.Text = name;
            Boxtitle.Font = new Font("Times New Roman", 10, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            Boxtitle.Multiline = true;
            Boxtitle.Size = new Size(this.Width, 40);
            Boxtitle.Location = new Point(0, 0);
            Boxtitle.Visible = true;
            

            Boxtext.Text = text;
            Boxtext.Font = new Font("Times New Roman", 10, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            Boxtext.Multiline = true;
            Boxtext.Size = new Size(this.Width, 80);
            Boxtext.Location = new Point(0, 40);
            Boxtext.Visible = true;
          


            

            Boxtext.TextChanged += Boxtext_TextChanged;
            Boxtitle.TextChanged += Boxtitle_TextChanged;
         
            this.Controls.Add(Boxtext);
            this.Controls.Add(Boxtitle);
            this.Controls.Add(BoxTime);
           
        }

        private void Boxtitle_TextChanged(object sender, EventArgs e)
        {
            File.WriteAllText("TmpTitle.txt", Boxtitle.Text);
        }

        private void Boxtext_TextChanged(object sender, EventArgs e)
        {
            File.WriteAllText("TmpText.txt", Boxtext.Text);
        }

      

      
    }
}
