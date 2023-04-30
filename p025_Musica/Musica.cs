using System;
namespace HelloWorld 
{ 
    class Musica 
    { 
        //Variales
        private int _anio;
        public string _estilo;
        private string _grupoMusical;


        public int anio{
            get { return _anio;}
            set { _anio = value;}
        }

        public string estilo{
            get { return _estilo;}
            set { _estilo = value;}
        }

        public string grupoMusical{
            get { return _grupoMusical;}
            set { _grupoMusical = value;}
        }

        //Constructor
        public Musica(int panio, string pestilo, string pgrupoMusical){
            anio = panio;
            estilo = pestilo;
            grupoMusical = pgrupoMusical;
        }




    //Constructor
        // public Musica(int anio, string estilo, string grupoMusical){
        //     this._anio = anio;
        //     this.estilo = estilo;
        //     this._grupoMusical = grupoMusical;
        // }
      

        //Metodos get y set
    //    public int Anio
    //     {
    //         get { return _anio; }
    //         set { _anio = value; }
    //     }
    //     public void ImprimirAnio(){
    //         int imprimeAnio = Anio;
    //         System.Console.WriteLine("Año: " + imprimeAnio);
    //     }
      
        // public String getEstilo()
        // {
        //     return _estilo;
        // }
        //   public void setEstilo(String nombre)
        // {
        //         this._estilo = estilo;
        // }

        // public String getGrupoMusical()
        // {
        //     return _grupoMusical;
        // }
        //   public void setGrupoMusical(String grupoMusical)
        // {
        //         this._grupoMusical = grupoMusical;
        // }
        // public int MostrarAnio(){
        //     return getAnio();
        // }
        // public string MostrarEstilo(){
        //     return getEstilo();
        // }
        // public string MostrarGrupo(){
        //     return getGrupoMusical();
        // }
            
    }
}