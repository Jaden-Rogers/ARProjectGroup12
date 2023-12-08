using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCardManager : MonoBehaviour
{
    public bool enemyTurn = false;
    public bool canPlay;
    private int amountOfTurns = 0;

    public GameObject[] cards;
    public GameObject mycard;
    public GameObject enemySlot;



    public CardSlot cardSlot;

    // Start is called before the first frame update
    void Start()
    {
        mycard = cards[Random.Range(0, cards.Length)];
        CanPlayRandomizer();
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyTurn == true && cardSlot.emptySlot == true)
        {
            StartCoroutine(PlayEnemyCards());
            
        }
    }

    public void SetParent(GameObject newParent)
    {
        //Makes the GameObject "newParent" the parent of the GameObject "player".
        enemySlot.transform.parent = newParent.transform;

    }

    public IEnumerator PlayEnemyCards()
    {
        mycard = cards[Random.Range(0, cards.Length)];
        yield return new WaitForEndOfFrame();
        if (canPlay == true)
        {
            Instantiate(mycard, enemySlot.transform);
            enemyTurn = false;
            CanPlayRandomizer();
            amountOfTurns = amountOfTurns + 1;
        }
        else
        {
            enemyTurn = false;
            CanPlayRandomizer();
            amountOfTurns = amountOfTurns + 1;
        }
        
         
    }

    void CanPlayRandomizer()
    {
        // Generate a random float value between 0 and 1
        float randomValue = Random.value;

        // Set a boolean based on the random value and a threshold
        if (amountOfTurns <= 10)
        {
            canPlay = (randomValue > 0.5f);
        }
        else if (amountOfTurns >= 10)
        {
            canPlay = (randomValue > 0.9f);
        }
        else if (amountOfTurns > 15)
        {
            canPlay = false;
        }

    }
}
