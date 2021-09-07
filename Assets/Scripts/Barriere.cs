using UnityEngine;

namespace SpaceInvaders
{
    public class Barriere : MonoBehaviour
    {
        private void OnCollisionEnter2D() => Actions.OnBarriereCollision(gameObject);
    }
}