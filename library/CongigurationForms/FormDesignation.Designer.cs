namespace LibraryManagementSystem_Amal.Forms.CongigurationForms
{
    partial class FormDesignation
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
            this.label1 = new System.Windows.Forms.Label();
            this.textDesignation = new System.Windows.Forms.TextBox();
            this.dgvDesignation = new System.Windows.Forms.DataGridView();
            this.buttonADD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDesignation)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Designation";
            // 
            // textDesignation
            // 
            this.textDesignation.Location = new System.Drawing.Point(155, 58);
            this.textDesignation.Name = "textDesignation";
            this.textDesignation.Size = new System.Drawing.Size(224, 22);
            this.textDesignation.TabIndex = 1;
            // 
            // dgvDesignation
            // 
            this.dgvDesignation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDesignation.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDesignation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDesignation.Location = new System.Drawing.Point(1, 136);
            this.dgvDesignation.MultiSelect = false;
            this.dgvDesignation.Name = "dgvDesignation";
            this.dgvDesignation.ReadOnly = true;
            this.dgvDesignation.RowHeadersVisible = false;
            this.dgvDesignation.RowHeadersWidth = 51;
            this.dgvDesignation.RowTemplate.Height = 24;
            this.dgvDesignation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDesignation.Size = new System.Drawing.Size(450, 308);
            this.dgvDesignation.TabIndex = 2;
            // 
            // buttonADD
            // 
            this.buttonADD.Location = new System.Drawing.Point(304, 95);
            this.buttonADD.Name = "buttonADD";
            this.buttonADD.Size = new System.Drawing.Size(75, 23);
            this.buttonADD.TabIndex = 13;
            this.buttonADD.Text = "Add";
            this.buttonADD.UseVisualStyleBackColor = true;
            this.buttonADD.Click += new System.EventHandler(this.buttonADD_Click);
            // 
            // FormDesignation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 450);
            this.Controls.Add(this.buttonADD);
            this.Controls.Add(this.dgvDesignation);
            this.Controls.Add(this.textDesignation);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormDesignation";
            this.Text = "Designation";
            this.Load += new System.EventHandler(this.FormDesignation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDesignation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textDesignation;
        private System.Windows.Forms.DataGridView dgvDesignation;
        private System.Windows.Forms.Button buttonADD;
    }
}