using UnityEngine;
using UnityEngine.SceneManagement;

public class Settings : MonoBehaviour
{
    public PlayerMovement PlayerSpeed1;
    public PlayerMovement PlayerSpeed2;
    public PlayerMovement PlayerSpeed3;

    public void easy()
    {
        PlayerSpeed1.forwardForce = 4000f;
        PlayerSpeed2.forwardForce = 4000f;
        PlayerSpeed3.forwardForce = 4000f;
    }

    public void StartNow()
    { 
        SceneManager.LoadScene(1);
    }

    public void GoBack()
    {
        SceneManager.LoadScene(0);
    }

}
