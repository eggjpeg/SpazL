﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpazL
{
    class ExpNode
    {
        public List<ExpNode> ChildList = null;
        public void AddChild(ExpNode n)
        {
            if (ChildList == null)
                ChildList = new List<ExpNode>();
            ChildList.Add(n);
        }

        public bool IsFunction { get; set; }
        public bool IsListIndex { get; set; }

        public Token Token;

        public string ListName
        {   
            get
            {
                if (Token.Type == TokenType.VarName)
                    return Token.Value;
                else
                    throw new Exception("Not a list name, spaz.");
            }
        }

        public string FunctionName
        {
            get {
                if (Token.Type == TokenType.Command)
                    return Token.SubType.ToString();
                else if (Token.Type == TokenType.VarName)
                    return Token.Value;
                else
                    throw new Exception("Not a function, spaz.");
            }
        }


        public object Value = null; //Used for Interpreter
        public bool IsInterpreted()
        {
            if (Value == null)
                return false;
            else
                return true;
        }


        public ExpNode(OpType op)
        {
            this.Token = new Token(TokenType.Op, op);
        }


        public ExpNode(Token t)
        {
            this.Token = t;

            if (t.Type == TokenType.Const || t.Type == TokenType.VarName)
                Value = t.Value;
        }

        public bool IsLeaf()
        {
            if (ChildList == null)
                return true;
            else
                return false;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            ToStr(sb, "", false);
            return sb.ToString();
        }

        public void ToStr(StringBuilder sb, string indent, bool last)
        {
            sb.Append(indent);
            if (last)
            {
                sb.Append("\\-");
                indent += "  ";
            }
            else
            {
                sb.Append("|-");
                indent += "| ";
            }

            if(IsFunction)
                sb.AppendLine("func " + Token.Value);
            else
                sb.AppendLine(Token.ToString());

            if (ChildList == null)
                return;

            for (int i = 0; i < ChildList.Count; i++)
                ChildList[i].ToStr(sb,indent, i == ChildList.Count - 1);
        }
    }
}
