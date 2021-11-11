using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private Inventory playerInventory;

    public Player()
    {
        playerInventory = new Inventory();
    }

}
