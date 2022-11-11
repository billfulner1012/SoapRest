using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SoapService
{
	// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
	// NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
	public class Calculator : ICalculator
	{
		public Result Efficiency(Amdhal data)
		{
			var result = (data.Speedup / data.Core) * 100;

			return new Result()
			{
				Calculated = Math.Round(result, 4)
			};
		}

		public Result Speedup(Speedup data)
		{
			var result = (data.SerialTime + data.Time) / ((data.Time / data.Core) + data.SerialTime);

			return new Result()
			{
				Calculated = Math.Round(result, 4)
			};
		}

        public Result DolarSoles(Dolar data)
        {
			decimal valorSoles = 3.9m;
            decimal result = data.ValueDolar * valorSoles;

			return new Result()
			{
				Calculated = Math.Round(result, 2)
            };
        }

        public Result SolesDolar(Soles data)
        {
            decimal valorDolar = 3.9m;
            decimal result = data.ValueSoles / valorDolar;

            return new Result()
            {
                Calculated = Math.Round(result, 2)
            };
        }
    }
}
