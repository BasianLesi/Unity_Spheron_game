using UnityEngine;
using UnityEngine.Audio;

public class Music : MonoBehaviour {

    public AudioSource GameMusic;
    bool musicFlag = true;

    public void Onoff()
    {
        if (musicFlag)
        {
            GameMusic.volume = 0f;
            musicFlag = false;
        }
        else
        {
            GameMusic.volume = 1f;
            musicFlag = true;
        }
    
    }
    

}
