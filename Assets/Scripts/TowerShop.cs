using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerShop : LoadingEnemies<TowerShop>
{
    ButtonTower buttonTowerPressed;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SelectedTower(ButtonTower towerSelected)
    {
        buttonTowerPressed = towerSelected;
        Debug.Log("Pressed" + buttonTowerPressed.gameObject);
    }
}
