using System.Text;

namespace EjercicioI03WformClase6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string texto = this.richText1Texto.Text;


            Dictionary<string,int> dict = new Dictionary<string,int>();

            string[] arrStrings = texto.Split(" ");
           

            foreach(string str in arrStrings)
            {
                if (!dict.ContainsKey(str))
                {
                    dict[str] = 1;
                }
                else
                {
                    dict[str]++;
                }
            }


            KeyValuePair<string, int> maximoPar1 = new KeyValuePair<string, int>("", int.MinValue);
            KeyValuePair<string, int> maximoPar2 = new KeyValuePair<string, int>("", int.MinValue);
            KeyValuePair<string, int> maximoPar3 = new KeyValuePair<string, int>("", int.MinValue);

            for (int i = 0; i < dict.Count; i++)
            {
                var kvp = dict.ElementAt(i);

                if (kvp.Value > maximoPar1.Value)
                {
                    maximoPar3 = maximoPar2;
                    maximoPar2 = maximoPar1;
                    maximoPar1 = kvp;
                }
                else if (kvp.Value > maximoPar2.Value)
                {
                    maximoPar3 = maximoPar2;
                    maximoPar2 = kvp;
                }
                else if (kvp.Value > maximoPar3.Value)
                {
                    maximoPar3 = kvp;
                }
            }

            Dictionary<string, int> dict2 = new Dictionary<string, int>
{
                { maximoPar1.Key, maximoPar1.Value },
                { maximoPar2.Key, maximoPar2.Value },
                { maximoPar3.Key, maximoPar3.Value }
};
            StringBuilder sb = new StringBuilder();
            foreach (var kvp in dict2)
            {
                sb.Append($"\nClave: {kvp.Key}, Valor: {kvp.Value}");
            }

            MessageBox.Show(sb.ToString(),"TOP 3 palabras");





        }
    }
}