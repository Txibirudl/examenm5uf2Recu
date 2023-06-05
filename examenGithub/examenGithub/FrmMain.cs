namespace examenGithub
{
    public partial class FrmMain : Form
    {
        Viatge viatge = null;
        Menjar menjar = null;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menjar = new Menjar();
            menjar.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            viatge= new Viatge();
            viatge.ShowDialog();
        }
    }
}