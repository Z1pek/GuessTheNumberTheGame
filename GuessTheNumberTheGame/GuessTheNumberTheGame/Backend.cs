using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace GuessTheNumberTheGame
{
    public class Backend
    {
        public int lifesleft = 3;
        public int generated;
        public int input;
        public int state;
        public Backend()
        {
            GenerateNumber();
        }
        public int GenerateNumber()
        {  
            generated = new Random().Next(1, 10);
            return generated;
        }
        public int GetInputFromUser()
        {
            // Attempt to parse the user input, and some error handling.
            bool isValid = int.TryParse(Console.ReadLine(), out input);

            if (!isValid)
            {
                Console.WriteLine(" Invalid input. Please enter a valid number.");
                return GetInputFromUser();  // Retry if input is invalid
            }
            lifesleft--;

            WinState();
            
            return state;
        }
       public void WinState()
       {
        if (input > generated)
        {
            state = 1;
        }
        else if (input < generated)
        {
            state = -1;
        }
        else
        {
            state = 0;
        }
       }
       
    }
}
