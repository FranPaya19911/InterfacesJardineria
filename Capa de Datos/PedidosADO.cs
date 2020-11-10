using Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
// Para contactar con la WEB API
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;

namespace Capa_Datos
{
    public class PedidosADO: ADO
    {
        public List<Pedido> PedidosCliente()
        {
            List<Pedido> ListarPedidos = new List<Pedido>();
            string aux;

            try
            {
                HttpResponseMessage response = client.GetAsync("api/pedidos/").Result;
                if (response.IsSuccessStatusCode)
                {
                    aux = response.Content.ReadAsStringAsync().Result;

                    ListarPedidos = JsonConvert.DeserializeObject<List<Pedido>>(aux);
                }
            }
            catch (Exception e)
            {
                throw new ExternalException("Error:" + e);
            }

            return ListarPedidos;
        }

        public string BuscarPedido(int id)
        {
            Pedido pedido = new Pedido();
            string resultado="Error no encontrado";
            string aux;

            try
            {
                HttpResponseMessage response = client.GetAsync("api/pedidos/" + id).Result;
                if (response.IsSuccessStatusCode)
                {
                    aux = response.Content.ReadAsStringAsync().Result;

                    pedido = JsonConvert.DeserializeObject<Pedido>(aux);
                    resultado = pedido.ToString();
                }
            }
            catch (Exception e)
            {
                throw new ExternalException("Error:" + e);
            }

            return resultado;
        }
    }
}
