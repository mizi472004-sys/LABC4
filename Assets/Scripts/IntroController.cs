using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroController : MonoBehaviour
{
    public string gameplayScene = "GameScene";

    public void SkipIntro()
    {
        SceneManager.LoadScene(gameplayScene);
    }
}
