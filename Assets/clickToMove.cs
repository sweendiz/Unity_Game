using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class clickToMove : MonoBehaviour {
    NavMeshAgent navAgent;
    // Use this for initialization
    void Start () {
        navAgent = GetComponent<NavMeshAgent>();
    }
    
    // Update is called once per frame
    void Update () {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Input.GetMouseButton(0))
        {
            if (Physics.Raycast(ray, out hit, 100))
            {
                navAgent.SetDestination(hit.point);
            }
        }
    }
}
