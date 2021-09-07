using System;
using UnityEngine;

namespace SpaceInvaders
{
    public static class Actions
    {
        public const int ScoreIncrementation = 10;

        public static int NbEnnemis = 0;
        public static int EnnemisRestants = 0;
        public static event Action MortEnnemi;
        public static event Action PerteVie;
        public static event Action<GameObject> BarriereCollision;
        public static event Action GameOver;
        public static event Action Victoire;
        public static void OnMortEnnemi() => MortEnnemi?.Invoke();
        public static void OnPerteVie() => PerteVie?.Invoke();
        public static void OnGameOver() => GameOver?.Invoke();
        public static void OnVictoire() => Victoire?.Invoke();
        public static void OnBarriereCollision(GameObject other) => BarriereCollision?.Invoke(other);
    }
}