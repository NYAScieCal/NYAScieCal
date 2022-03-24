
using System.Drawing;

namespace NYAScieCal
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.titleBar = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.Label();
            this.modeBtn = new System.Windows.Forms.Button();
            this.piBtn = new System.Windows.Forms.Button();
            this.logBtn = new System.Windows.Forms.Button();
            this.buttonIn = new System.Windows.Forms.Button();
            this.buttonDot = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.RichTextBox();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEq = new System.Windows.Forms.Button();
            this.radicalBtn = new System.Windows.Forms.Button();
            this.exponentBtn = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.trigoBtn = new System.Windows.Forms.Button();
            this.fractionBtn = new System.Windows.Forms.Button();
            this.natLogBtn = new System.Windows.Forms.Button();
            this.parOpBtn = new System.Windows.Forms.Button();
            this.parEndBtn = new System.Windows.Forms.Button();
            this.posNegBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.clrBtn = new System.Windows.Forms.Button();
            this.titleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleBar
            // 
            this.titleBar.Controls.Add(this.closeBtn);
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(567, 27);
            this.titleBar.TabIndex = 0;
            this.titleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseDown);
            // 
            // closeBtn
            // 
            this.closeBtn.Image = ((System.Drawing.Image)(resources.GetObject("closeBtn.Image")));
            this.closeBtn.Location = new System.Drawing.Point(385, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(20, 19);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // modeBtn
            // 
            this.modeBtn.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modeBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.modeBtn.Location = new System.Drawing.Point(3, 132);
            this.modeBtn.Name = "modeBtn";
            this.modeBtn.Size = new System.Drawing.Size(62, 35);
            this.modeBtn.TabIndex = 3;
            this.modeBtn.Text = "RAD";
            this.modeBtn.UseVisualStyleBackColor = true;
            // 
            // piBtn
            // 
            this.piBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.piBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.piBtn.Location = new System.Drawing.Point(71, 132);
            this.piBtn.Name = "piBtn";
            this.piBtn.Size = new System.Drawing.Size(60, 35);
            this.piBtn.TabIndex = 3;
            this.piBtn.Text = "Π";
            this.piBtn.UseVisualStyleBackColor = true;
            // 
            // logBtn
            // 
            this.logBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.logBtn.Location = new System.Drawing.Point(3, 173);
            this.logBtn.Name = "logBtn";
            this.logBtn.Size = new System.Drawing.Size(62, 35);
            this.logBtn.TabIndex = 3;
            this.logBtn.Text = "Log";
            this.logBtn.UseVisualStyleBackColor = true;
            this.logBtn.Click += new System.EventHandler(this.logBtn_Click);
            // 
            // buttonIn
            // 
            this.buttonIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonIn.Location = new System.Drawing.Point(71, 173);
            this.buttonIn.Name = "buttonIn";
            this.buttonIn.Size = new System.Drawing.Size(60, 35);
            this.buttonIn.TabIndex = 3;
            this.buttonIn.Text = "In";
            this.buttonIn.UseVisualStyleBackColor = true;
            this.buttonIn.Click += new System.EventHandler(this.buttonIn_Click);
            // 
            // buttonDot
            // 
            this.buttonDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDot.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDot.Location = new System.Drawing.Point(269, 248);
            this.buttonDot.Name = "buttonDot";
            this.buttonDot.Size = new System.Drawing.Size(60, 36);
            this.buttonDot.TabIndex = 3;
            this.buttonDot.Text = ".";
            this.buttonDot.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonDot.UseVisualStyleBackColor = true;
            this.buttonDot.Click += new System.EventHandler(this.dotBtn_Click);
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(11, 24);
            this.textBox.Margin = new System.Windows.Forms.Padding(2);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(394, 62);
            this.textBox.TabIndex = 4;
            this.textBox.Text = "0";
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(335, 376);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(70, 55);
            this.button11.TabIndex = 6;
            this.button11.Text = "button11";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(335, 315);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(70, 55);
            this.button12.TabIndex = 7;
            this.button12.Text = "button12";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(335, 254);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(70, 55);
            this.button13.TabIndex = 8;
            this.button13.Text = "button13";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(335, 193);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(70, 55);
            this.button14.TabIndex = 9;
            this.button14.Text = "button14";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(335, 132);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(70, 55);
            this.buttonAdd.TabIndex = 10;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEq
            // 
            this.buttonEq.Image = ((System.Drawing.Image)(resources.GetObject("buttonEq.Image")));
            this.buttonEq.Location = new System.Drawing.Point(335, 437);
            this.buttonEq.Name = "buttonEq";
            this.buttonEq.Size = new System.Drawing.Size(70, 55);
            this.buttonEq.TabIndex = 5;
            this.buttonEq.UseVisualStyleBackColor = true;
            this.buttonEq.Click += new System.EventHandler(this.buttonEq_Click);
            // 
            // radicalBtn
            // 
            this.radicalBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radicalBtn.Image = ((System.Drawing.Image)(resources.GetObject("radicalBtn.Image")));
            this.radicalBtn.Location = new System.Drawing.Point(71, 214);
            this.radicalBtn.Name = "radicalBtn";
            this.radicalBtn.Size = new System.Drawing.Size(60, 35);
            this.radicalBtn.TabIndex = 3;
            this.radicalBtn.UseVisualStyleBackColor = true;
            // 
            // exponentBtn
            // 
            this.exponentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exponentBtn.Image = ((System.Drawing.Image)(resources.GetObject("exponentBtn.Image")));
            this.exponentBtn.Location = new System.Drawing.Point(3, 214);
            this.exponentBtn.Name = "exponentBtn";
            this.exponentBtn.Size = new System.Drawing.Size(62, 35);
            this.exponentBtn.TabIndex = 3;
            this.exponentBtn.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.Location = new System.Drawing.Point(269, 132);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(60, 35);
            this.button9.TabIndex = 3;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Image = global::NYAScieCal.Properties.Resources._3;
            this.button3.Location = new System.Drawing.Point(269, 208);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 35);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.Image = global::NYAScieCal.Properties.Resources._6;
            this.button6.Location = new System.Drawing.Point(269, 170);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(60, 35);
            this.button6.TabIndex = 3;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button0
            // 
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button0.Image = global::NYAScieCal.Properties.Resources._0;
            this.button0.Location = new System.Drawing.Point(203, 248);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(60, 36);
            this.button0.TabIndex = 3;
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Image = global::NYAScieCal.Properties.Resources._2;
            this.button2.Location = new System.Drawing.Point(203, 208);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.button2.Size = new System.Drawing.Size(60, 35);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Image = global::NYAScieCal.Properties.Resources._5;
            this.button5.Location = new System.Drawing.Point(203, 170);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(60, 35);
            this.button5.TabIndex = 3;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button8.Image = global::NYAScieCal.Properties.Resources._8;
            this.button8.Location = new System.Drawing.Point(203, 132);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(60, 35);
            this.button8.TabIndex = 3;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(137, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 35);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Image = global::NYAScieCal.Properties.Resources._4;
            this.button4.Location = new System.Drawing.Point(137, 170);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 35);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button7.Image = global::NYAScieCal.Properties.Resources._7;
            this.button7.Location = new System.Drawing.Point(137, 132);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(60, 35);
            this.button7.TabIndex = 3;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // trigoBtn
            // 
            this.trigoBtn.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trigoBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.trigoBtn.Image = ((System.Drawing.Image)(resources.GetObject("trigoBtn.Image")));
            this.trigoBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.trigoBtn.Location = new System.Drawing.Point(3, 91);
            this.trigoBtn.Name = "trigoBtn";
            this.trigoBtn.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.trigoBtn.Size = new System.Drawing.Size(146, 31);
            this.trigoBtn.TabIndex = 2;
            this.trigoBtn.Text = "Trigonometry";
            this.trigoBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.trigoBtn.UseVisualStyleBackColor = true;
            this.trigoBtn.Click += new System.EventHandler(this.trigoBtn_Click);
            // 
            // fractionBtn
            // 
            this.fractionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fractionBtn.Location = new System.Drawing.Point(3, 254);
            this.fractionBtn.Name = "fractionBtn";
            this.fractionBtn.Size = new System.Drawing.Size(62, 35);
            this.fractionBtn.TabIndex = 3;
            this.fractionBtn.UseVisualStyleBackColor = true;
            // 
            // natLogBtn
            // 
            this.natLogBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.natLogBtn.Location = new System.Drawing.Point(69, 254);
            this.natLogBtn.Name = "natLogBtn";
            this.natLogBtn.Size = new System.Drawing.Size(62, 35);
            this.natLogBtn.TabIndex = 3;
            this.natLogBtn.UseVisualStyleBackColor = true;
            // 
            // parOpBtn
            // 
            this.parOpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parOpBtn.Location = new System.Drawing.Point(3, 295);
            this.parOpBtn.Name = "parOpBtn";
            this.parOpBtn.Size = new System.Drawing.Size(62, 35);
            this.parOpBtn.TabIndex = 3;
            this.parOpBtn.UseVisualStyleBackColor = true;
            // 
            // parEndBtn
            // 
            this.parEndBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parEndBtn.Location = new System.Drawing.Point(69, 295);
            this.parEndBtn.Name = "parEndBtn";
            this.parEndBtn.Size = new System.Drawing.Size(62, 35);
            this.parEndBtn.TabIndex = 3;
            this.parEndBtn.UseVisualStyleBackColor = true;
            // 
            // posNegBtn
            // 
            this.posNegBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.posNegBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.posNegBtn.Location = new System.Drawing.Point(137, 249);
            this.posNegBtn.Name = "posNegBtn";
            this.posNegBtn.Size = new System.Drawing.Size(60, 35);
            this.posNegBtn.TabIndex = 3;
            this.posNegBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.posNegBtn.UseVisualStyleBackColor = true;
            this.posNegBtn.Click += new System.EventHandler(this.clrBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(137, 290);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 203);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button10.Location = new System.Drawing.Point(345, 91);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(60, 36);
            this.button10.TabIndex = 3;
            this.button10.Text = "x";
            this.button10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // clrBtn
            // 
            this.clrBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clrBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clrBtn.Location = new System.Drawing.Point(279, 91);
            this.clrBtn.Name = "clrBtn";
            this.clrBtn.Size = new System.Drawing.Size(60, 36);
            this.clrBtn.TabIndex = 3;
            this.clrBtn.Text = "c";
            this.clrBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.clrBtn.UseVisualStyleBackColor = true;
            this.clrBtn.Click += new System.EventHandler(this.clrBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 505);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.buttonEq);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.buttonIn);
            this.Controls.Add(this.radicalBtn);
            this.Controls.Add(this.parEndBtn);
            this.Controls.Add(this.parOpBtn);
            this.Controls.Add(this.natLogBtn);
            this.Controls.Add(this.fractionBtn);
            this.Controls.Add(this.exponentBtn);
            this.Controls.Add(this.logBtn);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.posNegBtn);
            this.Controls.Add(this.clrBtn);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.buttonDot);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.piBtn);
            this.Controls.Add(this.modeBtn);
            this.Controls.Add(this.trigoBtn);
            this.Controls.Add(this.titleBar);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.titleBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titleBar;
        private System.Windows.Forms.Button trigoBtn;
        private System.Windows.Forms.Button modeBtn;
        private System.Windows.Forms.Button piBtn;
        private System.Windows.Forms.Label closeBtn;
        private System.Windows.Forms.Button logBtn;
        private System.Windows.Forms.Button buttonIn;
        private System.Windows.Forms.Button exponentBtn;
        private System.Windows.Forms.Button radicalBtn;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonDot;
        private System.Windows.Forms.RichTextBox textBox;
        private System.Windows.Forms.Button buttonEq;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button fractionBtn;
        private System.Windows.Forms.Button natLogBtn;
        private System.Windows.Forms.Button parOpBtn;
        private System.Windows.Forms.Button parEndBtn;
        private System.Windows.Forms.Button posNegBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button clrBtn;
    }
}

