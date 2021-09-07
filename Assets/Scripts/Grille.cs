using System;
using SpaceInvaders.Interfaces;
using UnityEngine;

namespace SpaceInvaders
{
    public class Grille : MonoBehaviour
    {
        private IBougeable _bougeable;
        private Vector2 _direction;

        private void Awake()
        {
            _direction = Vector2.right;
            _bougeable = GetComponent<IBougeable>();
        }

        private void Update() => _bougeable?.Bouger(_direction);
        
        private void OnEnable() => Actions.BarriereCollision += OnBarriereCollision;
        
        private void OnDisable() => Actions.BarriereCollision -= OnBarriereCollision;
        
        private void OnBarriereCollision(GameObject obj)
        {
            if (obj.transform.CompareTag("LimiteDroite")) _direction = Vector2.left;
            else if (obj.transform.CompareTag("LimiteGauche")) _direction = Vector2.right;
            _bougeable.Bouger(Vector2.down);
        }
    }
}