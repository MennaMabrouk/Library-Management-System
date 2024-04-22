namespace LibraryManagementSystem_Amal.Forms.CongigurationForms
{
    partial class FormDepartment
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
            buttonCancel = new Button();
            buttonUpdate = new Button();
            dgvDepartment = new DataGridView();
            ColID = new DataGridViewTextBoxColumn();
            ColDepartment = new DataGridViewTextBoxColumn();
            ColDate = new DataGridViewTextBoxColumn();
            ColDescription = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            dtp_establishdate = new DateTimePicker();
            label1 = new Label();
            buttonEdit = new Button();
            buttonDelete = new Button();
            buttonClear = new Button();
            buttonADD = new Button();
            txt_Department_description = new TextBox();
            textProgramme_name = new TextBox();
            lblDescription = new Label();
            textDepartment_name = new Label();
            ep_Department = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvDepartment).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ep_Department).BeginInit();
            SuspendLayout();
            // 
            // buttonCancel
            // 
            buttonCancel.Enabled = false;
            buttonCancel.Location = new Point(651, 236);
            buttonCancel.Margin = new Padding(3, 4, 3, 4);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 29);
            buttonCancel.TabIndex = 19;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Enabled = false;
            buttonUpdate.Location = new Point(528, 236);
            buttonUpdate.Margin = new Padding(3, 4, 3, 4);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(75, 29);
            buttonUpdate.TabIndex = 18;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // dgvDepartment
            // 
            dgvDepartment.AllowUserToAddRows = false;
            dgvDepartment.BackgroundColor = SystemColors.ButtonHighlight;
            dgvDepartment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDepartment.Columns.AddRange(new DataGridViewColumn[] { ColID, ColDepartment, ColDate, ColDescription });
            dgvDepartment.Location = new Point(2, 460);
            dgvDepartment.Margin = new Padding(3, 4, 3, 4);
            dgvDepartment.MultiSelect = false;
            dgvDepartment.Name = "dgvDepartment";
            dgvDepartment.ReadOnly = true;
            dgvDepartment.RowHeadersVisible = false;
            dgvDepartment.RowHeadersWidth = 51;
            dgvDepartment.RowTemplate.Height = 24;
            dgvDepartment.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDepartment.Size = new Size(837, 336);
            dgvDepartment.TabIndex = 17;
            // 
            // ColID
            // 
            ColID.HeaderText = "ID";
            ColID.MinimumWidth = 6;
            ColID.Name = "ColID";
            ColID.ReadOnly = true;
            ColID.Width = 125;
            // 
            // ColDepartment
            // 
            ColDepartment.HeaderText = "Department Name";
            ColDepartment.MinimumWidth = 6;
            ColDepartment.Name = "ColDepartment";
            ColDepartment.ReadOnly = true;
            ColDepartment.Width = 125;
            // 
            // ColDate
            // 
            ColDate.HeaderText = "Establish Date";
            ColDate.MinimumWidth = 6;
            ColDate.Name = "ColDate";
            ColDate.ReadOnly = true;
            ColDate.Width = 125;
            // 
            // ColDescription
            // 
            ColDescription.HeaderText = "Description";
            ColDescription.MinimumWidth = 6;
            ColDescription.Name = "ColDescription";
            ColDescription.ReadOnly = true;
            ColDescription.Width = 125;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtp_establishdate);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(buttonEdit);
            groupBox2.Controls.Add(buttonCancel);
            groupBox2.Controls.Add(buttonUpdate);
            groupBox2.Controls.Add(buttonDelete);
            groupBox2.Controls.Add(buttonClear);
            groupBox2.Controls.Add(buttonADD);
            groupBox2.Controls.Add(txt_Department_description);
            groupBox2.Controls.Add(textProgramme_name);
            groupBox2.Controls.Add(lblDescription);
            groupBox2.Controls.Add(textDepartment_name);
            groupBox2.Location = new Point(12, 15);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(827, 438);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "Enter Department";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // dtp_establishdate
            // 
            dtp_establishdate.CustomFormat = "dd MMMM,yyyy";
            dtp_establishdate.Format = DateTimePickerFormat.Custom;
            dtp_establishdate.Location = new Point(143, 131);
            dtp_establishdate.Margin = new Padding(3, 4, 3, 4);
            dtp_establishdate.Name = "dtp_establishdate";
            dtp_establishdate.Size = new Size(200, 27);
            dtp_establishdate.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 131);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 20;
            label1.Text = "Establish Date";
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(403, 236);
            buttonEdit.Margin = new Padding(3, 4, 3, 4);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(75, 29);
            buttonEdit.TabIndex = 11;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(403, 175);
            buttonDelete.Margin = new Padding(3, 4, 3, 4);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 29);
            buttonDelete.TabIndex = 10;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(403, 110);
            buttonClear.Margin = new Padding(3, 4, 3, 4);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(75, 29);
            buttonClear.TabIndex = 9;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonADD
            // 
            buttonADD.Location = new Point(403, 50);
            buttonADD.Margin = new Padding(3, 4, 3, 4);
            buttonADD.Name = "buttonADD";
            buttonADD.Size = new Size(75, 29);
            buttonADD.TabIndex = 8;
            buttonADD.Text = "Add";
            buttonADD.UseVisualStyleBackColor = true;
            buttonADD.Click += buttonADD_Click;
            // 
            // txt_Department_description
            // 
            txt_Department_description.Location = new Point(141, 214);
            txt_Department_description.Margin = new Padding(3, 4, 3, 4);
            txt_Department_description.Multiline = true;
            txt_Department_description.Name = "txt_Department_description";
            txt_Department_description.Size = new Size(200, 114);
            txt_Department_description.TabIndex = 5;
            // 
            // textProgramme_name
            // 
            textProgramme_name.Location = new Point(143, 70);
            textProgramme_name.Margin = new Padding(3, 4, 3, 4);
            textProgramme_name.Name = "textProgramme_name";
            textProgramme_name.Size = new Size(200, 27);
            textProgramme_name.TabIndex = 4;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(19, 200);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(85, 20);
            lblDescription.TabIndex = 3;
            lblDescription.Text = "Description";
            // 
            // textDepartment_name
            // 
            textDepartment_name.AutoSize = true;
            textDepartment_name.Location = new Point(19, 74);
            textDepartment_name.Name = "textDepartment_name";
            textDepartment_name.Size = new Size(127, 20);
            textDepartment_name.TabIndex = 0;
            textDepartment_name.Text = "Enter Department";
            // 
            // ep_Department
            // 
            ep_Department.ContainerControl = this;
            // 
            // FormDepartment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 796);
            Controls.Add(groupBox2);
            Controls.Add(dgvDepartment);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormDepartment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Department";
            Load += FormDepartment_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDepartment).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ep_Department).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.DataGridView dgvDepartment;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtp_establishdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonADD;
        private System.Windows.Forms.TextBox txt_Department_description;
        private System.Windows.Forms.TextBox textProgramme_name;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label textDepartment_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDescription;
        private System.Windows.Forms.ErrorProvider ep_Department;
    }
}