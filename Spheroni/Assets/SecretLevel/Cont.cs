using UnityEngine;
using UnityEngine.SceneManagement;

public class Cont : MonoBehaviour {

    void OnTriggerEnter()
    {
        SceneManager.LoadScene(3);
    }
}
