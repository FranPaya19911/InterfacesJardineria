using Capa_Datos;
using Entidades;
using System.Collections.Generic;

namespace Negocio
{
    public class Tienda
    {
        protected List<Pedido> _pedidoList = new List<Pedido>();
        protected List<Producto> _productoList = new List<Producto>();

        public Tienda()
        {
            _pedidoList = new List<Pedido>();
            _productoList = new List<Producto>();
        }

        public Tienda(Pedido pedido, Producto producto)
        {
            _pedidoList.Add(pedido);
            _productoList.Add(producto);
        }

        public Tienda(Tienda previousTienda)
        {
            _pedidoList = previousTienda._pedidoList;
            _productoList = previousTienda._productoList;

        }
        ~Tienda()
        {
            _pedidoList = new List<Pedido>();
            _productoList = new List<Producto>();
        }

        public override string ToString()
        {
            string listaPedido = "";
            string listaProducto = "";

            for (int i = 0; i < _pedidoList.Count; i++)
            {
                listaPedido += _pedidoList[i].ToString();
            }

            for (int i = 0; i < _productoList.Count; i++)
            {
                listaProducto += _productoList[i].ToString();
            }

            return listaPedido + " # " + listaProducto;
        }

        public List<Pedido> Lista_Pedigo
        {
            get
            {
                return _pedidoList;
            }

            set
            {
                _pedidoList = value;
            }
        }

        public List<Producto> Lista_Producto
        {
            get
            {
                return _productoList;
            }
            set
            {
                _productoList = value;
            }
        }


        public List<Pago> ObtenerPagos()
        {
            PagoADO p = new PagoADO();

            return p.LeerPagos();
        }

        public bool InsertarPago(Pago p)
        {
            PagoADO pA = new PagoADO();
            bool resultado = pA.InsertarPago(p.Codigo_Cliente, p.Forma_pago, p.Id_Transaccion, p.Fecha_Pago, p.Total);

            return resultado;
        }

        public Pago ActualizarPago(Pago p)
        {
            PagoADO pA = new PagoADO();
            Pago resultado = pA.ActualizarPago(p);

            return resultado;
        }

        public List<Pedido> ListarPedidos(int codigoCliente)
        {
            PedidosADO pedidos = new PedidosADO();
            List<Pedido> pedidoPorCodigoCliente = new List<Pedido>();


            _pedidoList =  pedidos.PedidosCliente();
            
            foreach (Pedido lista in _pedidoList)
            {
                if(codigoCliente == lista.Codigo_Cliente)
                {
                    pedidoPorCodigoCliente.Add(lista);
                }
            }

            return pedidoPorCodigoCliente;
        }

        public string ListarPedido(int codigoPedido)
        {
            PedidosADO pedidos = new PedidosADO();

            return pedidos.BuscarPedido(codigoPedido);
        }

        public List<Producto> ListarProductos(int codigoPedido)
        {
            DetallePedidoADO detallePedido = new DetallePedidoADO();
            ProductosADO producto = new ProductosADO();

            List<Detalle_pedido> detallePedidoList = new List<Detalle_pedido>();
            detallePedidoList = detallePedido.ListarDetallePedido(codigoPedido);

            foreach(Detalle_pedido lista in detallePedidoList)
            {
                _productoList.Add(producto.ListarDetallePedido(lista.Codigo_producto));
            }

            return _productoList;
        }

        public List<Pedido> Listar()
        {
            PedidosADO pedidos = new PedidosADO();

            _pedidoList = pedidos.PedidosCliente();

            return _pedidoList;
        }
    }
}
