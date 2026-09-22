using UnityEngine;

namespace PSS.Player
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private PlayerShip _currentShip = null;

        private void Update()
        {
            Vector2 inputs = Vector2.zero;
            inputs.x = Input.GetAxisRaw("Horizontal");
            inputs.y = Input.GetAxisRaw("Vertical");

            _currentShip.Move(inputs);

            if (Input.GetKey(KeyCode.K) == true)
            {
                _currentShip.FirstAttack();
            }
            else if (Input.GetKeyDown(KeyCode.L) == true)
            {
                _currentShip.SecondAttack();
            }
        }
    }   
}
