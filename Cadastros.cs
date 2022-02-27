using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtivSem01
{
    public class Cadastros
    {
        public interface IOperacoesBD
        {
            void Inserir();
            void Alterar();
            void Deletar();
            void Pesquisar();
        }

        public abstract class Cadastro : IOperacoesBD
        {
            protected object Conexao { get; set; }

            protected Cadastro (object conexao)
            {
                Conexao = conexao;
            }

            public void Alterar()
            {
                Console.WriteLine("Alterado");
            }

            public void Deletar()
            {
                Console.WriteLine("Deletado");
            }

            public void Inserir()
            {
                Console.WriteLine("Inserido");
            }

            public void Pesquisar()
            {
                Console.WriteLine("Pesquisado");
            }
        }
    }
}