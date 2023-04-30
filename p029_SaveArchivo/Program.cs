using System;
namespace HelloWorld
{
    class Hello
    {
        static void Main(string[] args)
        {
            SaveToFile obj1 = new SaveToFile();
            // obj1.Save("test");
            // obj1.Save("Randy");
             obj1.Save("Sofi");
             obj1.Save("Obi");
            //obj1.DeleteFile();
            //obj1.moveFile();
            obj1.showDate();
            obj1.showTime();
        }
    }
}