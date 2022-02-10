using System;

namespace Ander
{
    class Program
    {
        static void Main(string[] args)
        {

            char OpcionCarro;
            int Marca;
            char Opcion, Opcion1, Opcion2, Opcion3;

            Console.WriteLine("--------------");
            Console.WriteLine("BIENVENIDO A LA VENTA DE AUTOMOVILES");
            Console.WriteLine("--------------");
            Console.WriteLine("Estas son las marcas que proveemos en nuestro sitio: \n Chevrolet \n Nissan \n Renault \n Hyundai \n  oprima 0 si le interesa alguna marca de estas o 1 si no es el caso");
            int.TryParse(Console.ReadLine(), out Marca);

            if (Marca == 0)
            {
                Console.WriteLine(" Escoje el auto que desees comprar con el numero indicado: \n 1) Chevrolet: \n 2) Nissan: \n 3) Renault: \n  4) Hyundai:  ");
                char.TryParse(Console.ReadLine(), out OpcionCarro);

                switch (OpcionCarro)
                {
                    case '1':
                        {
                            Console.WriteLine("Chevrolet: " +
                                "\n 1) chevrolet Aveo  " +
                                "\n 2)  Chevrolet Spark \n" +
                                "3) chevrolet Camaro \n " +
                                "4) Chevrolet Captiva " +
                                "\n Escoje el numero de interes");
                            char.TryParse(Console.ReadLine(), out Opcion);
                            switch (Opcion)
                            {
                                case '1':
                                    {
                                        Console.WriteLine("el Aveo tiene un costo de 20.000.000, Feliz Compra");
                                    }
                                    break;
                                case '2':
                                    {
                                        Console.WriteLine("el Spark tiene un costo de 15.000.000, Feliz Compra");
                                    }
                                    break;
                                case '3':
                                    {
                                        Console.WriteLine("el Camaro tiene un costo de 45.000.000, Feliz Compra");
                                    }
                                    break;
                                case '4':
                                    {
                                        Console.WriteLine("el Captiva tiene un costo de 30.000.000, Feliz Compra");
                                    }
                                    break;
                            }
                        }
                        break;
                    case '2':
                        {
                            Console.WriteLine("Nissan: " +
                                "\n 1) nuevo march:  " +
                                "\n 2) nuevo versa:  " +
                                " \n 3) nuevo sentra:  " +
                                "\n 4) leaf: " +
                                "\n Escoje el numero de interes");
                            char.TryParse(Console.ReadLine(), out Opcion1);
                            switch (Opcion1)
                            {
                                case '1':
                                    {
                                        Console.WriteLine("el March tiene un costo de 60.490.000, Feliz Compra");
                                    }
                                    break;
                                case '2':
                                    {
                                        Console.WriteLine("el Versa tiene un costo de 70.990.000, Feliz Compra");
                                    }
                                    break;
                                case '3':
                                    {
                                        Console.WriteLine("el sentra tiene un costo de 125.000.000, Feliz Compra");
                                    }
                                    break;
                                case '4':
                                    {
                                        Console.WriteLine("el leaf tiene un costo de 170.000.000, Feliz Compra");
                                    }
                                    break;
                            }
                        }
                        break;

                    case '3':
                        {
                            Console.WriteLine("Renault: " +
                                "\n 1) Renault captur: 77,115,748 " +
                                "\n 2) Renault koleos: 120,500,000 " +
                                "\n 3) Renault kwid: 40,500,000 " +
                                "\n 4) Renault logan: 45,866,535" +
                                "\n Escoje el numero de interes");
                            char.TryParse(Console.ReadLine(), out Opcion2);
                            switch (Opcion2)
                            {
                                case '1':
                                    {
                                        Console.WriteLine("el Captur tiene un costo de 77.000.000, Feliz Compra");
                                    }
                                    break;
                                case '2':
                                    {
                                        Console.WriteLine("el Koleos tiene un costo de 115.000.000, Feliz Compra");
                                    }
                                    break;
                                case '3':
                                    {
                                        Console.WriteLine("el Kwid tiene un costo de 45.000.000, Feliz Compra");
                                    }
                                    break;
                                case '4':
                                    {
                                        Console.WriteLine("el Logan tiene un costo de 45.000.000, Feliz Compra");
                                    }
                                    break;
                            }
                        }
                        break;

                    case '4':
                        {
                            Console.WriteLine("Hyundai: " +
                                "\n 1) Tucson:  " +
                                "\n 2) HB20 Accent:  " +
                                "\n 3) kona:  \n" +
                                " 4) HB20 Graviti:" +
                                "\n Escoje el numero de interes");
                            char.TryParse(Console.ReadLine(), out Opcion3);
                            switch (Opcion3)
                            {
                                case '1':
                                    {
                                        Console.WriteLine("el tucson tiene un costo de 115.200.000, Feliz Compra");
                                    }
                                    break;
                                case '2':
                                    {
                                        Console.WriteLine("el HB20 Accent tiene un costo de 65.000.000, Feliz Compra");
                                    }
                                    break;
                                case '3':
                                    {
                                        Console.WriteLine("el Kona tiene un costo de 124.990.000, Feliz Compra");
                                    }
                                    break;
                                case '4':
                                    {
                                        Console.WriteLine("el HB20 Graviti tiene un costo de 73.000.000, Feliz Compra");
                                    }
                                    break;
                            }
                        }
                        break;

                }
            }
            else
            {
                Console.WriteLine(":(");
            }
        }

    }
}
