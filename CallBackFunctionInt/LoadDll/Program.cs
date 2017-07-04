using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace LoadDll
{
    class Program
    {


        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        delegate int FuncaoImprime(int valor);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        delegate int FuncaoImprime02();
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        delegate double FuncaoImprime03(double valor1, double valor2);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        delegate int FuncaoImprime04();
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        delegate int FuncaoImprime05(int valor);

        //Importando funcao da Dll 
        [DllImport(@"CallingCDll.dll", CallingConvention = CallingConvention.Cdecl)]//Cdecl é a forma padrão de chamada em C
        static extern void ChamaFunc(FuncaoImprime func);
        [DllImport(@"CallingCDll.dll", CallingConvention = CallingConvention.Cdecl)]//Cdecl é a forma padrão de chamada em C
        static extern void ChamaFuncString(FuncaoImprime02 func);
        [DllImport(@"CallingCDll.dll", EntryPoint = "CalcularResisEletrica", CallingConvention = CallingConvention.Cdecl)]//Cdecl é a forma padrão de chamada em C
        static extern void CalcularResisEletrica(FuncaoImprime03 func);

        [DllImport("CallingCDll02.dll")]//Cdecl é a forma padrão de chamada em C
        public static extern void showMessageFromBack();

        [DllImport("TestLib.dll")]
        public static extern void DisplayHelloFromDLL();

        [DllImport("TestLib.dll")]
        public static extern void showMessageFromOut();

        [DllImport("TestLib.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern void ChamaFuncStringDesc(FuncaoImprime04 func);

        [DllImport(@"TestLib.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern void ChamaFuncIntDesc(int x,FuncaoImprime05 func);

        //Funcao que sera chamada do C (Callback)
        static int Imprime(int valor)
        {
            Console.WriteLine("Valor: {0} ", valor);
            return 0;
        }

        static int ImprimeInt(int valor)
        {
            int resu;
            resu = (valor * valor * valor) / 2;
            Console.WriteLine();
            Console.WriteLine("Dentro do C# agora imprimindo o calculo Complexo: {0} ", resu);
            Console.WriteLine();
            return 0;
        }

        static double ImprimeCalculoComplexo(double valor1, double valor2)
        {
            double resultado;
            resultado = valor1 / valor2;
            Console.WriteLine();
            Console.WriteLine("Valor do calc Complexo: {0} ", resultado);
            Console.WriteLine();
            
            return 23.2;
        }

        public static int ImprimeOutro()
        {
            Console.WriteLine();
            Console.WriteLine("Outro Chamado de Callback");
            Console.WriteLine("Parabens esse é um chamado para testar callBack");
            Console.WriteLine();
            return 0;
        }

        public static int ImprimeOutro02()
        {
            Console.WriteLine();
            Console.WriteLine("Outro Chamado de Callback02 ");
            Console.WriteLine("Parabens esse é um chamado para testar callBack segundo teste");
            Console.WriteLine();
            return 0;
        }

        static void Main(string[] args)
        {

            //Chama a funcao da DLL e espera o callback ser chamado
            showMessageFromBack();

            ChamaFunc(Imprime);
            ChamaFuncString(ImprimeOutro);
            DisplayHelloFromDLL();
            CalcularResisEletrica(ImprimeCalculoComplexo);
            showMessageFromOut();

            ChamaFuncStringDesc(ImprimeOutro02);

            ChamaFuncIntDesc(221,ImprimeInt);
            // ChamaFunc(ImprimeOutro);
            Console.ReadKey();
        }
    }
}
