using System.Drawing;

namespace Calculator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PnlTitle = new System.Windows.Forms.Panel();
            this.TitlePicture = new System.Windows.Forms.PictureBox();
            this.BtnMinimize = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.PnlHistory = new System.Windows.Forms.Panel();
            this.RtBoxDisplayHistory = new System.Windows.Forms.RichTextBox();
            this.BtnClearHistory = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnHistory = new System.Windows.Forms.Button();
            this.TxtDisplay2 = new System.Windows.Forms.TextBox();
            this.TxtDisplay1 = new System.Windows.Forms.TextBox();
            this.SquareBtn = new Calculator.CustomButton();
            this.CubeBtn = new Calculator.CustomButton();
            this.SquareRootBtn = new Calculator.CustomButton();
            this.CubeRootBtn = new Calculator.CustomButton();
            this.OneDivBtn = new Calculator.CustomButton();
            this.LogBtn = new Calculator.CustomButton();
            this.BtnPercent = new Calculator.CustomButton();
            this.Btn3 = new Calculator.CustomButton();
            this.Btn6 = new Calculator.CustomButton();
            this.Btn9 = new Calculator.CustomButton();
            this.BtnCE = new Calculator.CustomButton();
            this.Btn0 = new Calculator.CustomButton();
            this.BtnEquals = new Calculator.CustomButton();
            this.Btn2 = new Calculator.CustomButton();
            this.BtnAdd = new Calculator.CustomButton();
            this.Btn5 = new Calculator.CustomButton();
            this.BtnDiv = new Calculator.CustomButton();
            this.BtnPM = new Calculator.CustomButton();
            this.Btn8 = new Calculator.CustomButton();
            this.Btn1 = new Calculator.CustomButton();
            this.BtnPi = new Calculator.CustomButton();
            this.Btn4 = new Calculator.CustomButton();
            this.BtnDesimal = new Calculator.CustomButton();
            this.BtnCos = new Calculator.CustomButton();
            this.BtnSub = new Calculator.CustomButton();
            this.Btn7 = new Calculator.CustomButton();
            this.BtnMul = new Calculator.CustomButton();
            this.BtnBackSpace = new Calculator.CustomButton();
            this.BtnE = new Calculator.CustomButton();
            this.BtnSin = new Calculator.CustomButton();
            this.BtnC = new Calculator.CustomButton();
            this.PnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TitlePicture)).BeginInit();
            this.PnlHistory.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlTitle
            // 
            this.PnlTitle.Controls.Add(this.TitlePicture);
            this.PnlTitle.Controls.Add(this.BtnMinimize);
            this.PnlTitle.Controls.Add(this.BtnExit);
            this.PnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTitle.Location = new System.Drawing.Point(0, 0);
            this.PnlTitle.Margin = new System.Windows.Forms.Padding(0);
            this.PnlTitle.Name = "PnlTitle";
            this.PnlTitle.Size = new System.Drawing.Size(350, 40);
            this.PnlTitle.TabIndex = 0;
            this.PnlTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlTitle_MouseDown);
            // 
            // TitlePicture
            // 
            this.TitlePicture.Image = ((System.Drawing.Image)(resources.GetObject("TitlePicture.Image")));
            this.TitlePicture.Location = new System.Drawing.Point(9, 11);
            this.TitlePicture.Name = "TitlePicture";
            this.TitlePicture.Size = new System.Drawing.Size(221, 28);
            this.TitlePicture.TabIndex = 2;
            this.TitlePicture.TabStop = false;
            this.TitlePicture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitlePicture_MouseDown);
            // 
            // BtnMinimize
            // 
            this.BtnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnMinimize.FlatAppearance.BorderSize = 0;
            this.BtnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("BtnMinimize.Image")));
            this.BtnMinimize.Location = new System.Drawing.Point(250, 0);
            this.BtnMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMinimize.Name = "BtnMinimize";
            this.BtnMinimize.Size = new System.Drawing.Size(50, 40);
            this.BtnMinimize.TabIndex = 4;
            this.BtnMinimize.UseCompatibleTextRendering = true;
            this.BtnMinimize.UseVisualStyleBackColor = true;
            this.BtnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Image = ((System.Drawing.Image)(resources.GetObject("BtnExit.Image")));
            this.BtnExit.Location = new System.Drawing.Point(300, 0);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(0);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(50, 40);
            this.BtnExit.TabIndex = 1;
            this.BtnExit.UseCompatibleTextRendering = true;
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // PnlHistory
            // 
            this.PnlHistory.Controls.Add(this.RtBoxDisplayHistory);
            this.PnlHistory.Controls.Add(this.BtnClearHistory);
            this.PnlHistory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlHistory.Location = new System.Drawing.Point(0, 575);
            this.PnlHistory.Margin = new System.Windows.Forms.Padding(0);
            this.PnlHistory.Name = "PnlHistory";
            this.PnlHistory.Size = new System.Drawing.Size(350, 0);
            this.PnlHistory.TabIndex = 1;
            // 
            // RtBoxDisplayHistory
            // 
            this.RtBoxDisplayHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.RtBoxDisplayHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RtBoxDisplayHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RtBoxDisplayHistory.ForeColor = System.Drawing.Color.Silver;
            this.RtBoxDisplayHistory.Location = new System.Drawing.Point(0, 0);
            this.RtBoxDisplayHistory.Margin = new System.Windows.Forms.Padding(0);
            this.RtBoxDisplayHistory.Name = "RtBoxDisplayHistory";
            this.RtBoxDisplayHistory.ReadOnly = true;
            this.RtBoxDisplayHistory.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.RtBoxDisplayHistory.Size = new System.Drawing.Size(350, 0);
            this.RtBoxDisplayHistory.TabIndex = 6;
            this.RtBoxDisplayHistory.Text = "";
            // 
            // BtnClearHistory
            // 
            this.BtnClearHistory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnClearHistory.FlatAppearance.BorderSize = 0;
            this.BtnClearHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClearHistory.Image = ((System.Drawing.Image)(resources.GetObject("BtnClearHistory.Image")));
            this.BtnClearHistory.Location = new System.Drawing.Point(0, -40);
            this.BtnClearHistory.Margin = new System.Windows.Forms.Padding(0);
            this.BtnClearHistory.Name = "BtnClearHistory";
            this.BtnClearHistory.Size = new System.Drawing.Size(350, 40);
            this.BtnClearHistory.TabIndex = 5;
            this.BtnClearHistory.UseCompatibleTextRendering = true;
            this.BtnClearHistory.UseVisualStyleBackColor = true;
            this.BtnClearHistory.Click += new System.EventHandler(this.BtnClearHistory_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnHistory);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 40);
            this.panel1.TabIndex = 2;
            // 
            // BtnHistory
            // 
            this.BtnHistory.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnHistory.FlatAppearance.BorderSize = 0;
            this.BtnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHistory.Image = ((System.Drawing.Image)(resources.GetObject("BtnHistory.Image")));
            this.BtnHistory.Location = new System.Drawing.Point(0, 0);
            this.BtnHistory.Margin = new System.Windows.Forms.Padding(0);
            this.BtnHistory.Name = "BtnHistory";
            this.BtnHistory.Size = new System.Drawing.Size(50, 40);
            this.BtnHistory.TabIndex = 1;
            this.BtnHistory.UseCompatibleTextRendering = true;
            this.BtnHistory.UseVisualStyleBackColor = true;
            this.BtnHistory.Click += new System.EventHandler(this.BtnHistory_Click);
            // 
            // TxtDisplay2
            // 
            this.TxtDisplay2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.TxtDisplay2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDisplay2.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtDisplay2.Font = new System.Drawing.Font("Gadugi", 14F);
            this.TxtDisplay2.ForeColor = System.Drawing.Color.Silver;
            this.TxtDisplay2.Location = new System.Drawing.Point(0, 80);
            this.TxtDisplay2.Margin = new System.Windows.Forms.Padding(0);
            this.TxtDisplay2.Multiline = true;
            this.TxtDisplay2.Name = "TxtDisplay2";
            this.TxtDisplay2.ReadOnly = true;
            this.TxtDisplay2.Size = new System.Drawing.Size(350, 35);
            this.TxtDisplay2.TabIndex = 3;
            this.TxtDisplay2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtDisplay1
            // 
            this.TxtDisplay1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.TxtDisplay1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDisplay1.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtDisplay1.Font = new System.Drawing.Font("Gadugi", 25F, System.Drawing.FontStyle.Bold);
            this.TxtDisplay1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TxtDisplay1.Location = new System.Drawing.Point(0, 115);
            this.TxtDisplay1.Margin = new System.Windows.Forms.Padding(0);
            this.TxtDisplay1.Multiline = true;
            this.TxtDisplay1.Name = "TxtDisplay1";
            this.TxtDisplay1.Size = new System.Drawing.Size(350, 57);
            this.TxtDisplay1.TabIndex = 4;
            this.TxtDisplay1.Tag = "";
            this.TxtDisplay1.Text = "0";
            this.TxtDisplay1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtDisplay1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDisplay1KeyPress);
            // 
            // SquareBtn
            // 
            this.SquareBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.SquareBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.SquareBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.SquareBtn.BorderRadius = 15;
            this.SquareBtn.BorderSize = 0;
            this.SquareBtn.FlatAppearance.BorderSize = 0;
            this.SquareBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SquareBtn.Font = new System.Drawing.Font("Gadugi", 12F);
            this.SquareBtn.ForeColor = System.Drawing.Color.DarkGray;
            this.SquareBtn.Location = new System.Drawing.Point(9, 182);
            this.SquareBtn.Margin = new System.Windows.Forms.Padding(0);
            this.SquareBtn.Name = "SquareBtn";
            this.SquareBtn.Size = new System.Drawing.Size(50, 30);
            this.SquareBtn.TabIndex = 6;
            this.SquareBtn.Text = "x²";
            this.SquareBtn.TextColor = System.Drawing.Color.DarkGray;
            this.SquareBtn.UseVisualStyleBackColor = false;
            this.SquareBtn.Click += new System.EventHandler(this.AdditionalOperations_Click);
            // 
            // CubeBtn
            // 
            this.CubeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.CubeBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.CubeBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.CubeBtn.BorderRadius = 15;
            this.CubeBtn.BorderSize = 0;
            this.CubeBtn.FlatAppearance.BorderSize = 0;
            this.CubeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CubeBtn.Font = new System.Drawing.Font("Gadugi", 12F);
            this.CubeBtn.ForeColor = System.Drawing.Color.DarkGray;
            this.CubeBtn.Location = new System.Drawing.Point(66, 182);
            this.CubeBtn.Margin = new System.Windows.Forms.Padding(0);
            this.CubeBtn.Name = "CubeBtn";
            this.CubeBtn.Size = new System.Drawing.Size(50, 30);
            this.CubeBtn.TabIndex = 6;
            this.CubeBtn.Text = "x³";
            this.CubeBtn.TextColor = System.Drawing.Color.DarkGray;
            this.CubeBtn.UseVisualStyleBackColor = false;
            this.CubeBtn.Click += new System.EventHandler(this.AdditionalOperations_Click);
            // 
            // SquareRootBtn
            // 
            this.SquareRootBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.SquareRootBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.SquareRootBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.SquareRootBtn.BorderRadius = 15;
            this.SquareRootBtn.BorderSize = 0;
            this.SquareRootBtn.FlatAppearance.BorderSize = 0;
            this.SquareRootBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SquareRootBtn.Font = new System.Drawing.Font("Gadugi", 12F);
            this.SquareRootBtn.ForeColor = System.Drawing.Color.DarkGray;
            this.SquareRootBtn.Location = new System.Drawing.Point(124, 182);
            this.SquareRootBtn.Margin = new System.Windows.Forms.Padding(0);
            this.SquareRootBtn.Name = "SquareRootBtn";
            this.SquareRootBtn.Size = new System.Drawing.Size(50, 30);
            this.SquareRootBtn.TabIndex = 6;
            this.SquareRootBtn.Text = "√x";
            this.SquareRootBtn.TextColor = System.Drawing.Color.DarkGray;
            this.SquareRootBtn.UseVisualStyleBackColor = false;
            this.SquareRootBtn.Click += new System.EventHandler(this.AdditionalOperations_Click);
            // 
            // CubeRootBtn
            // 
            this.CubeRootBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.CubeRootBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.CubeRootBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.CubeRootBtn.BorderRadius = 15;
            this.CubeRootBtn.BorderSize = 0;
            this.CubeRootBtn.FlatAppearance.BorderSize = 0;
            this.CubeRootBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CubeRootBtn.Font = new System.Drawing.Font("Gadugi", 12F);
            this.CubeRootBtn.ForeColor = System.Drawing.Color.DarkGray;
            this.CubeRootBtn.Location = new System.Drawing.Point(180, 182);
            this.CubeRootBtn.Margin = new System.Windows.Forms.Padding(0);
            this.CubeRootBtn.Name = "CubeRootBtn";
            this.CubeRootBtn.Size = new System.Drawing.Size(50, 30);
            this.CubeRootBtn.TabIndex = 6;
            this.CubeRootBtn.Text = "∛x";
            this.CubeRootBtn.TextColor = System.Drawing.Color.DarkGray;
            this.CubeRootBtn.UseVisualStyleBackColor = false;
            this.CubeRootBtn.Click += new System.EventHandler(this.AdditionalOperations_Click);
            // 
            // OneDivBtn
            // 
            this.OneDivBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.OneDivBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.OneDivBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.OneDivBtn.BorderRadius = 15;
            this.OneDivBtn.BorderSize = 0;
            this.OneDivBtn.FlatAppearance.BorderSize = 0;
            this.OneDivBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OneDivBtn.Font = new System.Drawing.Font("Gadugi", 10F);
            this.OneDivBtn.ForeColor = System.Drawing.Color.DarkGray;
            this.OneDivBtn.Location = new System.Drawing.Point(235, 182);
            this.OneDivBtn.Margin = new System.Windows.Forms.Padding(0);
            this.OneDivBtn.Name = "OneDivBtn";
            this.OneDivBtn.Size = new System.Drawing.Size(50, 30);
            this.OneDivBtn.TabIndex = 6;
            this.OneDivBtn.Text = "1/x";
            this.OneDivBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.OneDivBtn.TextColor = System.Drawing.Color.DarkGray;
            this.OneDivBtn.UseVisualStyleBackColor = false;
            this.OneDivBtn.Click += new System.EventHandler(this.AdditionalOperations_Click);
            // 
            // LogBtn
            // 
            this.LogBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.LogBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.LogBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.LogBtn.BorderRadius = 15;
            this.LogBtn.BorderSize = 0;
            this.LogBtn.FlatAppearance.BorderSize = 0;
            this.LogBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogBtn.Font = new System.Drawing.Font("Gadugi", 10F);
            this.LogBtn.ForeColor = System.Drawing.Color.DarkGray;
            this.LogBtn.Location = new System.Drawing.Point(291, 182);
            this.LogBtn.Margin = new System.Windows.Forms.Padding(0);
            this.LogBtn.Name = "LogBtn";
            this.LogBtn.Size = new System.Drawing.Size(50, 30);
            this.LogBtn.TabIndex = 6;
            this.LogBtn.Text = "lg(x)";
            this.LogBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LogBtn.TextColor = System.Drawing.Color.DarkGray;
            this.LogBtn.UseVisualStyleBackColor = false;
            this.LogBtn.Click += new System.EventHandler(this.AdditionalOperations_Click);
            // 
            // BtnPercent
            // 
            this.BtnPercent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnPercent.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnPercent.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnPercent.BorderRadius = 65;
            this.BtnPercent.BorderSize = 0;
            this.BtnPercent.FlatAppearance.BorderSize = 0;
            this.BtnPercent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPercent.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPercent.ForeColor = System.Drawing.Color.White;
            this.BtnPercent.Location = new System.Drawing.Point(143, 494);
            this.BtnPercent.Margin = new System.Windows.Forms.Padding(0);
            this.BtnPercent.Name = "BtnPercent";
            this.BtnPercent.Size = new System.Drawing.Size(65, 65);
            this.BtnPercent.TabIndex = 5;
            this.BtnPercent.Text = "%";
            this.BtnPercent.TextColor = System.Drawing.Color.White;
            this.BtnPercent.UseVisualStyleBackColor = false;
            this.BtnPercent.Click += new System.EventHandler(this.BtnOperations_Click);
            // 
            // Btn3
            // 
            this.Btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Btn3.BorderRadius = 65;
            this.Btn3.BorderSize = 0;
            this.Btn3.FlatAppearance.BorderSize = 0;
            this.Btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn3.Image = ((System.Drawing.Image)(resources.GetObject("Btn3.Image")));
            this.Btn3.Location = new System.Drawing.Point(143, 425);
            this.Btn3.Margin = new System.Windows.Forms.Padding(0);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(65, 65);
            this.Btn3.TabIndex = 5;
            this.Btn3.Tag = "3";
            this.Btn3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn3.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn3.UseVisualStyleBackColor = false;
            this.Btn3.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn6
            // 
            this.Btn6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn6.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Btn6.BorderRadius = 65;
            this.Btn6.BorderSize = 0;
            this.Btn6.FlatAppearance.BorderSize = 0;
            this.Btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn6.Image = ((System.Drawing.Image)(resources.GetObject("Btn6.Image")));
            this.Btn6.Location = new System.Drawing.Point(143, 356);
            this.Btn6.Margin = new System.Windows.Forms.Padding(0);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(65, 65);
            this.Btn6.TabIndex = 5;
            this.Btn6.Tag = "6";
            this.Btn6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn6.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn6.UseVisualStyleBackColor = false;
            this.Btn6.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn9
            // 
            this.Btn9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn9.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Btn9.BorderRadius = 65;
            this.Btn9.BorderSize = 0;
            this.Btn9.FlatAppearance.BorderSize = 0;
            this.Btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn9.Image = ((System.Drawing.Image)(resources.GetObject("Btn9.Image")));
            this.Btn9.Location = new System.Drawing.Point(143, 287);
            this.Btn9.Margin = new System.Windows.Forms.Padding(0);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(65, 65);
            this.Btn9.TabIndex = 5;
            this.Btn9.Tag = "9";
            this.Btn9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn9.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn9.UseVisualStyleBackColor = false;
            this.Btn9.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // BtnCE
            // 
            this.BtnCE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnCE.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnCE.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnCE.BorderRadius = 65;
            this.BtnCE.BorderSize = 0;
            this.BtnCE.FlatAppearance.BorderSize = 0;
            this.BtnCE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCE.Font = new System.Drawing.Font("Gadugi", 14F);
            this.BtnCE.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnCE.Location = new System.Drawing.Point(143, 218);
            this.BtnCE.Margin = new System.Windows.Forms.Padding(0);
            this.BtnCE.Name = "BtnCE";
            this.BtnCE.Size = new System.Drawing.Size(65, 65);
            this.BtnCE.TabIndex = 5;
            this.BtnCE.Text = "CE";
            this.BtnCE.TextColor = System.Drawing.Color.Gainsboro;
            this.BtnCE.UseVisualStyleBackColor = false;
            this.BtnCE.Click += new System.EventHandler(this.BtnCE_Click);
            // 
            // Btn0
            // 
            this.Btn0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn0.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn0.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Btn0.BorderRadius = 65;
            this.Btn0.BorderSize = 0;
            this.Btn0.FlatAppearance.BorderSize = 0;
            this.Btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn0.Image = ((System.Drawing.Image)(resources.GetObject("Btn0.Image")));
            this.Btn0.Location = new System.Drawing.Point(74, 494);
            this.Btn0.Margin = new System.Windows.Forms.Padding(0);
            this.Btn0.Name = "Btn0";
            this.Btn0.Size = new System.Drawing.Size(65, 65);
            this.Btn0.TabIndex = 5;
            this.Btn0.Tag = "0";
            this.Btn0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn0.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn0.UseVisualStyleBackColor = false;
            this.Btn0.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // BtnEquals
            // 
            this.BtnEquals.BackColor = System.Drawing.Color.SlateBlue;
            this.BtnEquals.BackgroundColor = System.Drawing.Color.SlateBlue;
            this.BtnEquals.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnEquals.BorderRadius = 65;
            this.BtnEquals.BorderSize = 0;
            this.BtnEquals.FlatAppearance.BorderSize = 0;
            this.BtnEquals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEquals.Font = new System.Drawing.Font("Gadugi", 14F);
            this.BtnEquals.ForeColor = System.Drawing.Color.White;
            this.BtnEquals.Location = new System.Drawing.Point(281, 494);
            this.BtnEquals.Margin = new System.Windows.Forms.Padding(0);
            this.BtnEquals.Name = "BtnEquals";
            this.BtnEquals.Size = new System.Drawing.Size(65, 65);
            this.BtnEquals.TabIndex = 5;
            this.BtnEquals.Text = "=";
            this.BtnEquals.TextColor = System.Drawing.Color.White;
            this.BtnEquals.UseVisualStyleBackColor = false;
            this.BtnEquals.Click += new System.EventHandler(this.BtnEquals_Click);
            // 
            // Btn2
            // 
            this.Btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Btn2.BorderRadius = 65;
            this.Btn2.BorderSize = 0;
            this.Btn2.FlatAppearance.BorderSize = 0;
            this.Btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn2.Image = ((System.Drawing.Image)(resources.GetObject("Btn2.Image")));
            this.Btn2.Location = new System.Drawing.Point(74, 425);
            this.Btn2.Margin = new System.Windows.Forms.Padding(0);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(65, 65);
            this.Btn2.TabIndex = 5;
            this.Btn2.Tag = "2";
            this.Btn2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn2.UseVisualStyleBackColor = false;
            this.Btn2.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnAdd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnAdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnAdd.BorderRadius = 65;
            this.BtnAdd.BorderSize = 0;
            this.BtnAdd.FlatAppearance.BorderSize = 0;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Font = new System.Drawing.Font("Gadugi", 14F);
            this.BtnAdd.ForeColor = System.Drawing.Color.White;
            this.BtnAdd.Location = new System.Drawing.Point(281, 425);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(65, 65);
            this.BtnAdd.TabIndex = 5;
            this.BtnAdd.Text = "+";
            this.BtnAdd.TextColor = System.Drawing.Color.White;
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnMathOperation_Click);
            // 
            // Btn5
            // 
            this.Btn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn5.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Btn5.BorderRadius = 65;
            this.Btn5.BorderSize = 0;
            this.Btn5.FlatAppearance.BorderSize = 0;
            this.Btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn5.Image = ((System.Drawing.Image)(resources.GetObject("Btn5.Image")));
            this.Btn5.Location = new System.Drawing.Point(74, 356);
            this.Btn5.Margin = new System.Windows.Forms.Padding(0);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(65, 65);
            this.Btn5.TabIndex = 5;
            this.Btn5.Tag = "5";
            this.Btn5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn5.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn5.UseVisualStyleBackColor = false;
            this.Btn5.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // BtnDiv
            // 
            this.BtnDiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnDiv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnDiv.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnDiv.BorderRadius = 65;
            this.BtnDiv.BorderSize = 0;
            this.BtnDiv.FlatAppearance.BorderSize = 0;
            this.BtnDiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDiv.Font = new System.Drawing.Font("Gadugi", 14F);
            this.BtnDiv.ForeColor = System.Drawing.Color.White;
            this.BtnDiv.Location = new System.Drawing.Point(281, 356);
            this.BtnDiv.Margin = new System.Windows.Forms.Padding(0);
            this.BtnDiv.Name = "BtnDiv";
            this.BtnDiv.Size = new System.Drawing.Size(65, 65);
            this.BtnDiv.TabIndex = 5;
            this.BtnDiv.Text = "÷";
            this.BtnDiv.TextColor = System.Drawing.Color.White;
            this.BtnDiv.UseVisualStyleBackColor = false;
            this.BtnDiv.Click += new System.EventHandler(this.BtnMathOperation_Click);
            // 
            // BtnPM
            // 
            this.BtnPM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnPM.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnPM.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnPM.BorderRadius = 65;
            this.BtnPM.BorderSize = 0;
            this.BtnPM.FlatAppearance.BorderSize = 0;
            this.BtnPM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPM.ForeColor = System.Drawing.Color.White;
            this.BtnPM.Location = new System.Drawing.Point(5, 494);
            this.BtnPM.Margin = new System.Windows.Forms.Padding(0);
            this.BtnPM.Name = "BtnPM";
            this.BtnPM.Size = new System.Drawing.Size(65, 65);
            this.BtnPM.TabIndex = 5;
            this.BtnPM.Text = "+/-";
            this.BtnPM.TextColor = System.Drawing.Color.White;
            this.BtnPM.UseVisualStyleBackColor = false;
            this.BtnPM.Click += new System.EventHandler(this.BtnOperations_Click);
            // 
            // Btn8
            // 
            this.Btn8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn8.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Btn8.BorderRadius = 65;
            this.Btn8.BorderSize = 0;
            this.Btn8.FlatAppearance.BorderSize = 0;
            this.Btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn8.Image = ((System.Drawing.Image)(resources.GetObject("Btn8.Image")));
            this.Btn8.Location = new System.Drawing.Point(74, 287);
            this.Btn8.Margin = new System.Windows.Forms.Padding(0);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(65, 65);
            this.Btn8.TabIndex = 5;
            this.Btn8.Tag = "8";
            this.Btn8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn8.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn8.UseVisualStyleBackColor = false;
            this.Btn8.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn1
            // 
            this.Btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Btn1.BorderRadius = 65;
            this.Btn1.BorderSize = 0;
            this.Btn1.FlatAppearance.BorderSize = 0;
            this.Btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn1.Image = ((System.Drawing.Image)(resources.GetObject("Btn1.Image")));
            this.Btn1.Location = new System.Drawing.Point(5, 425);
            this.Btn1.Margin = new System.Windows.Forms.Padding(0);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(65, 65);
            this.Btn1.TabIndex = 5;
            this.Btn1.Tag = "1";
            this.Btn1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn1.UseVisualStyleBackColor = false;
            this.Btn1.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // BtnPi
            // 
            this.BtnPi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnPi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnPi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnPi.BorderRadius = 65;
            this.BtnPi.BorderSize = 0;
            this.BtnPi.FlatAppearance.BorderSize = 0;
            this.BtnPi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPi.Font = new System.Drawing.Font("Times New Roman", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPi.ForeColor = System.Drawing.Color.White;
            this.BtnPi.Location = new System.Drawing.Point(281, 287);
            this.BtnPi.Margin = new System.Windows.Forms.Padding(0);
            this.BtnPi.Name = "BtnPi";
            this.BtnPi.Size = new System.Drawing.Size(65, 65);
            this.BtnPi.TabIndex = 5;
            this.BtnPi.Text = "π";
            this.BtnPi.TextColor = System.Drawing.Color.White;
            this.BtnPi.UseVisualStyleBackColor = false;
            this.BtnPi.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn4
            // 
            this.Btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Btn4.BorderRadius = 65;
            this.Btn4.BorderSize = 0;
            this.Btn4.FlatAppearance.BorderSize = 0;
            this.Btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn4.Image = ((System.Drawing.Image)(resources.GetObject("Btn4.Image")));
            this.Btn4.Location = new System.Drawing.Point(5, 356);
            this.Btn4.Margin = new System.Windows.Forms.Padding(0);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(65, 65);
            this.Btn4.TabIndex = 5;
            this.Btn4.Tag = "4";
            this.Btn4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn4.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn4.UseVisualStyleBackColor = false;
            this.Btn4.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // BtnDesimal
            // 
            this.BtnDesimal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnDesimal.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnDesimal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnDesimal.BorderRadius = 65;
            this.BtnDesimal.BorderSize = 0;
            this.BtnDesimal.FlatAppearance.BorderSize = 0;
            this.BtnDesimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDesimal.Font = new System.Drawing.Font("Gadugi", 14F);
            this.BtnDesimal.ForeColor = System.Drawing.Color.White;
            this.BtnDesimal.Location = new System.Drawing.Point(212, 494);
            this.BtnDesimal.Margin = new System.Windows.Forms.Padding(0);
            this.BtnDesimal.Name = "BtnDesimal";
            this.BtnDesimal.Size = new System.Drawing.Size(65, 65);
            this.BtnDesimal.TabIndex = 5;
            this.BtnDesimal.Text = ".";
            this.BtnDesimal.TextColor = System.Drawing.Color.White;
            this.BtnDesimal.UseVisualStyleBackColor = false;
            this.BtnDesimal.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // BtnCos
            // 
            this.BtnCos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnCos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnCos.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnCos.BorderRadius = 65;
            this.BtnCos.BorderSize = 0;
            this.BtnCos.FlatAppearance.BorderSize = 0;
            this.BtnCos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCos.ForeColor = System.Drawing.Color.White;
            this.BtnCos.Location = new System.Drawing.Point(74, 218);
            this.BtnCos.Margin = new System.Windows.Forms.Padding(0);
            this.BtnCos.Name = "BtnCos";
            this.BtnCos.Size = new System.Drawing.Size(65, 65);
            this.BtnCos.TabIndex = 5;
            this.BtnCos.Text = "cos";
            this.BtnCos.TextColor = System.Drawing.Color.White;
            this.BtnCos.UseVisualStyleBackColor = false;
            this.BtnCos.Click += new System.EventHandler(this.BtnOperations_Click);
            // 
            // BtnSub
            // 
            this.BtnSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnSub.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnSub.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnSub.BorderRadius = 65;
            this.BtnSub.BorderSize = 0;
            this.BtnSub.FlatAppearance.BorderSize = 0;
            this.BtnSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSub.Font = new System.Drawing.Font("Gadugi", 14F);
            this.BtnSub.ForeColor = System.Drawing.Color.White;
            this.BtnSub.Location = new System.Drawing.Point(212, 425);
            this.BtnSub.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSub.Name = "BtnSub";
            this.BtnSub.Size = new System.Drawing.Size(65, 65);
            this.BtnSub.TabIndex = 5;
            this.BtnSub.Text = "-";
            this.BtnSub.TextColor = System.Drawing.Color.White;
            this.BtnSub.UseVisualStyleBackColor = false;
            this.BtnSub.Click += new System.EventHandler(this.BtnMathOperation_Click);
            // 
            // Btn7
            // 
            this.Btn7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn7.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Btn7.BorderRadius = 65;
            this.Btn7.BorderSize = 0;
            this.Btn7.FlatAppearance.BorderSize = 0;
            this.Btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn7.Image = ((System.Drawing.Image)(resources.GetObject("Btn7.Image")));
            this.Btn7.Location = new System.Drawing.Point(5, 287);
            this.Btn7.Margin = new System.Windows.Forms.Padding(0);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(65, 65);
            this.Btn7.TabIndex = 5;
            this.Btn7.Tag = "7";
            this.Btn7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn7.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn7.UseVisualStyleBackColor = false;
            this.Btn7.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // BtnMul
            // 
            this.BtnMul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnMul.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnMul.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnMul.BorderRadius = 65;
            this.BtnMul.BorderSize = 0;
            this.BtnMul.FlatAppearance.BorderSize = 0;
            this.BtnMul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMul.Font = new System.Drawing.Font("Gadugi", 14F);
            this.BtnMul.ForeColor = System.Drawing.Color.White;
            this.BtnMul.Location = new System.Drawing.Point(212, 356);
            this.BtnMul.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMul.Name = "BtnMul";
            this.BtnMul.Size = new System.Drawing.Size(65, 65);
            this.BtnMul.TabIndex = 5;
            this.BtnMul.Text = "×";
            this.BtnMul.TextColor = System.Drawing.Color.White;
            this.BtnMul.UseVisualStyleBackColor = false;
            this.BtnMul.Click += new System.EventHandler(this.BtnMathOperation_Click);
            // 
            // BtnBackSpace
            // 
            this.BtnBackSpace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnBackSpace.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnBackSpace.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnBackSpace.BorderRadius = 65;
            this.BtnBackSpace.BorderSize = 0;
            this.BtnBackSpace.FlatAppearance.BorderSize = 0;
            this.BtnBackSpace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBackSpace.ForeColor = System.Drawing.Color.White;
            this.BtnBackSpace.Image = ((System.Drawing.Image)(resources.GetObject("BtnBackSpace.Image")));
            this.BtnBackSpace.Location = new System.Drawing.Point(281, 218);
            this.BtnBackSpace.Margin = new System.Windows.Forms.Padding(0);
            this.BtnBackSpace.Name = "BtnBackSpace";
            this.BtnBackSpace.Size = new System.Drawing.Size(65, 65);
            this.BtnBackSpace.TabIndex = 5;
            this.BtnBackSpace.TextColor = System.Drawing.Color.White;
            this.BtnBackSpace.UseVisualStyleBackColor = false;
            this.BtnBackSpace.Click += new System.EventHandler(this.BtnBackSpace_Click);
            // 
            // BtnE
            // 
            this.BtnE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnE.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnE.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnE.BorderRadius = 65;
            this.BtnE.BorderSize = 0;
            this.BtnE.FlatAppearance.BorderSize = 0;
            this.BtnE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnE.Font = new System.Drawing.Font("Times New Roman", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnE.ForeColor = System.Drawing.Color.White;
            this.BtnE.Location = new System.Drawing.Point(212, 287);
            this.BtnE.Margin = new System.Windows.Forms.Padding(0);
            this.BtnE.Name = "BtnE";
            this.BtnE.Size = new System.Drawing.Size(65, 65);
            this.BtnE.TabIndex = 5;
            this.BtnE.Text = "e";
            this.BtnE.TextColor = System.Drawing.Color.White;
            this.BtnE.UseVisualStyleBackColor = false;
            this.BtnE.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // BtnSin
            // 
            this.BtnSin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnSin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnSin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnSin.BorderRadius = 65;
            this.BtnSin.BorderSize = 0;
            this.BtnSin.FlatAppearance.BorderSize = 0;
            this.BtnSin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSin.ForeColor = System.Drawing.Color.White;
            this.BtnSin.Location = new System.Drawing.Point(5, 218);
            this.BtnSin.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSin.Name = "BtnSin";
            this.BtnSin.Size = new System.Drawing.Size(65, 65);
            this.BtnSin.TabIndex = 5;
            this.BtnSin.Text = "sin";
            this.BtnSin.TextColor = System.Drawing.Color.White;
            this.BtnSin.UseVisualStyleBackColor = false;
            this.BtnSin.Click += new System.EventHandler(this.BtnOperations_Click);
            // 
            // BtnC
            // 
            this.BtnC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnC.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnC.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnC.BorderRadius = 65;
            this.BtnC.BorderSize = 0;
            this.BtnC.FlatAppearance.BorderSize = 0;
            this.BtnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnC.Font = new System.Drawing.Font("Gadugi", 14.8F);
            this.BtnC.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnC.Location = new System.Drawing.Point(212, 218);
            this.BtnC.Margin = new System.Windows.Forms.Padding(0);
            this.BtnC.Name = "BtnC";
            this.BtnC.Size = new System.Drawing.Size(65, 65);
            this.BtnC.TabIndex = 5;
            this.BtnC.Text = "C";
            this.BtnC.TextColor = System.Drawing.Color.Gainsboro;
            this.BtnC.UseVisualStyleBackColor = false;
            this.BtnC.Click += new System.EventHandler(this.BtnC_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(350, 575);
            this.Controls.Add(this.PnlHistory);
            this.Controls.Add(this.SquareBtn);
            this.Controls.Add(this.CubeBtn);
            this.Controls.Add(this.SquareRootBtn);
            this.Controls.Add(this.CubeRootBtn);
            this.Controls.Add(this.OneDivBtn);
            this.Controls.Add(this.LogBtn);
            this.Controls.Add(this.BtnPercent);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn6);
            this.Controls.Add(this.Btn9);
            this.Controls.Add(this.BtnCE);
            this.Controls.Add(this.Btn0);
            this.Controls.Add(this.BtnEquals);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.Btn5);
            this.Controls.Add(this.BtnDiv);
            this.Controls.Add(this.BtnPM);
            this.Controls.Add(this.Btn8);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.BtnPi);
            this.Controls.Add(this.Btn4);
            this.Controls.Add(this.BtnDesimal);
            this.Controls.Add(this.BtnCos);
            this.Controls.Add(this.BtnSub);
            this.Controls.Add(this.Btn7);
            this.Controls.Add(this.BtnMul);
            this.Controls.Add(this.BtnBackSpace);
            this.Controls.Add(this.BtnE);
            this.Controls.Add(this.BtnSin);
            this.Controls.Add(this.BtnC);
            this.Controls.Add(this.TxtDisplay1);
            this.Controls.Add(this.TxtDisplay2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PnlTitle);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.PnlTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TitlePicture)).EndInit();
            this.PnlHistory.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlTitle;
        private System.Windows.Forms.Panel PnlHistory;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnMinimize;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnHistory;
        private System.Windows.Forms.TextBox TxtDisplay2;
        private System.Windows.Forms.TextBox TxtDisplay1;
        private System.Windows.Forms.Button BtnClearHistory;
        private System.Windows.Forms.RichTextBox RtBoxDisplayHistory;
        private CustomButton BtnC;
        private CustomButton LogBtn;
        private CustomButton OneDivBtn;
        private CustomButton CubeRootBtn;
        private CustomButton SquareRootBtn;
        private CustomButton CubeBtn;
        private CustomButton SquareBtn;
        private CustomButton BtnSin;
        private CustomButton BtnCos;
        private CustomButton BtnCE;
        private CustomButton BtnBackSpace;
        private CustomButton BtnE;
        private CustomButton Btn7;
        private CustomButton BtnPi;
        private CustomButton Btn8;
        private CustomButton Btn9;
        private CustomButton BtnMul;
        private CustomButton Btn4;
        private CustomButton BtnDiv;
        private CustomButton Btn5;
        private CustomButton Btn6;
        private CustomButton BtnSub;
        private CustomButton Btn1;
        private CustomButton BtnAdd;
        private CustomButton Btn2;
        private CustomButton Btn3;
        private CustomButton BtnDesimal;
        private CustomButton BtnPM;
        private CustomButton BtnEquals;
        private CustomButton Btn0;
        private CustomButton BtnPercent;
        private System.Windows.Forms.PictureBox TitlePicture;
    }
}

