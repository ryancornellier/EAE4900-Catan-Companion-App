using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trading : MonoBehaviour
{
    public Text merchantText;
    public int merchantAmount;
    public int playerAmount;
    private int merchantResource;
    private int playerResource;
    public string merchantString;
    public string playerString;

    // Start is called before the first frame update
    void Start()
    {
        madLib();
        merchantText.text = "A wandering merchant has come to town. They are offering you " + merchantAmount.ToString() + merchantString + "for " + playerAmount.ToString() + playerString;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void madLib()
    {
        var p = Random.Range(1, 3);
        var m = Random.Range(1, 3);
        playerAmount = p;
        merchantAmount = m;

        var pp = Random.Range(0, 3);
        var mm = Random.Range(0, 4);

        if(pp == mm)
        {
            pp = 4;
        }

        //player resource assignment
        if(pp == 0)
        {
            playerString = " wheat.";
        }
        else if(pp == 1)
        {
            playerString = " stone.";
        }
        else if(pp == 2)
        {
            playerString = " brick.";
        }
        else if(pp == 3)
        {
            playerString = " sheep.";
        }
        else if(pp == 4)
        {
            playerString = " wood.";
        }

        //merchant resource assignment
        if (mm == 0)
        {
            merchantString = " wheat ";
        }
        else if (mm == 1)
        {
            merchantString = " stone ";
        }
        else if (mm == 2)
        {
            merchantString = " brick ";
        }
        else if (mm == 3)
        {
            merchantString = " sheep ";
        }
        else if (mm == 4)
        {
            merchantString = " wood ";
        }
    }
}
