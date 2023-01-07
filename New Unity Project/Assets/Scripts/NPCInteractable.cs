using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCInteractable : MonoBehaviour
{
    [SerializeField] float deathDelay = 1f;
    [SerializeField] GameObject elderWish;
    [SerializeField] GameObject soulObject;
    [SerializeField] Vector3 ownLocation;
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip audioDying;
   

    
    public void Interact()
    {
        DeathSequence();
    }

    public void GiveWish()
    {
        FindObjectOfType<Dialogue>().StartDialogue();
        Instantiate(elderWish, Vector3.zero, Quaternion.identity);
    }




    void DeathSequence()
    {
        audioSource.PlayOneShot(audioDying);
        Invoke("ElderDies", deathDelay);
    }

    void ElderDies()
    {
        ownLocation = transform.position;
        Instantiate(soulObject, ownLocation, Quaternion.identity);
        Destroy(gameObject);
    }
}
