﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{

    public class Tree<T> where T : IComparable
    {
        public T Nodedata { get; set; }
        public Tree<T> LeftTree { get; set; }
        public Tree<T> RightTree { get; set; }
        public Tree(T Nodedata)
        {
            this.Nodedata = Nodedata;
            this.LeftTree = null;
            this.RightTree = null;
        }
        public void Insert(T Value)
        {
            T Root = this.Nodedata;
            if (Root.CompareTo(Value) > 0)
            {
                if (this.LeftTree == null)
                {
                    this.LeftTree = new Tree<T>(Value);
                }
                else
                {
                    this.LeftTree.Insert(Value);
                }
            }
            else
            {
                if (this.RightTree == null)
                {
                    this.RightTree = new Tree<T>(Value);
                }
                else
                {
                    this.RightTree.Insert(Value);
                }
            }
        }
        public void Display()
        {
            if (this.LeftTree != null)
            {
                this.LeftTree.Display();
            }
            Console.WriteLine(this.Nodedata.ToString());
            if (this.RightTree != null)
            {
                this.RightTree.Display();
            }
        }
    }
}
