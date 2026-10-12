namespace _2026G26W06GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void OnDeal(object sender, EventArgs e)
        {
            string name = "3000_of_clubs";

            Card1.Image = Properties.Resources.ResourceManager
                .GetObject(name) as Image
                ?? Properties.Resources.red_joker;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}