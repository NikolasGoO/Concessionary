using Concessionary.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concessionary.Classes
{
    public class Vehicle
    {
        public Vehicle(Guid idVehicle, VehicleType typeVehicle, decimal priceVehicle, string vehiclePlate, int vehicleYear, string vehicleBrand, string vehicleColor, Availability availabilityVehicle)
        {
            IdVehicle = idVehicle;
            TypeVehicle = typeVehicle;
            PriceVehicle = priceVehicle;
            VehiclePlate = vehiclePlate;
            VehicleYear = vehicleYear;
            VehicleBrand = vehicleBrand;
            VehicleColor = vehicleColor;
            AvailabilityVehicle = availabilityVehicle;
        }

        public Guid IdVehicle { get; private set; }
        public VehicleType TypeVehicle { get; private set; }
        public decimal PriceVehicle { get; private set; }
        public string VehiclePlate { get; private set; }
        public int VehicleYear { get; private set; }
        public string VehicleBrand { get; private set; }
        public string VehicleColor { get; private set; }
        public Availability AvailabilityVehicle { get; private set; }
        public string VehicleModel { get; private set; }
        
        public void SetIdVehicle(Guid idVehicle)
        {
            IdVehicle = idVehicle;
        }

        public void SetVehicleType(VehicleType typeVehicle)
        {
            TypeVehicle = typeVehicle;
        }

        public void SetPriceVehicle(decimal priceVehicle)
        {
            PriceVehicle = priceVehicle;
        }

        public void SetVehiclePlate(string vehiclePlate)
        {
            VehiclePlate = vehiclePlate;
        }

        public void SetVehicleYear(int vehicleYear)
        {
            VehicleYear = vehicleYear;
        }

        public void SetVehicleBrand(string vehicleBrand)
        {
            VehicleBrand = vehicleBrand;
        }

        public void SetVehicleColor(string vehicleColor)
        {
            VehicleColor = vehicleColor;
        }

        public void SetAvailabilityVehicle(Availability availabilityVehicle)
        {
            AvailabilityVehicle = availabilityVehicle;
        }
    }
}
