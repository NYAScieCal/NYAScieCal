
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
            this.moduloBtn = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonSubtract = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEq = new System.Windows.Forms.Button();
            this.radicalBtn = new System.Windows.Forms.Button();
            this.expBtn = new System.Windows.Forms.Button();
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
            this.eulerBtn = new System.Windows.Forms.Button();
            this.permBtn = new System.Windows.Forms.Button();
            this.parOpBtn = new System.Windows.Forms.Button();
            this.parEndBtn = new System.Windows.Forms.Button();
            this.posNegBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.clrBtn = new System.Windows.Forms.Button();
            this.modeComboBox = new System.Windows.Forms.ComboBox();
            this.logFuncBtn = new System.Windows.Forms.Button();
            this.eulerFuncBtn = new System.Windows.Forms.Button();
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
            // moduloBtn
            // 
            this.moduloBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moduloBtn.Location = new System.Drawing.Point(335, 376);
            this.moduloBtn.Name = "moduloBtn";
            this.moduloBtn.Size = new System.Drawing.Size(70, 55);
            this.moduloBtn.TabIndex = 6;
            this.moduloBtn.Text = "%";
            this.moduloBtn.UseVisualStyleBackColor = true;
            this.moduloBtn.Click += new System.EventHandler(this.button11_Click);
            // 
            // buttonDivide
            // 
            this.buttonDivide.Location = new System.Drawing.Point(335, 315);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(70, 55);
            this.buttonDivide.TabIndex = 7;
            this.buttonDivide.UseVisualStyleBackColor = true;
            this.buttonDivide.Click += new System.EventHandler(this.buttonDivide_Click);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.Location = new System.Drawing.Point(335, 254);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(70, 55);
            this.buttonMultiply.TabIndex = 8;
            this.buttonMultiply.UseVisualStyleBackColor = true;
            this.buttonMultiply.Click += new System.EventHandler(this.buttonMultiply_Click);
            // 
            // buttonSubtract
            // 
            this.buttonSubtract.Location = new System.Drawing.Point(335, 193);
            this.buttonSubtract.Name = "buttonSubtract";
            this.buttonSubtract.Size = new System.Drawing.Size(70, 55);
            this.buttonSubtract.TabIndex = 9;
            this.buttonSubtract.UseVisualStyleBackColor = true;
            this.buttonSubtract.Click += new System.EventHandler(this.buttonSubtract_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(335, 132);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(70, 55);
            this.buttonAdd.TabIndex = 10;
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
            this.radicalBtn.Click += new System.EventHandler(this.radicalBtn_Click);
            // 
            // expBtn
            // 
            this.expBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expBtn.Image = ((System.Drawing.Image)(resources.GetObject("expBtn.Image")));
            this.expBtn.Location = new System.Drawing.Point(3, 214);
            this.expBtn.Name = "expBtn";
            this.expBtn.Size = new System.Drawing.Size(62, 35);
            this.expBtn.TabIndex = 3;
            this.expBtn.UseVisualStyleBackColor = true;
            this.expBtn.Click += new System.EventHandler(this.expBtn_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
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
            // eulerBtn
            // 
            this.eulerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eulerBtn.Location = new System.Drawing.Point(3, 254);
            this.eulerBtn.Name = "eulerBtn";
            this.eulerBtn.Size = new System.Drawing.Size(62, 35);
            this.eulerBtn.TabIndex = 3;
            this.eulerBtn.UseVisualStyleBackColor = true;
            this.eulerBtn.Click += new System.EventHandler(this.eulerBtn_Click);
            // 
            // permBtn
            // 
            this.permBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.permBtn.Location = new System.Drawing.Point(69, 254);
            this.permBtn.Name = "permBtn";
            this.permBtn.Size = new System.Drawing.Size(62, 35);
            this.permBtn.TabIndex = 3;
            this.permBtn.Text = "n!";
            this.permBtn.UseVisualStyleBackColor = true;
            this.permBtn.Click += new System.EventHandler(this.permBtn_Click);
            // 
            // parOpBtn
            // 
            this.parOpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parOpBtn.Location = new System.Drawing.Point(3, 295);
            this.parOpBtn.Name = "parOpBtn";
            this.parOpBtn.Size = new System.Drawing.Size(62, 35);
            this.parOpBtn.TabIndex = 3;
            this.parOpBtn.UseVisualStyleBackColor = true;
            this.parOpBtn.Click += new System.EventHandler(this.parOpBtn_Click);
            // 
            // parEndBtn
            // 
            this.parEndBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parEndBtn.Location = new System.Drawing.Point(69, 295);
            this.parEndBtn.Name = "parEndBtn";
            this.parEndBtn.Size = new System.Drawing.Size(62, 35);
            this.parEndBtn.TabIndex = 3;
            this.parEndBtn.UseVisualStyleBackColor = true;
            this.parEndBtn.Click += new System.EventHandler(this.parEndBtn_Click);
            // 
            // posNegBtn
            // 
            this.posNegBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.posNegBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.posNegBtn.Location = new System.Drawing.Point(137, 249);
            this.posNegBtn.Name = "posNegBtn";
            this.posNegBtn.Size = new System.Drawing.Size(60, 35);
            this.posNegBtn.TabIndex = 3;
            this.posNegBtn.Text = "+ / -";
            this.posNegBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.posNegBtn.UseVisualStyleBackColor = true;
            this.posNegBtn.Click += new System.EventHandler(this.clrBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(137, 290);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 202);
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
            // modeComboBox
            // 
            this.modeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modeComboBox.FormattingEnabled = true;
            this.modeComboBox.Items.AddRange(new object[] {
            "Standard",
            "Graphing"});
            this.modeComboBox.Location = new System.Drawing.Point(155, 92);
            this.modeComboBox.Name = "modeComboBox";
            this.modeComboBox.Size = new System.Drawing.Size(121, 28);
            this.modeComboBox.TabIndex = 12;
            this.modeComboBox.SelectedIndexChanged += new System.EventHandler(this.modeComboBox_SelectedIndexChanged);
            // 
            // logFuncBtn
            // 
            this.logFuncBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logFuncBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.logFuncBtn.Location = new System.Drawing.Point(3, 336);
            this.logFuncBtn.Name = "logFuncBtn";
            this.logFuncBtn.Size = new System.Drawing.Size(62, 35);
            this.logFuncBtn.TabIndex = 3;
            this.logFuncBtn.UseVisualStyleBackColor = true;
            this.logFuncBtn.Click += new System.EventHandler(this.logBtn_Click);
            // 
            // eulerFuncBtn
            // 
            this.eulerFuncBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eulerFuncBtn.Location = new System.Drawing.Point(69, 336);
            this.eulerFuncBtn.Name = "eulerFuncBtn";
            this.eulerFuncBtn.Size = new System.Drawing.Size(62, 35);
            this.eulerFuncBtn.TabIndex = 3;
            this.eulerFuncBtn.UseVisualStyleBackColor = true;
            this.eulerFuncBtn.Click += new System.EventHandler(this.eulerBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 505);
            this.Controls.Add(this.modeComboBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonSubtract);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.buttonDivide);
            this.Controls.Add(this.moduloBtn);
            this.Controls.Add(this.buttonEq);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.buttonIn);
            this.Controls.Add(this.radicalBtn);
            this.Controls.Add(this.parEndBtn);
            this.Controls.Add(this.parOpBtn);
            this.Controls.Add(this.permBtn);
            this.Controls.Add(this.eulerFuncBtn);
            this.Controls.Add(this.eulerBtn);
            this.Controls.Add(this.expBtn);
            this.Controls.Add(this.logFuncBtn);
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
        private System.Windows.Forms.Button expBtn;
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
        private System.Windows.Forms.Button moduloBtn;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttonSubtract;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button eulerBtn;
        private System.Windows.Forms.Button permBtn;
        private System.Windows.Forms.Button parOpBtn;
        private System.Windows.Forms.Button parEndBtn;
        private System.Windows.Forms.Button posNegBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button clrBtn;
        private System.Windows.Forms.ComboBox modeComboBox;
        private System.Windows.Forms.Button logFuncBtn;
        private System.Windows.Forms.Button eulerFuncBtn;
    }
}

