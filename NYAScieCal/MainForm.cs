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
            this.trigoBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            Program.util.resizeImage((System.Drawing.Image)(resources.GetObject("button1.Image")), 80, 40);*/


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
            textBox.Text += "7";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox.Text += "6";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox.Text += "3";
        }

        private void button0_Click(object sender, EventArgs e)
        {
         
            textBox.Text += "0";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
 
            textBox.Text += "9";
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox.AppendText("2");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox.Text += "5";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (Program.operandState.getCurrentState() == utils.OperandStateConsts.OFF && 
                Program.buttonState.getCurrentState() == utils.ButtonStateConsts.OFF)
            {
                Program.operandState.setCurrentState(utils.OperandStateConsts.START_OPERAND_SET);
                textBox.AppendText("1");
            }
            
            else if (Program.operandState.getCurrentState() == utils.OperandStateConsts.END_OPERAND_SET &&
                    Program.buttonState.getCurrentState() == utils.ButtonStateConsts.MODULO_BUTTON_ON)
            {
                string temp = textBox.Text;
                textBox.Text = "1";
                textBox.SelectionStart = textBox.Text.Length;
                textBox.SelectionLength = 0;
                textBox.SelectionFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                textBox.AppendText("\n"+temp);
                Program.operandState.setCurrentState(utils.OperandStateConsts.OFF);
              
            }
            else if (Program.operandState.getCurrentState() != utils.OperandStateConsts.OFF)
            {
 
                textBox.AppendText("1");
            }
            else
            {
                string temp1 = textBox.Lines[0];
                string temp2 = textBox.Lines[1];
                temp1 = temp1 + "1";
                textBox.Text = temp1;
                textBox.SelectionStart = textBox.Text.Length;
                textBox.SelectionLength = 0;
                textBox.SelectionFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                textBox.AppendText("\n"+temp2);
            }



        }

        private void buttonEq_Click(object sender, EventArgs e)
        {
            textBox.SelectionStart = textBox.Text.Length;
            textBox.SelectionLength = 0;
            textBox.SelectionFont=new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textBox.AppendText("\n"+textBox.Text);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            if (Program.operandState.getCurrentState() == utils.OperandStateConsts.START_OPERAND_SET)
            {
                Program.buttonState.setCurrentState(utils.ButtonStateConsts.MODULO_BUTTON_ON);
                Program.operandState.setCurrentState(utils.OperandStateConsts.END_OPERAND_SET);
                textBox.AppendText(Environment.NewLine);
            }
           
        }
    }
}
