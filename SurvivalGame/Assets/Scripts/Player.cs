using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //variables are decleared 
    private Inventory playerInventory;

    private int hp;

    [SerializeField] private UI_Inventory uiInventory;

    //Constructor
    private void Awake()
    {
        playerInventory = new Inventory();
        uiInventory.SetInventory(playerInventory);

        hp = 100;

    }

    //Update method, updates every frame
    void Update()
    {

        Debug.Log(hp);

    }

    //Method hurts player with amount
    public void HurtPlayer(int amount)
    {

        hp -= amount;

        if (hp < 0)
        {
            hp = 0;
        }

    }
}

