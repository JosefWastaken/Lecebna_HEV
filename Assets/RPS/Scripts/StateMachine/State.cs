using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public abstract class State
{
    protected NavMeshAgent _agent;
    protected const float RANGE = 5f;
    public float Range => RANGE;
    public State(NavMeshAgent agent)
    {
        this._agent = agent;
    }

    public void EnterState()
    {

    }

    public abstract void UpdateState();

    public abstract State TryToChangeState();
}
