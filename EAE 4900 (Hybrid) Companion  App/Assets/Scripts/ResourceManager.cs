using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ResourceManager : MonoBehaviour
{
    public Button WheatButtonPlus;
    public Button WheatButtonMinus;
    public static int WheatCounter; 
    public Text WheatText;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("WheatCounter"))
        {
            WheatCounter = PlayerPrefs.GetInt("WheatCounter");
        }
        else
        {
            PlayerPrefs.SetInt("WheatCounter", WheatCounter);
        }

        WheatButtonPlus.onClick.AddListener(incrementWheat);
        WheatButtonMinus.onClick.AddListener(decrementWheat);
        WheatText.text = WheatCounter.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void incrementWheat()
    {
        if(WheatCounter < 99)
        {
            WheatCounter++;
            PlayerPrefs.SetInt("WheatCounter", WheatCounter);
            WheatText.text = WheatCounter.ToString();
        }      
    }
    void decrementWheat()
    {
        if(WheatCounter >= 0)
        {
            WheatCounter--;
            PlayerPrefs.SetInt("WheatCounter", WheatCounter);
            WheatText.text = WheatCounter.ToString();
        }       
    }
}
