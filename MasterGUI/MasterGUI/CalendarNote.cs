using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterGUI
{
    class CalendarNote:Control
    {
        private TextBox Boxtitle;
        private TextBox Boxtext;
        public CalendarNote()
        {

        }
        public CalendarNote(string text,string name,int x,int y):base()
        {
            Boxtext = new TextBox();
            Boxtitle = new TextBox();
         

            Name = "rec";
            this.BackColor = Color.Gray;
            this.Location = new Point(10,20);
            this.Size = new Size(170, 140);
            this.Visible = true;

            Boxtitle.Text = name;
            Boxtitle.Font =new Font("Times New Roman", 10, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            Boxtitle.Multiline = true;
            Boxtitle.Size = new Size(this.Width, 40);
            Boxtitle.Visible = true;

            Boxtext.Text = text;

            this.Controls.Add(Boxtext);

            this.Click += CalendarNote_Click;
            this.Paint += CalendarNote_Paint;
        }

        private void CalendarNote_Click(object sender, EventArgs e)
        {
           
        }

        private void CalendarNote_Paint(object sender, PaintEventArgs e)
        {
          
        }
    }
}
