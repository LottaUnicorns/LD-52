using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI dialogueText;
    [SerializeField] GameObject dialoguePanel;
    [SerializeField] string[] lines;
    [SerializeField] float textSpeed;
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip audioTalking;
    bool dialogStarted = false;
    
    int index = 0;

    // Start is called before the first frame update
    void Start()
    {
    //    dialogueText.text = string.Empty;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && dialogStarted == true)
        {
            if (dialogueText.text == lines[index])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                dialogueText.text = lines[index];
            }
        }
    }

    public void StartDialogue()
    {
        dialogStarted = true;
        dialogueText.text = string.Empty;
        dialoguePanel.SetActive(true);
        StartCoroutine(TypeLine());
        audioSource.PlayOneShot(audioTalking);       
    }

    IEnumerator TypeLine()
    {
        // type each character 1 by 1
        foreach (char item in lines[index].ToCharArray())
        {
            dialogueText.text += item;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    void NextLine()
    {
        if (index < lines.Length - 1)
        {
            index++;
            dialogueText.text = string.Empty;
            StartCoroutine(TypeLine());
            audioSource.PlayOneShot(audioTalking);
        }
        else
        {
            dialoguePanel.SetActive(false);
            dialogStarted = false;
        }
    }
}
