using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CardSlot : MonoBehaviour, IDropHandler
{

    public bool emptySlot = true;
    public int indexSlotNumber;
    public bool isEnemySlot;

    public void OnDrop(PointerEventData eventData)
    {
        if (transform.childCount == 0)
        {
            
            GameObject dropped = eventData.pointerDrag;
            FoodCard card = dropped.GetComponent<FoodCard>();
            CardPickupController cardPickup = dropped.GetComponent<CardPickupController>();
            cardPickup.parentAfterDrag = transform;
            emptySlot = false;

            if (isEnemySlot == true)
            {
                FindObjectOfType<CardAttack>().SetPlayerCard(card, indexSlotNumber);
            }
            else if (isEnemySlot == false)
            {
                FindObjectOfType<CardAttack>().SetEnemyCard(card, indexSlotNumber);

            }


        }


    }

    public void EmptyClear()
    {
        if (isEnemySlot == true)
        {
            FindObjectOfType<CardAttack>().SetPlayerCard(null, indexSlotNumber);
        }
        else if (isEnemySlot == false)
        {
            FindObjectOfType<CardAttack>().SetEnemyCard(null, indexSlotNumber);

        }

        emptySlot = true;
        
    }
}
