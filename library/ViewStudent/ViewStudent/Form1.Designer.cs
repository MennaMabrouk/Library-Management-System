namespace ViewStudent
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
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            txtSearchEnrollment = new TextBox();
            btnRefresh = new Button();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnCancel = new Button();
            txtStudentName = new TextBox();
            txtEnrollmentNo = new TextBox();
            txtDepartment = new TextBox();
            txtStudentContact = new TextBox();
            txtStudentEmail = new TextBox();
            txtStudentSemester = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            panel1.Location = new Point(0, 1);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1112, 131);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.IndianRed;
            label2.Location = new Point(583, 63);
            label2.Name = "label2";
            label2.Size = new Size(129, 41);
            label2.TabIndex = 2;
            label2.Text = "Student";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(546, 23);
            label1.Name = "label1";
            label1.Size = new Size(87, 41);
            label1.TabIndex = 1;
            label1.Text = "View";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(346, -52);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(310, 253);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.IndianRed;
            label3.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(178, 187);
            label3.Name = "label3";
            label3.Size = new Size(225, 29);
            label3.TabIndex = 1;
            label3.Text = "Enrollment Number";
            // 
            // txtSearchEnrollment
            // 
            txtSearchEnrollment.Location = new Point(421, 187);
            txtSearchEnrollment.Margin = new Padding(3, 4, 3, 4);
            txtSearchEnrollment.Name = "txtSearchEnrollment";
            txtSearchEnrollment.Size = new Size(217, 27);
            txtSearchEnrollment.TabIndex = 2;
            txtSearchEnrollment.TextChanged += txtSearchEnrollment_TextChanged;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = SystemColors.ButtonHighlight;
            btnRefresh.Font = new Font("Bahnschrift SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnRefresh.ForeColor = SystemColors.ActiveCaptionText;
            btnRefresh.Location = new Point(675, 181);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(96, 37);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.LightGray;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 247);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1069, 289);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonFace;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(txtStudentName);
            panel2.Controls.Add(txtEnrollmentNo);
            panel2.Controls.Add(txtDepartment);
            panel2.Controls.Add(txtStudentContact);
            panel2.Controls.Add(txtStudentEmail);
            panel2.Controls.Add(txtStudentSemester);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(25, 619);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1043, 483);
            panel2.TabIndex = 5;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(410, 32);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(221, 153);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.IndianRed;
            btnDelete.Font = new Font("Bahnschrift SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.LightGray;
            btnDelete.Location = new Point(518, 415);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(103, 45);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.IndianRed;
            btnUpdate.Font = new Font("Bahnschrift SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.LightGray;
            btnUpdate.Location = new Point(306, 415);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(97, 45);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.IndianRed;
            btnCancel.Font = new Font("Bahnschrift SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.LightGray;
            btnCancel.Location = new Point(765, 415);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(105, 45);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(217, 229);
            txtStudentName.Margin = new Padding(3, 4, 3, 4);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(210, 27);
            txtStudentName.TabIndex = 11;
            // 
            // txtEnrollmentNo
            // 
            txtEnrollmentNo.Location = new Point(217, 288);
            txtEnrollmentNo.Margin = new Padding(3, 4, 3, 4);
            txtEnrollmentNo.Name = "txtEnrollmentNo";
            txtEnrollmentNo.Size = new Size(210, 27);
            txtEnrollmentNo.TabIndex = 10;
            // 
            // txtDepartment
            // 
            txtDepartment.Location = new Point(217, 341);
            txtDepartment.Margin = new Padding(3, 4, 3, 4);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(210, 27);
            txtDepartment.TabIndex = 9;
            txtDepartment.TextChanged += textBox5_TextChanged;
            // 
            // txtStudentContact
            // 
            txtStudentContact.Location = new Point(800, 288);
            txtStudentContact.Margin = new Padding(3, 4, 3, 4);
            txtStudentContact.Name = "txtStudentContact";
            txtStudentContact.Size = new Size(210, 27);
            txtStudentContact.TabIndex = 8;
            // 
            // txtStudentEmail
            // 
            txtStudentEmail.Location = new Point(800, 337);
            txtStudentEmail.Margin = new Padding(3, 4, 3, 4);
            txtStudentEmail.Name = "txtStudentEmail";
            txtStudentEmail.Size = new Size(210, 27);
            txtStudentEmail.TabIndex = 7;
            // 
            // txtStudentSemester
            // 
            txtStudentSemester.Location = new Point(800, 233);
            txtStudentSemester.Margin = new Padding(3, 4, 3, 4);
            txtStudentSemester.Name = "txtStudentSemester";
            txtStudentSemester.Size = new Size(210, 27);
            txtStudentSemester.TabIndex = 6;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.IndianRed;
            label9.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(29, 352);
            label9.Name = "label9";
            label9.Size = new Size(141, 29);
            label9.TabIndex = 5;
            label9.Text = "Department";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.IndianRed;
            label8.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(29, 299);
            label8.Name = "label8";
            label8.Size = new Size(168, 29);
            label8.TabIndex = 4;
            label8.Text = "Enrollment No";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.IndianRed;
            label7.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(584, 348);
            label7.Name = "label7";
            label7.Size = new Size(163, 29);
            label7.TabIndex = 3;
            label7.Text = "Student Email";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.IndianRed;
            label6.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(584, 288);
            label6.Name = "label6";
            label6.Size = new Size(184, 29);
            label6.TabIndex = 2;
            label6.Text = "Student Contact";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.IndianRed;
            label5.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(584, 229);
            label5.Name = "label5";
            label5.Size = new Size(207, 29);
            label5.TabIndex = 1;
            label5.Text = "Student Semester";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.IndianRed;
            label4.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(29, 233);
            label4.Name = "label4";
            label4.Size = new Size(166, 29);
            label4.TabIndex = 0;
            label4.Text = "Student Name";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1109, 609);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(btnRefresh);
            Controls.Add(txtSearchEnrollment);
            Controls.Add(label3);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox txtSearchEnrollment;
        private Button btnRefresh;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnCancel;
        private TextBox txtStudentName;
        private TextBox txtEnrollmentNo;
        private TextBox txtDepartment;
        private TextBox txtStudentContact;
        private TextBox txtStudentEmail;
        private TextBox txtStudentSemester;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private PictureBox pictureBox2;
    }
}