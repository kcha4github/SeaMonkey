using System;
using System.Collections.Generic;
using System.Text;

namespace SeaMonkey.Token
{
    public class Token
    {
        public const string ILLEGAL = "ILLEGAL";
        public const string EOF = "EOF";

        // 識別子
        public const string IDENT = "IDENT";
        public const string INT = "INT";

        // 演算子
        public const string ASSIGN = "=";
        public const string PLUS = "+";
        public const string MINUS = "-";
        public const string BANG = "!";
        public const string ASTERISK = "*";
        public const string SLASH = "/";

        public const string LT = "<";
        public const string GT = ">";

        public const string EQ = "==";
        public const string NOT_EQ = "!=";

        // デリミタ
        public const string COMMA = ",";
        public const string SEMICOLON = ";";

        public const string LPARAM = "(";
        public const string RPARAM = ")";
        public const string LBRACE = "{";
        public const string RBRACE = "}";

        // キーワード
        public const string FUNCTION = "FUNCTION";
        public const string LET = "LET";
        public const string TRUE = "TRUE";
        public const string FALSE = "FALSE";
        public const string IF = "IF";
        public const string ELSE = "ELSE";
        public const string RETURN = "RETURN";

    }
}
