using System;
using UnityEngine;

namespace SpaceInvaders
{
    public class GenererGrille : MonoBehaviour
    {
        [SerializeField] private int nbRow;
        [SerializeField] private int nbColonne;
        [SerializeField] private float espacement = 0.5f;
        [SerializeField] private GameObject ennemi;
        private Vector2 _position;

        private void Awake() => _position = transform.position;

        private void Start() => GenererEnnemis();

        private void GenererEnnemis()
        {
            for (var row = 0; row < nbRow; row++)
            {
                var posRowY = _position.y - espacement * row;
                for (var colonne = 0; colonne < nbColonne; colonne++)
                {
                    var pos = new Vector2(_position.x + espacement * colonne, posRowY);
                    var copieEnnemi = Instantiate(ennemi.gameObject, pos, Quaternion.identity);
                    copieEnnemi.transform.SetParent(transform);
                    Actions.NbEnnemis++;
                }
            }

            Actions.EnnemisRestants = Actions.NbEnnemis;
        }
    }
}