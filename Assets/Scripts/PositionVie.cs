using System;
using UnityEngine;

namespace SpaceInvaders
{
    public class PositionVie : MonoBehaviour
    {
        [SerializeField] private float positionXDepart = -8f;
        private Vector2 _position;

        private void Awake() => _position = transform.position;
        private void OnEnable() => Actions.PerteVie += OnPerteVie;

        private void OnDisable() => Actions.PerteVie -= OnPerteVie;

        private void OnPerteVie()
        {
            _position.x = positionXDepart;
            transform.position = _position;
        }
    }
}