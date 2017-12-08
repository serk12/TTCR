using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats {
    private Hashtable stats = new Hashtable() {
        { "Ataque", 0f },
        { "Defensa", 0f },
        { "Vida", 0f },
        { "Cadencia", 0f },
        { "VelMov", 0f }
    };

    public object getStat(string Key){
        return stats[Key];
    }

    public void setStat(string Key, int Value){
        stats[Key] = Value;
    }    
}
