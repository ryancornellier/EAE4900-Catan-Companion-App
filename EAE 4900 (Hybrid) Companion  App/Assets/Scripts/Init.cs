using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Init : MonoBehaviour
{
    // Start is called before the first frame update
    public void Start_Game()
    {
        if (PlayerPrefs.HasKey("White_WheatCounter"))
        {
            PlayerPrefs.DeleteKey("White_WheatCounter");
        }

        if (PlayerPrefs.HasKey("White_StoneCounter"))
        {
            PlayerPrefs.DeleteKey("White_StoneCounter");
        }
        // Copy & Paste for Remaining 3 Resources 
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
