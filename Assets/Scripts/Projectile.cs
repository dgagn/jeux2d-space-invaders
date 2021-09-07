using UnityEngine;

namespace SpaceInvaders
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Projectile : MonoBehaviour
    {
        [SerializeField] private float speed;
        [SerializeField] private Vector2 direction;

        private void Awake()
            => GetComponent<Rigidbody2D>().velocity = direction * speed;

        private void OnCollisionEnter2D(Collision2D unit)
        {
            var estEnnemi = unit.transform.CompareTag("Ennemi");
            var estJoueur = unit.transform.CompareTag("Player");

            if (estEnnemi) MortEnnemi(unit);
            else if (estJoueur) PerteVie();
        }

        private void PerteVie()
        {
            Destroy(gameObject);
            Actions.OnPerteVie();
        }

        private void MortEnnemi(Collision2D unit)
        {
            Destroy(gameObject);
            Destroy(unit.gameObject);
            Actions.OnMortEnnemi();
        }
    }
}