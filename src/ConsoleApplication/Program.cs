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
           // for(int i =1;i<10000001;i++){
             //   var train = new Train($"tren{i}");
            //}

            //Console.WriteLine(Train.Count);

            //train.StartEngines();
            var t1 = new Train("Last Train To London");      
            var t2 = new Train("Last Train To London");
            var t3 = new Train("Runaway Train");      

            Console.WriteLine(t1==t2);
            Console.WriteLine(t2==t3);
            Console.WriteLine(t1.getname());

        }
    }
}