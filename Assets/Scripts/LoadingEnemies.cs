using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadingEnemies : MonoBehaviour
{
    public GameObject manager;

    void Awake()
    {
        if (Manager.instance == null)
        {
            Instantiate(manager);
        }
    }
}

