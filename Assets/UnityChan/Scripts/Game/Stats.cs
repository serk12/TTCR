using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats {
    private Hashtable stats;

    public Stats()
    {
        stats = new Hashtable() {
            { "Ataque", 0 },
            { "Defensa", 0 },
            { "Vida", 0 },
            { "Cadencia", 0 },
            { "VelMov", 0 }
        };
    }
    public Stats(int attack, int defense, int hp, int fireRate, int speed)
    {
        stats = new Hashtable()
        {
            { "Ataque", attack },
            { "Defensa", defense },
            { "Vida", hp },
            { "Cadencia", fireRate },
            { "VelMov", speed }
        };
    }

    public object getStat(string Key){
        return stats[Key];
    }

    public void setStat(string Key, int Value){
        stats[Key] = Value;
    }    
}
