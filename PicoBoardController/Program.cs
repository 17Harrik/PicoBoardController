﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PicoBoardController
{
    class Program
    { 
        static void Main(string[] args)
        {
            PicoBoard p = new PicoBoard();
            p.Connect();
           
            bool running = true;
            while(running)
            {
                int button = p.ReadSensor(PicoBoard.Sensor.BUTTON);
                Console.WriteLine($"Button: {button}");

                if (Console.ReadLine() == "quit")
                {
                    running = false;
                }
            }
            
            p.Disconnect();
        }
    }
}
