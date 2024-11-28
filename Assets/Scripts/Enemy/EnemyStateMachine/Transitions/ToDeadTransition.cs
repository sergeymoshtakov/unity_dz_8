using StateMachine;
using UnityEngine;

namespace Enemy.EnemyStateMachine.Transitions
{
    public class ToDeadTransition : AbstractTransition
    {
        [SerializeField] private float _timeToDeath = 15f;

        private float _timer;

        private void Update()
        {
            _timer += Time.deltaTime;

            if (_timer >= _timeToDeath)
            {
                ShouldTransition = true;
            }
        }

        private void OnEnable()
        {
            _timer = 0;
        }
    }
}
