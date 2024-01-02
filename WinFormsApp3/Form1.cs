namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        int dikey = 5;
        int yatay = 5;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (button1.Bottom >= this.Height || button1.Top <= 0)
                dikey *= -1;
            if (button1.Right >= this.Width || button1.Left <= 0)
                yatay *= -1;

            button1.Top += dikey;
            button1.Left += yatay;
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

    }
}