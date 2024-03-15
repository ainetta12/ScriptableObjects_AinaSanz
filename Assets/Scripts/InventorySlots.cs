using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlots : MonoBehaviour
{
    public ScriptableItem slotItem;
    public int slotNumber;
    public GameObject inspectionWindow;
    public Image inspectionImage;
    public Text inspectionName;
    public Text inspectionPrice;
    public Text inspectionDescription;

    public Button deleteButton;


    public void INspectItem()
    {
        if(slotItem =! null)
        {
            inspectionImage.sprite = slotItem.itemSprite;
            inspectionName.text = slotItem.itemName;
            inspectionPrice.text = slotItem.itemPrince;
            inspectionDescription.text = slotItem.itemDescription;

            inspectionWindow.SetActive(true);
        }
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
