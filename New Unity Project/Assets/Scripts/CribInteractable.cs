using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CribInteractable : MonoBehaviour
{
    [SerializeField] GameObject newLife;

    public void CreateLife()
    {
        Debug.Log("Crib: One life was created!");
        Instantiate(newLife, Vector3.zero, Quaternion.identity);
    }
}
