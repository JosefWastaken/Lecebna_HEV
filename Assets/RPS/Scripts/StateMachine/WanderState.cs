using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.AI;

public class WanderState : State
{
    public WanderState(NavMeshAgent agent) : base(agent)
    {

    }

    public override void UpdateState()
    {
        
    }
    public override State TryToChangeState()
    {
        var clds = Physics.OverlapSphere(_agent.transform.position, RANGE);

        var symbol = clds.FirstOrDefault(cld => cld.GetComponentInParent<RPS_Symbol>());

        if (symbol != null)
        {
            return new AggroState(_agent);
        }
        return this;
    }
}
