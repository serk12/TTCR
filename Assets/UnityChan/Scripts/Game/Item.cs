using System;

public class Item { 

    protected Stats stats;
    protected string name;
    protected bool equipped;
    protected int quantity;

    public Item(string name, Stats stats, int quantity){
        this.name = name;
        this.stats = stats;
        this.equipped = false;
        this.quantity = quantity;
    }

    public bool isEquipped(){
        return equipped;
    }

    public string getName()
    {
        return this.name;
    }

    public void setEquipped(bool equip){
        this.equipped = equip;
    }

    public int getQuantity(){
        return quantity;
    }

    public void setQuantity(int quantity){
        this.quantity = quantity;
    }

}
