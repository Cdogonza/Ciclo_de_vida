//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using ClassLibrary;

namespace ConsoleApplication
{
    /// <summary>
    /// Programa de consola de demostración.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main()
        {   
            for(int i =0;i<100;i++)
            {
                string nombre = i.ToString();
                var train = new Train(nombre);               
            }
            Console.WriteLine(Train.Count); // IMPRIME DEL 1 AL 100 QUE SON LAS 100 PRIMERAS INSTANCIAS DE CLASE
            for(int i =0;i<10000000;i++)
            {
                string nombre = i.ToString();
                var train = new Train(nombre);               
            }
            Console.WriteLine(Train.Count); //IMPRIME 10000100 INSTANCIAS PORQUE LA VARIABLE COUNT TIENE VALOR 100 CUANDO INICIA ESTE FOR PORQUE NO SE REINICIA YA QUE 
                                            //EL PROGRAMA NO HA TERMINADO
            var t1 = new Train("Last Train To London"); 
            var t2 = new Train("Last Train To London");
            var t3 = new Train("Runaway Train");
            //t1==t2 POR MAS QUE LLEVEN EL MISMO IDENTIFICADOR SON INSTANCIAS DIFERENTES
            //t2 == t3 TAMBIEN SON INSTANCIAS DIFERENTES
        
            
           // train.StartEngines();
         //   Console.WriteLine("Hello World!");
        }
    }
}