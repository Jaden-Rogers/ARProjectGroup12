using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FoodCard : MonoBehaviour
{
    [SerializeField] public int cardHealth = 0;
    [SerializeField] public int cardDamage = 0;
    [SerializeField] public int cardCost = 0;

    [SerializeField] private TMP_Text cardHealthUI;
    [SerializeField] private TMP_Text cardDamageUI;
    [SerializeField] private TMP_Text cardCostUI;

    public string cardName;
    public bool contested;
    public bool enemyCard;



    private void Start()
    {
        // Ensure that the childText reference is not null
        if (cardHealthUI != null)
        {
            // Set the text of the child Text component to the integer value
            cardHealthUI.text = cardHealth.ToString();
            cardDamageUI.text = cardDamage.ToString();
            cardCostUI.text = cardCost.ToString();
        }
        else
        {
            // Log an error if the childText reference is null
            Debug.LogError("Child Text component reference is not set!");
        }
    }


    private void Update()
    {
        if (cardHealth <= 0)
        {
            Destroy(gameObject);
            Debug.Log(cardName + "has fallen!");
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            TakeDamage(1);
        }

        if (contested == true)
        {
            
        }
    }

    public void TakeDamage(int damage)
    {
        //Debug.Log("ouch");
        cardHealth -= damage;
    }

    public void EnemyCardDamage(int damage)
    {

    }

    public void EnemyPlayerDamage(int damage)
    {

    }
}
