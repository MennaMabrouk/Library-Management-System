namespace WinFormsApp1
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
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label7 = new Label();
            txtBookName = new TextBox();
            txtPublication = new TextBox();
            txtAuthor = new TextBox();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(419, 596);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonFace;
            panel2.Controls.Add(label7);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(905, 60);
            panel2.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe Print", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(369, 3);
            label7.Name = "label7";
            label7.Size = new Size(172, 54);
            label7.TabIndex = 0;
            label7.Text = "Add Book";
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(235, 34);
            txtBookName.Multiline = true;
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(238, 34);
            txtBookName.TabIndex = 0;
            txtBookName.TextChanged += textBox1_TextChanged;
            // 
            // txtPublication
            // 
            txtPublication.Location = new Point(235, 147);
            txtPublication.Multiline = true;
            txtPublication.Name = "txtPublication";
            txtPublication.Size = new Size(238, 34);
            txtPublication.TabIndex = 1;
            txtPublication.TextChanged += txtPublication_TextChanged;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(235, 87);
            txtAuthor.Multiline = true;
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(238, 34);
            txtAuthor.TabIndex = 2;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(235, 267);
            txtPrice.Multiline = true;
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(238, 34);
            txtPrice.TabIndex = 4;
            txtPrice.TextChanged += txtPrice_TextChanged;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(235, 333);
            txtQuantity.Multiline = true;
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(238, 34);
            txtQuantity.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(235, 217);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(238, 27);
            dateTimePicker1.TabIndex = 6;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.IndianRed;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(3, 39);
            label1.Name = "label1";
            label1.Size = new Size(149, 29);
            label1.TabIndex = 7;
            label1.Text = "Book Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.IndianRed;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(0, 92);
            label2.Name = "label2";
            label2.Size = new Size(231, 29);
            label2.TabIndex = 8;
            label2.Text = "Book Author Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.IndianRed;
            label3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(0, 152);
            label3.Name = "label3";
            label3.Size = new Size(210, 29);
            label3.TabIndex = 9;
            label3.Text = "Book Publication";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.IndianRed;
            label4.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(0, 217);
            label4.Name = "label4";
            label4.Size = new Size(250, 29);
            label4.TabIndex = 10;
            label4.Text = "Book Purchase Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.IndianRed;
            label5.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(3, 272);
            label5.Name = "label5";
            label5.Size = new Size(141, 29);
            label5.TabIndex = 11;
            label5.Text = "Book Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.IndianRed;
            label6.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(3, 333);
            label6.Name = "label6";
            label6.Size = new Size(175, 29);
            label6.TabIndex = 12;
            label6.Text = "Book Quantity";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Info;
            button1.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(53, 482);
            button1.Name = "button1";
            button1.Size = new Size(114, 48);
            button1.TabIndex = 3;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Info;
            button2.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(264, 482);
            button2.Name = "button2";
            button2.Size = new Size(114, 48);
            button2.TabIndex = 13;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(txtQuantity);
            panel1.Controls.Add(txtPrice);
            panel1.Controls.Add(txtAuthor);
            panel1.Controls.Add(txtPublication);
            panel1.Controls.Add(txtBookName);
            panel1.Location = new Point(416, 60);
            panel1.Name = "panel1";
            panel1.Size = new Size(489, 599);
            panel1.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 659);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
        private TextBox txtBookName;
        private TextBox txtAuthor;
        private TextBox txtPublication;
        private DateTimePicker dateTimePicker1;
        private TextBox txtQuantity;
        private TextBox txtPrice;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button2;
        private Button button1;
        private Label label7;
        private Button button4;
        private OpenFileDialog openFileDialog1;
    }
}