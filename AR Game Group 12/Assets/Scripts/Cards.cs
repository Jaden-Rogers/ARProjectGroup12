using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    // Generic Card Class acts as a parent for other cards. Inheritance.
    public virtual int cardHealth { get; set; }
    public virtual int cardDamage { get; set; }
    public virtual int cardCost { get; set; }

}

public class SoldierCard : Card
{
    // Override the cardHealth, cardDamage, cardCost property with a specific value
    public override int cardHealth { get { return 3; } set { base.cardHealth = value; } }
    public override int cardDamage { get { return 4; } set { base.cardHealth = value; } }
    public override int cardCost { get { return 2; } set { base.cardHealth = value; } }
}
public class RavenCard : Card
{
    // Override the cardHealth, cardDamage, cardCost property with a specific value
    public override int cardHealth { get { return 2; } set { base.cardHealth = value; } }
    public override int cardDamage { get { return 3; } set { base.cardHealth = value; } }
    public override int cardCost { get { return 2; } set { base.cardHealth = value; } }

    void Start()
    {
        // Log the health value on start
        Debug.Log($"CustomCard Health on Start: {cardHealth}");
    }
}
public class SnakeCard : Card
{
    // Override the cardHealth, cardDamage, cardCost property with a specific value
    public override int cardHealth { get { return 0; } set { base.cardHealth = 2; } }
    public override int cardDamage { get { return 0; } set { base.cardHealth = 2; } }
    public override int cardCost { get { return 0; } set { base.cardHealth = 2; } }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log($"Card Health: {cardHealth}");
        }

    }
}
