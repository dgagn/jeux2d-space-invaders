using System;
using UnityEngine;
using UnityEngine.UI;

namespace SpaceInvaders.HUD
{
    public class UIScore : MonoBehaviour
    {
        private int _score;
        private Text _txtScore;
        private void Awake() => _txtScore = GetComponent<Text>();

        private void OnEnable() => Actions.MortEnnemi += OnMortEnnemi;

        private void OnDisable() => Actions.MortEnnemi -= OnMortEnnemi;

        private void OnMortEnnemi()
        {
            _score += Actions.ScoreIncrementation;
            _txtScore.text = _score.ToString("0000");
        }
    }
}