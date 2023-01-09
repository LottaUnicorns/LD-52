using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowTutorial : MonoBehaviour
{
    [SerializeField] GameObject tutorialPanel;
    
    // Start is called before the first frame update
    void Start()
    {
        tutorialPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (tutorialPanel.activeSelf == true)
            {
                tutorialPanel.SetActive(false);
            }

            else if (tutorialPanel.activeSelf == false)
            {
                tutorialPanel.SetActive(true);
            }

        }
    }
}
