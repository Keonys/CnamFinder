using System;
using System.Collections;
using System.Collections.Generic;
using RPGM.Gameplay;
using UnityEngine;
using UnityEngine.U2D;

namespace RPGM.Gameplay
{
    /// <summary>
    /// Create all the InventoryItem
    /// </summary>
    public class ItemFactory : MonoBehaviour
    {
        public InventoryItem createItems(string typeItem)
        {
            switch(typeItem)
            {
                case "Chicken":
                    return new Chicken();
                case "Chest":
                    return new Chest();
                case "Cactus":
                    return new Cactus();
                case "Flower":
                    return new Flower();
                case "MailBox":
                    return new MailBox();
                case "Pot":
                    return new Pot();
                case "Trunk":
                    return new Trunk();
                case "GoldenApple":
                    return new GoldenApple();
                default:
                    return null;
            }
        }
    }
}