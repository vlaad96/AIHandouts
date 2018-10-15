using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Pathfinding : MonoBehaviour {

    public GameObject target;
    public NavMeshAgent agent;
    

    private void Start()
    {

        agent = GetComponent<NavMeshAgent>();
       
    }
    // Update is called once per frame
    void Update ()
    {
		
        if(agent != null && target != null)
        {
            agent.destination = target.transform.position;
        }
        
	}
}
