using System;
namespace HelloWorld 
{ 
    class Pedido
    { 
        private int _items;


       public void AddItem(){
        _items  +=1;
       }
       public void RemoveItem(){
        _items  -=1;
       }
       public int checkItems(){
        return _items; 
              }
    }
}