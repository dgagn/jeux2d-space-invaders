using System.Collections;
using SpaceInvaders.Interfaces;
using UnityEngine;

namespace SpaceInvaders
{
    public class Ennemi : MonoBehaviour
    {
        private IPeutTirer _peutTirer;

        private void Awake()
            => _peutTirer = GetComponent<IPeutTirer>();

        private void Start()
            => StartCoroutine(TirerAleatoire());

        private void OnCollisionEnter2D(Collision2D other)
        {
            if (other.gameObject.CompareTag("Player") || other.gameObject.CompareTag("Bouclier")) Actions.OnGameOver();
        }

        private IEnumerator TirerAleatoire()
        {
            while (true)
            {
                yield return new WaitForSeconds(Random.value * 7);
                _peutTirer?.Tirer();
            }
        }
    }
}