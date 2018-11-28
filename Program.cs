using System;
using System.Collections.Generic;

namespace ListadoUsuarioTesco
{
    class Program
    {
        static void Main(string[] args)
        {
            var lista = new List<Trabajador>() {
                new Trabajador("Pepe", "Gonzalez", new DateTime(2015,8,3)),
                new Trabajador("Zol", "Sanchez", new DateTime(2018,11,05)),
                new Trabajador("Deis", "Vega", new DateTime(2018,6,15)),
                new Trabajador("ZLM", "Gonzalez", new DateTime(2016,1,12)),
                new Trabajador("LOKO", "Villarejo", new DateTime(2014,9,15))
                

             
            };


           Console.WriteLine("Introduzca el nombre del nuevo trabajador XD: ");
           string name;
           name=Console.ReadLine();
           Console.WriteLine("Introduce el apellido del trabajador: ");
           string surname;
           surname= Console.ReadLine();
           Console.WriteLine("Introduce la fecha de entrada del trabajador en Everis: (dd/mm/yyyy) ");
           DateTime FechaEntrada;
           FechaEntrada= DateTime.Parse (Console.ReadLine());
           lista.Add(new Trabajador (name, surname, FechaEntrada));


           foreach (ListadoUsuarioTesco.Trabajador item in lista)
            {
                Console.WriteLine($"{item.Name} {item.Surname} /// Tiempo trabajado: {item.añostrabajados} años, {item.mesestrabajados} meses y {item.diastrabajados} dias.");
            }
        
        

            //Necesitamos un programa que añada un nuevo trabajador y devuelva
            //un listado con todos los trabajadores y el tiempo que lleva en la empresa

            //Añadir un trabajador a la lista
            


            //Mostrar la lista
            
        }
        
    }

    class Trabajador
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime FechaEntrada { get; set; }


        public DateTime tiempoactual = DateTime.Now;

        public int añostrabajados;

        public int mesestrabajados;

        public int diastrabajados;


        public Trabajador(string name, string surname, DateTime fechaEntradaEveris)
        {
            Name = name;
            Surname = surname;
            FechaEntrada = fechaEntradaEveris;

            añostrabajados = tiempoactual.Year - fechaEntradaEveris.Year;

            mesestrabajados = tiempoactual.Month - fechaEntradaEveris.Month;

            diastrabajados = tiempoactual.Day - fechaEntradaEveris.Day;


        }

    }
}

       

       
           
       

    

        
    

    
    
    


