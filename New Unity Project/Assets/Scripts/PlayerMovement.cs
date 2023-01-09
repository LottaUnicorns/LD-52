using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip audioFootsteps;
    NavMeshAgent agent;
    Animator playerAnimator;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        playerAnimator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        PlaySound();
        SetGoal();
    }


    void PlaySound()
    {
        if (agent.velocity != Vector3.zero)
        {
            playerAnimator.SetBool("IsWalking", true);

            if (!audioSource.isPlaying)
            {
                audioSource.PlayOneShot(audioFootsteps);
            }
        }
        else
        {
            playerAnimator.SetBool("IsWalking", false);
        }
        
        
    }

    void SetGoal()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;

            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
            {
                agent.destination = hit.point;
            }
        }
    }
}
