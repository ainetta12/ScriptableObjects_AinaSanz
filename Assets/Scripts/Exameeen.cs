using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Crear un escenario con canvas (inventario)
//Creamos Script 1
//Cambiar MonoBehaviour a ScriptableObjects

/*
public class ScriptableItem : ScriptableObject
{
    public enum ItemType
    {
        Weapon,
        Armor,
        Shield
    }

    public ItemType itemType;

    public string itemName;
    public string itemDescription;
    public int itemPrince;
    public Sprite itemSprite;

}
*/


//Creamos script 2 (invetorymanager)
//poner using UnityEngine.UI;

// despues de las variables nos vamos al menu y creamos un empty y le ponemos el script 

/*public class InventoryManager : MonoBehaviour
{
    (crear varable por cada cosa que nos pida, daño, precio / poner un texto si es text ocmo el daño y una image si es sprite)
   
    public static InventoryManager instance;
    public ScriptableItem[] weapons;
    public Text[] weaponsNames;
    public Image[] weaponsSprites;
    public InventorySlots[] WeaponSlots;


    void Awake()
    {
        instance = this;
    }

    public void AddItem(ScriptableItem item)
    {
        for(int i = 0; i < weapons.Length; i ++)
        {
            if(weapons[i] == null)
            {
                weapons[i] = item;
                weaponsNames[i].text = item.itemName;
                weaponsSprites[i].sprite = item.itemSprite;

                WeaponSlots[i].slotItem = item;
                WeaponSlots[i].slotNumber = i;

                return;
            }
        }
    }
 
}
*/


//crear nuevo script 3 (pickableItem)
// se pone en el objeto que se puede coger

/*
public class PickableItem : MonoBehaviour
{
    public ScriptableItem item;

    private SpriteRenderer spriteRenderer;
   
    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

   
    void Start()
    {
        spriteRenderer.sprite = item.itemSprite;     
    }

    void OnTriggerEnter2D (Collider2D collider)
    {
        InventoryManager.instance.AddItem(item);
        Destroy(this.gameObject);
    }
}
*/

