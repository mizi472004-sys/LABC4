using UnityEngine;

public class GlobalAudioController : MonoBehaviour
{
    bool muted = false;
    bool paused = false;

    void Update()
    {
        // Mute / Unmute
        if (Input.GetKeyDown(KeyCode.M))
        {
            muted = !muted;
            AudioListener.volume = muted ? 0f : 1f;
        }

        // Pause / Resume
        if (Input.GetKeyDown(KeyCode.P))
        {
            paused = !paused;
            AudioListener.pause = paused;
        }
    }
}
