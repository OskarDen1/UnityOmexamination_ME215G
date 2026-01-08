using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHandler : MonoBehaviour
{
    public static SceneHandler Instance { get; private set; }

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            transform.SetParent(null);
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void LoadScene(string name)
    {
        SceneManager.LoadScene(name);
    }

    public void LoadGameScene()
    {
        Scene scene = SceneManager.GetSceneByName("GameScene");
        if (scene.isLoaded) return;
        SceneManager.LoadScene("GameScene");
    }

    public void LoadSettingScene()
    {
        Scene scene = SceneManager.GetSceneByName("SettingScene");
        if (scene.isLoaded) return;
        SceneManager.LoadScene("SettingScene", LoadSceneMode.Additive);
    }
}