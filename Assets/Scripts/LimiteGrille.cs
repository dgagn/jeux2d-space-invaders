using UnityEngine;

namespace SpaceInvaders
{
    public class LimiteGrille : MonoBehaviour
    {
        [SerializeField] private float limiteY = -2f;

        private void Update()
        {
            if (transform.position.y <= limiteY) Actions.OnGameOver();
        }
    }
}