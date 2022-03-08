using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NYAScieCal
{
    public partial class MainForm : Form
    {

        private int currentX;
        private int currentY;

        public MainForm()
        {
            InitializeComponent();
            /*this.trigoBtn.Image = Program.util.resizeImage(Image.FromFile("C:\\Users\\Lazar-PC\\source\\repos\\NYAScieCal\\NYAScieCal\\images\\25243.png"),15,15);
            this.trigoBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.closeBtn.Image= Program.util.resizeImage(Image.FromFile("C:\\Users\\Lazar-PC\\source\\repos\\NYAScieCal\\NYAScieCal\\images\\closeIcon.png"), 15, 15);
            this.trigoBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;*/
            
           
        }

        private void trigoBtn_Click(object sender, EventArgs e)
        {
            int x = this.DesktopLocation.X;
            int y = this.DesktopLocation.Y;
            TrigoDialog dialog = new TrigoDialog();
            dialog.StartPosition = FormStartPosition.Manual;
            dialog.SetDesktopLocation(trigoBtn.Location.X + x, trigoBtn.Location.Y + y + trigoBtn.Height);
            dialog.ShowDialog(this);
            

        }

        private void titleBar_MouseDown(object sender, MouseEventArgs e)
        {

            if (Control.MouseButtons == MouseButtons.Left)
            {

                if (this.currentX==0&&this.currentY==0)
                {

                    this.currentX = e.X;
                    this.currentY = e.Y;

                }

                this.SetDesktopLocation(this.Location.X + (e.X - this.currentX), this.Location.Y + (e.Y - this.currentY)) ;

            }

            if (Control.MouseButtons == MouseButtons.None)
            {
                this.currentX = e.X;
                this.currentY = e.Y;
            }

            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox.Text = "7";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox.Text = "6";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox.Text = "3";
        }

        private void button0_Click(object sender, EventArgs e)
        {

            textBox.Text = "0";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox.Text = "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox.Text = "9";
        }
    }
}
