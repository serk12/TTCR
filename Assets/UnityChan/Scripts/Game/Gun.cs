using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : Item {
    private int maxAmmo;
    private int ammo;
    private int currentAmmo;

    public Gun(string name, Stats stats, int quantity, int ammoMax, int ammo) : base(name, stats, quantity) { 
        this.name = name;
        this.stats = stats;
        this.equipped = false;
        this.ammo = ammo;
        this.currentAmmo = ammoMax;
        this.maxAmmo = ammoMax;
        this.quantity = quantity;
    }

    public int getMaxAmmo(){
        return this.maxAmmo;
    }

    public int getAmmo(){
        return this.ammo;
    }

    public int getCurrentAmmo()
    {
        return this.ammo;
    }

    public void setAmmo(int ammo)
    {
        this.ammo = ammo;
    }

    public void setCurrentAmmo(int currentAmmo)
    {
        this.currentAmmo = ammo;
    }

    public void reload()
    {
        this.ammo -= (this.maxAmmo - this.currentAmmo);
        this.currentAmmo = maxAmmo;
    }
}
