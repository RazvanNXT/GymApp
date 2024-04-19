namespace GymApp
{
    partial class Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            AmountTb = new TextBox();
            label5 = new Label();
            label4 = new Label();
            Periode = new DateTimePicker();
            label6 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label11 = new Label();
            label10 = new Label();
            pictureBox2 = new PictureBox();
            NameCb = new ComboBox();
            PaymentDGV = new DataGridView();
            button4 = new Button();
            SearchName = new TextBox();
            label7 = new Label();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PaymentDGV).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Crimson;
            label3.Location = new Point(1098, 9);
            label3.Name = "label3";
            label3.Size = new Size(31, 35);
            label3.TabIndex = 7;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.Crimson;
            label2.Location = new Point(483, 60);
            label2.Name = "label2";
            label2.Size = new Size(138, 37);
            label2.TabIndex = 6;
            label2.Text = "PAYMENTS";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(469, 23);
            label1.Name = "label1";
            label1.Size = new Size(172, 37);
            label1.TabIndex = 5;
            label1.Text = "GYM CENTER";
            // 
            // AmountTb
            // 
            AmountTb.BackColor = Color.White;
            AmountTb.BorderStyle = BorderStyle.FixedSingle;
            AmountTb.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AmountTb.ForeColor = Color.Crimson;
            AmountTb.Location = new Point(72, 369);
            AmountTb.Name = "AmountTb";
            AmountTb.Size = new Size(209, 32);
            AmountTb.TabIndex = 34;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Impact", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(73, 341);
            label5.Name = "label5";
            label5.Size = new Size(73, 25);
            label5.TabIndex = 33;
            label5.Text = "Amount";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Impact", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(72, 263);
            label4.Name = "label4";
            label4.Size = new Size(128, 25);
            label4.TabIndex = 32;
            label4.Text = "Member Name";
            // 
            // Periode
            // 
            Periode.Location = new Point(72, 214);
            Periode.Name = "Periode";
            Periode.Size = new Size(209, 27);
            Periode.TabIndex = 35;
            Periode.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Impact", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(72, 186);
            label6.Name = "label6";
            label6.Size = new Size(136, 25);
            label6.TabIndex = 36;
            label6.Text = "Payment Month";
            // 
            // button3
            // 
            button3.BackColor = Color.Crimson;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(181, 435);
            button3.Name = "button3";
            button3.Size = new Size(124, 38);
            button3.TabIndex = 43;
            button3.Text = "Reset";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Crimson;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(51, 435);
            button2.Name = "button2";
            button2.Size = new Size(124, 38);
            button2.TabIndex = 42;
            button2.Text = "Pay";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Crimson;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(117, 498);
            button1.Name = "button1";
            button1.Size = new Size(124, 38);
            button1.TabIndex = 44;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(363, 720);
            label11.Name = "label11";
            label11.Size = new Size(336, 23);
            label11.TabIndex = 48;
            label11.Text = "Contact:razvan.drila@yahoo.com";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(398, 697);
            label10.Name = "label10";
            label10.Size = new Size(270, 23);
            label10.TabIndex = 47;
            label10.Text = "DeveloppedByRazvanDrila";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(507, 100);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(84, 80);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 49;
            pictureBox2.TabStop = false;
            // 
            // NameCb
            // 
            NameCb.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NameCb.ForeColor = Color.Crimson;
            NameCb.FormattingEnabled = true;
            NameCb.Items.AddRange(new object[] { "6Am-8Am", "8Am-10Am", "6Pm-8Pm", "8Pm-10Pm" });
            NameCb.Location = new Point(72, 291);
            NameCb.Name = "NameCb";
            NameCb.Size = new Size(209, 33);
            NameCb.TabIndex = 50;
            // 
            // PaymentDGV
            // 
            PaymentDGV.BackgroundColor = SystemColors.ActiveBorder;
            PaymentDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PaymentDGV.Location = new Point(339, 291);
            PaymentDGV.Name = "PaymentDGV";
            PaymentDGV.RowHeadersWidth = 51;
            PaymentDGV.RowTemplate.Height = 29;
            PaymentDGV.Size = new Size(765, 392);
            PaymentDGV.TabIndex = 51;
            // 
            // button4
            // 
            button4.BackColor = Color.Crimson;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(736, 256);
            button4.Name = "button4";
            button4.Size = new Size(124, 32);
            button4.TabIndex = 52;
            button4.Text = "Search";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // SearchName
            // 
            SearchName.BackColor = Color.White;
            SearchName.BorderStyle = BorderStyle.FixedSingle;
            SearchName.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SearchName.ForeColor = Color.Crimson;
            SearchName.Location = new Point(521, 256);
            SearchName.Name = "SearchName";
            SearchName.Size = new Size(209, 32);
            SearchName.TabIndex = 53;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Impact", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = Color.Crimson;
            label7.Location = new Point(561, 216);
            label7.Name = "label7";
            label7.Size = new Size(138, 37);
            label7.TabIndex = 54;
            label7.Text = "PAYMENTS";
            // 
            // button5
            // 
            button5.BackColor = Color.Crimson;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(866, 256);
            button5.Name = "button5";
            button5.Size = new Size(124, 32);
            button5.TabIndex = 55;
            button5.Text = "Refresh";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1141, 766);
            Controls.Add(button5);
            Controls.Add(label7);
            Controls.Add(SearchName);
            Controls.Add(button4);
            Controls.Add(PaymentDGV);
            Controls.Add(NameCb);
            Controls.Add(pictureBox2);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(Periode);
            Controls.Add(AmountTb);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Payment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Payment";
            Load += Payment_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)PaymentDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox AmountTb;
        private Label label5;
        private Label label4;
        private DateTimePicker Periode;
        private Label label6;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label11;
        private Label label10;
        private PictureBox pictureBox2;
        private ComboBox NameCb;
        private DataGridView PaymentDGV;
        private Button button4;
        private TextBox SearchName;
        private Label label7;
        private Button button5;
    }
}