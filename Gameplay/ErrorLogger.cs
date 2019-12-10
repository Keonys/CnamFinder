using System;
using System.Collections;
using System.Collections.Generic;
using RPGM.Gameplay;
using UnityEngine;
using UnityEngine.U2D;

namespace RPGM.Gameplay
{
    /// <summary>
    /// This class gives error messages
    /// </summary>
    public class ErrorLogger : AbstractLogger
    {
        public new void setNextLogger()
        {
            //Chercher le prochain log à afficher
        }

        public new void logMessage()
        {
            Console.WriteLine("ERREUR");
            Console.ReadLine();
        }

        public new bool isInError()
        {
            return false;
        }
    }
}