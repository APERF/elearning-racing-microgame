using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PitStopTwo : MonoBehaviour
{
    private PitStopController pitStopController;

    // Start is called before the first frame update
    void Start()
    {
        pitStopController = GameObject.FindObjectOfType<PitStopController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && gameObject.CompareTag("Pit Stop 2"))
        {
            Debug.Log("Load Question 2 Triggered.");
            pitStopController.pitStopTwoPassed = true;
            pitStopController.pitStopOnePassed = false;
            SceneManager.LoadScene(6);
        }
    }
}
