using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button_ : MonoBehaviour
{
    // Start is called before the first frame update
    bool isClicked = false;
    


 
    void OnGUI()
    {
        if (!isClicked)
        {
            if (GUI.Button(new Rect(10, 10, 150, 100), "START"))
            {
                isClicked = true;
            }
        }
        else
        {
            GUI.Label(new Rect(10, 10, 100, 20), "Hello");
        }
    }



}
