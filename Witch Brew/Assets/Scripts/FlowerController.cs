using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerController : MonoBehaviour
{
    public HarvestableItem itemHeld;

    private void Start()
    {
        itemHeld.itemName = "Berry";
    }
}
public class HarvestableItem
{
    public string itemName;
}
