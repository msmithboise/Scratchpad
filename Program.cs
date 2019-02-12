using System;
using System.Linq;
using System.Text;
using Colors;
using CSD;
using System.Collections.Generic;
using System.Collections;
using DictionaryDemo;

namespace Practice
{


    class Program
{
  static void Main (string[] args)
  {

    

    // Dictionary<string, string> capitals = new Dictionary<string, string>();

    // capitals.Add("Alabama", "Montgomery");
    // capitals.Add("Alaska", "Juneau");
    // capitals.Add("Arizona", "Pheonix");
    // capitals.Add("Massachusetts", "Boston");
    // capitals.Add("Wyoming", "Cheyenne");

    //                                 // rather than passing in an integer, I put in the key, to find it's value.
    // string capitalOfMass = capitals["Massachusetts"];
    // System.Console.WriteLine("The capital of Massachusetts is {0}", capitalOfMass);

                        // GetStates returns a Dictionary, where the key is string and the value is a state

                        // because we used var, the compiler will determine the correct data type for theStates... which is a dictionary.
    var theStates = State.GetStates();

    // we can retreive one of our states by using the index as the key

    //string capitalOfAlaska = theStates["Alaska"].Capital;
    var theState = theStates["Alaska"];
    System.Console.WriteLine("The capital of Alaska is {0}, it's population is {1} and it is {2} square miles", theState.Capital, theState.Population, theState.Size);

    // i could instead of retreiving the string, retreive the state and then use that state to populate the writeline with the pop and size













  
  }
}
}









    
            





            

            








           

           
       
