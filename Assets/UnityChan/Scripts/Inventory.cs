using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory {
    private List<Item> inventory = new List<Item>();

    public void addItem(Item item){
        inventory.Add(item);
    }

    public bool isInInventory(Item item){
        return inventory.Contains(item);
    }

    public void removeItem(Item item){
        inventory.Remove(item);
    }
}
