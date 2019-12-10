using System;
using System.Collections;
using System.Collections.Generic;
using RPGM.Gameplay;
using UnityEngine;
using UnityEngine.U2D;

namespace RPGM.Gameplay
{
    /// <summary>
    /// An abstract class for console log and error log
    /// </summary>
    public class AbstractLogger : CharacterController2D
    {
        public bool inError;
        public AbstractLogger nextLogger;


        public void setNextLogger()
        {
            //Chercher le prochain log à afficher
        }

        public void logMessage() { }

        public bool isInError()
        {
            //Vérifier si l'on souhaite afficher un simple message console, ou un message d'erreur

            return inError;
        }
    }
}