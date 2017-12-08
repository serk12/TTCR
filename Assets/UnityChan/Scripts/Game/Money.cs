using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money {
    private string name;
    private int money;

    public Money() {
        this.name = "Bitcoin(s)";
        this.money = 0;
    }

    public int getMoney() {
        return money;
    }

    public void setMoney(int money) {
        this.money = money;
    }
}