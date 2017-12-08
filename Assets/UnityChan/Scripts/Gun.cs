using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : Item {
    private int maxAmmo;
    private int ammo;

    public Gun(string name, Stats stats, int quantity, int ammo) : base(name, stats, quantity) { 
        this.name = name;
        this.stats = stats;
        this.equipped = false;
        this.ammo = ammo;
        this.maxAmmo = ammo;
        this.quantity = quantity;
    }

    public int getMaxAmmo(){
        return maxAmmo;
    }

    public int getAmmo(){
        return ammo;
    }

    public void setAmmo(int ammo){
        this.ammo = ammo;
    }
}
