namespace Libro
{
    public class Libro
    {
        private List<string> paginas;

        public Libro()
        {
            this.paginas = new List<string>();
        }
        public string this[int index]
        {
            get
            {
                if(index < 0 || index >= paginas.Count)
                {
                    return "";
                }
                else
                {
                    return paginas[index];
                }
            }

            set
            {
                if (index > this.paginas.Count)
                {

                    paginas.Add(value);
                  
                }
                else if (index >= 0)
                {
                    paginas.Insert(index, value);
                }
            }
        }
    }
}