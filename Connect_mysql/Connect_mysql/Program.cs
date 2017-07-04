using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect_mysql
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor01;
            int valor_assis01;
            int valor_assis02;
            int valor_assis03;
            int fatorial = 0;
            Modelo modelo    = new Modelo();
            BancoMysql banco = new BancoMysql();

            Console.WriteLine("Digite um valor para Calcular o Fatorial.");
            valor01 = int.Parse(Console.ReadLine());

            valor_assis01 = valor01;
            valor_assis03 = valor01;

            for(int i = 0; i <= valor01; i++)
            {
                valor_assis01--;
                if(valor_assis01 > 0)
                {
                    valor_assis02 = valor_assis03 * valor_assis01;
                    fatorial = valor_assis02;
                    valor_assis03 = valor_assis02;                    
                }                
            }

            modelo.Valor    = valor01;
            modelo.Fatorial = fatorial;

            banco.cadastro(modelo);

            Console.WriteLine("Valor Digitado: {0} ", valor01);
            Console.WriteLine("Valor do Fatorial: {0} ", fatorial);
            Console.ReadLine();

        }
    }
}
