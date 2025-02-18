using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuessTheNumberTheGame;
using static System.Runtime.InteropServices.JavaScript.JSType;
public class Frontend
{

   
    public void DisplayWelcomeScreen()
    {
        Console.WriteLine(" Welcome to the Guess The Number - THE GAME");
        Console.WriteLine(" Try to find the number from 1 to 10 in three tries");
        Console.Write(" Naciśnij ENTER, aby rozpoczać grę ... ");
        Console.ReadLine();
    }
   
    public void GetAnswer()
    {
        Backend backend = new Backend();
       
        while(backend.input != backend.generated && backend.lifesleft > 0) {
        Console.Write("\n You have:" + backend.lifesleft + " lifes left\n");
        Console.Write(" Please input the number: \n"); // backend.generated is the value of the generated number 
        int result = backend.GetInputFromUser();
        DisplayState(result);
        }
        
    }
    public void DisplayState(int result)
    { 
        switch(result)
        {
            case -1:
            Console.WriteLine(" TOO LOW");
            break;

            case 1:
            Console.WriteLine(" TOO MUCH");
            break;
            case 0:
            Console.WriteLine(" YOU WON");
            break;
        }
    }
}
    
    