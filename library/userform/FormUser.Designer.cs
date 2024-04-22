using System;

namespace LibraryManagementSystem_Amal.Forms.userform
{
    partial class FormUser
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
            groupBox1 = new GroupBox();
            label6 = new Label();
            comb_contactno = new ComboBox();
            label5 = new Label();
            text_Designation = new TextBox();
            text_confirm_password = new TextBox();
            text_password = new TextBox();
            txt_UserName = new TextBox();
            combo_select_user = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            chk_Email = new CheckBox();
            chk_ReturnBook = new CheckBox();
            chk_Students = new CheckBox();
            chk_gsm = new CheckBox();
            chk_issueBook = new CheckBox();
            chk_LibraryStaff = new CheckBox();
            chk_Reports = new CheckBox();
            chk_Books = new CheckBox();
            chk_Configuration = new CheckBox();
            btn_Create = new Button();
            btn_Cancel = new Button();
            ep_Error = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ep_Error).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(comb_contactno);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(text_Designation);
            groupBox1.Controls.Add(text_confirm_password);
            groupBox1.Controls.Add(text_password);
            groupBox1.Controls.Add(txt_UserName);
            groupBox1.Controls.Add(combo_select_user);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 15);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(405, 364);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "User Information";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 96);
            label6.Name = "label6";
            label6.Size = new Size(80, 20);
            label6.TabIndex = 11;
            label6.Text = "ContactNo";
            // 
            // comb_contactno
            // 
            comb_contactno.DropDownStyle = ComboBoxStyle.DropDownList;
            comb_contactno.FormattingEnabled = true;
            comb_contactno.Location = new Point(173, 92);
            comb_contactno.Margin = new Padding(3, 4, 3, 4);
            comb_contactno.Name = "comb_contactno";
            comb_contactno.Size = new Size(169, 28);
            comb_contactno.TabIndex = 10;
            comb_contactno.SelectedIndexChanged += comb_contactno_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 141);
            label5.Name = "label5";
            label5.Size = new Size(89, 20);
            label5.TabIndex = 9;
            label5.Text = "Designation";
            // 
            // text_Designation
            // 
            text_Designation.Location = new Point(173, 141);
            text_Designation.Margin = new Padding(3, 4, 3, 4);
            text_Designation.Name = "text_Designation";
            text_Designation.ReadOnly = true;
            text_Designation.Size = new Size(169, 27);
            text_Designation.TabIndex = 8;
            // 
            // text_confirm_password
            // 
            text_confirm_password.Location = new Point(173, 310);
            text_confirm_password.Margin = new Padding(3, 4, 3, 4);
            text_confirm_password.Name = "text_confirm_password";
            text_confirm_password.PasswordChar = '*';
            text_confirm_password.Size = new Size(169, 27);
            text_confirm_password.TabIndex = 7;
            // 
            // text_password
            // 
            text_password.Location = new Point(173, 251);
            text_password.Margin = new Padding(3, 4, 3, 4);
            text_password.Name = "text_password";
            text_password.PasswordChar = '*';
            text_password.Size = new Size(169, 27);
            text_password.TabIndex = 6;
            // 
            // txt_UserName
            // 
            txt_UserName.Location = new Point(173, 194);
            txt_UserName.Margin = new Padding(3, 4, 3, 4);
            txt_UserName.Name = "txt_UserName";
            txt_UserName.Size = new Size(169, 27);
            txt_UserName.TabIndex = 5;
            // 
            // combo_select_user
            // 
            combo_select_user.DropDownStyle = ComboBoxStyle.DropDownList;
            combo_select_user.FormattingEnabled = true;
            combo_select_user.Location = new Point(173, 40);
            combo_select_user.Margin = new Padding(3, 4, 3, 4);
            combo_select_user.Name = "combo_select_user";
            combo_select_user.Size = new Size(169, 28);
            combo_select_user.TabIndex = 4;
            combo_select_user.SelectedIndexChanged += combo_select_user_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 314);
            label4.Name = "label4";
            label4.Size = new Size(127, 20);
            label4.TabIndex = 3;
            label4.Text = "Confirm Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 259);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 2;
            label3.Text = "Enter Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 194);
            label2.Name = "label2";
            label2.Size = new Size(120, 20);
            label2.TabIndex = 1;
            label2.Text = "Enter User Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 44);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 0;
            label1.Text = "Select user";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(chk_Email);
            groupBox2.Controls.Add(chk_ReturnBook);
            groupBox2.Controls.Add(chk_Students);
            groupBox2.Controls.Add(chk_gsm);
            groupBox2.Controls.Add(chk_issueBook);
            groupBox2.Controls.Add(chk_LibraryStaff);
            groupBox2.Controls.Add(chk_Reports);
            groupBox2.Controls.Add(chk_Books);
            groupBox2.Controls.Add(chk_Configuration);
            groupBox2.Location = new Point(458, 15);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(456, 364);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Privileges";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // chk_Email
            // 
            chk_Email.AutoSize = true;
            chk_Email.Location = new Point(341, 254);
            chk_Email.Margin = new Padding(3, 4, 3, 4);
            chk_Email.Name = "chk_Email";
            chk_Email.Size = new Size(68, 24);
            chk_Email.TabIndex = 8;
            chk_Email.Text = "Email";
            chk_Email.UseVisualStyleBackColor = true;
            // 
            // chk_ReturnBook
            // 
            chk_ReturnBook.AutoSize = true;
            chk_ReturnBook.Location = new Point(174, 254);
            chk_ReturnBook.Margin = new Padding(3, 4, 3, 4);
            chk_ReturnBook.Name = "chk_ReturnBook";
            chk_ReturnBook.Size = new Size(108, 24);
            chk_ReturnBook.TabIndex = 7;
            chk_ReturnBook.Text = "ReturnBook";
            chk_ReturnBook.UseVisualStyleBackColor = true;
            // 
            // chk_Students
            // 
            chk_Students.AutoSize = true;
            chk_Students.Location = new Point(31, 254);
            chk_Students.Margin = new Padding(3, 4, 3, 4);
            chk_Students.Name = "chk_Students";
            chk_Students.Size = new Size(88, 24);
            chk_Students.TabIndex = 6;
            chk_Students.Text = "Students";
            chk_Students.UseVisualStyleBackColor = true;
            // 
            // chk_gsm
            // 
            chk_gsm.AutoSize = true;
            chk_gsm.Location = new Point(341, 156);
            chk_gsm.Margin = new Padding(3, 4, 3, 4);
            chk_gsm.Name = "chk_gsm";
            chk_gsm.Size = new Size(95, 24);
            chk_gsm.TabIndex = 5;
            chk_gsm.Text = "GSM SMS";
            chk_gsm.UseVisualStyleBackColor = true;
            // 
            // chk_issueBook
            // 
            chk_issueBook.AutoSize = true;
            chk_issueBook.Location = new Point(174, 156);
            chk_issueBook.Margin = new Padding(3, 4, 3, 4);
            chk_issueBook.Name = "chk_issueBook";
            chk_issueBook.Size = new Size(97, 24);
            chk_issueBook.TabIndex = 4;
            chk_issueBook.Text = "IssueBook";
            chk_issueBook.UseVisualStyleBackColor = true;
            // 
            // chk_LibraryStaff
            // 
            chk_LibraryStaff.AutoSize = true;
            chk_LibraryStaff.Location = new Point(31, 156);
            chk_LibraryStaff.Margin = new Padding(3, 4, 3, 4);
            chk_LibraryStaff.Name = "chk_LibraryStaff";
            chk_LibraryStaff.Size = new Size(111, 24);
            chk_LibraryStaff.TabIndex = 3;
            chk_LibraryStaff.Text = "Library Staff";
            chk_LibraryStaff.UseVisualStyleBackColor = true;
            // 
            // chk_Reports
            // 
            chk_Reports.AutoSize = true;
            chk_Reports.Location = new Point(341, 61);
            chk_Reports.Margin = new Padding(3, 4, 3, 4);
            chk_Reports.Name = "chk_Reports";
            chk_Reports.Size = new Size(82, 24);
            chk_Reports.TabIndex = 2;
            chk_Reports.Text = "Reports";
            chk_Reports.UseVisualStyleBackColor = true;
            // 
            // chk_Books
            // 
            chk_Books.AutoSize = true;
            chk_Books.Location = new Point(174, 59);
            chk_Books.Margin = new Padding(3, 4, 3, 4);
            chk_Books.Name = "chk_Books";
            chk_Books.Size = new Size(71, 24);
            chk_Books.TabIndex = 1;
            chk_Books.Text = "Books";
            chk_Books.UseVisualStyleBackColor = true;
            // 
            // chk_Configuration
            // 
            chk_Configuration.AutoSize = true;
            chk_Configuration.Location = new Point(31, 58);
            chk_Configuration.Margin = new Padding(3, 4, 3, 4);
            chk_Configuration.Name = "chk_Configuration";
            chk_Configuration.Size = new Size(122, 24);
            chk_Configuration.TabIndex = 0;
            chk_Configuration.Text = "Configuration";
            chk_Configuration.UseVisualStyleBackColor = true;
            // 
            // btn_Create
            // 
            btn_Create.Location = new Point(670, 402);
            btn_Create.Margin = new Padding(3, 4, 3, 4);
            btn_Create.Name = "btn_Create";
            btn_Create.Size = new Size(99, 29);
            btn_Create.TabIndex = 2;
            btn_Create.Text = "Create";
            btn_Create.UseVisualStyleBackColor = true;
            btn_Create.Click += btn_Create_Click;
            // 
            // btn_Cancel
            // 
            btn_Cancel.Location = new Point(801, 402);
            btn_Cancel.Margin = new Padding(3, 4, 3, 4);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(113, 29);
            btn_Cancel.TabIndex = 3;
            btn_Cancel.Text = "Cancel";
            btn_Cancel.UseVisualStyleBackColor = true;
            btn_Cancel.Click += btn_Cancel_Click;
            // 
            // ep_Error
            // 
            ep_Error.ContainerControl = this;
            // 
            // FormUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(926, 446);
            Controls.Add(btn_Cancel);
            Controls.Add(btn_Create);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormUser";
            Text = "UserForm";
            Load += FormUser_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ep_Error).EndInit();
            ResumeLayout(false);
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comb_contactno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text_Designation;
        private System.Windows.Forms.TextBox text_confirm_password;
        private System.Windows.Forms.TextBox text_password;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.ComboBox combo_select_user;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chk_Email;
        private System.Windows.Forms.CheckBox chk_ReturnBook;
        private System.Windows.Forms.CheckBox chk_Students;
        private System.Windows.Forms.CheckBox chk_gsm;
        private System.Windows.Forms.CheckBox chk_issueBook;
        private System.Windows.Forms.CheckBox chk_LibraryStaff;
        private System.Windows.Forms.CheckBox chk_Reports;
        private System.Windows.Forms.CheckBox chk_Books;
        private System.Windows.Forms.CheckBox chk_Configuration;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.ErrorProvider ep_Error;
    }
}