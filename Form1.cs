namespace Биохимический_анализ_крови
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0;
            int f = 0;
            Start newForm = new Start(a,f);
            this.Hide();
            newForm.ShowDialog();
            this.Show(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Info newForm = new Info();
            this.Hide();
            newForm.ShowDialog();
            this.Show();
        }
    }
}

