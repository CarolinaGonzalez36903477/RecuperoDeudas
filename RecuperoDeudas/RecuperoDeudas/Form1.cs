using AccesoDatos;
using Clases;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecuperoDeudas
{
    public partial class Form1 : Form
    {
        private  DeudorNegocio _deudoresNegocio;
        private Servicio _Servicio;
        private Pago _pago;
        private List<Pago> _pagos;
        private Operador _operador;
        public Form1()
        {
            _deudoresNegocio = new DeudorNegocio();
            _Servicio = new Servicio();
            _pago = new Pago();
            _pagos = new List<Pago>();
            _operador = new Operador(_pagos);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbServicio.DataSource = _Servicio.CargarServicio();

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            try
            {
                ValidacionesCalcular();
                _Servicio = (Servicio)cmbServicio.SelectedItem;
                _pago = CargarPagoCalcular(_Servicio);
                if (_Servicio.id == 1)
                {
                    txbPunitorioDia.Text = "8.45";
                }
                if (_Servicio.id == 2)
                {
                    txbPunitorioDia.Text = "5.20";
                }
                if (_Servicio.id == 3)
                {
                    txbPunitorioDia.Text = "2.21";
                }

                txtbPunitorio.Text = _pago.InteresPunitorio.ToString("0.00");

                txbImporteTotal.Text = _pago.ImporteTotal.ToString("0.00");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void ValidacionesCalcular()
        {
            if (cmbServicio.SelectedItem == null || txbImporteAdeudado.Text == "" || txbFechaVencimiento.Text == "" || txbFechaPago.Text == "")
            {
                throw new Exception("Todos los campos deben estar completados y seleccionados");
                
            }

            if(!double.TryParse(txbImporteAdeudado.Text,out double salida))
            {
                throw new Exception("El campo importe adeudado debe ser numerico y positivo");

            }


            if (!DateTime.TryParse(txbFechaVencimiento.Text, out DateTime salida1) || !DateTime.TryParse(txbFechaPago.Text, out DateTime salida2))
            {
                throw new Exception("Ingrese fechas validas");

            }


        }

        public Pago CargarPagoCalcular(Servicio servicio)
        {
            Pago _pago = new Pago();
            _pago.ImporteAdeudado = Convert.ToDouble(txbImporteAdeudado.Text);
            _pago.FechaVencimiento = Convert.ToDateTime(txbFechaVencimiento.Text);
            _pago.FechaPago = Convert.ToDateTime(txbFechaPago.Text);
            return _pago;
        }

        private void BtnPagar_Click(object sender, EventArgs e)
        {
            try
            {
                TransactionResult _Resultado = new TransactionResult();
                _Servicio = (Servicio)cmbServicio.SelectedItem;
                _pago = CargarPagoCalcular(_Servicio);
                _Resultado = _deudoresNegocio.Alta(_pago);
                Refrescar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        public void Refrescar()
        {
            _pagos = _deudoresNegocio.TraerPagos();
            lstbPagos.DataSource = _pagos.ToString();
            TxbInteresPromedio.Text = _operador.InteresPromedio().ToString("0.00");
            txbDiasDeAtraso.Text = _operador.AtrasoPromedio().ToString("0.00");

        }
    }
}
