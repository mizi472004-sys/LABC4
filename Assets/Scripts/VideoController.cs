using UnityEngine;
using UnityEngine.Video;

public class VideoController : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public GameObject endUI; // UI hiện khi video xong

    void Start()
    {
        videoPlayer.prepareCompleted += OnPrepared;
        videoPlayer.loopPointReached += OnVideoEnd;

        videoPlayer.Prepare();
    }

    void OnPrepared(VideoPlayer vp)
    {
        vp.Play();
    }

    void OnVideoEnd(VideoPlayer vp)
    {
        if (endUI != null)
            endUI.SetActive(true);

        Debug.Log("Video kết thúc");
    }
}
