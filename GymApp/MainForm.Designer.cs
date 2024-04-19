namespace GymApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(949, 533);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.AppWorkspace;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Crimson;
            button1.Location = new Point(198, 3);
            button1.Name = "button1";
            button1.Size = new Size(151, 51);
            button1.TabIndex = 1;
            button1.Text = "Add Member";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.AppWorkspace;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.Crimson;
            button2.Location = new Point(795, 3);
            button2.Name = "button2";
            button2.Size = new Size(151, 51);
            button2.TabIndex = 2;
            button2.Text = "Payment";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.AppWorkspace;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.Crimson;
            button4.Location = new Point(512, 3);
            button4.Name = "button4";
            button4.Size = new Size(277, 51);
            button4.TabIndex = 4;
            button4.Text = "Update/Delete";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(949, 60);
            panel1.TabIndex = 5;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(60, 60);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.AppWorkspace;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.Crimson;
            button3.Location = new Point(355, 3);
            button3.Name = "button3";
            button3.Size = new Size(151, 51);
            button3.TabIndex = 6;
            button3.Text = "View Member";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 533);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Button button4;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Button button3;
    }
}