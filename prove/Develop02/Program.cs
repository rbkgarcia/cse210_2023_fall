using System;
using System.IO; 
class Program
{
    static void Main(string[] args)
    {
        var journal = new Journal(); //instance of the journal class
        journal.Menu(); //menu method instance to start interaction with the journal program
    }
}