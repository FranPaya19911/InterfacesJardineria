using System;
using Entidades;
using Negocio;
using System.Windows.Forms;

namespace Jardineria
{
    public partial class Pruebas : Form
    {

       
        Tienda tienda = new Tienda();
        public Pruebas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pedido pedido2 = new Pedido(55, DateTime.Now, DateTime.Now, DateTime.Now, "Entregado", "sin comentar", 5);
            Producto producto2 = new Producto("789-8d8", "Velco", "Media", "45x56", "Roto", "No sirve para nada", 200, 20, 10);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCodigoCliente_Click(object sender, EventArgs e)
        {
            int codigoCliente = int.Parse(txtCodigoCliente.Text);

            listBox1.DataSource = tienda.ListarPedidos(codigoCliente);
            
        }

        private void BuscarPedido_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            
            int codigoPedido = int.Parse(txtCodigoPedido.Text);
            
            listBox1.Items.Add(tienda.ListarPedido(codigoPedido));
            
        }

        private void btnListarProductos_Click(object sender, EventArgs e)
        {
            int codigoPedido = int.Parse(txtListarProductos.Text);

            listBox1.DataSource = tienda.ListarProductos(codigoPedido);
        }

        private void ListarPedidos_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = tienda.Listar();
        }
    }
}
