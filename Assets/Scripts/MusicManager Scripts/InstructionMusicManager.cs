using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InstructionMusicManager : MonoBehaviour
{
    public static InstructionMusicManager Instance;

    public AudioSource bgSource;

    // Start is called before the first frame update
    void Start()
    {
        //Creating Singleton
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(this.gameObject);

        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        //Trying to make script disable or enable music on specific scene names
        if (scene.name == "InstructionScreen")
        {
            bgSource.Play();
        }

        else if (scene.name == "MainTrackScene")
        {
            bgSource.Stop();
        }
    }
}
