using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CribInteractable : MonoBehaviour
{
    [SerializeField] GameObject newLife;
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip audioSoulDeposit;

    public void CreateLife()
    {
        audioSource.PlayOneShot(audioSoulDeposit);
        Instantiate(newLife, Vector3.zero, Quaternion.identity);
    }
}
