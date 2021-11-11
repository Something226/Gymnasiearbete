using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class BlockModification : MonoBehaviour
{
    private Tilemap Tilemap;

    // Update is called once per frame
    void Update()
    {
        //when left click is pressed 
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3Int coordinate = Tilemap.WorldToCell(mouseWorldPos);
            Tilemap.SetTile(coordinate, null);
        }
        //when right click is pressed
        /*        if (Input.GetMouseButtonDown(1))
                {
                    Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                    Vector3Int coordinate = Tilemap.WorldToCell(mouseWorldPos);
                    Tilemap.SetTile(coordinate, DirtBlock);
                }*/
    }
}
