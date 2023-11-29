using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodCard : Card
{
    // Override the cardHealth, cardDamage, cardCost property with a specific value
    public override int cardHealth { get { return 0; } set { base.cardHealth = value; } }
    public override int cardDamage { get { return 0; } set { base.cardHealth = value; } }
    public override int cardCost { get { return 0; } set { base.cardHealth = value; } }
}
