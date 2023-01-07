using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoulInteractible : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip audioPickupSoul;

    public void Harvest()
    {
        audioSource.PlayOneShot(audioPickupSoul);
        Destroy(gameObject);
    }
}
