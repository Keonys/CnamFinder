using System;
using System.Collections;
using System.Collections.Generic;
using RPGM.Gameplay;
using UnityEngine;
using UnityEngine.U2D;

namespace RPGM.Gameplay
{
    /// <summary>
    /// This class gives logs directly in the console
    /// </summary>
    public class ConsoleLogger : AbstractLogger
    {
        public new void setNextLogger()
        {
            //Chercher le prochain log à afficher
        }

        public new void logMessage()
        {
            Console.WriteLine("Message Console");
            Console.ReadLine();
        }

        public bool isInError()
        {
            return false;
        }
    }
}