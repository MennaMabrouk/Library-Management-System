namespace issuebookframe
{
    partial class issueBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(issueBookForm));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            panel2 = new Panel();
            btnIssueBook = new Button();
            dateTimePicker1 = new DateTimePicker();
            comboBoxBooks = new ComboBox();
            txtdept = new TextBox();
            txtStSemester = new TextBox();
            txtContact = new TextBox();
            txtEmail = new TextBox();
            txtStname = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel3 = new Panel();
            btnExit = new Button();
            btnRefresh = new Button();
            btnSearch = new Button();
            txtEnrNum = new TextBox();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1205, 174);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(640, 118);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(89, 33);
            label1.TabIndex = 1;
            label1.Text = "Issue";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(475, 5);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(203, 165);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(740, 118);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(98, 33);
            label2.TabIndex = 2;
            label2.Text = "Books";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(btnIssueBook);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(comboBoxBooks);
            panel2.Controls.Add(txtdept);
            panel2.Controls.Add(txtStSemester);
            panel2.Controls.Add(txtContact);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(txtStname);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(405, 183);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 629);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // btnIssueBook
            // 
            btnIssueBook.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnIssueBook.FlatStyle = FlatStyle.Flat;
            btnIssueBook.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnIssueBook.Location = new Point(551, 537);
            btnIssueBook.Margin = new Padding(4, 5, 4, 5);
            btnIssueBook.Name = "btnIssueBook";
            btnIssueBook.Size = new Size(192, 62);
            btnIssueBook.TabIndex = 14;
            btnIssueBook.Text = "Issue Book";
            btnIssueBook.UseVisualStyleBackColor = true;
            btnIssueBook.Click += btnIssueBook_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePicker1.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(319, 471);
            dateTimePicker1.Margin = new Padding(4, 5, 4, 5);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(405, 27);
            dateTimePicker1.TabIndex = 13;
            // 
            // comboBoxBooks
            // 
            comboBoxBooks.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxBooks.AutoCompleteSource = AutoCompleteSource.FileSystem;
            comboBoxBooks.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxBooks.FormattingEnabled = true;
            comboBoxBooks.Location = new Point(319, 411);
            comboBoxBooks.Margin = new Padding(4, 5, 4, 5);
            comboBoxBooks.Name = "comboBoxBooks";
            comboBoxBooks.Size = new Size(405, 27);
            comboBoxBooks.TabIndex = 12;
            comboBoxBooks.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtdept
            // 
            txtdept.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtdept.AutoCompleteSource = AutoCompleteSource.FileSystem;
            txtdept.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtdept.Location = new Point(319, 120);
            txtdept.Margin = new Padding(4, 5, 4, 5);
            txtdept.Name = "txtdept";
            txtdept.ReadOnly = true;
            txtdept.Size = new Size(405, 27);
            txtdept.TabIndex = 11;
            // 
            // txtStSemester
            // 
            txtStSemester.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtStSemester.AutoCompleteSource = AutoCompleteSource.FileSystem;
            txtStSemester.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtStSemester.Location = new Point(319, 189);
            txtStSemester.Margin = new Padding(4, 5, 4, 5);
            txtStSemester.Name = "txtStSemester";
            txtStSemester.ReadOnly = true;
            txtStSemester.Size = new Size(405, 27);
            txtStSemester.TabIndex = 10;
            // 
            // txtContact
            // 
            txtContact.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtContact.AutoCompleteSource = AutoCompleteSource.FileSystem;
            txtContact.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtContact.Location = new Point(319, 257);
            txtContact.Margin = new Padding(4, 5, 4, 5);
            txtContact.Name = "txtContact";
            txtContact.ReadOnly = true;
            txtContact.Size = new Size(405, 27);
            txtContact.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.AutoCompleteSource = AutoCompleteSource.FileSystem;
            txtEmail.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtEmail.Location = new Point(319, 322);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(405, 27);
            txtEmail.TabIndex = 8;
            // 
            // txtStname
            // 
            txtStname.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtStname.AutoCompleteSource = AutoCompleteSource.FileSystem;
            txtStname.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtStname.Location = new Point(319, 48);
            txtStname.Margin = new Padding(4, 5, 4, 5);
            txtStname.Name = "txtStname";
            txtStname.ReadOnly = true;
            txtStname.Size = new Size(405, 27);
            txtStname.TabIndex = 7;
            txtStname.TextChanged += textBox2_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(79, 471);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(174, 24);
            label10.TabIndex = 6;
            label10.Text = "Book Issue Date";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(80, 400);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(124, 24);
            label9.TabIndex = 5;
            label9.Text = "Book Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(79, 323);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(151, 24);
            label8.TabIndex = 4;
            label8.Text = "Student Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(79, 254);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(173, 24);
            label7.TabIndex = 3;
            label7.Text = "Student Contact";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(79, 186);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(191, 24);
            label6.TabIndex = 2;
            label6.Text = "Student Semester";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(80, 117);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(131, 24);
            label5.TabIndex = 1;
            label5.Text = "Department";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(80, 45);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(154, 24);
            label4.TabIndex = 0;
            label4.Text = "Student Name";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel3.BackColor = SystemColors.MenuHighlight;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(btnExit);
            panel3.Controls.Add(btnRefresh);
            panel3.Controls.Add(btnSearch);
            panel3.Controls.Add(txtEnrNum);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(pictureBox2);
            panel3.Location = new Point(0, 183);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(397, 628);
            panel3.TabIndex = 2;
            // 
            // btnExit
            // 
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(232, 438);
            btnExit.Margin = new Padding(4, 5, 4, 5);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(100, 46);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnRefresh.Location = new Point(71, 438);
            btnRefresh.Margin = new Padding(4, 5, 4, 5);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(117, 46);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += button2_Click;
            // 
            // btnSearch
            // 
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.Location = new Point(71, 351);
            btnSearch.Margin = new Padding(4, 5, 4, 5);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(261, 51);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search Student";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += button1_Click;
            // 
            // txtEnrNum
            // 
            txtEnrNum.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtEnrNum.Location = new Point(55, 246);
            txtEnrNum.Margin = new Padding(4, 5, 4, 5);
            txtEnrNum.Name = "txtEnrNum";
            txtEnrNum.Size = new Size(295, 27);
            txtEnrNum.TabIndex = 2;
            txtEnrNum.TextChanged += txtEnrNum_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(49, 185);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(279, 24);
            label3.TabIndex = 1;
            label3.Text = "Enter Enrollement Number";
            label3.Click += label3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(133, 25);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(133, 140);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // issueBookForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1204, 814);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "issueBookForm";
            Text = "IssueBook";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtEnrNum;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStname;
        private System.Windows.Forms.TextBox txtdept;
        private System.Windows.Forms.TextBox txtStSemester;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnIssueBook;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBoxBooks;
    }
}

