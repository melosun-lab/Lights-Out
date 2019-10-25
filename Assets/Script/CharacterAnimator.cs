using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class CharacterAnimator : MonoBehaviour
{

    const float smooth_time = 0.1f;
    NavMeshAgent agent;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //float speedPercent = agent.velocity.magnitude / agent.speed;
        float speedPercent;
        if(FindObjectOfType<PlayerMoter>().moving){
            speedPercent = 0.7f;
        }
        else{
            speedPercent = 0f;
        }
        
        animator.SetFloat("speedPercent", speedPercent, smooth_time , Time.deltaTime);
    }
}
