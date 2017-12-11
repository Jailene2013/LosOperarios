using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operarios
{
    
    class Program
    {
      
        static void Main(string[] args)
        {
            String[] Nombres= new string [5]; //Listado de 5 Nombres en la Memoria
            float[] Sueldos = new float[5];   //Listado de 5 Sueldos en la Memoria
            int PosMayor = 0;                 //Posicion del Sueldo Mayor en el Listado
            string Nombre1, Nombre2, Nombre3, Mat1, Mat2, Mat3;
            Nombre1 = "Halkis Gomez";
            Mat1 = "16-SIIN-1-048";
            Nombre2 = "Jailene Rodriguez";
            Mat2 = "16-SIIN-1-060";
            Nombre3 = "Vileysis Feliz";
            Mat3 = "16-SIIT-1-037";
            //Console.WriteLine("Nombre: Halkis Gomez E. Matricula 16-SIIN-1-048");
            Console.WriteLine("=============================================================");
            Console.WriteLine("     Programacion Estructurada       Seccion 0463            ");
            Console.WriteLine("=============================================================");
            Console.WriteLine("                    Miembros del Grupo                       ");
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine(string.Format("Nombre : {0,-20} - Matricula :{1}", Nombre1, Mat1));
            Console.WriteLine(string.Format("Nombre : {0,-20} - Matricula :{1}", Nombre2, Mat2));
            Console.WriteLine(string.Format("Nombre : {0,-20} - Matricula :{1}", Nombre3, Mat3));
            Console.WriteLine("");
            Console.WriteLine("Presione una tecla para continuar.");
            Console.ReadKey();
            Console.WriteLine("==================================================");
            Console.WriteLine("            Preguntar Operarios y Sueldo          ");
            Console.WriteLine("==================================================");
            //Preguntamos los Nombres y Sueldos
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Introduzca el Nombre del Operario :");
                Nombres[i] = Console.ReadLine();
                Console.Write("Introduzca el Sueldo :");
                Sueldos[i] =float.Parse( Console.ReadLine());
            }
            //Presentamos los Nombres y Sueldos
            Console.WriteLine("==================================================");
            Console.WriteLine("               Operarios y Sueldo                 ");
            Console.WriteLine("==================================================");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(String.Format("Nombre :{0,-20}  Sueldo: {1:C}", Nombres[i], Sueldos[i]));
                //Determinamos el Mayor de los Sueldos

                if (i==0)
                {
                    PosMayor = i;
                }
                else
                {
                    if (Sueldos[i]>Sueldos[PosMayor])
                    {
                        PosMayor = i;
                    }
                }

            }
            //Imprimimos el Mayor de los Sueldos
            Console.WriteLine("==================================================");
            Console.WriteLine("               Sueldo Mayor                       ");
            Console.WriteLine("==================================================");
            Console.WriteLine(String.Format("Nombre :{0,-20}  Sueldo: {1:C}", Nombres[PosMayor], Sueldos[PosMayor]));
            Console.WriteLine("Presione una Tecla para Terminar.");
            Console.ReadLine();
        }
    }

 }
