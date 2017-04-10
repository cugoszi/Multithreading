﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarciniakRatajczak
{
    class SplitAgent : Agent
    {
        int ID;
        static readonly List<string[]> Strings = new List<string[]>();
        public static List<string[]> _Strings { get { return Strings; } }
        char delimiter= ' ';
        public static int textLength;
        

        public SplitAgent()
        {
            ID = ++id;
            try
            {
                using (StreamReader sr = new StreamReader("TestFile.txt"))
                {
                    string Text = sr.ReadToEnd();
                    Strings.Add(Text.Split(delimiter));

                }
            }
            catch { Console.WriteLine("Error, Can't load file"); }


        }
        public override void Update()
        {
            textLength = Strings.Count;
            HasFinished = true;
        }
    }
}
