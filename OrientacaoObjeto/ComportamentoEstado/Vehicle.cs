using System;

namespace OrientacaoObjeto.ComportamentoEstado
{
    public class Vehicle
    {
        public string VehicleModel { get; set; }
        public DateTime ManufacturYear { get; set; }

        public int CalulateYearUse()
        {
            var dateNow = DateTime.Now;
            var dateUse = dateNow.Year - ManufacturYear.Year;

            if (dateNow < ManufacturYear.AddYears(dateUse)) dateUse--;

            return dateUse;
        }
    }
}
