using UnityEngine;
using UnityEngine.SceneManagement;

public class Conversation : MonoBehaviour
{
    public GameObject critter;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("space") && SceneManager.GetActiveScene().name == "Critter Explores House")
        {

        }
    }
}
