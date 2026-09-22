using System.Collections;
using UnityEngine;

namespace PSS.Player
{
    public class GreenShip : PlayerShip
    {
        [SerializeField] private float _movementSpeed = 4f;
        [SerializeField] private float _attackDelay = 1f;
        [SerializeField] private float _bulletSpeed = 6f;
        [SerializeField] private float _bulletDamage = 1f;
        [SerializeField] private Transform[] _bulletSpawnPoints = new Transform[0];
        [SerializeField] private PlayerBullet _bulletPrefab = null;

        private Coroutine _attackDelaying = null;

        private IEnumerator AttackDelaying()
        {
            yield return new WaitForSeconds(_attackDelay);
            _attackDelaying = null;
        }

        public override void Move(Vector2 direction)
        {
            transform.Translate(_movementSpeed * direction * Time.deltaTime);
        }

        public override void FirstAttack()
        {
            if (_attackDelaying != null) return;

            _attackDelaying = StartCoroutine(AttackDelaying()); 

            for (int i = 0; i < _bulletSpawnPoints.Length; i++)
            {
                PlayerBullet inst = Instantiate(_bulletPrefab, _bulletSpawnPoints[i].position, Quaternion.identity);
                inst.Initialize(_bulletSpeed, _bulletDamage);
            }
        }

        public override void SecondAttack()
        {
            
        }  
    }
}