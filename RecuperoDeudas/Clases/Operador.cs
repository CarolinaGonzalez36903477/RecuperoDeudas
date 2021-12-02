using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Operador
    {
        private List<Pago> _pagos;

        public Operador(List<Pago> pagos)
        {
            _pagos = new List<Pago>();
            _pagos = pagos;
        }

        public double AtrasoPromedio()
        {
            double _promediodias = 0;
            double totalDias = 0;

                foreach (Pago p in _pagos)
            {
                totalDias = +p.DiasDeAtraso();
                 
            }
            _promediodias = _promediodias/_pagos.Count;
            return _promediodias;


        }

        public double InteresPromedio()
        {
            double _interesPromedio = 0;

            foreach (Pago p in _pagos)
            {
                _interesPromedio = p.InteresPunitorio;

            }

            _interesPromedio = _interesPromedio/ _pagos.Count;
            return _interesPromedio;
        }
    }
}
