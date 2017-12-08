using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player {
    private string myName;
    private Inventory myInventory;
    private Stats myStats;
    private Money myMoney;

    public Player(string name, Stats stats, Money money, Inventory inventory) {
        this.myName = name;
        this.myStats = stats;
        this.myMoney = money;
        this.myInventory = inventory;
    }

    public Stats getMyStats(){
        return myStats;
    }

    public void setMyStats(Stats stats) {
        this.myStats = stats;
    }

    public Inventory getMyInventory(){
        return myInventory;
    }

    public void setMyInventory(Inventory inventory){
        this.myInventory = inventory;
    }

    public Money getMyMoney(){
        return myMoney;
    }

    public void setMyMoney(Money money){
        this.myMoney = money;
    }
}
