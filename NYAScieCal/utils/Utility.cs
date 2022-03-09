﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NYAScieCal.utils
{
    class Utility
    {


        public Image resizeImage(Image img, int width, int height)
        {
            
            Bitmap new_image = new Bitmap(width, height);
            Graphics g = Graphics.FromImage((Image)new_image);
            g.InterpolationMode = InterpolationMode.High;
            g.DrawImage(img, 0, 0, width, height);
            return new_image;

        }

        public void executeNumberDisplay(String number,RichTextBox textBox)
        {

            if (Program.buttonState.getCurrentState() == utils.ButtonStateConsts.OFF)
            {
                textBox.AppendText(number);
            }
            else if (Program.operandState.getCurrentState() == utils.OperandStateConsts.END_OPERAND_SET)
            {
                string temp1 = textBox.Lines[0];
                string temp2 = textBox.Lines[1];
                temp1 = temp1 + number;
                textBox.Text = temp1;
                textBox.SelectionStart = textBox.Text.Length;
                textBox.SelectionLength = 0;
                textBox.SelectionFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                textBox.AppendText("\n" + temp2);
            }
            else
            {
                string temp = textBox.Text;
                textBox.Text = number;
                textBox.SelectionStart = textBox.Text.Length;
                textBox.SelectionLength = 0;
                textBox.SelectionFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                textBox.AppendText("\n" + temp);
                Program.operandState.setCurrentState(utils.OperandStateConsts.END_OPERAND_SET);
            }


        }

    }
}
