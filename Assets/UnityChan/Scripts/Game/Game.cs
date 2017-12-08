using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour {

    public int attack;
    public int defense;
    public int hp;
    public int fireRate;
    public int speed;
	// Use this for initialization
	void Start () {
        Player pj = new Player("Mam", new Stats(attack, defense, hp, fireRate, speed), new Money(), firstInventory());
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxis("Fire") != 0 && AimBehaviourBasic.isAim())
        {
            Debug.Log("Fire");
        }
	}

    Inventory firstInventory()
    {
        Gun g = new Gun("Pistola", new Stats(10, 0, 0, 2, 0), 1, 30, 90);
        g.setEquipped(true);
        
        Inventory inv = new Inventory();
        inv.addItem(g);
        return inv;
    }
}
