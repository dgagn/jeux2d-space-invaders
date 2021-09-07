using System;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace SpaceInvaders.HUD
{
    public class UIVie : MonoBehaviour
    {
        [SerializeField] private int vie = 3;
        [SerializeField] private GameObject[] imagesVie;
        private Text _txtVie;

        private void Awake()
        {
            _txtVie = GetComponentInChildren<Text>();
            imagesVie = GameObject.FindGameObjectsWithTag("UIVie");
            _txtVie.text = vie.ToString();
        }

        private void OnEnable() => Actions.PerteVie += OnPerteVie;

        private void OnDisable() => Actions.PerteVie -= OnPerteVie;

        private void OnPerteVie()
        {
            vie--;
            if (vie <= 0) Actions.OnGameOver();
            _txtVie.text = vie.ToString();
            imagesVie.Last().SetActive(false);
            if (imagesVie.Length > 1) imagesVie = imagesVie.Take(imagesVie.Length - 1).ToArray();
        }
    }
}