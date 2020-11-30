using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using SeaMonkey.Lexer;

namespace SeaMonkey.Repl
{
    public class Repl
    {
        public static void Start(TextReader reader, TextWriter writer)
        {
            while (true)
            {
                var line = reader.ReadLine();
                if (string.IsNullOrEmpty(line))
                {
                    return;
                }

                var l = new Lexer.Lexer(line);

            }

        }
    }
}
