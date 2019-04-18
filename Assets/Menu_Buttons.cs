using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_Buttons : MonoBehaviour
{
    public GameObject MenuPanel;
    public GameObject ShopPanel;
    public GameObject BattlePanel;
    // Start is called before the first frame update
    public void Start()
    {
        MenuPanel.SetActive(true);
        ShopPanel.SetActive(false);
        BattlePanel.SetActive(false);
    }

    // Update is called once per frame
    public void Update()
    {

    }

    public void ShowMenuPanel()
    {
        MenuPanel.SetActive(true);
        ShopPanel.SetActive(false);
        BattlePanel.SetActive(false);
    }
    public void ShowShopPanel()
    {
        MenuPanel.SetActive(false);
        ShopPanel.SetActive(true);
        BattlePanel.SetActive(false);
    }
}
