namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void managementButton_Click(object sender, EventArgs e)
        {

            management management = new management("Customer");
            management.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cashierButton_Click(object sender, EventArgs e)
        {
            Cashier cashier = new Cashier();
            cashier.Show();
            this.Hide();
        }
    }
}
