namespace GymApp
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            UidTb = new MaskedTextBox();
            pictureBox2 = new PictureBox();
            PassTb = new MaskedTextBox();
            pictureBox3 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(34, 96);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(248, 242);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(422, 63);
            label1.Name = "label1";
            label1.Size = new Size(172, 37);
            label1.TabIndex = 1;
            label1.Text = "GYM CENTER";
            // 
            // UidTb
            // 
            UidTb.Font = new Font("Impact", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            UidTb.Location = new Point(376, 150);
            UidTb.Name = "UidTb";
            UidTb.Size = new Size(260, 48);
            UidTb.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(642, 150);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 48);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // PassTb
            // 
            PassTb.Font = new Font("Impact", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            PassTb.Location = new Point(376, 250);
            PassTb.Name = "PassTb";
            PassTb.PasswordChar = '*';
            PassTb.Size = new Size(260, 48);
            PassTb.TabIndex = 4;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(642, 250);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(48, 48);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Crimson;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(549, 368);
            button1.Name = "button1";
            button1.Size = new Size(169, 52);
            button1.TabIndex = 6;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Crimson;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(347, 368);
            button2.Name = "button2";
            button2.Size = new Size(169, 52);
            button2.TabIndex = 7;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Crimson;
            label3.Location = new Point(726, 9);
            label3.Name = "label3";
            label3.Size = new Size(31, 35);
            label3.TabIndex = 8;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(769, 471);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox3);
            Controls.Add(PassTb);
            Controls.Add(pictureBox2);
            Controls.Add(UidTb);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private MaskedTextBox UidTb;
        private PictureBox pictureBox2;
        private MaskedTextBox PassTb;
        private PictureBox pictureBox3;
        private Button button1;
        private Button button2;
        private Label label3;
    }
}
