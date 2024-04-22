namespace LibraryManagementSystem_Amal.Forms.CongigurationForms
{
    partial class FormSession
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSession));
            groupBox2 = new GroupBox();
            dtpenddate = new DateTimePicker();
            buttonCancel = new Button();
            buttonUpdate = new Button();
            buttonEdit = new Button();
            buttonDelete = new Button();
            buttonClear = new Button();
            buttonADD = new Button();
            dtpStartdate = new DateTimePicker();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            lblDescription = new Label();
            lbl_end_Date = new Label();
            lableStartDate = new Label();
            lbl_session_name = new Label();
            dgv_programme = new DataGridView();
            ColSsesionID = new DataGridViewTextBoxColumn();
            ColusessName = new DataGridViewTextBoxColumn();
            Colstart_Date = new DataGridViewTextBoxColumn();
            ColEnd_Date = new DataGridViewTextBoxColumn();
            ColDescr = new DataGridViewTextBoxColumn();
            epPrograme = new ErrorProvider(components);
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_programme).BeginInit();
            ((System.ComponentModel.ISupportInitialize)epPrograme).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtpenddate);
            groupBox2.Controls.Add(buttonCancel);
            groupBox2.Controls.Add(buttonUpdate);
            groupBox2.Controls.Add(buttonEdit);
            groupBox2.Controls.Add(buttonDelete);
            groupBox2.Controls.Add(buttonClear);
            groupBox2.Controls.Add(buttonADD);
            groupBox2.Controls.Add(dtpStartdate);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(lblDescription);
            groupBox2.Controls.Add(lbl_end_Date);
            groupBox2.Controls.Add(lableStartDate);
            groupBox2.Controls.Add(lbl_session_name);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(649, 297);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Enter Session";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // dtpenddate
            // 
            dtpenddate.CustomFormat = "ddMMMM,yyyy";
            dtpenddate.Format = DateTimePickerFormat.Custom;
            dtpenddate.Location = new Point(152, 135);
            dtpenddate.Name = "dtpenddate";
            dtpenddate.Size = new Size(200, 27);
            dtpenddate.TabIndex = 14;
            // 
            // buttonCancel
            // 
            buttonCancel.Enabled = false;
            buttonCancel.Location = new Point(507, 245);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 33);
            buttonCancel.TabIndex = 13;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Enabled = false;
            buttonUpdate.Location = new Point(403, 245);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(75, 33);
            buttonUpdate.TabIndex = 12;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(403, 189);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(75, 32);
            buttonEdit.TabIndex = 11;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(403, 140);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 43);
            buttonDelete.TabIndex = 10;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(403, 88);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(75, 29);
            buttonClear.TabIndex = 9;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonADD
            // 
            buttonADD.Location = new Point(403, 40);
            buttonADD.Name = "buttonADD";
            buttonADD.Size = new Size(75, 27);
            buttonADD.TabIndex = 8;
            buttonADD.Text = "Add";
            buttonADD.UseVisualStyleBackColor = true;
            buttonADD.Click += buttonADD_Click;
            // 
            // dtpStartdate
            // 
            dtpStartdate.CustomFormat = "ddMMMM,yyyy";
            dtpStartdate.Format = DateTimePickerFormat.Custom;
            dtpStartdate.Location = new Point(152, 90);
            dtpStartdate.Name = "dtpStartdate";
            dtpStartdate.Size = new Size(200, 27);
            dtpStartdate.TabIndex = 6;
            dtpStartdate.ValueChanged += dateTimePickerStartdate_ValueChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(152, 186);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(200, 92);
            textBox4.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(152, 40);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 27);
            textBox3.TabIndex = 4;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(19, 192);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(85, 20);
            lblDescription.TabIndex = 3;
            lblDescription.Text = "Description";
            // 
            // lbl_end_Date
            // 
            lbl_end_Date.AutoSize = true;
            lbl_end_Date.Location = new Point(19, 140);
            lbl_end_Date.Name = "lbl_end_Date";
            lbl_end_Date.Size = new Size(70, 20);
            lbl_end_Date.TabIndex = 2;
            lbl_end_Date.Text = "End Date";
            // 
            // lableStartDate
            // 
            lableStartDate.AutoSize = true;
            lableStartDate.Location = new Point(19, 95);
            lableStartDate.Name = "lableStartDate";
            lableStartDate.Size = new Size(76, 20);
            lableStartDate.TabIndex = 1;
            lableStartDate.Text = "Start Date";
            // 
            // lbl_session_name
            // 
            lbl_session_name.AutoSize = true;
            lbl_session_name.Location = new Point(19, 40);
            lbl_session_name.Name = "lbl_session_name";
            lbl_session_name.Size = new Size(102, 20);
            lbl_session_name.TabIndex = 0;
            lbl_session_name.Text = "Session Name";
            // 
            // dgv_programme
            // 
            dgv_programme.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopLeft;
            dgv_programme.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgv_programme.BackgroundColor = SystemColors.ButtonHighlight;
            dgv_programme.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_programme.Columns.AddRange(new DataGridViewColumn[] { ColSsesionID, ColusessName, Colstart_Date, ColEnd_Date, ColDescr });
            dgv_programme.Location = new Point(12, 352);
            dgv_programme.MultiSelect = false;
            dgv_programme.Name = "dgv_programme";
            dgv_programme.ReadOnly = true;
            dgv_programme.RowHeadersVisible = false;
            dgv_programme.RowHeadersWidth = 51;
            dgv_programme.RowTemplate.Height = 24;
            dgv_programme.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_programme.Size = new Size(973, 281);
            dgv_programme.TabIndex = 1;
            dgv_programme.CellContentClick += dgv_programme_CellContentClick;
            // 
            // ColSsesionID
            // 
            ColSsesionID.HeaderText = "ID";
            ColSsesionID.MinimumWidth = 6;
            ColSsesionID.Name = "ColSsesionID";
            ColSsesionID.ReadOnly = true;
            ColSsesionID.Width = 125;
            // 
            // ColusessName
            // 
            ColusessName.HeaderText = "Session Name";
            ColusessName.MinimumWidth = 6;
            ColusessName.Name = "ColusessName";
            ColusessName.ReadOnly = true;
            ColusessName.Width = 200;
            // 
            // Colstart_Date
            // 
            Colstart_Date.HeaderText = "start Date";
            Colstart_Date.MinimumWidth = 6;
            Colstart_Date.Name = "Colstart_Date";
            Colstart_Date.ReadOnly = true;
            Colstart_Date.Width = 125;
            // 
            // ColEnd_Date
            // 
            ColEnd_Date.HeaderText = "End Date";
            ColEnd_Date.MinimumWidth = 6;
            ColEnd_Date.Name = "ColEnd_Date";
            ColEnd_Date.ReadOnly = true;
            ColEnd_Date.Width = 125;
            // 
            // ColDescr
            // 
            ColDescr.HeaderText = "Description";
            ColDescr.MinimumWidth = 6;
            ColDescr.Name = "ColDescr";
            ColDescr.ReadOnly = true;
            ColDescr.Width = 300;
            // 
            // epPrograme
            // 
            epPrograme.ContainerControl = this;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackgroundImage = (Image)resources.GetObject("flowLayoutPanel1.BackgroundImage");
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.Location = new Point(991, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(491, 522);
            flowLayoutPanel1.TabIndex = 2;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Location = new Point(3, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(10, 10);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // FormSession
            // 
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(1479, 653);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(dgv_programme);
            Controls.Add(groupBox2);
            Name = "FormSession";
            Text = "Session";
            Load += FormSession_Load_1;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_programme).EndInit();
            ((System.ComponentModel.ISupportInitialize)epPrograme).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Programme;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSessName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDescription;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_programme;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.DateTimePicker dtpenddate;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonADD;
        private System.Windows.Forms.DateTimePicker dtpStartdate;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lbl_end_Date;
        private System.Windows.Forms.Label lableStartDate;
        private System.Windows.Forms.Label lbl_session_name;
        private System.Windows.Forms.ErrorProvider epPrograme;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSsesionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColusessName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colstart_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEnd_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDescr;
    }
}
