﻿using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Engine.Factories
{
    internal static class ItemFactory
    {
        private static List<GameItem> _standardGameItems;

        static ItemFactory()
        {
            _standardGameItems = new List<GameItem>();

            _standardGameItems.Add(new Weapon(1001, "Pointy Stick", 1, 1, 2));
            _standardGameItems.Add(new Weapon(1002, "Rusty Sword", 5, 1, 3));
            _standardGameItems.Add(new GameItem(9001, "Snake fang", 1));
            _standardGameItems.Add(new GameItem(9002, "Snakeskin", 2));
            _standardGameItems.Add(new GameItem(9003, "Rat tail", 1));
            _standardGameItems.Add(new GameItem(9004, "Rat fur", 2));
            _standardGameItems.Add(new GameItem(9005, "Spider fang", 1));
            _standardGameItems.Add(new GameItem(9006, "Spider silk", 2));
        }

        internal static GameItem CreateGameItem(int itemTypeId)
        {
            var gameItem = _standardGameItems.FirstOrDefault(i => i.ItemTypeId == itemTypeId);

            // TODO: refactor this via polymorphism
            if(gameItem != null )
            {
                if(gameItem is Weapon)
                {
                    return (gameItem as Weapon).DeepClone();
                }

                return gameItem.DeepClone();
            }

            return null;
        }
    }
}
