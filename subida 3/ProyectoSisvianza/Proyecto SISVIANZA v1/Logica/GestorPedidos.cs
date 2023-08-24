using Proyecto_SISVIANZA_v1.Persistencia;
using System;
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
                try
                {
                    pedidoPersistencia.GuardarPedido(pedido);
                    Console.WriteLine("¡Pedido registrado en la base de datos exitosamente bien pibe");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al agregar el pedido inservivle : " + ex.Message);
                }
           }








        public bool EliminarPedido(int idpedido)
        {
            return pedidoPersistencia.EliminarPedido(idpedido);
        }



        public void ActualizarPedido(Pedido pedido)
        {
            try
            {
                pedidoPersistencia.ActualizarPedido(pedido);
                Console.WriteLine("Pedido actualizado bien pibe");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar el pedid inservivle:  " + ex.Message);
            }
        }




        public Pedido ObtenerPedidoPorId(int id)
        {
            return pedidoPersistencia.ObtenerPedidoPorId(id);
        }



        public List<Pedido> ObtenerPedidoPorIdTipoLista(int id)
        {
            return pedidoPersistencia.ObtenerPedidoPorIdTipoLista(id);
        }


        public List<Pedido> ObtenerTodosLosPedidos()
        {
            return pedidoPersistencia.ObtenerTodosLosPedidos();
        }


    public bool ExistenPedidos()
{
    List<Pedido> listaPedidos = ObtenerTodosLosPedidos();

    return listaPedidos.Count > 0;
}
    
    }
}
