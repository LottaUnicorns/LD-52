using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCInteractable : MonoBehaviour
{
    [SerializeField] float deathDelay = 1f;
    [SerializeField] GameObject elderWish;
    [SerializeField] GameObject soulObject;
    [SerializeField] Vector3 ownLocation;

    
    public void Interact()
    {
        DeathSequence();
    }

    public void GiveWish()
    {
        Debug.Log("Elder: I want COLLECTIBLE");
        Instantiate(elderWish, Vector3.zero, Quaternion.identity);
    }




    void DeathSequence()
    {
        Debug.Log("ELDER IS DYING");
        Invoke("ElderDies", deathDelay);
    }

    void ElderDies()
    {
        Debug.Log("ELDER DIED");
        ownLocation = transform.position;
        Instantiate(soulObject, ownLocation, Quaternion.identity);
        Destroy(gameObject);
    }
}
