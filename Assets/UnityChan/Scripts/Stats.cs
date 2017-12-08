using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats {
    private Hashtable stats = new Hashtable() {
        { "Ataque", 0 },
        { "Defensa", 0 },
        { "Vida", 0 },
        { "Cadencia", 0 },
        { "VelMov", 0 }
    };

    public object getStat(string Key){
        return stats[Key];
    }

    public void setStat(string Key, int Value){
        stats[Key] = Value;
    }    
}
