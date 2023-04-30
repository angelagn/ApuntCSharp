using System;
namespace HelloWorld 
{ 
   class Taxi : Vehiculo{
    public int  numLicencia;
        
        
        public int getNumLicencia(){
            return numLicencia;
        }

        public void setNumLicencia(int tempNum){
        numLicencia = tempNum;
        }
    
   }
}