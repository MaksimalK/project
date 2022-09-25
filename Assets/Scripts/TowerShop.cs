using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class TowerShop : LoadingEnemies<TowerShop>
{
    ButtonTower buttonTowerPressed;


    void Start()
    {
        
    }

   
    void Update()
    {
       if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(mousePoint, Vector2.zero);
            
            if (hit.collider.tag == "TowerPlace")
            {
                PlaceTower(hit);
            }

        }
    }

    public void PlaceTower(RaycastHit2D hit)
    {
        if (!EventSystem.current.IsPointerOverGameObject() && buttonTowerPressed != null)
        {
            GameObject newTower = Instantiate(buttonTowerPressed.TowerObject);
            newTower.transform.position = hit.transform.position;
        }
        
    }

    public void SelectedTower(ButtonTower towerSelected)
    {
        buttonTowerPressed = towerSelected;
        Debug.Log("Pressed" + buttonTowerPressed.gameObject);
    }
}
