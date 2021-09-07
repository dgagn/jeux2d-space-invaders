using UnityEngine;

namespace SpaceInvaders.Interfaces
{
    public interface IBougeable
    {
        float VitesseMovement { get; set; }
        void Bouger(Vector2 direction);
    }
}