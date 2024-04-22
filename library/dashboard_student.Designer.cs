namespace library
{
    partial class dashboard_student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard_student));
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Turquoise;
            flowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch;
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1466, 803);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.LightSeaGreen;
            flowLayoutPanel2.Controls.Add(flowLayoutPanel3);
            flowLayoutPanel2.Controls.Add(button1);
            flowLayoutPanel2.Controls.Add(button2);
            flowLayoutPanel2.Controls.Add(button3);
            flowLayoutPanel2.Controls.Add(button4);
            flowLayoutPanel2.Controls.Add(button5);
            flowLayoutPanel2.Controls.Add(button6);
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(3, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(248, 979);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.BackgroundImage = (Image)resources.GetObject("flowLayoutPanel3.BackgroundImage");
            flowLayoutPanel3.BackgroundImageLayout = ImageLayout.Stretch;
            flowLayoutPanel3.Location = new Point(3, 3);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(253, 239);
            flowLayoutPanel3.TabIndex = 1;
            flowLayoutPanel3.Paint += flowLayoutPanel3_Paint;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(30, 248);
            button1.Margin = new Padding(30, 3, 3, 3);
            button1.Name = "button1";
            button1.Size = new Size(182, 43);
            button1.TabIndex = 1;
            button1.Text = "MyBooks";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(30, 304);
            button2.Margin = new Padding(30, 10, 3, 3);
            button2.Name = "button2";
            button2.Size = new Size(182, 43);
            button2.TabIndex = 2;
            button2.Text = "FavouriteBooks";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button3.Location = new Point(30, 360);
            button3.Margin = new Padding(30, 10, 3, 3);
            button3.Name = "button3";
            button3.Size = new Size(182, 43);
            button3.TabIndex = 3;
            button3.Text = "ReturnBooks";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.AutoSize = true;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button4.Location = new Point(30, 416);
            button4.Margin = new Padding(30, 10, 3, 3);
            button4.Name = "button4";
            button4.Size = new Size(182, 43);
            button4.TabIndex = 4;
            button4.Text = "BorrowBooks";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.AutoSize = true;
            button5.FlatStyle = FlatStyle.Popup;
            button5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button5.Location = new Point(30, 472);
            button5.Margin = new Padding(30, 10, 3, 3);
            button5.Name = "button5";
            button5.Size = new Size(182, 43);
            button5.TabIndex = 5;
            button5.Text = "MyAccount";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.AutoSize = true;
            button6.FlatStyle = FlatStyle.Popup;
            button6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button6.Location = new Point(30, 528);
            button6.Margin = new Padding(30, 10, 3, 3);
            button6.Name = "button6";
            button6.Size = new Size(182, 43);
            button6.TabIndex = 6;
            button6.Text = "Logout";
            button6.UseVisualStyleBackColor = true;
            // 
            // dashboard_student
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1466, 803);
            Controls.Add(flowLayoutPanel1);
            Name = "dashboard_student";
            Text = "dashboard_student";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}