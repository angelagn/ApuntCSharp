using System;
namespace HelloWorld
{
    class SaveToFile
    {
        public void Save(string stringTemp)
        {
            //Usar el try cuando se trabaja con archivos
            try
            {
                System.Console.WriteLine("Hola " + stringTemp);

                //StreamWriter estructura1 = File.CreateText("SaveToFile.ext");
                //usar archivo como base de datos
                StreamWriter estructura1 = File.AppendText("SaveToFile.txt");
                estructura1.WriteLine(stringTemp);
                estructura1.Close();
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Error actual: {0}", ex.Message);//dice el nombre del error
            }
            finally
            { //Siempre poner, indica que termina el try, se ejecuta siempre
                System.Console.WriteLine("treminado el proceso try...");
            }
        }

        public void readFile()
        {
            try
            {
                StreamReader lectura = File.OpenText("SaveToFile.txt");
                string linea = lectura.ReadLine();
                while (linea != null){
                    System.Console.WriteLine(linea);
                    linea = lectura.ReadLine();
                }
                lectura.Close();
            }catch{
                System.Console.WriteLine("Error al leer");
            }
        }
        public void DeleteFile(){
            //Pregintar si el archivo existe
           if( File.Exists("SaveToFile.ext"))
                //Borrar archivo
                File.Delete("SaveToFile.ext");
        }
        public void copyFile(){
            File.Copy("SaveToFile.txt", "CopiaSeguridad/SaveToFile.txt");
        }
        public void moveFile(){
            //Al mover el archivo tambuien se le puede cambiar el nombre
            File.Move("SaveToFile.txt", "CopiaSeguridad/uno.txt");
        }

        public void showDate(){
            DateTime now = DateTime.Now;
            System.Console.WriteLine("La fecha actual es: " + now);

        }
        public void showTime(){
            //dar formato paara mostrar solo la hora
           string time = DateTime.Now.ToString("h:mm:ss tt");
            System.Console.WriteLine("Hora: " + time);

        }
        /*FOrmatos de fecha y hora

        https://www.c-sharpcorner.com/blogs/date-and-time-format-in-c-sharp-programming1

        
        DateTime.Now.ToString("MM/dd/yyyy")	05/29/2015
    DateTime.Now.ToString("dddd, dd MMMM yyyy")	Friday, 29 May 2015
    DateTime.Now.ToString("dddd, dd MMMM yyyy")	Friday, 29 May 2015 05:50
    DateTime.Now.ToString("dddd, dd MMMM yyyy")	Friday, 29 May 2015 05:50 AM
    DateTime.Now.ToString("dddd, dd MMMM yyyy")	Friday, 29 May 2015 5:50
    DateTime.Now.ToString("dddd, dd MMMM yyyy")	Friday, 29 May 2015 5:50 AM
    DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss")	Friday, 29 May 2015 05:50:06
    DateTime.Now.ToString("  */

    }
}