using System;
namespace HelloWorld 
{ 
    class Cliente 
    { 
       private Pedido _Orden;

        /*Constructor que asigna un objeto */
       public Cliente(){ //Cliente llama por si solo a una nueva orden
        _Orden = new Pedido();
       } 

        //Constructor
        public Cliente(Pedido pedido){
            _Orden = pedido;
        }
        
        //El set siemrpe lleva void
        public void setOrden(Pedido pedido){
            _Orden = pedido;
        }

        public void AddItemPedido(){
            _Orden.AddItem(); //añade elemento a la orden
        }

        public int checkItems(){
            return _Orden.checkItems();
        }

    }
}