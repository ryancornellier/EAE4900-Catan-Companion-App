using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TradeButton : MonoBehaviour
{
    public Text uiText;
    public float mainTimer;

    private float timer;
    private bool canCount = true;
    private bool doOnce = false;
    public Button button;

    void Start()
    {
        timer = Random.Range(30, 120);
        button = GetComponent<Button>();
        button.interactable = false;
    }

    void Update()
    {
        if (timer >= 0.0f && canCount)
        {
            timer -= Time.deltaTime;
            uiText.text = timer.ToString("F");
            button.interactable = false;
        }

        else if (timer <= 0.0f && !doOnce)
        {
            canCount = false;
            doOnce = true;
            button.interactable = true;
            uiText.text = "Trade Offer";
            timer = 0.0f;
        }
    }
}