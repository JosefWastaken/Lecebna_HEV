using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RPSEnemyStateMachine : MonoBehaviour
{
    State currentState;

    void Start()
    {
        var agent = GetComponent<NavMeshAgent>();
        currentState = new WanderState(agent);
        currentState.EnterState();
    }

    void Update()
    {
        if (currentState != null)
        {
            currentState.UpdateState();
            var newState = currentState.TryToChangeState();
            if (newState != currentState)
            {
                currentState = newState;
                currentState.EnterState();
            }
        }
    }
}
