using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardAttack : MonoBehaviour
{
    private HealthScale healthScale;
    private EnemyCardManager cardManager;

    public bool enemyActiveTurn = false;
    public bool playerActiveTurn = false;

    [SerializeField] private FoodCard[] enemyCards = new FoodCard[4];
    [SerializeField] private FoodCard[] playerCards = new FoodCard[4];

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //SetEnemyCard(enemyCards[4], 4);

        if (enemyActiveTurn == true)
        {
            EnemyAttack();
        }
        else
        {
            //cardManager.canPlay = false;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlayerAttack();
        }
    }

    public void EnemyAttack()
    {
        // Perform enemy attacks
        for (int i = 0; i < 4; i++)
        {
            if (playerCards[i] != null && enemyCards[i] != null)
            {
                playerCards[i].cardHealth -= enemyCards[i].cardDamage;
            }
            
        }

    }

    public void PlayerAttack()
    {
        // Perform player attacks
        for (int i = 0; i < 4; i++)
        {
            if (playerCards[i] != null && enemyCards[i] != null)
            {
                enemyCards[i].cardHealth -= playerCards[i].cardDamage;
            }
            
        }

    }

    public void SetEnemyCard(FoodCard card, int index)
    {

        enemyCards[index] = card;
    }
    public void SetPlayerCard(FoodCard card, int index)
    {

        playerCards[index] = card;
    }

}
