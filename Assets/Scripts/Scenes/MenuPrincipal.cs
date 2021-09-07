using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SpaceInvaders.Scenes
{
    public class MenuPrincipal : MonoBehaviour
    {
        public void Jouer() => SceneManager.LoadScene("Scenes/SampleScene");

        public void Quitter()
        {
            #if UNITY_EDITOR
                EditorApplication.isPlaying = false;
            #else
                Application.Quit();
            #endif
        }
    }
}