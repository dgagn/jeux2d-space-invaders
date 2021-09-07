using SpaceInvaders.Interfaces;
using UnityEngine;

namespace SpaceInvaders
{
    public class Movement : MonoBehaviour, IBougeable
    {
        [SerializeField] private float vitesseMovement;

        public float VitesseMovement
        {
            get => vitesseMovement;
            set => vitesseMovement = value;
        }

        public void Bouger(Vector2 direction)
            => transform.Translate(direction * (VitesseMovement * Time.deltaTime));
    }
}