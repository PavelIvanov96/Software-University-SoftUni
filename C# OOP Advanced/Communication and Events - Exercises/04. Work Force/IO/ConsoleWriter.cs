﻿namespace _04.Work_Force.IO
{
    using System;
    using Interfaces;

    public class ConsoleWriter : IWriter
    {
        public void WriteLine(string line) => Console.WriteLine(line);
    }
}
