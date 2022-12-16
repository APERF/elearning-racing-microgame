using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMusicManager : MonoBehaviour
{
    public static GameMusicManager Instance;

    public AudioSource bgMusic;

    // Start is called before the first frame update
    void Start()
    {
        if(Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(this.gameObject);

        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    public void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Debug.Log("On Scene Loaded" + scene.name);

        if(scene.name == "MainTrackScene")
        {
            bgMusic.Play();
        }

        else if(scene.name == "Question1Scene" || scene.name == "Question2Scene" || scene.name == "Question3Scene" || scene.name == "Question4Scene")
        {
            bgMusic.Pause();
        }

        else if(scene.name == "MainTrackScene2" || scene.name == "MainTrackScene3" || scene.name == "MainTrackScene4" || scene.name == "MainTrackScene5")
        {
            bgMusic.UnPause();
        }

        else if(scene.name == "Question5Scene")
        {
            bgMusic.Stop();
        }
    }
}
