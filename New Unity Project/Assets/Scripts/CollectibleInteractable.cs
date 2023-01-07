using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleInteractable : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip audioPickup;
    
    // Start is called before the first frame update
    public void Collect()
    {
        audioSource.PlayOneShot(audioPickup);
        Invoke("DestroyMe", 2f);
        
    }

    private void DestroyMe()
    {
        Destroy(gameObject);
    }
}
