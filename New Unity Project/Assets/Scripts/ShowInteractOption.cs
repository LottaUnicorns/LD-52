using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ShowInteractOption : MonoBehaviour
{
    [SerializeField] Canvas interactOptionCanvas;

    private void Start()
    {
        interactOptionCanvas.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        interactOptionCanvas.enabled = true;
    }

    private void OnTriggerExit(Collider other)
    {
        interactOptionCanvas.enabled = false;
    }
}
