using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ResourceManager : MonoBehaviour
{
    public Button WheatButtonPlus;
    public Button WheatButtonMinus;
    public int White_WheatCounter = 0;
    public Text WheatText;

    public Button StoneButtonPlus;
    public Button StoneButtonMinus;
    public int White_StoneCounter = 0;
    public Text StoneText;

    public Button SheepButtonPlus;
    public Button SheepButtonMinus;
    public int White_SheepCounter = 0;
    public Text SheepText;

    public Button BrickButtonPlus;
    public Button BrickButtonMinus;
    public int White_BrickCounter = 0;
    public Text BrickText;

    public Button WoodButtonPlus;
    public Button WoodButtonMinus;
    public int White_WoodCounter = 0;
    public Text WoodText;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("White_WheatCounter"))
        {
            White_WheatCounter = PlayerPrefs.GetInt("White_WheatCounter");
        }
        else
        {
            PlayerPrefs.SetInt("White_WheatCounter", White_WheatCounter);
        }
        WheatButtonPlus.onClick.AddListener(incrementWheat);
        WheatButtonMinus.onClick.AddListener(decrementWheat);
        WheatText.text = White_WheatCounter.ToString();

        if (PlayerPrefs.HasKey("White_StoneCounter"))
        {
            White_StoneCounter = PlayerPrefs.GetInt("White_StoneCounter");
        }
        else
        {
            PlayerPrefs.SetInt("White_StoneCounter", White_StoneCounter);
        }
        StoneButtonPlus.onClick.AddListener(incrementStone);
        StoneButtonMinus.onClick.AddListener(decrementStone);
        StoneText.text = White_StoneCounter.ToString();

        if (PlayerPrefs.HasKey("White_SheepCounter"))
        {
            White_SheepCounter = PlayerPrefs.GetInt("White_SheepCounter");
        }
        else
        {
            PlayerPrefs.SetInt("White_SheepCounter", White_SheepCounter);
        }
        SheepButtonPlus.onClick.AddListener(incrementSheep);
        SheepButtonMinus.onClick.AddListener(decrementSheep);
        SheepText.text = White_SheepCounter.ToString();

        if (PlayerPrefs.HasKey("White_BrickCounter"))
        {
            White_BrickCounter = PlayerPrefs.GetInt("White_BrickCounter");
        }
        else
        {
            PlayerPrefs.SetInt("White_BrickCounter", White_BrickCounter);
        }
        BrickButtonPlus.onClick.AddListener(incrementBrick);
        BrickButtonMinus.onClick.AddListener(decrementBrick);
        BrickText.text = White_BrickCounter.ToString();

        if (PlayerPrefs.HasKey("White_WoodCounter"))
        {
            White_WoodCounter = PlayerPrefs.GetInt("White_WoodCounter");
        }
        else
        {
            PlayerPrefs.SetInt("White_WoodCounter", White_WoodCounter);
        }
        WoodButtonPlus.onClick.AddListener(incrementWood);
        WoodButtonMinus.onClick.AddListener(decrementWood);
        WoodText.text = White_WoodCounter.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void incrementWheat()
    {
        if (White_WheatCounter < 99)
        {
            White_WheatCounter++;
            PlayerPrefs.SetInt("White_WheatCounter", White_WheatCounter);
            WheatText.text = White_WheatCounter.ToString();
        }
    }

    void incrementStone()
    {
        if (White_StoneCounter < 99)
        {
            White_StoneCounter++;
            PlayerPrefs.SetInt("White_StoneCounter", White_StoneCounter);
            StoneText.text = White_StoneCounter.ToString();
        }
    }

    void incrementSheep()
    {
        if (White_SheepCounter < 99)
        {
            White_SheepCounter++;
            PlayerPrefs.SetInt("White_SheepCounter", White_SheepCounter);
            SheepText.text = White_SheepCounter.ToString();
        }
    }

    void incrementBrick()
    {
        if (White_BrickCounter < 99)
        {
            White_BrickCounter++;
            PlayerPrefs.SetInt("White_BrickCounter", White_BrickCounter);
            BrickText.text = White_BrickCounter.ToString();
        }
    }

    void incrementWood()
    {
        if (White_WoodCounter < 99)
        {
            White_WoodCounter++;
            PlayerPrefs.SetInt("White_WoodCounter", White_WoodCounter);
            WoodText.text = White_WoodCounter.ToString();
        }
    }
    void decrementWheat()
    {
        if (White_WheatCounter >= 0)
        {
            White_WheatCounter--;
            PlayerPrefs.SetInt("White_WheatCounter", White_WheatCounter);
            WheatText.text = White_WheatCounter.ToString();
        }
    }
    void decrementStone()
    {
        if (White_StoneCounter >= 0)
        {
            White_StoneCounter--;
            PlayerPrefs.SetInt("White_StoneCounter", White_StoneCounter);
            StoneText.text = White_StoneCounter.ToString();
        }
    }

    void decrementSheep()
    {
        if (White_SheepCounter >= 0)
        {
            White_SheepCounter--;
            PlayerPrefs.SetInt("White_SheepCounter", White_SheepCounter);
            SheepText.text = White_SheepCounter.ToString();
        }
    }

    void decrementBrick()
    {
        if (White_BrickCounter >= 0)
        {
            White_BrickCounter--;
            PlayerPrefs.SetInt("White_BrickCounter", White_BrickCounter);
            BrickText.text = White_BrickCounter.ToString();
        }
    }

    void decrementWood()
    {
        if (White_WoodCounter >= 0)
        {
            White_WoodCounter--;
            PlayerPrefs.SetInt("White_WoodCounter", White_WoodCounter);
            WoodText.text = White_WoodCounter.ToString();
        }
    }
}
