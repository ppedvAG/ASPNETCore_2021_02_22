using System;
using System.Collections.Generic;
using System.Text;

namespace CarService
{
    public class MyImpl
    {
        public void TestMain ()
        {
            ICar myCar = new GoodCar(); //Test


            ICarService service = new GoodCarService();
            service.RepairCar(myCar);
        }
    }
}
