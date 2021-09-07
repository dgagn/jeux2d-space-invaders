using SpaceInvaders.Interfaces;
using UnityEngine;

namespace SpaceInvaders
{
    public class Joueur : MonoBehaviour
    {
        private IBougeable _bougeable;
        private IPeutTirer _peutTirer;

        private void Awake()
        {
            _bougeable = GetComponent<IBougeable>();
            _peutTirer = GetComponent<IPeutTirer>();
        }

        private void Update()
            => GererInput();

        private void GererInput()
        {
            if (Input.GetKeyDown(KeyCode.Space)) _peutTirer?.Tirer();
            if (Input.GetKey(KeyCode.RightArrow)) _bougeable?.Bouger(Vector2.right);
            if (Input.GetKey(KeyCode.LeftArrow)) _bougeable?.Bouger(Vector2.left);
        }
    }
}