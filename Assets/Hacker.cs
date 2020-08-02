using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour{

    int level;
    enum Screen {MainMenu, PassWord, Win};

    Screen currentScreen;
    
    void Start()  {
        ShowLines();
    }


    void ShowLines () {
        Terminal.ClearScreen();
    
        Terminal.WriteLine("What would you like to hack into?\n");
        Terminal.WriteLine("Press 1 for the Benelux Bureau of \n Intellectual Property");
        Terminal.WriteLine("Press 2 for the police station");
        Terminal.WriteLine("Press 3 for the AIVD \n");
        Terminal.WriteLine("Enter your selection:");
    }

    void OnUserInput(string input) {
        if (input == "menu") {
            ShowLines();
        } else if (input == "1" || input == "2" || input == "3") {
            level = int.Parse(input);
            StartGame();
        } else {
            Terminal.WriteLine("Invalid input");
        }
    }

    void StartGame () {
        Terminal.WriteLine("You chose level " + level);
        Terminal.WriteLine("Please enter your password:");
    }

}
