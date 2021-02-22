using System;
using System.Collections.Generic;
using System.Text;

namespace CarService
{
    public interface ICar
    {
        public string Marke { get; set; }
        public string Model { get; set; }
        public DateTime ConstructedAt { get; set; }
    }

    public interface ICarService
    {
        void RepairCar(ICar car);
    }



    public class GoodCar : ICar // 5 Tage
    {
        public string Marke { get; set; }
        public string Model { get; set; }
        public DateTime ConstructedAt { get; set; }
    }


    
    public class GoodCarService : ICarService // 3 Tage
    {
        public GoodCarService()
        {
                
        }

        public GoodCarService(ICar car)
        {

        }
        public void RepairCar(ICar car)
        {
            //Machwas
        }
    }

    public class MockCar : ICar
    {
        public string Marke { get; set; } = "BMW";
        public string Model { get; set; } = "Z8";
        public DateTime ConstructedAt { get; set; } = DateTime.Now;
    }
}
