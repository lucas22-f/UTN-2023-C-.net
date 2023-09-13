namespace Form03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int importe = int.Parse(this.textBoxImporte.Text);
            double desc = 0;
            if (importe >= 3000 && importe <= 5000)
            {
                desc = 0.10;
            }else if(importe >= 5000)
            {
                desc = 0.20;
            }
            else
            {
                desc = 0;
            }

            this.textBoxDcto.Text = $"{importe * desc}";

            this.textBoxTotal.Text = $"{importe - (importe * desc)}";



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.textBoxDcto.Enabled = false;
            this.textBoxTotal.Enabled = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            
                this.textBoxDcto.Text = "";
                this.textBoxImporte.Text = "";
                this.textBoxTotal.Text = "";
            
        }
    }
}