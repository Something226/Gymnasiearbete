
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class BlockModification : MonoBehaviour
{
    [SerializeField] private Tilemap tilemap_Foreground;
    [SerializeField] private Tile stone, dirtBlock, wood, sand, leaves;

    [SerializeField] private Tile currentTile;


    // Update is called once per frame
    void Update()
    {

        if (Input.GetButton("1"))
        {
            currentTile = stone;
        }

        else if (Input.GetButton("2"))
        {
            currentTile = dirtBlock;
        }
        //when left click is pressed, remove tile at mouse position
        if (Input.GetMouseButtonDown(0))
        {
            // Debug.Log("pressed");
            Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3Int coordinate = tilemap_Foreground.WorldToCell(mouseWorldPos);
            tilemap_Foreground.SetTile(coordinate, null);



        }
        //when right click is pressed, place tile at mouse position
        if (Input.GetMouseButtonDown(1))
        {

            Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3Int coordinate = tilemap_Foreground.WorldToCell(mouseWorldPos);
            if (tilemap_Foreground.GetTile(coordinate) == null)
            {
                tilemap_Foreground.SetTile(coordinate, currentTile);
            }
        }
    }
}
