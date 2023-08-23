using Proyecto_SISVIANZA_v1.Persistencia;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Proyecto_SISVIANZA_v1.Logica
{
    class GestorPedidos
    {
        private PedidosPersistencia pedidoPersistencia;

        public GestorPedidos()
        {
            this.pedidoPersistencia = new PedidosPersistencia();
        }

        public void AgregarPedido(Pedido pedido)
        {
            pedidoPersistencia.GuardarPedido(pedido);
        }

        public List<Pedido> ObtenerPedidoPorId(int idPedido)
        {
            return pedidoPersistencia.ObtenerPedidoPorId(idPedido);
        }
        public List<Pedido> ObtenerTodosLosPedidos()
        {
            return pedidoPersistencia.ObtenerTodosLosPedidos();
        }


        public bool ExisteIDPedido(int idPedido)
        {
            return pedidoPersistencia.ExisteIDPedido(idPedido);
        }
    }
}
