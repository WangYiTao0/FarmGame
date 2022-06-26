﻿using System;
using System.Collections.Generic;
using UnityEngine;

namespace FarmGame
{
    public static class EventHandler
    {
        public static event Action<InventoryLocation, List<InventoryItem>> UpdateInventoryUI;

        public static void CallUpdateInventoryUI(InventoryLocation location, List<InventoryItem> itemList)
        {
            UpdateInventoryUI?.Invoke(location,itemList);
        }

        public static event Action<int, Vector3> InstantiateItemInScene;

        public static void CallInstantiateItemInScene(int id, Vector3 pos)
        {
            InstantiateItemInScene?.Invoke(id,pos);
        }
        
        public static event Action<ItemDetails, bool> ItemSelectedEvent;
        public static void CallItemSelectedEvent(ItemDetails itemDetails, bool isSelected)
        {
            ItemSelectedEvent?.Invoke(itemDetails,isSelected);
        }
    }
}