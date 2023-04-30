using System;

namespace Examen_M2
{
    class Ejercicio2
    {   
        struct Comandas
        {
            public string nombreCliente;
            public string direccionEntrega;
            public string pedidoCliente;
            public decimal totalACobrar;
        }

         public void solucion2()
        {
            Console.Clear();
            System.Console.WriteLine("\nEjecutando ejercicio numero 2\n");
            Comandas[] datos = new Comandas[3];

            Console.WriteLine("Primer registro: \n\n ");
            Console.Write("Introduce el nombre del usuarix: ");
            string nombreCliente = Console.ReadLine();
            Console.Write("Introduce la dirección de entrega, por favor: ");
            string direccionEntrega = Console.ReadLine();
            Console.Write("Introduce el pedido, por favor: ");
            string pedidoCliente = Console.ReadLine();
            Console.Write("Introduce el total a cobrar, por favor: ");
            decimal totalACobrar = decimal.Parse(Console.ReadLine());

            datos[0].nombreCliente = nombreCliente;
            datos[0].direccionEntrega = direccionEntrega;
            datos[0].pedidoCliente = pedidoCliente;
            datos[0].totalACobrar = totalACobrar;

            datos[1].nombreCliente = "Administrador";
            datos[1].direccionEntrega = "Admin 123";
            datos[1].pedidoCliente = "Admin";
            datos[1].totalACobrar = 0;

            datos[2].nombreCliente = "ClienteDePrueba";
            datos[2].direccionEntrega = "Av. Siempre Viva 742, Springfield";
            datos[2].pedidoCliente = "10 pizzas y 50 cervezas";
            datos[2].totalACobrar = 75;

            Console.WriteLine("\n\n Datos insertados:");
            foreach (Comandas registro in datos)
            {
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine("Nombre del Cliente: " + registro.nombreCliente);
                Console.WriteLine("Dirección de Entrega: " + registro.direccionEntrega);
                Console.WriteLine("Pedido: " + registro.pedidoCliente);
                Console.WriteLine("Total a Cobrar: " + registro.totalACobrar + "€");
            }

            Console.ReadLine();
        }
    }
}
