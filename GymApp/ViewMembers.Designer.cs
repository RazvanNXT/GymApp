namespace GymApp
{
    partial class ViewMembers
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            MemberSDGV = new DataGridView();
            button2 = new Button();
            SearchMember = new TextBox();
            button1 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)MemberSDGV).BeginInit();
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
            label2.Location = new Point(478, 60);
            label2.Name = "label2";
            label2.Size = new Size(189, 37);
            label2.TabIndex = 6;
            label2.Text = "MEMBERS LIST";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(495, 23);
            label1.Name = "label1";
            label1.Size = new Size(172, 37);
            label1.TabIndex = 5;
            label1.Text = "GYM CENTER";
            // 
            // MemberSDGV
            // 
            MemberSDGV.BackgroundColor = SystemColors.ActiveBorder;
            MemberSDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MemberSDGV.Location = new Point(38, 182);
            MemberSDGV.Name = "MemberSDGV";
            MemberSDGV.RowHeadersWidth = 51;
            MemberSDGV.RowTemplate.Height = 29;
            MemberSDGV.Size = new Size(1052, 513);
            MemberSDGV.TabIndex = 46;
            // 
            // button2
            // 
            button2.BackColor = Color.Crimson;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(636, 128);
            button2.Name = "button2";
            button2.Size = new Size(109, 32);
            button2.TabIndex = 47;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // SearchMember
            // 
            SearchMember.BackColor = Color.White;
            SearchMember.BorderStyle = BorderStyle.FixedSingle;
            SearchMember.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SearchMember.ForeColor = Color.Crimson;
            SearchMember.Location = new Point(381, 130);
            SearchMember.Name = "SearchMember";
            SearchMember.Size = new Size(249, 32);
            SearchMember.TabIndex = 48;
            // 
            // button1
            // 
            button1.BackColor = Color.Crimson;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(751, 128);
            button1.Name = "button1";
            button1.Size = new Size(109, 32);
            button1.TabIndex = 49;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Crimson;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(506, 716);
            button4.Name = "button4";
            button4.Size = new Size(124, 38);
            button4.TabIndex = 50;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // ViewMembers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1141, 766);
            Controls.Add(button4);
            Controls.Add(button1);
            Controls.Add(SearchMember);
            Controls.Add(button2);
            Controls.Add(MemberSDGV);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewMembers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewMembers";
            Load += ViewMembers_Load;
            ((System.ComponentModel.ISupportInitialize)MemberSDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView MemberSDGV;
        private Button button2;
        private TextBox SearchMember;
        private Button button1;
        private Button button4;
    }
}