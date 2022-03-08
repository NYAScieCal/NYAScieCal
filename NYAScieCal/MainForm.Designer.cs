
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
            this.trigoBtn = new System.Windows.Forms.Button();
            this.modeBtn = new System.Windows.Forms.Button();
            this.piBtn = new System.Windows.Forms.Button();
            this.logBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.exponentBtn = new System.Windows.Forms.Button();
            this.radicalBtn = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonDot = new System.Windows.Forms.Button();
            this.textbox = new System.Windows.Forms.RichTextBox();
            this.titleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleBar
            // 
            this.titleBar.Controls.Add(this.closeBtn);
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Margin = new System.Windows.Forms.Padding(4);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(522, 31);
            this.titleBar.TabIndex = 0;
            this.titleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseDown);
            // 
            // closeBtn
            // 
            this.closeBtn.Image = ((System.Drawing.Image)(resources.GetObject("closeBtn.Image")));
            this.closeBtn.Location = new System.Drawing.Point(495, 4);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(27, 25);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // trigoBtn
            // 
            this.trigoBtn.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trigoBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.trigoBtn.Image = ((System.Drawing.Image)(resources.GetObject("trigoBtn.Image")));
            this.trigoBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.trigoBtn.Location = new System.Drawing.Point(4, 112);
            this.trigoBtn.Margin = new System.Windows.Forms.Padding(4);
            this.trigoBtn.Name = "trigoBtn";
            this.trigoBtn.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.trigoBtn.Size = new System.Drawing.Size(195, 38);
            this.trigoBtn.TabIndex = 2;
            this.trigoBtn.Text = "Trigonometry";
            this.trigoBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.trigoBtn.UseVisualStyleBackColor = true;
            this.trigoBtn.Click += new System.EventHandler(this.trigoBtn_Click);
            // 
            // modeBtn
            // 
            this.modeBtn.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modeBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.modeBtn.Location = new System.Drawing.Point(4, 162);
            this.modeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.modeBtn.Name = "modeBtn";
            this.modeBtn.Size = new System.Drawing.Size(83, 43);
            this.modeBtn.TabIndex = 3;
            this.modeBtn.Text = "RAD";
            this.modeBtn.UseVisualStyleBackColor = true;
            // 
            // piBtn
            // 
            this.piBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.piBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.piBtn.Location = new System.Drawing.Point(95, 162);
            this.piBtn.Margin = new System.Windows.Forms.Padding(4);
            this.piBtn.Name = "piBtn";
            this.piBtn.Size = new System.Drawing.Size(80, 43);
            this.piBtn.TabIndex = 3;
            this.piBtn.Text = "Π";
            this.piBtn.UseVisualStyleBackColor = true;
            // 
            // logBtn
            // 
            this.logBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.logBtn.Location = new System.Drawing.Point(4, 213);
            this.logBtn.Margin = new System.Windows.Forms.Padding(4);
            this.logBtn.Name = "logBtn";
            this.logBtn.Size = new System.Drawing.Size(83, 43);
            this.logBtn.TabIndex = 3;
            this.logBtn.Text = "Log";
            this.logBtn.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(95, 213);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 43);
            this.button2.TabIndex = 3;
            this.button2.Text = "In";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // exponentBtn
            // 
            this.exponentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exponentBtn.Image = ((System.Drawing.Image)(resources.GetObject("exponentBtn.Image")));
            this.exponentBtn.Location = new System.Drawing.Point(4, 264);
            this.exponentBtn.Margin = new System.Windows.Forms.Padding(4);
            this.exponentBtn.Name = "exponentBtn";
            this.exponentBtn.Size = new System.Drawing.Size(83, 43);
            this.exponentBtn.TabIndex = 3;
            this.exponentBtn.UseVisualStyleBackColor = true;
            // 
            // radicalBtn
            // 
            this.radicalBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radicalBtn.Image = ((System.Drawing.Image)(resources.GetObject("radicalBtn.Image")));
            this.radicalBtn.Location = new System.Drawing.Point(95, 264);
            this.radicalBtn.Margin = new System.Windows.Forms.Padding(4);
            this.radicalBtn.Name = "radicalBtn";
            this.radicalBtn.Size = new System.Drawing.Size(80, 43);
            this.radicalBtn.TabIndex = 3;
            this.radicalBtn.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button7.Location = new System.Drawing.Point(206, 162);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 43);
            this.button7.TabIndex = 3;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button8.Location = new System.Drawing.Point(314, 162);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(100, 43);
            this.button8.TabIndex = 3;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(206, 213);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 43);
            this.button4.TabIndex = 3;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(206, 264);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 43);
            this.button1.TabIndex = 3;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Location = new System.Drawing.Point(314, 213);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 43);
            this.button5.TabIndex = 3;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button9.Location = new System.Drawing.Point(422, 162);
            this.button9.Margin = new System.Windows.Forms.Padding(4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(100, 43);
            this.button9.TabIndex = 3;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.Location = new System.Drawing.Point(422, 213);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 43);
            this.button6.TabIndex = 3;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(422, 264);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 43);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button15.Location = new System.Drawing.Point(314, 264);
            this.button15.Margin = new System.Windows.Forms.Padding(4);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(100, 43);
            this.button15.TabIndex = 3;
            this.button15.Text = "2";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button0
            // 
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button0.Location = new System.Drawing.Point(314, 315);
            this.button0.Margin = new System.Windows.Forms.Padding(4);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(100, 43);
            this.button0.TabIndex = 3;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // buttonDot
            // 
            this.buttonDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDot.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDot.Location = new System.Drawing.Point(422, 315);
            this.buttonDot.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDot.Name = "buttonDot";
            this.buttonDot.Size = new System.Drawing.Size(100, 43);
            this.buttonDot.TabIndex = 3;
            this.buttonDot.Text = ".";
            this.buttonDot.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonDot.UseVisualStyleBackColor = true;
            // 
            // textbox
            // 
            this.textbox.Location = new System.Drawing.Point(4, 29);
            this.textbox.Name = "textbox";
            this.textbox.Size = new System.Drawing.Size(518, 76);
            this.textbox.TabIndex = 4;
            this.textbox.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 505);
            this.Controls.Add(this.textbox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.radicalBtn);
            this.Controls.Add(this.exponentBtn);
            this.Controls.Add(this.logBtn);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.buttonDot);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.piBtn);
            this.Controls.Add(this.modeBtn);
            this.Controls.Add(this.trigoBtn);
            this.Controls.Add(this.titleBar);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Form1";
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
        private System.Windows.Forms.Button button2;
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
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonDot;
        private System.Windows.Forms.RichTextBox textbox;
    }
}

