using System;
using UnityEngine;
using UnityEngine.UI;

namespace SpaceInvaders.HUD
{
    public class UIScoreVie : MonoBehaviour
    {
        private int _score;
        private Text _txtScoreVie;
        private void Awake() => _txtScoreVie = GetComponent<Text>();

        private void OnEnable()
        {
            Actions.MortEnnemi += OnMortEnnemi;
            Actions.PerteVie += OnPerteVie;
        }

        private void OnDisable()
        {
            Actions.MortEnnemi -= OnMortEnnemi;
            Actions.PerteVie -= OnPerteVie;
        }

        private void OnPerteVie()
        {
            _score = 0;
            UpdateScoreVie();
        }

        private void OnMortEnnemi()
        {
            _score += Actions.ScoreIncrementation;
            UpdateScoreVie();
        }

        private void UpdateScoreVie() 
            => _txtScoreVie.text = _score.ToString("0000");
    }
}