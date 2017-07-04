using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Connect_mysql
{
    class BancoMysql
    {
        private MySqlConnection conexao;
        
        public void cadastro(Modelo modelo)
        {
            string caminho = "SERVER=localhost;DATABASE=test;UID=root;PASSWORD=;";

            try
            {
                conexao = new MySqlConnection(caminho);
                conexao.Open();

                string inserir = "INSERT INTO tbexemplo (valor_input, fatorial_output) values ('" + modelo.Valor + "', '" + modelo.Fatorial + "') ";

                MySqlCommand comandos = new MySqlCommand(inserir, conexao);
                comandos.ExecuteNonQuery();

                conexao.Close();
            }catch(Exception ex)
            {
                throw new Exception("Erro de Comando: "+ex.Message);
            }
        }
    }
}
