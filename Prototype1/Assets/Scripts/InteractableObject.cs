using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    public GameObject blockade;
    public Sprite spriteChange;
    public bool isOpen;
    public bool isChest = false;
    public bool isFakeChest = false;

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
        

    }

}
