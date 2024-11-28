using System;
using StateMachine;
using UnityEngine;

namespace Enemy.EnemyStateMachine.Transitions
{
    public class ToChaseTransition : AbstractTransition
    {
        [SerializeField] private Player.Player _player;
        [SerializeField] private Enemy _enemy;
        [SerializeField] private float _detectedRadius;

        private void Update()
        {
            if (Vector3.Distance(_enemy.transform.position, _player.transform.position) <= _detectedRadius)
            {
                ShouldTransition = true;
            }
        }
    }
}