namespace GymApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UidTb.Text = "";
            PassTb.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UidTb.Text == "" || PassTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else if (UidTb.Text == "Admin" && PassTb.Text == "Admin")
            {
                MainForm mainform = new MainForm();
                mainform.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Id or Password");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
