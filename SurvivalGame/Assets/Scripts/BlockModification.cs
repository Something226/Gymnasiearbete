using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class BlockModification : MonoBehaviour
{

    [SerializeField] private Tilemap Tilemap_Foreground;
    [SerializeField] private Tile DirtBlock;



    // Update is called once per frame
    void Update()
    {
        //when left click is pressed, remove tile at mouse position
        if (Input.GetMouseButtonDown(0))
        {
            // Debug.Log("pressed");
            Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            // Debug.Log(mouseWorldPos);
            Vector3Int coordinate = Tilemap_Foreground.WorldToCell(mouseWorldPos);
            // Debug.Log(coordinate);
            Tilemap_Foreground.SetTile(coordinate, null);



        }
        //when right click is pressed, place tile at mouse position
        if (Input.GetMouseButtonDown(1))
        {
            // Debug.Log("pressed");
            Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            // Debug.Log(mouseWorldPos);
            Vector3Int coordinate = Tilemap_Foreground.WorldToCell(mouseWorldPos);
            // Debug.Log(coordinate);
            Tilemap_Foreground.SetTile(coordinate, DirtBlock);
        }
    }
}
