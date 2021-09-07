using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SpaceInvaders.Scenes
{
    public class Victoire : MonoBehaviour
    {
        private void OnEnable()
        {
            Actions.MortEnnemi += OnMortEnnemi;
            Actions.Victoire += OnVictoire;
        }

        private void OnDisable()
        {
            Actions.MortEnnemi -= OnMortEnnemi;
            Actions.Victoire -= OnVictoire;
        }

        private static void OnVictoire() => SceneManager.LoadScene("Scenes/Victoire");

        private static void OnMortEnnemi()
        {
            Actions.EnnemisRestants--;
            if (Actions.EnnemisRestants <= 0) Actions.OnVictoire();
        }
    }
}