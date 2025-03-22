
using System;

namespace ProgramacionOrientadaAObjetos.NewFolder
{
    class Program
    {
        static void Main(string[] args)
        {
            

            // Auto de Combustión
            AutoDeCombustion miAuto = new AutoDeCombustion("Rojo", "Ferrari", "2022");
            miAuto.InformacionVehiculo();
            miAuto.Encender();
            miAuto.Acelerar();
            miAuto.Frenar();
            miAuto.CargarGasolina(30);

            Console.WriteLine();

            // Motocicleta
            Motocicleta miMoto = new Motocicleta("Negra", "Yamaha MT 09", "2023");
            miMoto.InformacionVehiculo();
            miMoto.Encender();
            miMoto.Acelerar();
            miMoto.Frenar();
            miMoto.CambiarAceite();

            Console.WriteLine();

            // Camión
            Camion miCamion = new Camion("Azul", "Volvo FH", "2022");
            miCamion.InformacionVehiculo();
            miCamion.Encender();
            miCamion.Acelerar();
            miCamion.Frenar();
            miCamion.CargarCamion(4000);

            Console.WriteLine();

            // Auto Eléctrico
            AutoElectrico miTesla = new AutoElectrico("Blanco", "Tesla ", "2024");
            miTesla.InformacionVehiculo();
            miTesla.Encender();
            miTesla.Acelerar();
            miTesla.Frenar();
            miTesla.CargarBateria(74); // Cargar 74% de la batería

            Console.WriteLine();
        }
    }
}
