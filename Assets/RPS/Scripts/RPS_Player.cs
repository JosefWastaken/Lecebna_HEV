using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RPS_Player : MonoBehaviour
{
    Camera cam;
    NavMeshAgent agent;
    RPS_Symbol symbol;

    [SerializeField]
    float symbolChangingTime = 5f;

    void Start()
    {
        cam = Camera.main;
        agent = GetComponent<NavMeshAgent>();
        symbol = GetComponent<RPS_Symbol>();
        StartCoroutine(ChangeSymbol());
    }

    private IEnumerator ChangeSymbol()
    {
        while(true)
        {
            yield return new WaitForSeconds(symbolChangingTime);
            symbol.ChangeSymbolToRandom();
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var ray = cam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit , 150f))
            {
                agent.SetDestination(hit.point);
            }
        }
    }
}
