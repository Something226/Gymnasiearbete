
using System;
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

    [SerializeField] private bool useNumberKeys = true;

    private static int currentBlock = 1;

    // Update is called once per frame
    void Update()
    {

        if (useNumberKeys)
        {

            if (Input.GetKey("1"))
            {
                currentTile = stone;

            }

            else if (Input.GetKey("2"))
            {
                currentTile = dirtBlock;

            }

            else if (Input.GetKey("3"))
            {
                currentTile = wood;

            }

            else if (Input.GetKey("4"))
            {
                currentTile = sand;

            }

            else if (Input.GetKey("5"))
            {
                currentTile = leaves;

            }
        }
        else
        {
            if (Input.mouseScrollDelta.y == 1)
            {
                currentBlock++;

            }
            else if (Input.mouseScrollDelta.y == -1)
            {
                currentBlock--;

            }
            if (currentBlock >= 6)
            {
                currentBlock = 5;
            }
            if (currentBlock <= 0)
            {
                currentBlock = 1;
            }

            if (currentBlock == 1)
            {
                currentTile = stone;
            }

            else if (currentBlock == 2)
            {
                currentTile = dirtBlock;
            }

            else if (currentBlock == 3)
            {
                currentTile = wood;
            }

            else if (currentBlock == 4)
            {
                currentTile = sand;
            }

            else if (currentBlock == 5)
            {
                currentTile = leaves;
            }


            Debug.Log(currentBlock);
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
