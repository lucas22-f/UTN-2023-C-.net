using System.Text;

namespace Form02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            this.listBoxTabla.Items.Clear();
            this.textBox1.Text = "";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            
            
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int numero = int.Parse(this.textBox1.Text);
                for (int i = 1; i <= 10; i++)
                {
                    this.listBoxTabla.Items.Add($"\n{numero} * {i} = {numero * i}");

                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            MessageBox.Show("esta seguro de cerrar la app? ");
            
        }
    }
}