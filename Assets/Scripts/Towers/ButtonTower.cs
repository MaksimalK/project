
using UnityEngine;

public class ButtonTower : MonoBehaviour
{
    [SerializeField]
    GameObject towerObject;

    public GameObject TowerObject
    {
        get
        {
            return towerObject;
        }
    }
}
