using UnityEngine;
using UnityEngine.SceneManagement;
public class SecretEndTrigger : MonoBehaviour {

    void OnTriggerEnter()
    {
        SceneManager.LoadScene(6);
    }
}
