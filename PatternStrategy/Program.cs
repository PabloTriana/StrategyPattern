using PatternStrategy.Ducks;
using PatternStrategy.FlyBehavior;
using PatternStrategy.QuackBehavior;
using PatternStrategy.SwimBehavior;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternStrategy
{

    internal class Program
    {
        public static  void EspecieVista(Duck especie)
        {
            int option = 0;
            string optionDuck;
            Console.WriteLine("*************************************");
            Console.Write("Especie: ");
            especie.display();
            Console.Write("Comportamiento volar: ");
            especie.perfomFly();
            Console.Write("Comportamiento nadar: ");
            especie.swim();
            Console.Write("Comportamiento graznar: ");
            especie.perfomQuack();
            Console.WriteLine("*************************************");
            Console.Write("Ingrese que comportamiento del Pato le gustaria cambiar (volar , nadar, graznar, o salir): ");
            optionDuck = Console.ReadLine().ToLower();
            //Cambiar Comportamientos de vuelo//
            if (optionDuck == "volar")
            {
                Console.Clear();
                Console.WriteLine("*************************************");
                Console.Write("Ingrese 1 para volar con alas o 2 para no volar o 3 para volar con cohete: ");
                option = int.Parse(Console.ReadLine());
                
                    if (option == 1)
                    {
                        especie.flyBehavior = new FlyWithWings();
                    }
                    if (option == 2)
                    {
                        especie.flyBehavior = new FlyNoWay();
                    }
                    if (option == 3)
                    {
                        especie.flyBehavior = new FlyWithRocket();
                    }
                Console.WriteLine("Cambio realizado!");
                Console.ReadKey();
                Console.Clear();

            }
            //Cambiar Comportamientos de nadar//
            if (optionDuck == "nadar")
            {
                Console.Clear();
                Console.WriteLine("*************************************");
                Console.Write("Ingrese 1 para nadar o 2 para no nadar o 3 para nadar en bote: ");
                option = int.Parse(Console.ReadLine());
                if (option == 1)
                {
                    especie.swimBehavior = new SwimDuck();
                }
                if (option == 2)
                {
                    especie.swimBehavior = new SwimNoWay();
                }
                if(option == 3)
                {
                    especie.swimBehavior = new SwimWithBoat();
                }
                Console.WriteLine("Cambio realizado!");
                Console.ReadKey();
                Console.Clear();

            }
            //Cambiar Comportamientos de graznar//
            if (optionDuck == "graznar")
            {
                Console.Clear();
                Console.WriteLine("*************************************");
                Console.Write("Ingrese 1 para hacer Quack o 2 para Mute o 3 para Squeak: ");
                option = int.Parse(Console.ReadLine());
                if (option == 1)
                {
                    especie.quackBehavior = new Quack();
                }
                if (option == 2)
                {
                    especie.quackBehavior = new MuteQuack();
                }
                if (option == 3)
                {
                    especie.quackBehavior = new Squeak();
                }
                Console.WriteLine("Cambio realizado!");
                Console.ReadKey();
                Console.Clear();

            }
            if (optionDuck == "salir")
            {
                Console.Clear();
            }

        }

        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            Duck readHead = new RedHeadDuck();
            Duck decoy = new DecoyDuck();
            Duck model = new ModelDuck();
            Duck rubber = new RubberDuck();

            int option = 0;
            do
            {
                Console.WriteLine("************* Bienvenido ***********");
                Console.WriteLine("** Seleccione una especie de pato **");
                Console.WriteLine("Presione 1 para seleccionar el tipo Mallard Duck");
                Console.WriteLine("Presione 2 para seleccionar el tipo Red Head Duck");
                Console.WriteLine("Presione 3 para seleccionar el tipo Decoy Duck");
                Console.WriteLine("Presione 4 para seleccionar el tipo Model Duck");
                Console.WriteLine("Presione 5 para seleccionar el tipo Rubber Duck");
                Console.WriteLine("Presione 0 para salir del programa");
                Console.WriteLine("*************************************");
                Console.Write(">>> ");
                option = (int.Parse(Console.ReadLine()));
                Console.Clear();
                switch (option)
                {
                    case 0:
                        Environment.Exit(0);
                    break;

                    case 1:
                        EspecieVista(mallard);
                    break;

                    case 2:
                        EspecieVista(readHead);
                    break;

                    case 3:
                        EspecieVista(decoy);
                    break;

                    case 4:
                        EspecieVista(model);
                    break;

                    case 5:
                        EspecieVista(rubber);
                    break;

                    default:
                        Console.WriteLine("Ingrese una opcion Correcta.");
                        Console.WriteLine("Presione <Enter> para volver...");
                        Console.ReadKey();
                        Console.Clear();
                    break;
                }
                

            } while (option != 0);
        }
    }
}


/*
 
  Console.WriteLine("*************************************");
                        Console.Write("Especie: ");
                        mallard.display();
                        Console.Write("Comportamiento volar: ");
                        mallard.perfomFly();
                        Console.Write("Comportamiento nadar: ");
                        mallard.swim();
                        Console.Write("Comportamiento graznar: ");
                        mallard.perfomQuack();
                        Console.WriteLine("*************************************");
                        Console.Write("Ingrese que comportamiento del Pato le gustaria cambiar.(volar , nadar,graznar): ");
                        optionDuck = Console.ReadLine().ToLower();
                        //Cambiar Comportamientos de vuelo//
                        if(optionDuck == "volar")
                        {
                            Console.Clear();
                            Console.WriteLine("*************************************");
                            Console.Write("Ingrese 1 para volar con alas o 2 para no volar: ");
                            option = int.Parse(Console.ReadLine());
                            if(option == 1)
                            {
                                mallard.flyBehavior = new FlyWithWings();
                            }
                            if(option == 2)
                            {
                                mallard.flyBehavior = new FlyNoWay();
                            }
                            Console.WriteLine("Cambio realizado!");
                            Console.ReadKey();

                        }
                        //Cambiar Comportamientos de nadar//
                        if (optionDuck == "nadar")
                        {
                            Console.Clear();
                            Console.WriteLine("*************************************");
                            Console.Write("Ingrese 1 para nadar o 2 para no nadar: ");
                            option = int.Parse(Console.ReadLine());
                            if (option == 1)
                            {
                                mallard.swimBehavior = new SwimDuck();
                            }
                            if (option == 2)
                            {
                                mallard.swimBehavior = new SwimNoWay();
                            }
                            Console.WriteLine("Cambio realizado!");
                            Console.ReadKey();

                        }
                        //Cambiar Comportamientos de graznar//
                        if (optionDuck == "graznar")
                        {
                            Console.Clear();
                            Console.WriteLine("*************************************");
                            Console.Write("Ingrese 1 para hacer Quack o 2 para Mute o 3 para Squeak: ");
                            option = int.Parse(Console.ReadLine());
                            if (option == 1)
                            {
                                mallard.quackBehavior = new Quack();
                            }
                            if(option == 2)
                            {
                                mallard.quackBehavior = new MuteQuack();
                            }
                            if(option == 3)
                            {
                                mallard.quackBehavior = new Squeak();
                            }
                            Console.WriteLine("Cambio realizado!");
                            Console.ReadKey();

                        }
                        Console.WriteLine("Presione <Enter> para volver...");
                        Console.ReadKey();
                        Console.Clear();
 */