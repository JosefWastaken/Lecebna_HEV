using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AggroState : State
{
    public AggroState(NavMeshAgent agent) : base(agent)
    {

    }

    public override void UpdateState()
    {
        Debug.Log("I'm ready to attack your ass NIGGA!");
    }
    public override State TryToChangeState()
    {
        return this;
    }
}
