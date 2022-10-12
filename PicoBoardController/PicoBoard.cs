using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PicoBoardController
{
    class PicoBoard
    {
        // source: https://twiki.cern.ch/twiki/pub/Sandbox/DaqSchoolExercise14/Picoboard_protocol.pdf

        public enum Sensor
        {
            RESISTANCE_D = 0,
            RESISTANCE_C = 1,
            RESISTANCE_B = 2,
            BUTTON = 3,
            RESISTANCE_A = 4,
            LIGHT = 5,
            SOUND = 6,
            SLIDER = 7
        }

        private int[] sensorValues = new int[8];

        public void Connect(portName)
        {
            // show all port names
            /*foreach (string portName in SerialPort.GetPortNames())
            {
                Console.WriteLine(portName);
            }*/
           
        }

        public void Disconnect()
        {

        }

        public int ReadSensor(Sensor SensorNumber)
        {
            return sensorValues[(int)SensorNumber];
        }

        public bool isConnected;

    }

}
