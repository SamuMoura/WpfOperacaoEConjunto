using System.Collections.Generic;

namespace WpfOpEConj.Model
{
    public class Conjunto
    {
        public List<int> Elementos { get; private set; }

        public Conjunto()
        {
            Elementos = new List<int>();
        }

        public void Adicionar(int elemento)
        {
            if (!Elementos.Contains(elemento))
                Elementos.Add(elemento);
        }

        public void Remover(int elemento)
        {
            Elementos.Remove(elemento);
        }
    }
}
