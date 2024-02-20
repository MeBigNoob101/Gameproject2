using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryUI : MonoBehaviour
{
    private TextMeshProUGUI diamondText;
    void Start()
    {
        diamondText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateDiamondText(PlayerInventory PlayerInventory)
    {
        diamondText.text = PlayerInventory.NumberOfDiamonds.ToString();
    }

}
 