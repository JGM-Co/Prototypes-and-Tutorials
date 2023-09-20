using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorCollision : MonoBehaviour
{
    private void OnTriggerEnter2D()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
