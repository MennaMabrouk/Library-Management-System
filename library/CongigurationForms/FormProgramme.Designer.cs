namespace LibraryManagementSystem_Amal.Forms.CongigurationForms
{
    partial class FormProgramme
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonADD = new System.Windows.Forms.Button();
            this.txt_programme_description = new System.Windows.Forms.TextBox();
            this.textProgramme_name = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lbl_session_name = new System.Windows.Forms.Label();
            this.dgvprogramme = new System.Windows.Forms.DataGridView();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProgramme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvprogramme)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonEdit);
            this.groupBox2.Controls.Add(this.buttonDelete);
            this.groupBox2.Controls.Add(this.buttonClear);
            this.groupBox2.Controls.Add(this.buttonADD);
            this.groupBox2.Controls.Add(this.txt_programme_description);
            this.groupBox2.Controls.Add(this.textProgramme_name);
            this.groupBox2.Controls.Add(this.lblDescription);
            this.groupBox2.Controls.Add(this.lbl_session_name);
            this.groupBox2.Location = new System.Drawing.Point(-3, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(649, 237);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Enter Programme";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(403, 189);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 11;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(403, 140);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 10;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(403, 88);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 9;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonADD
            // 
            this.buttonADD.Location = new System.Drawing.Point(403, 40);
            this.buttonADD.Name = "buttonADD";
            this.buttonADD.Size = new System.Drawing.Size(75, 23);
            this.buttonADD.TabIndex = 8;
            this.buttonADD.Text = "Add";
            this.buttonADD.UseVisualStyleBackColor = true;
            this.buttonADD.Click += new System.EventHandler(this.buttonADD_Click);
            // 
            // txt_programme_description
            // 
            this.txt_programme_description.Location = new System.Drawing.Point(152, 106);
            this.txt_programme_description.Multiline = true;
            this.txt_programme_description.Name = "txt_programme_description";
            this.txt_programme_description.Size = new System.Drawing.Size(200, 92);
            this.txt_programme_description.TabIndex = 5;
            this.txt_programme_description.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textProgramme_name
            // 
            this.textProgramme_name.Location = new System.Drawing.Point(152, 40);
            this.textProgramme_name.Name = "textProgramme_name";
            this.textProgramme_name.Size = new System.Drawing.Size(200, 22);
            this.textProgramme_name.TabIndex = 4;
            this.textProgramme_name.TextChanged += new System.EventHandler(this.textProgramme_name_TextChanged);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(19, 112);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(75, 16);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description";
            // 
            // lbl_session_name
            // 
            this.lbl_session_name.AutoSize = true;
            this.lbl_session_name.Location = new System.Drawing.Point(19, 40);
            this.lbl_session_name.Name = "lbl_session_name";
            this.lbl_session_name.Size = new System.Drawing.Size(118, 16);
            this.lbl_session_name.TabIndex = 0;
            this.lbl_session_name.Text = "Programme Name";
            // 
            // dgvprogramme
            // 
            this.dgvprogramme.AllowUserToAddRows = false;
            this.dgvprogramme.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvprogramme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvprogramme.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColProgramme,
            this.ColDescription});
            this.dgvprogramme.Location = new System.Drawing.Point(3, 321);
            this.dgvprogramme.MultiSelect = false;
            this.dgvprogramme.Name = "dgvprogramme";
            this.dgvprogramme.ReadOnly = true;
            this.dgvprogramme.RowHeadersVisible = false;
            this.dgvprogramme.RowHeadersWidth = 51;
            this.dgvprogramme.RowTemplate.Height = 24;
            this.dgvprogramme.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvprogramme.Size = new System.Drawing.Size(643, 324);
            this.dgvprogramme.TabIndex = 2;
            this.dgvprogramme.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvprogramme_CellContentClick);
            // 
            // ColID
            // 
            this.ColID.HeaderText = "ID";
            this.ColID.MinimumWidth = 6;
            this.ColID.Name = "ColID";
            this.ColID.ReadOnly = true;
            this.ColID.Width = 125;
            // 
            // ColProgramme
            // 
            this.ColProgramme.HeaderText = "Programme";
            this.ColProgramme.MinimumWidth = 6;
            this.ColProgramme.Name = "ColProgramme";
            this.ColProgramme.ReadOnly = true;
            this.ColProgramme.Width = 125;
            // 
            // ColDescription
            // 
            this.ColDescription.HeaderText = "Description";
            this.ColDescription.MinimumWidth = 6;
            this.ColDescription.Name = "ColDescription";
            this.ColDescription.ReadOnly = true;
            this.ColDescription.Width = 125;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Enabled = false;
            this.buttonCancel.Location = new System.Drawing.Point(280, 270);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 15;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Enabled = false;
            this.buttonUpdate.Location = new System.Drawing.Point(176, 270);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 14;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // FormProgramme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(643, 644);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.dgvprogramme);
            this.Controls.Add(this.groupBox2);
            this.Name = "FormProgramme";
            this.Text = "Programme";
            this.Load += new System.EventHandler(this.FormProgramme_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvprogramme)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonADD;
        private System.Windows.Forms.TextBox txt_programme_description;
        private System.Windows.Forms.TextBox textProgramme_name;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lbl_session_name;
        private System.Windows.Forms.DataGridView dgvprogramme;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProgramme;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDescription;
    }
}