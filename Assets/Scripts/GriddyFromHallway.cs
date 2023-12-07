using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using TMPro;

public class GriddyFromHallway : MonoBehaviour
{
    private NavMeshAgent ai;
    public Transform destination;
    private Animator anim;
    bool arrived;
    public TextMeshProUGUI myUI;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        ai = GetComponent<NavMeshAgent>();
        ai.SetDestination(destination.position);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log((transform.position - destination.position).magnitude);
        if ((transform.position - destination.position).magnitude < 0.9 && arrived == false) 
        {
            // Switch anim
            //Debug.Log("Arrived at Destination!");
            arrived = true;
            anim.SetBool("Arrived", true);
        }
    }
}
