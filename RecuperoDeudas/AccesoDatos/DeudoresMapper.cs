using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;
using Newtonsoft.Json;

namespace AccesoDatos
{
    public class DeudoresMapper
    {

        public DeudoresMapper()
        { }

        public List<Pago> TraerPagos()
        {
            string json = WebHelper.Get("PagoMorosos/889350");
            List<Pago> _lstPagos = JsonConvert.DeserializeObject<List<Pago>>(json);
            return _lstPagos;
        }

        public TransactionResult AltaPagos(Pago NuevoPago)
        {
            NameValueCollection n = ReversoMap(NuevoPago);
            string json = WebHelper.Post("PagoMorosos", n);
            TransactionResult Operacion = JsonConvert.DeserializeObject<TransactionResult>(json);
            return Operacion;
        }

        private NameValueCollection ReversoMap(Pago NuevoPago)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("idServicio", NuevoPago.idServicio.ToString());
            n.Add("ImporteAdeudado", NuevoPago.ImporteAdeudado.ToString("0,00"));
            n.Add("FechaVencimiento", NuevoPago.FechaVencimiento.ToString("yy-MM-dd"));
            n.Add("FechaPago", NuevoPago.FechaPago.ToString("yyyy-MM-dd"));
            n.Add("InteresPunitorio", NuevoPago.InteresPunitorio.ToString("0,00"));
            n.Add("Usuario", "889350");
            n.Add("id", "0");
            n.Add("idCliente", "0");
            return n;
        }

    }
}
