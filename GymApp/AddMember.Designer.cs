namespace GymApp
{
    partial class AddMember
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            NameTb = new TextBox();
            label4 = new Label();
            label5 = new Label();
            PhoneTb = new TextBox();
            AgeTb = new TextBox();
            label6 = new Label();
            label7 = new Label();
            GenderCb = new ComboBox();
            AmountTb = new TextBox();
            label8 = new Label();
            TimingCb = new ComboBox();
            label9 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label10 = new Label();
            label11 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(469, 23);
            label1.Name = "label1";
            label1.Size = new Size(172, 37);
            label1.TabIndex = 2;
            label1.Text = "GYM CENTER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.Crimson;
            label2.Location = new Point(439, 60);
            label2.Name = "label2";
            label2.Size = new Size(228, 37);
            label2.TabIndex = 3;
            label2.Text = "ADD NEW MEMBER";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Crimson;
            label3.Location = new Point(1098, 9);
            label3.Name = "label3";
            label3.Size = new Size(31, 35);
            label3.TabIndex = 4;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // NameTb
            // 
            NameTb.BackColor = Color.White;
            NameTb.BorderStyle = BorderStyle.FixedSingle;
            NameTb.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NameTb.ForeColor = Color.Crimson;
            NameTb.Location = new Point(119, 210);
            NameTb.Name = "NameTb";
            NameTb.Size = new Size(209, 32);
            NameTb.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Impact", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(119, 182);
            label4.Name = "label4";
            label4.Size = new Size(128, 25);
            label4.TabIndex = 6;
            label4.Text = "Member Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Impact", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(469, 182);
            label5.Name = "label5";
            label5.Size = new Size(129, 25);
            label5.TabIndex = 7;
            label5.Text = "Phone Number";
            label5.Click += label5_Click;
            // 
            // PhoneTb
            // 
            PhoneTb.BackColor = Color.White;
            PhoneTb.BorderStyle = BorderStyle.FixedSingle;
            PhoneTb.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PhoneTb.ForeColor = Color.Crimson;
            PhoneTb.Location = new Point(469, 210);
            PhoneTb.Name = "PhoneTb";
            PhoneTb.Size = new Size(209, 32);
            PhoneTb.TabIndex = 8;
            PhoneTb.TextChanged += textBox2_TextChanged;
            // 
            // AgeTb
            // 
            AgeTb.BackColor = Color.White;
            AgeTb.BorderStyle = BorderStyle.FixedSingle;
            AgeTb.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AgeTb.ForeColor = Color.Crimson;
            AgeTb.Location = new Point(783, 210);
            AgeTb.Name = "AgeTb";
            AgeTb.Size = new Size(209, 32);
            AgeTb.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Impact", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(783, 182);
            label6.Name = "label6";
            label6.Size = new Size(42, 25);
            label6.TabIndex = 10;
            label6.Text = "Age";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Impact", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(119, 337);
            label7.Name = "label7";
            label7.Size = new Size(70, 25);
            label7.TabIndex = 12;
            label7.Text = "Gender";
            label7.Click += label7_Click;
            // 
            // GenderCb
            // 
            GenderCb.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            GenderCb.ForeColor = Color.Crimson;
            GenderCb.FormattingEnabled = true;
            GenderCb.Items.AddRange(new object[] { "Male", "Female" });
            GenderCb.Location = new Point(119, 365);
            GenderCb.Name = "GenderCb";
            GenderCb.Size = new Size(209, 33);
            GenderCb.TabIndex = 13;
            // 
            // AmountTb
            // 
            AmountTb.BackColor = Color.White;
            AmountTb.BorderStyle = BorderStyle.FixedSingle;
            AmountTb.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AmountTb.ForeColor = Color.Crimson;
            AmountTb.Location = new Point(469, 365);
            AmountTb.Name = "AmountTb";
            AmountTb.Size = new Size(209, 32);
            AmountTb.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Impact", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(469, 337);
            label8.Name = "label8";
            label8.Size = new Size(141, 25);
            label8.TabIndex = 14;
            label8.Text = "Monthly Amount";
            // 
            // TimingCb
            // 
            TimingCb.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TimingCb.ForeColor = Color.Crimson;
            TimingCb.FormattingEnabled = true;
            TimingCb.Items.AddRange(new object[] { "6Am-8Am", "8Am-10Am", "6Pm-8Pm", "8Pm-10Pm" });
            TimingCb.Location = new Point(783, 365);
            TimingCb.Name = "TimingCb";
            TimingCb.Size = new Size(209, 33);
            TimingCb.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Impact", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(783, 337);
            label9.Name = "label9";
            label9.Size = new Size(66, 25);
            label9.TabIndex = 16;
            label9.Text = "Timing";
            // 
            // button1
            // 
            button1.BackColor = Color.Crimson;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(272, 483);
            button1.Name = "button1";
            button1.Size = new Size(169, 52);
            button1.TabIndex = 18;
            button1.Text = "Add";
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
            button2.Location = new Point(477, 483);
            button2.Name = "button2";
            button2.Size = new Size(169, 52);
            button2.TabIndex = 19;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Crimson;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(680, 483);
            button3.Name = "button3";
            button3.Size = new Size(169, 52);
            button3.TabIndex = 20;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Crimson;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(477, 563);
            button4.Name = "button4";
            button4.Size = new Size(169, 52);
            button4.TabIndex = 21;
            button4.Text = "Exit";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(438, 711);
            label10.Name = "label10";
            label10.Size = new Size(270, 23);
            label10.TabIndex = 22;
            label10.Text = "DeveloppedByRazvanDrila";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(405, 734);
            label11.Name = "label11";
            label11.Size = new Size(336, 23);
            label11.TabIndex = 23;
            label11.Text = "Contact:razvan.drila@yahoo.com";
            label11.Click += label11_Click;
            // 
            // AddMember
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1141, 766);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(TimingCb);
            Controls.Add(label9);
            Controls.Add(AmountTb);
            Controls.Add(label8);
            Controls.Add(GenderCb);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(AgeTb);
            Controls.Add(PhoneTb);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(NameTb);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddMember";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddMember";
            Load += AddMember_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox NameTb;
        private Label label4;
        private Label label5;
        private TextBox PhoneTb;
        private TextBox AgeTb;
        private Label label6;
        private Label label7;
        private ComboBox GenderCb;
        private TextBox AmountTb;
        private Label label8;
        private ComboBox TimingCb;
        private Label label9;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label10;
        private Label label11;
    }
}