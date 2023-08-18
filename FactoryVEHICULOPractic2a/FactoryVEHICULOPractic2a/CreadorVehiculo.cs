using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryVEHICULOPractic2a
{

    class CreadorVehiculo
    {

        public static IVehiculo GetVehiculo(string vehiculo)
        {
            if (vehiculo == "1")
            {
                string marca = "XYZ Motorcycles";
                string modelo = "XZ200";
                int año = 2022;
                float precio = 5000.00f;
                return new Motocicleta(marca, modelo, año, precio);


            }
            else if (vehiculo == "2")
            {
                string marca = "ABC Motors";
                string modelo = "XYZ";
                int año = 2022;
                float precio = 25000.00f;
                return new Carro(marca, modelo, año, precio);
            }
            else if (vehiculo == "3")
            {
                string marca = "Electra Motors";
                string modelo = "ECO-EV";
                string tiempo_Carga = "6 horas";
                int año = 2023;
                float precio = 35000.00f;
                return new Electrico(marca, modelo, tiempo_Carga, año, precio);
            }
            else if (vehiculo == "4")
            {
                string marca = "ABC Vans";
                string modelo = "CargoMaster";
                int año = 2022;
                float precio = 30000.00f;
                return new Furgoneta(marca, modelo, año, precio);
            }
            else if (vehiculo == "5")
            {
                string marca = "BikeTech";
                string modelo = "SpeedRider";
                string Tipo_bicicleta = "Bicicleta de montaña";
                int año = 2022;
                float precio = 1500.00f;
                return new Bicicleta(marca, modelo, Tipo_bicicleta, año, precio);
            }
            else
            {
                return null;
            }
        }
    }
}
