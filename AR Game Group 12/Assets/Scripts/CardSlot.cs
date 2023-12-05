using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CardSlot : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
            GameObject dropped = eventData.pointerDrag;
            CardPickupController cardPickup = dropped.GetComponent<CardPickupController>();
            cardPickup.parentAfterDrag = transform;

    }
}
