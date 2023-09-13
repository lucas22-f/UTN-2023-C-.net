namespace Form01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {

            this.lblHolaMundo.Text = "Hola mundo";
            this.lblHolaMundo.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "HOLA TURRACO ";
           
        }
    }
}