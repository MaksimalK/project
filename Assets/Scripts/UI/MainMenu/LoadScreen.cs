using System.Collections;
using UnityEditor.Rendering;
using UnityEngine;

namespace Game.UI.MainMenu
{
    public class LoadScreen : MonoBehaviour
    {
        [SerializeField] private CanvasGroup screen;

        private void Awake()
        {
            DontDestroyOnLoad(this);
        }

        public void Show()
        {
            gameObject.SetActive(true);
            screen.alpha = 1;
        }

        public void Hide() =>
            StartCoroutine(ShowRoutine());

        private IEnumerator ShowRoutine()
        {
            while (screen.alpha > 0)
            {
                screen.alpha -= 0.03f;
                yield return new WaitForSeconds(0.03f);
            }

            gameObject.SetActive(false);
        }
    }
}
