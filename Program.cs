using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_de_laboratorio
{
    internal class Program
    {
        static string[] codigos = { "OC-101", "OC-102", "OC-103", "OC-104", "OC-105", "OC-106" };
        static string[] proveedores = { "TechCorp", "LogiExpress", "InsumosGlobal", "TechCorp", "AlfaSuministros", "ServiRedes" };
        static void matriz_finan()
        {
            double[,] datos= new double[6, 2];
            double[] precio_unitario = new double [6] { 150.0, 450.0, 80.0, 1200.0, 25.0, 600.0 };
            double[] cantidad = new double [6] {10 , 2 , 50 , 1 , 100 , 3 };
            return;
        }
        static bool validacion_datos()
        {
            double precio = 0;
            double cantidad = 0;
            {
                while (true)
                {
                    if (precio > 0 && cantidad > 0)
                    {
                        return true;
                    }
                }
                Console.WriteLine("Error:  el precio y la cantidad debe ser mayor a 0");
                return false;
            }
        }
        static void contador_Acumuladores(string[] codigos, string[] proveedor)
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6 - i; j++)
                {
                    double monto1 = 
                }
            }
        }   
       
        static void Main(string[] args)
        {
            Console.WriteLine("============================");
            Console.WriteLine("control de ordenes de compra");
            Console.WriteLine("============================");
            Console.WriteLine(""

        }
    }
}
