using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Game.UI.MainMenu
{
    [RequireComponent(typeof(Button))]
    public class StartGameButton : MonoBehaviour
    {
        [SerializeField] private Button button;
        [SerializeField] private LoadScreen loadScreen;

        private void Awake()
        {
            button.onClick.AddListener(LoadScene);
        }

        private void LoadScene()
        {
            StartCoroutine(Load("1"));
        }

        private IEnumerator Load(String name)
        {
            LoadScreen loadScreen1 = Instantiate(loadScreen);
            GameObject.DontDestroyOnLoad(loadScreen1);
            AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(name);
            asyncLoad.allowSceneActivation = false;
            while (asyncLoad.progress > 0.8)
            {
                yield return null;
            }
            loadScreen1.Hide();
            asyncLoad.allowSceneActivation = true;

        }
    }
}
