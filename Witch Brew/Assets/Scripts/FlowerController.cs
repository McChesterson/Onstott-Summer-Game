using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerController : MonoBehaviour
{
    public bool harvested;
    public PlayerInv.Item itemHeld;
    

    private void Awake()
    {
        harvested = false;
        itemHeld.itemName = "Berry";
        
    }
    private void Start()
    {
        
    }
}
