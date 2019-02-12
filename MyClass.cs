using System.Collections.Generic;

namespace Colors{

    public class Pallette
    {
    public void ColorMethod(){
        
    List<string> ColorOptions = new List<string>();

            ColorOptions.Add("Red");
            ColorOptions.Add("White");
            ColorOptions.Add("Blue");

            foreach (var color in ColorOptions)
            {
                System.Console.WriteLine(color);
            }

    }
    }
}