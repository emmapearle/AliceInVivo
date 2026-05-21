using ToonyColorsPro;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public GameObject InventoryMenu;
    private bool menuActive;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Inventory") && menuActive)
        {
            InventoryMenu.SetActive(false);
            menuActive = false;
        }
        else if (Input.GetButtonDown("Inventory") && !menuActive)
        {
            InventoryMenu.SetActive(true);
            menuActive = true;
        }
    }
}
