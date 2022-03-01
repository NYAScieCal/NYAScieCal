
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.trigoBtn = new System.Windows.Forms.Button();
            this.modeBtn = new System.Windows.Forms.Button();
            this.piBtn = new System.Windows.Forms.Button();
            this.titleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleBar
            // 
            this.titleBar.Controls.Add(this.closeBtn);
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(420, 25);
            this.titleBar.TabIndex = 0;
            this.titleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseDown);
            // 
            // closeBtn
            // 
            this.closeBtn.Image = ((System.Drawing.Image)(resources.GetObject("closeBtn.Image")));
            this.closeBtn.Location = new System.Drawing.Point(402, 4);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(20, 20);
            this.closeBtn.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 27);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(414, 58);
            this.textBox1.TabIndex = 1;
            // 
            // trigoBtn
            // 
            this.trigoBtn.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trigoBtn.Image = ((System.Drawing.Image)(resources.GetObject("trigoBtn.Image")));
            this.trigoBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.trigoBtn.Location = new System.Drawing.Point(3, 91);
            this.trigoBtn.Name = "trigoBtn";
            this.trigoBtn.Size = new System.Drawing.Size(146, 31);
            this.trigoBtn.TabIndex = 2;
            this.trigoBtn.Text = "Trigonometry";
            this.trigoBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.trigoBtn.UseVisualStyleBackColor = true;
            this.trigoBtn.Click += new System.EventHandler(this.trigoBtn_Click);
            // 
            // modeBtn
            // 
            this.modeBtn.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modeBtn.Location = new System.Drawing.Point(3, 132);
            this.modeBtn.Name = "modeBtn";
            this.modeBtn.Size = new System.Drawing.Size(75, 35);
            this.modeBtn.TabIndex = 3;
            this.modeBtn.Text = "RAD";
            this.modeBtn.UseVisualStyleBackColor = true;
            // 
            // piBtn
            // 
            this.piBtn.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.piBtn.Location = new System.Drawing.Point(81, 132);
            this.piBtn.Name = "piBtn";
            this.piBtn.Size = new System.Drawing.Size(75, 35);
            this.piBtn.TabIndex = 3;
            this.piBtn.Text = "Π";
            this.piBtn.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 410);
            this.Controls.Add(this.piBtn);
            this.Controls.Add(this.modeBtn);
            this.Controls.Add(this.trigoBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.titleBar);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.titleBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel titleBar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button trigoBtn;
        private System.Windows.Forms.Button modeBtn;
        private System.Windows.Forms.Button piBtn;
        private System.Windows.Forms.Label closeBtn;
    }
}

