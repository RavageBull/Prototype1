using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    public GameObject blockade;
    public Sprite spriteChange;
    public bool isOpen;
    public bool isChest;
    public bool isFakeChest;
    public bool isPot;
    public bool isBox;
    public bool isBarrel;
    public GameObject playerChoice;
    public GameObject aiChoice;

    public void DoInteraction()
    {
        //
        // gameObject.SetActive(false);

        if (isChest == true)
        {
            GetComponent<SpriteRenderer>().sprite = spriteChange;
            if (isFakeChest == true)
            {
                print("u died");

            }
        }


        if (isOpen == false && isChest == false)
        {
            blockade.GetComponent<Blockade>().Open();
            GetComponent<SpriteRenderer>().sprite = spriteChange;
            isOpen = true;
        }

        if (isPot == true)
        {
            playerChoice.GetComponent<PlayerChosen>().potChange();
            aiChoice.GetComponent<AiChosen>().potChange();
        }

        if (isBox == true)
        {
            playerChoice.GetComponent<PlayerChosen>().boxChange();
            aiChoice.GetComponent<AiChosen>().boxChange();
        }
        if (isBarrel == true)
        {
            playerChoice.GetComponent<PlayerChosen>().barrelChange();
            aiChoice.GetComponent<AiChosen>().barrelChange();
        }


    }

}
