using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SpaceInvaders.Scenes
{
    public class GameOver : MonoBehaviour
    {
        private void OnEnable() => Actions.GameOver += OnGameOver;

        private void OnDisable() => Actions.GameOver -= OnGameOver;

        private static void OnGameOver() => SceneManager.LoadScene("Scenes/GameOver");
    }
}