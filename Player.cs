using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pair_Programming_Console
{
    public enum DifficultyOne
    {
        Documentaries = 1,

    }

    public enum DifficultyTwo
    {

    }

    public enum DifficultyThree
    {


    }
    public class PlayerRepo
    {
        public difficultyOne GetRandomWord(string word)
        {
            //if user input = 1 {

            //return (difficultyOne) 
        }

        public char[] RandomWordToChars()
        {

        }

        public char[] DisplayHiddenChars()
        {

        }

        public char GetUserInputChar(char guess)
        {

        }

        public void CheckUserInput()
        {

        }

        public char DisplayCorrectCharGuessed()
        {

        }

        public bool AskUserToGuessWord(bool guessWord)
        {

        }


    }
}


//method to select word - create list of strings(words or phrases)
//method to separate word(s) into chars - char[] word = new char[word.length] or maybe word.ToCharArray
//method to display correct number of dashes for word (for loop?) - for int i = 0; i < word.length; i++ { word[i] = "_"; 
// cw(word[i] + " ")???????
//method to check user input against selected word (also if input is a valid char) //(change input to ToLower or ToUpper??)
//set initial guess count = 0 -- run loop while guess count <= 6
//if char[] contains input - display char in correct spot
//method to check if user wants to guess word
//method to check if guess is correct
//method to alternate turns
//method to alert users if draw and display "word"
//*** method to alternate difficulties (time permitting)