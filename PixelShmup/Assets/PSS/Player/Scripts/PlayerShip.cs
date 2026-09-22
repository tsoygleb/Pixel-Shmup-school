using UnityEngine;

namespace PSS.Player
{
    public abstract class PlayerShip : MonoBehaviour
    {
        public abstract void Move(Vector2 direction);
        public abstract void FirstAttack();
        public abstract void SecondAttack();
    }    
}


