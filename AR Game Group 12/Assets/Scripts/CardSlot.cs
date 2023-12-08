using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CardSlot : MonoBehaviour, IDropHandler
{

    public bool emptySlot = true;

    public void OnDrop(PointerEventData eventData)
    {
        if (transform.childCount == 0)
        {
            GameObject dropped = eventData.pointerDrag;
            CardPickupController cardPickup = dropped.GetComponent<CardPickupController>();
            cardPickup.parentAfterDrag = transform;
        }


    }
}
