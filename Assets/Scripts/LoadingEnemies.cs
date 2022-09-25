
using UnityEngine;

public class LoadingEnemies <M>: MonoBehaviour where M: MonoBehaviour
{
    private static M instance;

    public static M Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<M>();
            }
            else if (instance = FindObjectOfType<M>())
            {
                Destroy(FindObjectOfType<M>());
            }

            DontDestroyOnLoad(FindObjectOfType<M>());

            return instance;
        }
    }
}

