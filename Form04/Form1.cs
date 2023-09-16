using System.Runtime.CompilerServices;

namespace Form04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int numero;
            if(int.TryParse(this.textBox1.Text,out numero)){
                this.listBoxNros.Items.Add(numero);
                this.textBox1.Text = "";
            }
            else
            {
                MessageBox.Show("Ingresa solo numeros","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                
            }
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
                List<int> lista = this.CrearListaDesdeListBox();
                this.listBoxNros.Items.Clear();

            if (this.radioBtnAsc.Checked)
            {
                this.ReemplazarListaOrdenada(lista,false);
                
            }else if (this.radioBtnDesc.Checked)
            {
                this.ReemplazarListaOrdenada(lista, true);
                
            }
        }

        private void ReemplazarListaOrdenada(List<int> lista,bool reversa)
        {
            if (!reversa)
            {
                lista.Sort();
            }
            else
            {
                lista.Reverse();
            }
            

            foreach (int numero in lista)
            {
                this.listBoxNros.Items.Add(numero);
            }
            
            
        }

        private List<int> CrearListaDesdeListBox()
        {
            List<int> lista = new List<int>();
            foreach (int numero in this.listBoxNros.Items)
            {
                lista.Add(numero);
            }
            return lista;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            foreach(Control controls in this.groupBoxEntrada.Controls)
            {
                if (controls is TextBox)
                {
                    controls.Text = "";
                }
            }

            this.listBoxNros.Items.Clear();

            foreach(Control controls in this.groupBoxOrden.Controls)
            {
                if (controls is RadioButton rb)
                {
                    rb.Checked = false;
                }
            }
        }
    }
}