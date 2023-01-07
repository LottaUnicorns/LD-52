using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemTracker : MonoBehaviour
{
    // Start is called before the first frame update
    int collectibleCount = 0;
    int wishCount = 0;
    int soulCount = 0;
    [SerializeField] float interactRange = 2f;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRange);
            foreach (Collider collider in colliderArray)
            {
                // INTERACT WITH ELDER ----------------------------------
                if (collider.TryGetComponent(out NPCInteractable npcInteractable))
                {
                    if (collectibleCount > 0)
                    {
                        InteractibleCount();
                        npcInteractable.Interact(); //Tells the NPC Interactable script to run! 
                    }
                    else if (wishCount < 1)
                    {
                        AskWish();
                        npcInteractable.GiveWish();
                    }
                }

                // INTERACT WITH SOUL ----------------------------------
                if (collider.TryGetComponent(out SoulInteractible soulInteractable))
                {
                    SoulCount();
                    soulInteractable.Harvest();
                }


                // INTERACT WITH PICKUP ----------------------------
                else if (collider.TryGetComponent(out CollectibleInteractable collectibleInteractable) && collectibleCount < 1)
                {
                    collectibleInteractable.Collect(); //Tells the NPC Interactable script to run!
                    CollectibleCount();
                }

                // INTERACT WITH CRIB ----------------------------------
                if (collider.TryGetComponent(out CribInteractable cribInteractable))
                {
                    if (soulCount > 0)
                    {
                        SouldDeposit();
                        cribInteractable.CreateLife();
                    }
                }
            }
        }
    }

    //    COLLECTIBLE METHODS ----------------------------------------
    void CollectibleCount()
    {
        collectibleCount++;
        Debug.Log("player picked up : " + collectibleCount);
    }

    //    ELDER METHODS ----------------------------------------
    void InteractibleCount()
    {
        Debug.Log("player gave elder : " + collectibleCount);
    }

    void AskWish()
    {
        wishCount++;
        Debug.Log("PLAYER: What is your wish?");
    }

    //    SOUL METHODS ----------------------------------------
    void SoulCount()
    {
        soulCount++;
        Debug.Log("Souls in storage is : " + soulCount);
    }

    void SouldDeposit()
    {
        
        soulCount--;
        Debug.Log("Souls in storage is : " + soulCount);
        
    }
}