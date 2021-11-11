using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{

    public enum ItemType
    {

        Tool,
        Weapon,
        Material,
        Consumeable,

    }

    public ItemType itemType;
    public int amount;

}
