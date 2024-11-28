using StateMachine;
using UnityEngine;

namespace Enemy.EnemyStateMachine.Transitions
{
    public class ChaseToTransition : AbstractTransition
    {
        [SerializeField] private Player.Player _player;
        [SerializeField] private Enemy _enemy;
        [SerializeField] private float _chaseRadius;
        
        private void Update()
        {
            if (Vector3.Distance(_player.transform.position, _enemy.transform.position) >= _chaseRadius)
            {
                ShouldTransition = true;
            }
        }
    }
}