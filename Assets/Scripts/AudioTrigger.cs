using UnityEngine;

public class AudioTrigger : MonoBehaviour
{
    public AudioSource audioSource;

    void Update()
    {
        // Nhấn Space để phát âm thanh
        if (Input.GetKeyDown(KeyCode.Space))
        {
            audioSource.Play();
        }

        // Nhấn S để dừng âm thanh
        if (Input.GetKeyDown(KeyCode.S))
        {
            audioSource.Stop();
        }
    }
}
