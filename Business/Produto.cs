using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Marca { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }

        public void Gravar()
        {
            new Database.Produto().Gravar(this.Nome, this.Marca, this.Descricao, this.Valor);
            Console.WriteLine(this.Nome +"-"+ this.Marca + "-" + this.Descricao + "-" + this.Valor);
        }
    }
}
