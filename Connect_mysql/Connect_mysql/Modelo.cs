using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect_mysql
{
    class Modelo
    {
        private int nCodigo;
        private int nValor;
        private int nFatorial;

        public int Codigo
        {
            get { return nCodigo; }
            set { nCodigo = value; }
        }

        public int Valor
        {
            get { return nValor; }
            set { nValor = value; }
        }

        public int Fatorial
        {
            get { return nFatorial; }
            set { nFatorial = value; }
        }

    }
}
