using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pair_Programming_Console_Game
{
    public class User
    {
        public void Player()
        {
            Lives = 6;
            Wins = 0;

        }

        public int Lives { get; set; }
        public int Wins { get; set; }
    }


    //^player.cs reference (Amanda)
    //below is following erick

    public class Player
    {
        public string Name { get; set; }
        public int Lives { get; set; }
        public int Wins { get; set; }

        //below is an empty constructor (only needed to be done when overloading a constructor)
        public Player()
        {

        }




        public Player()
        {


        }


    }
}
        //1.Start game?
        //2. Ready for next round?
        //3. Take in char from user(alternating)
        //4. if user selects they would like to guess(true), use (3), if false, run (2)
        //Exit Game



//**Ask user what difficulty/Category
//**best of three, five
//Then console write line ready(a bool and yes = true) if true, start game
//call on repo method(field with list) to randomly select string and display # of chars and spaces in string
//user 1 char input
//return char to a foreach loop, and run each char in string, return blanks of valid chars in string, if null then -1 life of user that entered char
//if user inputs invalid char, then c.w(I'm sorry, please enter a valid letter)
//if successful char is detected, then ask user if they would like to solve.
//      if yes, ask user for input
//         if guess is correct, c.w. Congratulations! You have won this round
        //if no, prompt other user to enter a valid char
//going to need _repoList of lives during game, then another list? tallying best of three (if wins <=2, continue next game.)
                                                                        //if wins = 2 c.w. to that user Congrats! You are the winner
                                                                        //c.w. to other user You lost.
//press any key to continue(console readline);
//Would you like to play again?(yes = true) if true, go back to 1 command (start game)
    //if false, exit
        //c.w. "Thanks for playing. See you soon!
