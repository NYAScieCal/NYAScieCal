using NYAScieCal.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NYAScieCal
{
    public partial class TrigoDialog : Form
    {

        private RichTextBox textBox;
        public TrigoDialog(RichTextBox textBox)
        {
            this.textBox = textBox;
            InitializeComponent();
            
        }

        private void sinBtn_Click(object sender, EventArgs e)
        {

            Program.buttonState.setCurrentState(ButtonStateConsts.SIN_BUTTON_SET);
            this.textBox.Text = "sin (" + this.textBox.Text + ")";
            this.Close();

        }

        private void cosBtn_Click(object sender, EventArgs e)
        {

            Program.buttonState.setCurrentState(ButtonStateConsts.COS_BUTTON_SET);
            this.textBox.Text = "cos (" + this.textBox.Text + ")";
            this.Close();

        }

        private void tanBtn_Click(object sender, EventArgs e)
        {

            Program.buttonState.setCurrentState(ButtonStateConsts.TAN_BUTTON_SET);
            this.textBox.Text = "tan (" + this.textBox.Text + ")";
            this.Close();

        }

        private void cotBtn_Click(object sender, EventArgs e)
        {

            Program.buttonState.setCurrentState(ButtonStateConsts.COT_BUTTON_SET);
            this.textBox.Text = "cot (" + this.textBox.Text + ")";
            this.Close();

        }

        private void secBtn_Click(object sender, EventArgs e)
        {

            Program.buttonState.setCurrentState(ButtonStateConsts.SEC_BUTTON_SET);
            this.textBox.Text = "sec (" + this.textBox.Text + ")";
            this.Close();

        }
        private void cscBtn_Click(object sender, EventArgs e)
        {

            Program.buttonState.setCurrentState(ButtonStateConsts.CSC_BUTTON_SET);
            this.textBox.Text = "csc (" + this.textBox.Text + ")";
            this.Close();

        }
    }
}
