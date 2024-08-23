namespace ProjetFrame
{
    public partial class splashScreen : Form
    {
        public splashScreen()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int startpos = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpos += 1;
            Myprogress.Value = startpos;
            if (Myprogress.Value == 30)
            {
                Myprogress.Value = 0;
                timer1.Stop();
                Login log = new Login();
                log.Show();
                this.Hide();
            }
        }

        private void splashScreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Myprogress_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
