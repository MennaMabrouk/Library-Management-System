namespace library
{
    partial class DashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            menuStrip1 = new MenuStrip();
            booksToolStripMenuItem = new ToolStripMenuItem();
            addNewBooksToolStripMenuItem = new ToolStripMenuItem();
            viewBooksToolStripMenuItem = new ToolStripMenuItem();
            studentToolStripMenuItem = new ToolStripMenuItem();
            addStudentsToolStripMenuItem = new ToolStripMenuItem();
            viewStudentInfoToolStripMenuItem = new ToolStripMenuItem();
            issueBooksToolStripMenuItem = new ToolStripMenuItem();
            returnBooksToolStripMenuItem = new ToolStripMenuItem();
            completeBooksDetailsToolStripMenuItem = new ToolStripMenuItem();
            sessionToolStripMenuItem = new ToolStripMenuItem();
            programmeToolStripMenuItem = new ToolStripMenuItem();
            libraryStaffToolStripMenuItem = new ToolStripMenuItem();
            designationToolStripMenuItem = new ToolStripMenuItem();
            departmentToolStripMenuItem = new ToolStripMenuItem();
            userPreviligeisToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.PaleTurquoise;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { booksToolStripMenuItem, studentToolStripMenuItem, issueBooksToolStripMenuItem, returnBooksToolStripMenuItem, completeBooksDetailsToolStripMenuItem, sessionToolStripMenuItem, programmeToolStripMenuItem, libraryStaffToolStripMenuItem, designationToolStripMenuItem, departmentToolStripMenuItem, userPreviligeisToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(1607, 58);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // booksToolStripMenuItem
            // 
            booksToolStripMenuItem.BackColor = Color.PaleTurquoise;
            booksToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addNewBooksToolStripMenuItem, viewBooksToolStripMenuItem });
            booksToolStripMenuItem.Image = (Image)resources.GetObject("booksToolStripMenuItem.Image");
            booksToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            booksToolStripMenuItem.Size = new Size(113, 54);
            booksToolStripMenuItem.Text = "Books";
            // 
            // addNewBooksToolStripMenuItem
            // 
            addNewBooksToolStripMenuItem.Image = (Image)resources.GetObject("addNewBooksToolStripMenuItem.Image");
            addNewBooksToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            addNewBooksToolStripMenuItem.Name = "addNewBooksToolStripMenuItem";
            addNewBooksToolStripMenuItem.Size = new Size(228, 56);
            addNewBooksToolStripMenuItem.Text = "Add New Books";
            addNewBooksToolStripMenuItem.Click += addNewBooksToolStripMenuItem_Click;
            // 
            // viewBooksToolStripMenuItem
            // 
            viewBooksToolStripMenuItem.Image = (Image)resources.GetObject("viewBooksToolStripMenuItem.Image");
            viewBooksToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            viewBooksToolStripMenuItem.Name = "viewBooksToolStripMenuItem";
            viewBooksToolStripMenuItem.Size = new Size(228, 56);
            viewBooksToolStripMenuItem.Text = "View Books";
            viewBooksToolStripMenuItem.Click += viewBooksToolStripMenuItem_Click;
            // 
            // studentToolStripMenuItem
            // 
            studentToolStripMenuItem.BackColor = Color.PaleTurquoise;
            studentToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addStudentsToolStripMenuItem, viewStudentInfoToolStripMenuItem });
            studentToolStripMenuItem.Image = (Image)resources.GetObject("studentToolStripMenuItem.Image");
            studentToolStripMenuItem.ImageAlign = ContentAlignment.MiddleRight;
            studentToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            studentToolStripMenuItem.Size = new Size(124, 54);
            studentToolStripMenuItem.Text = "Student";
            // 
            // addStudentsToolStripMenuItem
            // 
            addStudentsToolStripMenuItem.BackColor = Color.White;
            addStudentsToolStripMenuItem.Image = (Image)resources.GetObject("addStudentsToolStripMenuItem.Image");
            addStudentsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            addStudentsToolStripMenuItem.Name = "addStudentsToolStripMenuItem";
            addStudentsToolStripMenuItem.Size = new Size(289, 106);
            addStudentsToolStripMenuItem.Text = "Add Students";
            addStudentsToolStripMenuItem.Click += addStudentsToolStripMenuItem_Click;
            // 
            // viewStudentInfoToolStripMenuItem
            // 
            viewStudentInfoToolStripMenuItem.Image = (Image)resources.GetObject("viewStudentInfoToolStripMenuItem.Image");
            viewStudentInfoToolStripMenuItem.ImageAlign = ContentAlignment.BottomRight;
            viewStudentInfoToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            viewStudentInfoToolStripMenuItem.Name = "viewStudentInfoToolStripMenuItem";
            viewStudentInfoToolStripMenuItem.Size = new Size(289, 106);
            viewStudentInfoToolStripMenuItem.Text = "View Student info";
            viewStudentInfoToolStripMenuItem.Click += viewStudentInfoToolStripMenuItem_Click;
            // 
            // issueBooksToolStripMenuItem
            // 
            issueBooksToolStripMenuItem.Image = (Image)resources.GetObject("issueBooksToolStripMenuItem.Image");
            issueBooksToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            issueBooksToolStripMenuItem.Name = "issueBooksToolStripMenuItem";
            issueBooksToolStripMenuItem.Size = new Size(149, 54);
            issueBooksToolStripMenuItem.Text = "Issue Books";
            issueBooksToolStripMenuItem.Click += issueBooksToolStripMenuItem_Click;
            // 
            // returnBooksToolStripMenuItem
            // 
            returnBooksToolStripMenuItem.Image = (Image)resources.GetObject("returnBooksToolStripMenuItem.Image");
            returnBooksToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            returnBooksToolStripMenuItem.Name = "returnBooksToolStripMenuItem";
            returnBooksToolStripMenuItem.Size = new Size(160, 54);
            returnBooksToolStripMenuItem.Text = "Return Books";
            returnBooksToolStripMenuItem.Click += returnBooksToolStripMenuItem_Click;
            // 
            // completeBooksDetailsToolStripMenuItem
            // 
            completeBooksDetailsToolStripMenuItem.Image = (Image)resources.GetObject("completeBooksDetailsToolStripMenuItem.Image");
            completeBooksDetailsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            completeBooksDetailsToolStripMenuItem.Name = "completeBooksDetailsToolStripMenuItem";
            completeBooksDetailsToolStripMenuItem.Size = new Size(232, 54);
            completeBooksDetailsToolStripMenuItem.Text = "Complete Books Details";
            completeBooksDetailsToolStripMenuItem.Click += completeBooksDetailsToolStripMenuItem_Click;
            // 
            // sessionToolStripMenuItem
            // 
            sessionToolStripMenuItem.Image = (Image)resources.GetObject("sessionToolStripMenuItem.Image");
            sessionToolStripMenuItem.Name = "sessionToolStripMenuItem";
            sessionToolStripMenuItem.Size = new Size(92, 54);
            sessionToolStripMenuItem.Text = "Session";
            sessionToolStripMenuItem.Click += sessionToolStripMenuItem_Click;
            // 
            // programmeToolStripMenuItem
            // 
            programmeToolStripMenuItem.Image = (Image)resources.GetObject("programmeToolStripMenuItem.Image");
            programmeToolStripMenuItem.Name = "programmeToolStripMenuItem";
            programmeToolStripMenuItem.Size = new Size(121, 54);
            programmeToolStripMenuItem.Text = "Programme";
            programmeToolStripMenuItem.Click += programmeToolStripMenuItem_Click;
            // 
            // libraryStaffToolStripMenuItem
            // 
            libraryStaffToolStripMenuItem.Image = (Image)resources.GetObject("libraryStaffToolStripMenuItem.Image");
            libraryStaffToolStripMenuItem.Name = "libraryStaffToolStripMenuItem";
            libraryStaffToolStripMenuItem.Size = new Size(123, 54);
            libraryStaffToolStripMenuItem.Text = "Library Staff";
            libraryStaffToolStripMenuItem.Click += libraryStaffToolStripMenuItem_Click;
            // 
            // designationToolStripMenuItem
            // 
            designationToolStripMenuItem.Image = (Image)resources.GetObject("designationToolStripMenuItem.Image");
            designationToolStripMenuItem.Name = "designationToolStripMenuItem";
            designationToolStripMenuItem.Size = new Size(123, 54);
            designationToolStripMenuItem.Text = "Designation";
            designationToolStripMenuItem.Click += designationToolStripMenuItem_Click;
            // 
            // departmentToolStripMenuItem
            // 
            departmentToolStripMenuItem.Image = (Image)resources.GetObject("departmentToolStripMenuItem.Image");
            departmentToolStripMenuItem.Name = "departmentToolStripMenuItem";
            departmentToolStripMenuItem.Size = new Size(123, 54);
            departmentToolStripMenuItem.Text = "Department";
            departmentToolStripMenuItem.Click += departmentToolStripMenuItem_Click;
            // 
            // userPreviligeisToolStripMenuItem
            // 
            userPreviligeisToolStripMenuItem.Image = (Image)resources.GetObject("userPreviligeisToolStripMenuItem.Image");
            userPreviligeisToolStripMenuItem.Name = "userPreviligeisToolStripMenuItem";
            userPreviligeisToolStripMenuItem.Size = new Size(143, 54);
            userPreviligeisToolStripMenuItem.Text = "User Previligeis";
            userPreviligeisToolStripMenuItem.Click += userPreviligeisToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Image = (Image)resources.GetObject("exitToolStripMenuItem.Image");
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(67, 54);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click_1;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.BackgroundImage = (Image)resources.GetObject("contextMenuStrip1.BackgroundImage");
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // DashBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1607, 721);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MainMenuStrip = menuStrip1;
            Name = "DashBoard";
            Text = "DashBoard";
            Load += DashBoard_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem booksToolStripMenuItem;
        private ToolStripMenuItem addNewBooksToolStripMenuItem;
        private ToolStripMenuItem viewBooksToolStripMenuItem;
        private ToolStripMenuItem studentToolStripMenuItem;
        private ToolStripMenuItem addStudentsToolStripMenuItem;
        private ToolStripMenuItem viewStudentInfoToolStripMenuItem;
        private ToolStripMenuItem issueBooksToolStripMenuItem;
        private ToolStripMenuItem returnBooksToolStripMenuItem;
        private ToolStripMenuItem completeBooksDetailsToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem sessionToolStripMenuItem;
        private ToolStripMenuItem programmeToolStripMenuItem;
        private ToolStripMenuItem libraryStaffToolStripMenuItem;
        private ToolStripMenuItem designationToolStripMenuItem;
        private ToolStripMenuItem departmentToolStripMenuItem;
        private ToolStripMenuItem userPreviligeisToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}