using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public int scoreNumber = 0;
    public Text MyscoreText;
    //public Image image;

    // Start is called before the first frame update
    void Start()
    {
       scoreNumber = 0;
       MyscoreText.text = "Essence: " + scoreNumber;
    }

    // Update is called once per frame
    void Update()
    {
        MyscoreText.text = "Essence: " + scoreNumber;
    }

    public void UpdateIntValue(int newValue)
    {
        scoreNumber += newValue;
    }

}
