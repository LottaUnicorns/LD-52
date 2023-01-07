using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewLifeSequence : MonoBehaviour
{
    [SerializeField] float deathDelay = 3f;


    void Start()
    {
        Invoke("EndOfSequence", deathDelay);
    }

    // Update is called once per frame
    void EndOfSequence()
    {
        Destroy(gameObject);
    }
}
