using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
   public  class Servicio
    {

        private int _id;
        private double _tasa;
        private string _descripcion;

        public Servicio()
        { }

        public Servicio(int id, string descripcion, double tasa)
        {
            _id = id;
            _tasa = tasa;
            _descripcion = descripcion;
        }


        public int id { get=>_id; set=>_id=value; }
        public double tasa { get => _tasa; set => _tasa = value; }
        public string descripcion { get => _descripcion; set => _descripcion = value; }

        public List<Servicio> CargarServicio()
        {
            List<Servicio> _servicios = new List<Servicio>();
            _servicios.Add(new Servicio(1, "Edenor", 8.45));
            _servicios.Add(new Servicio(2,"Expensas", 5.20));
            _servicios.Add(new Servicio(3, "Telecom", 2.21));

            return _servicios;
        }


        public override string ToString()
        {
            return string.Format("{0}){1}-{2}", this.id,this.descripcion,this.tasa);

        }

    }
}
