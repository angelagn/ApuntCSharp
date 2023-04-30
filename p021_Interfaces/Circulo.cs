using System;
namespace HelloWorld 
{ 
    public interface IFigura5{
        void CalculaAreaFigura();
        void CalculaAreaFigura(int b, int altura);
    }
    class Circulo :IFigura5
    { 
        int radio;
        public Circulo(int radio){
            this.radio = radio;
        }

        public void CalcularAreaFigura(){
            System.Console.WriteLine("el area del circulo  es");
            System.Console.WriteLine(Math.PI* (radio* radio));
        }

        public void CalculaAreaFigura()
        {
            throw new NotImplementedException();
        }

        public void CalculaAreaFigura(int b, int altura)
        {
            throw new NotImplementedException();
        }
    }
}