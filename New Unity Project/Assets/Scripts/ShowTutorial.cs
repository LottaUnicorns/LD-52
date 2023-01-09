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
            if (tutorialPanel == false)
            {
                tutorialPanel.SetActive(true);
            }
            else if (tutorialPanel == true)
            {
                tutorialPanel.SetActive(true);
            }
            
        }
    }
}
