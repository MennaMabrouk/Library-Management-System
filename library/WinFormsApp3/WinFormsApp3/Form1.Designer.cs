namespace WinFormsApp3
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
            dateTimePicker1 = new DateTimePicker();
            txtBookIssueDate = new TextBox();
            txtBookName = new TextBox();
            txtIssueDate = new Label();
            label4 = new Label();
            txtBookReturnDate = new Label();
            btnCancel = new Button();
            btnReturn = new Button();
            dataGridView1 = new DataGridView();
            btnExit = new Button();
            btnRefresh = new Button();
            btnSearchStudent = new Button();
            txtEnterEnroll = new TextBox();
            label1 = new Label();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(283, 143);
            dateTimePicker1.Margin = new Padding(4, 5, 4, 5);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(345, 32);
            dateTimePicker1.TabIndex = 9;
            // 
            // txtBookIssueDate
            // 
            txtBookIssueDate.Location = new Point(283, 87);
            txtBookIssueDate.Margin = new Padding(4, 5, 4, 5);
            txtBookIssueDate.Name = "txtBookIssueDate";
            txtBookIssueDate.Size = new Size(345, 30);
            txtBookIssueDate.TabIndex = 8;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(283, 20);
            txtBookName.Margin = new Padding(4, 5, 4, 5);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(345, 30);
            txtBookName.TabIndex = 7;
            txtBookName.TextChanged += txtBookName_TextChanged;
            // 
            // txtIssueDate
            // 
            txtIssueDate.AutoSize = true;
            txtIssueDate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtIssueDate.ForeColor = SystemColors.ActiveCaptionText;
            txtIssueDate.Location = new Point(28, 84);
            txtIssueDate.Margin = new Padding(4, 0, 4, 0);
            txtIssueDate.Name = "txtIssueDate";
            txtIssueDate.Size = new Size(160, 28);
            txtIssueDate.TabIndex = 6;
            txtIssueDate.Text = "Book Issue Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(28, 23);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(116, 28);
            label4.TabIndex = 5;
            label4.Text = "Book Name";
            label4.Click += label4_Click;
            // 
            // txtBookReturnDate
            // 
            txtBookReturnDate.AutoSize = true;
            txtBookReturnDate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtBookReturnDate.ForeColor = SystemColors.ActiveCaptionText;
            txtBookReturnDate.Location = new Point(28, 149);
            txtBookReturnDate.Margin = new Padding(4, 0, 4, 0);
            txtBookReturnDate.Name = "txtBookReturnDate";
            txtBookReturnDate.Size = new Size(173, 28);
            txtBookReturnDate.TabIndex = 4;
            txtBookReturnDate.Text = "Book Return Date";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(255, 128, 128);
            btnCancel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = SystemColors.ActiveCaptionText;
            btnCancel.Location = new Point(706, 138);
            btnCancel.Margin = new Padding(4, 5, 4, 5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(96, 43);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.FromArgb(224, 224, 224);
            btnReturn.FlatStyle = FlatStyle.Popup;
            btnReturn.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnReturn.ForeColor = SystemColors.ActiveCaptionText;
            btnReturn.Location = new Point(706, 55);
            btnReturn.Margin = new Padding(4, 5, 4, 5);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(96, 44);
            btnReturn.TabIndex = 0;
            btnReturn.Text = "Return ";
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(255, 249, 241);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(383, 26);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(847, 564);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnExit
            // 
            btnExit.ForeColor = SystemColors.ActiveCaptionText;
            btnExit.Location = new Point(211, 442);
            btnExit.Margin = new Padding(4, 5, 4, 5);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(100, 55);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.ForeColor = SystemColors.ActiveCaptionText;
            btnRefresh.Location = new Point(53, 442);
            btnRefresh.Margin = new Padding(4, 5, 4, 5);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(99, 55);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnSearchStudent
            // 
            btnSearchStudent.FlatStyle = FlatStyle.Popup;
            btnSearchStudent.ForeColor = SystemColors.ActiveCaptionText;
            btnSearchStudent.Location = new Point(63, 308);
            btnSearchStudent.Margin = new Padding(4, 5, 4, 5);
            btnSearchStudent.Name = "btnSearchStudent";
            btnSearchStudent.Size = new Size(198, 63);
            btnSearchStudent.TabIndex = 3;
            btnSearchStudent.Text = "Search Student";
            btnSearchStudent.UseVisualStyleBackColor = true;
            btnSearchStudent.Click += btnSearchStudent_Click;
            // 
            // txtEnterEnroll
            // 
            txtEnterEnroll.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtEnterEnroll.Location = new Point(48, 235);
            txtEnterEnroll.Margin = new Padding(4, 5, 4, 5);
            txtEnterEnroll.Name = "txtEnterEnroll";
            txtEnterEnroll.Size = new Size(225, 32);
            txtEnterEnroll.TabIndex = 2;
            txtEnterEnroll.TextChanged += txtEnterEnroll_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Myanmar Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(28, 186);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(258, 36);
            label1.TabIndex = 1;
            label1.Text = "Enter Enrollment Number";
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightGray;
            panel3.Controls.Add(btnExit);
            panel3.Controls.Add(btnRefresh);
            panel3.Controls.Add(btnSearchStudent);
            panel3.Controls.Add(txtEnterEnroll);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(15, 26);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(333, 564);
            panel3.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(96, 41);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(129, 140);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 249, 241);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(txtBookIssueDate);
            panel2.Controls.Add(txtBookName);
            panel2.Controls.Add(txtIssueDate);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtBookReturnDate);
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(btnReturn);
            panel2.Location = new Point(383, 623);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(847, 228);
            panel2.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1296, 920);
            Controls.Add(dataGridView1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private TextBox txtBookIssueDate;
        private TextBox txtBookName;
        private Label txtIssueDate;
        private Label label4;
        private Label txtBookReturnDate;
        private Button btnCancel;
        private Button btnReturn;
        private DataGridView dataGridView1;
        private Button btnExit;
        private Button btnRefresh;
        private Button btnSearchStudent;
        private TextBox txtEnterEnroll;
        private Label label1;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Panel panel2;
    }
}