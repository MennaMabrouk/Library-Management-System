namespace library
{
    partial class login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            pictureBox1 = new PictureBox();
            txtusername = new TextBox();
            txtpassword = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            btn_login = new Button();
            pictureBox5 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox4 = new PictureBox();
            btnclose = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(182, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(111, 88);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtusername
            // 
            txtusername.BackColor = Color.FromArgb(35, 34, 130);
            txtusername.BorderStyle = BorderStyle.None;
            txtusername.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtusername.ForeColor = Color.White;
            txtusername.Location = new Point(93, 190);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(276, 29);
            txtusername.TabIndex = 1;
            txtusername.Text = "Username";
            txtusername.MouseClick += txtusername_MouseClick;
            txtusername.TextChanged += textBox1_TextChanged;
            txtusername.MouseEnter += textBox1_TextChanged;
            // 
            // txtpassword
            // 
            txtpassword.BackColor = Color.FromArgb(35, 34, 130);
            txtpassword.BorderStyle = BorderStyle.None;
            txtpassword.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtpassword.ForeColor = Color.White;
            txtpassword.Location = new Point(87, 263);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(287, 29);
            txtpassword.TabIndex = 2;
            txtpassword.Text = "Password";
            txtpassword.MouseClick += txtpassword_MouseClick;
            txtpassword.TextChanged += textBox2_TextChanged;
            txtpassword.MouseEnter += textBox2_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(37, 174);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 51);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(41, 263);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(37, 34);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(84, 215);
            panel1.Name = "panel1";
            panel1.Size = new Size(261, 1);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(84, 287);
            panel2.Name = "panel2";
            panel2.Size = new Size(260, 1);
            panel2.TabIndex = 6;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.LightCyan;
            btn_login.FlatStyle = FlatStyle.Popup;
            btn_login.Font = new Font("Segoe Script", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_login.Location = new Point(76, 355);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(293, 71);
            btn_login.TabIndex = 7;
            btn_login.Text = "LogIn as Admin";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += button1_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(84, 511);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(30, 30);
            pictureBox5.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox5.TabIndex = 10;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(371, 511);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(30, 30);
            pictureBox7.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox7.TabIndex = 12;
            pictureBox7.TabStop = false;
            pictureBox7.Click += pictureBox7_Click;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(154, 511);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(30, 30);
            pictureBox8.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox8.TabIndex = 13;
            pictureBox8.TabStop = false;
            pictureBox8.Click += pictureBox8_Click;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(207, 511);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(30, 30);
            pictureBox9.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox9.TabIndex = 14;
            pictureBox9.TabStop = false;
            pictureBox9.Click += pictureBox9_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(286, 511);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(30, 30);
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox4.TabIndex = 15;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // btnclose
            // 
            btnclose.BackColor = Color.FromArgb(35, 34, 130);
            btnclose.FlatStyle = FlatStyle.Popup;
            btnclose.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnclose.ForeColor = Color.Red;
            btnclose.Location = new Point(451, 1);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(32, 35);
            btnclose.TabIndex = 16;
            btnclose.Text = "X";
            btnclose.UseVisualStyleBackColor = false;
            btnclose.Click += button3_Click;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 34, 130);
            ClientSize = new Size(485, 573);
            Controls.Add(btnclose);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox5);
            Controls.Add(btn_login);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(txtpassword);
            Controls.Add(txtusername);
            Controls.Add(pictureBox1);
            ForeColor = Color.DarkSlateBlue;
            FormBorderStyle = FormBorderStyle.None;
            Name = "login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LogIn";
            Load += login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtusername;
        private TextBox txtpassword;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Panel panel1;
        private Panel panel2;
        private Button btn_login;
        private PictureBox pictureBox5;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private PictureBox pictureBox4;
        private Button btnclose;
    }
}