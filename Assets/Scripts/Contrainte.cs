using UnityEngine;

namespace SpaceInvaders
{
    public class Contrainte : MonoBehaviour
    {
        [SerializeField] private float contrainteX = 8.5f;

        private void LateUpdate() => BougerContrainteX();

        private void BougerContrainteX()
        {
            var pos = transform.position;
            pos.x = Mathf.Clamp(pos.x, contrainteX * -1, contrainteX);
            transform.position = pos;
        }
    }
}