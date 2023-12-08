using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SacrificeCard : MonoBehaviour, IPointerDownHandler
{

    public bool canSacrifice;
    //public int scoreNumber;
    //public Text MyscoreText;
    public Score score;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //MyscoreText.text = "Score :" + scoreNumber;
    }

    // https://www.youtube.com/watch?v=kWRyZ3hb1Vc
    public void OnPointerDown(PointerEventData eventData)
    {
        if (canSacrifice == true)
        {
            score.UpdateIntValue(1);
            Destroy(gameObject);
        }
    }

}

