using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Counter : MonoBehaviour
{
    public Text scoreText;
    public int score;
    public GameObject ButtonGameObject;

    //use this for initialization
    void Start()
    {

    }
    //update is called once per frame
    void Update ()
    {
        scoreText.text = "Wheat: " + score;

        if (Input.GetMouseButtonDown(0) && EventSystem.current.currentSelectedGameObject == ButtonGameObject)
        {
            score++;
        }

            
    }

  
}
