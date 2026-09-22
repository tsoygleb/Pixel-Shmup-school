using UnityEngine;

namespace PSS.Player
{
    public class PlayerBullet : MonoBehaviour
    {
        [SerializeField] private float _lifeTime = 4f;
        
        private float _movementSpeed = 0f;
        private float _damage = 0f;

        public void Initialize(float speed, float damage)
        {
            _movementSpeed = speed;
            _damage = damage;
        }

        private void Update()
        {
            if (_lifeTime > 0) _lifeTime -= 1 * Time.deltaTime;
            else Destroy(gameObject);

            transform.Translate(Vector2.up * _movementSpeed * Time.deltaTime);
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            
        }
    }   
}
