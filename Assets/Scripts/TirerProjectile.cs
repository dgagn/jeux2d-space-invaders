using SpaceInvaders.Interfaces;
using UnityEngine;

namespace SpaceInvaders
{
    public class TirerProjectile : MonoBehaviour, IPeutTirer
    {
        [SerializeField] private GameObject projectile;
        [SerializeField] private Transform positionTirer;

        public void Tirer()
        {
            var copieProj = Instantiate(projectile, positionTirer.position, positionTirer.rotation);
            Destroy(copieProj, 0.8f);
        }
    }
}