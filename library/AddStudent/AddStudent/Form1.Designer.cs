namespace AddStudent
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pageSetupDialog1 = new PageSetupDialog();
            panel1 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            btnExit = new Button();
            btnSave = new Button();
            btnRefresh = new Button();
            txtEmail = new TextBox();
            txtSemester = new TextBox();
            txtContact = new TextBox();
            txtDepartment = new TextBox();
            txtEnrollment = new TextBox();
            txtName = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1, -1);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1027, 129);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(555, 57);
            label2.Name = "label2";
            label2.Size = new Size(177, 37);
            label2.TabIndex = 1;
            label2.Text = "Add Student";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(421, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(147, 129);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1, 128);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(294, 620);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(btnExit);
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(btnRefresh);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(txtSemester);
            panel2.Controls.Add(txtContact);
            panel2.Controls.Add(txtDepartment);
            panel2.Controls.Add(txtEnrollment);
            panel2.Controls.Add(txtName);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(293, 128);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(736, 620);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.White;
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Font = new Font("Bahnschrift SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(547, 540);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(104, 45);
            btnExit.TabIndex = 14;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.White;
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Bahnschrift SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(336, 540);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(104, 45);
            btnSave.TabIndex = 13;
            btnSave.Text = "Save Info";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.White;
            btnRefresh.FlatStyle = FlatStyle.Popup;
            btnRefresh.Font = new Font("Bahnschrift SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnRefresh.Location = new Point(137, 540);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(104, 45);
            btnRefresh.TabIndex = 12;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(355, 415);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(305, 27);
            txtEmail.TabIndex = 11;
            // 
            // txtSemester
            // 
            txtSemester.Location = new Point(355, 272);
            txtSemester.Margin = new Padding(3, 4, 3, 4);
            txtSemester.Name = "txtSemester";
            txtSemester.Size = new Size(305, 27);
            txtSemester.TabIndex = 10;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(355, 337);
            txtContact.Margin = new Padding(3, 4, 3, 4);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(305, 27);
            txtContact.TabIndex = 9;
            txtContact.TextChanged += txtContact_TextChanged;
            // 
            // txtDepartment
            // 
            txtDepartment.Location = new Point(355, 207);
            txtDepartment.Margin = new Padding(3, 4, 3, 4);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(305, 27);
            txtDepartment.TabIndex = 8;
            // 
            // txtEnrollment
            // 
            txtEnrollment.Location = new Point(355, 139);
            txtEnrollment.Margin = new Padding(3, 4, 3, 4);
            txtEnrollment.Name = "txtEnrollment";
            txtEnrollment.Size = new Size(305, 27);
            txtEnrollment.TabIndex = 7;
            // 
            // txtName
            // 
            txtName.Location = new Point(355, 76);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(305, 27);
            txtName.TabIndex = 6;
            txtName.TextChanged += textBox1_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.IndianRed;
            label7.Font = new Font("Bahnschrift", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(66, 417);
            label7.Name = "label7";
            label7.Size = new Size(204, 36);
            label7.TabIndex = 5;
            label7.Text = "Student Email";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.IndianRed;
            label6.Font = new Font("Bahnschrift", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(66, 340);
            label6.Name = "label6";
            label6.Size = new Size(230, 36);
            label6.TabIndex = 4;
            label6.Text = "Student Contact";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.IndianRed;
            label5.Font = new Font("Bahnschrift", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(66, 272);
            label5.Name = "label5";
            label5.Size = new Size(258, 36);
            label5.TabIndex = 3;
            label5.Text = "Student Semester";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.IndianRed;
            label4.Font = new Font("Bahnschrift", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(66, 207);
            label4.Name = "label4";
            label4.Size = new Size(175, 36);
            label4.TabIndex = 2;
            label4.Text = "Department";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.IndianRed;
            label3.Font = new Font("Bahnschrift", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(66, 144);
            label3.Name = "label3";
            label3.Size = new Size(211, 36);
            label3.TabIndex = 1;
            label3.Text = "Enrollment No";
            label3.Click += label3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.IndianRed;
            label1.Font = new Font("Bahnschrift", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(66, 76);
            label1.Name = "label1";
            label1.Size = new Size(206, 36);
            label1.TabIndex = 0;
            label1.Text = "Student Name";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 746);
            Controls.Add(panel2);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PageSetupDialog pageSetupDialog1;
        private Panel panel1;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private TextBox txtEmail;
        private TextBox txtSemester;
        private TextBox txtContact;
        private TextBox txtDepartment;
        private TextBox txtEnrollment;
        private TextBox txtName;
        private Button btnExit;
        private Button btnSave;
        private Button btnRefresh;
    }
}