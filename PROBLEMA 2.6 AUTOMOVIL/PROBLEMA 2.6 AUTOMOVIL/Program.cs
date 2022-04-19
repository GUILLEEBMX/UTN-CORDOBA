using System;

namespace PROBLEMA_2._6_AUTOMOVIL
{
    class Program
    {
        static void Main(string[] args)
        {

            Automovil Auto = new Automovil();
            Tanque Tanque = new Tanque();

            double litrosCargar = 0;
            int kmRecorrer;

            //INGRESAR LA CANTIDAD DE LITROS ACTUALES DEL VEHICULO
            Console.WriteLine("INGRESE LA CANTIDAD DE LITROS ACTUALES DEL VEHICULO:");
            Tanque.LitrosActuales = double.Parse(Console.ReadLine());

            //INGRESAR LA CANTIDAD DE LITROS A CARGAR
            Console.WriteLine("INGRESE LA CANTIDAD DE LITROS A CARGAR:");
            litrosCargar = double.Parse(Console.ReadLine());

            //LLAMADA AL MÉTODO DE TANQUE AGREGAR COMBUSTIBLE
            double resultado = Tanque.AgregarCombustible(litrosCargar, Tanque.LitrosActuales);

            if (litrosCargar > 54)
            {
                Console.WriteLine("SE DERRAMARON " + resultado + " LITROS DE COMBUSTIBLE...");
                Tanque.LitrosActuales = Tanque.Capacidad + Tanque.Reserva;
            }
            else
            {
                Console.WriteLine("SE CARGARON " + litrosCargar + " LITROS " + " EN TOTAL HAY " + resultado + " LITROS...");
                Tanque.LitrosActuales = resultado;
            }

            //INGRESAR CANTIDAD DE KM A RECORRER
            Console.WriteLine("INGRESE LA CANTIDAD DE KM A RECORRER:");
            kmRecorrer = int.Parse(Console.ReadLine());

            //LLAMADA AL MÉTODO DE AUTOMOVIL CONDUCIR Y LLAMADA AL MÉTODO TANQUE CONSUMIR COMBUSTIBLE
            if (Auto.Conducir(kmRecorrer, Tanque.LitrosActuales) == true)
            {
                double litrosFinales = Tanque.LitrosActuales - Tanque.ConsumirCombustible(kmRecorrer);
                Console.WriteLine("SE RECORRIERON " + kmRecorrer + " KMS...");
                Console.WriteLine("PARA RECORRER LOS " + kmRecorrer + " KM FUERON NECESARIOS " + Tanque.ConsumirCombustible(kmRecorrer) + " LITROS Y QUEDARON DISPONIBLES " + litrosFinales + " LITROS...");
            }
            else
            {
                Console.WriteLine("NO HAY COMBUSTIBLE SUFICIENTE PARA RECORRER " + kmRecorrer + " KMS...");
            }

        }
    }
}
