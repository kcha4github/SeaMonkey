using System;
using System.Collections.Generic;
using System.Text;

namespace SeaMonkey.Lexer
{
    public class Lexer
    {
        string input;
        int position;
        int readPosition;
        char ch;

        public Lexer(string input)
        {
            this.input = input;
            this.ReadChar();
        }

        public void ReadChar()
        {
            if(this.input.Length <= this.readPosition)
            {
                this.ch = '\0';
            }
            else
            {
                this.ch = this.input[this.readPosition];
            }

            this.position = this.readPosition;
            this.readPosition++;
        }



    }
}
