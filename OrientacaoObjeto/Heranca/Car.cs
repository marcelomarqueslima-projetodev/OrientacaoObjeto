using System;
using OrientacaoObjeto.ComportamentoEstado;

namespace OrientacaoObjeto.Heranca
{
    public class Car : Vehicle
    {
        public DateTime ModelYear { get; set; }
        public string Register { get; set; }

        public class Process
        {
            public void Run()
            {
                var car = new Car()
                {
                    VehicleModel = "Fusca",
                    ManufacturYear = Convert.ToDateTime("1968/01/01"),
                    ModelYear = Convert.ToDateTime("1969/01/01"),
                    Register = "12346578"
                };

                car.CalulateYearUse();
            }
        }
    }
}
