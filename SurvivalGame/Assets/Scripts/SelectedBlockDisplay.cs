using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectedBlockDisplay : MonoBehaviour
{
    private int selected;
    [SerializeField] private bool useNumberKeys = true;
    public Text selectedText;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        selectedText.text = "Currently Selected: " + selected;

        if (useNumberKeys)
        {

            if (Input.GetKey("1"))
            {
                selected = 1;
            }

            else if (Input.GetKey("2"))
            {
                selected = 2;
            }

            else if (Input.GetKey("3"))
            {
                selected = 3;
            }

            else if (Input.GetKey("4"))
            {
                selected = 4;
            }

            else if (Input.GetKey("5"))
            {
                selected = 5;
            }

            
        }
        else
        {
            if (Input.mouseScrollDelta.y == 1)
            {
                selected++;

            }
            else if (Input.mouseScrollDelta.y == -1)
            {
                selected--;

            }
            if (selected >= 6)
            {
                selected = 5;
            }
            if (selected <= 0)
            {
                selected = 1;
            }
        }
    }
}
