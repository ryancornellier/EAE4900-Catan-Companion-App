﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Init : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("WheatCounter"))
        {
            PlayerPrefs.DeleteKey("WheatCounter");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
