using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardAttack : MonoBehaviour
{
    private FoodCard card;
    private HealthScale healthScale;
    private EnemyCardManager cardManager;

    //public Transform firePoint;

    //public GameObject enemyBulletPrefab;
    //public GameObject bulletPrefab;

    public bool enemyActiveTurn = false;
    public bool playerActiveTurn = false;

    public int playerNumber;
    public int enemyNumber;

    public bool canDamage;


    // Start is called before the first frame update
    void Start()
    {
        UpdateCardUpdate();

    }

    // Update is called once per frame
    void Update()
    {

        if (enemyActiveTurn == true && card.enemyCard == true)
        {
            EnemyAttack();
        }
        else
        {
            //cardManager.canPlay = false;
        }

        if (playerActiveTurn == true && card.enemyCard == false)
        {
            PlayerAttack();
        }
    }

    public void EnemyAttack()
    {
        if (CompareTag("EnemyCard") && canDamage == true) ;
        {
            card.TakeDamage(card.cardDamage);
            UpdateCardUpdate();
        }

    }

    public void PlayerAttack()
    {
        if (CompareTag("PlayerCard") && canDamage == true) ;
        {
            card.TakeDamage(card.cardDamage);
            UpdateCardUpdate();
        }
    }

    private void UpdateCardUpdate()
    {
        card = gameObject.GetComponent<FoodCard>();
    }

    private void CanDamage()
    {
        // Get the corresponding enemy
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("EnemySlot");
        GameObject targetEnemy = null;

        foreach (var enemy in enemies)
        {
            CardAttack enemyDamageSystem = enemy.GetComponent<CardAttack>();
            if (enemyDamageSystem != null && enemyDamageSystem.enemyNumber == playerNumber)
            {
                targetEnemy = enemy;
                canDamage = true;
                break;
                
            }
            else
            {
                canDamage = false;
            }
        }

    }
}
