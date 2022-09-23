using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerShop : MonoBehaviour
{
    TowerButton towerButtonPressed;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(mousePoint, Vector2.zero);

            PlaceTower(hit);
        }
    }


        public void PlaceTower(RaycastHit2D hit)
    {
    
        GameObject newTower = Instantiate(towerButtonPressed.TowerObject);
        newTower.transform.position = hit.transform.position;
    }


    public void SelectTower(TowerButton towerSelected)
    {
        towerButtonPressed = towerSelected;
        Debug.Log("Pressed" + towerButtonPressed.gameObject);
    }
    

}
