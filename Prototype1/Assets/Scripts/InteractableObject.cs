using UnityEngine;

public class InteractableObject : MonoBehaviour
{
   
    public void DoInteraction()
    {
        //
        gameObject.SetActive(false);
        DoorController dn = gameObject.GetComponent<DoorController>();
       
    }

}
