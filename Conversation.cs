using UnityEngine;
using UnityEngine.SceneManagement;

public class Conversation : MonoBehaviour
{
    public Transform critter;
    public int conversationControl;
    public GameObject conversation1;

    // Update is called once per frame
    void Update()
    {
        //If the character is within a certain distance of the NPC
        if(critter.position.x >= -1.04 && critter.position.x <= 0.97 && critter.position.y >= 1.58 && critter.position.y <= 4.12)
        {
            //Further the conversation through the use of a variable
            conversationControl = 1;
        } else
        {
            //Otherwise, do not trigger the interaction
            conversationControl = 0;
        }
        //If the conversation is allowed to be triggered, do so by clicking space and making the UI appear
        if(Input.GetKey("space"))
        {
            if(conversationControl == 1)
            {
                conversation1.SetActive(true);
            }
        }
    }
}
