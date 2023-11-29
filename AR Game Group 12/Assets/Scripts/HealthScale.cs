using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScale : MonoBehaviour
{

    public int scaleValue;

    // Start is called before the first frame update
    void Start()
    {
        scaleValue = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (scaleValue <= -6)
        {
            PlayerLose();
        }

        if (scaleValue >= 6)
        {
            PlayerWin();
        }
    }

    private void PlayerLose()
    {
        Debug.Log("You Lost");
    }
    private void PlayerWin()
    {
        Debug.Log("You Win!");
    }
}
