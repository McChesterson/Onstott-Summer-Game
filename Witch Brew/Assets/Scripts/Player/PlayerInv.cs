using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInv : MonoBehaviour
{
    public static Item[] playerHotbar = {null, null, null, null, null};

    private void Awake()
    {
        playerHotbar = new Item[]{ null, null, null, null, null};
    }
    void Start()
    {
        
    }


    void Update()
    {

    }

    public class Item 
    {
        public string itemName;
        public Image itemImage;
    }
    public void AddItem(Item itemToAdd)
    {
        for(int i = 0; i < playerHotbar.Length; i++)
        {
            if (playerHotbar[i] != null)
            {
                playerHotbar[i] = itemToAdd;
            }
        }
    }

}
