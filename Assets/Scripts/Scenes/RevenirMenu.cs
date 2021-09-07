using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SpaceInvaders.Scenes
{
    public class RevenirMenu : MonoBehaviour
    {
        public void AllerMenuPrincipal()
            => SceneManager.LoadScene("Scenes/MenuPrincipal");

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape)) 
                Application.Quit();
        }
    }
}