using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public  class Pago
    {
        private int _id;
        private int _idServicio;
        private int _idCliente;
        private DateTime _fechaVencimiento;
        private DateTime _fechaPago;
        private double _importeAdeudado;
        private double _interesPunitorio;
        private double _importeTotal;
        private string _usuario;
        private Servicio _servicio;

        private List<Servicio>();

        public Pago()
        { }

        public Pago(int id, int idservicio, int idcliente, DateTime fechavencimiento, DateTime fechapago, double importeadeudado, double interespunitorio, double importetotal, string usuario,Servicio servicio)
        {
            _id = id;
            _idServicio = idservicio;
            _idCliente = idcliente;
            _fechaVencimiento = fechavencimiento;
            _fechaPago = fechapago;
            _importeAdeudado = importeadeudado;
            _interesPunitorio = interespunitorio;
            _importeTotal = importetotal;
            _usuario = usuario;
            _servicio = new Servicio();

            
        }

        public int id { get=>_id; set=>_id=value; }
        public int idCliente { get => _idCliente; set => _idCliente = value; }
        public int idServicio { get => _idServicio; set => _idServicio = value; }
        public DateTime FechaVencimiento { get => _fechaVencimiento; set => _fechaVencimiento = value; }
        public DateTime FechaPago { get => _fechaPago; set => _fechaPago = value; }

        public double ImporteAdeudado { get => _importeAdeudado; set => _importeAdeudado = value; }
        public string Usuario { get => _usuario; set => _usuario = value; }

        //autocalculables

        public double InteresPunitorio
        {
            set { _interesPunitorio = value; }
            get
            {
                _interesPunitorio = (this._fechaPago-this._fechaVencimiento).Days*Servicio().tasa;
                return _interesPunitorio;
            }

        }
        public double ImporteTotal 
        {
            set{ _importeTotal = value; }
            get      
            {
                _importeTotal = (_importeAdeudado + InteresPunitorio);
              return _importeTotal;
            }
        
        }
        public Servicio Servicio()
        {
            List<Servicio> _servicios = new List<Servicio>();
            _servicios = _servicio.CargarServicio();
                
                foreach (Servicio s in _servicios)
            {
                if (s.id == this._idServicio)
                {
                    _servicio = s;
                }
                
            
            }

            return _servicio;
        
        }
        public int DiasDeAtraso()
        {

            return (_fechaPago - _fechaVencimiento).Days;
        }


        public override string ToString()
        {
            return string.Format("{0}){1}-{2}-{3}", this.idServicio, this.Servicio.descripcion, this.ImporteTotal, this.DiasDeAtraso());
     
       }

    

    }
}
