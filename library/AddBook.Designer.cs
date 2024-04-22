namespace library
{
    partial class AddBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBook));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 66);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(268, 494);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SandyBrown;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(840, 67);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(478, 21);
            label1.Name = "label1";
            label1.Size = new Size(140, 30);
            label1.TabIndex = 3;
            label1.Text = "Add Book";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.NavajoWhite;
            panel2.Location = new Point(267, 66);
            panel2.Name = "panel2";
            panel2.Size = new Size(503, 434);
            panel2.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(309, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 68);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(310, 99);
            label2.Name = "label2";
            label2.Size = new Size(118, 24);
            label2.TabIndex = 2;
            label2.Text = "Book Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(310, 157);
            label3.Name = "label3";
            label3.Size = new Size(188, 24);
            label3.TabIndex = 3;
            label3.Text = "Book Auther Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(310, 213);
            label4.Name = "label4";
            label4.Size = new Size(172, 24);
            label4.TabIndex = 4;
            label4.Text = "Book Publication";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(310, 275);
            label5.Name = "label5";
            label5.Size = new Size(202, 24);
            label5.TabIndex = 5;
            label5.Text = "Book Purchase Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(310, 335);
            label6.Name = "label6";
            label6.Size = new Size(113, 24);
            label6.TabIndex = 6;
            label6.Text = "Book Price";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(310, 400);
            label7.Name = "label7";
            label7.Size = new Size(147, 24);
            label7.TabIndex = 7;
            label7.Text = "Book Quantity";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(557, 99);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(271, 30);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(557, 155);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(271, 30);
            textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(557, 211);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(271, 30);
            textBox3.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(557, 275);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(271, 30);
            dateTimePicker1.TabIndex = 11;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(557, 335);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(271, 30);
            textBox4.TabIndex = 12;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(557, 400);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(271, 30);
            textBox5.TabIndex = 13;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Cooper Black", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(395, 487);
            button1.Name = "button1";
            button1.Size = new Size(117, 44);
            button1.TabIndex = 14;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Cooper Black", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(622, 487);
            button2.Name = "button2";
            button2.Size = new Size(106, 44);
            button2.TabIndex = 15;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // AddBook
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(840, 561);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "AddBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddBook";
            Load += AddBook_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button1;
        private Button button2;
    }
}