using AccesoDatos;
using Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class DeudorNegocio
    {
        private DeudoresMapper _deudorMapper;
        private List<Pago> _pagos;

        public DeudorNegocio()
        {
            _deudorMapper = new DeudoresMapper();
        }

        public List<Pago> TraerPagos()
        {
            _pagos = _deudorMapper.TraerPagos();
            return _pagos;
        }

        public TransactionResult Alta(Pago _nuevopago)
        {
            
            TransactionResult _resultado = new TransactionResult();
            _resultado = _deudorMapper.AltaPagos(_nuevopago);

            if (!_resultado.isok)
            {
                throw new Exception(_resultado.Error);
            }

            return _resultado;
        
        }


    }
}
