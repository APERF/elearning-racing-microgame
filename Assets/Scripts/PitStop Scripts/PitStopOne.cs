using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PitStopOne : MonoBehaviour
{
    private PitStopController pitStopController; 

    // Start is called before the first frame update
    void Start()
    {
        pitStopController = GameObject.FindObjectOfType<PitStopController>();
    }

    //Collision Trigger Function triggers Question Scene(s)
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && gameObject.CompareTag("Pit Stop 1"))
        {
            Debug.Log("Load Question 1 Triggered.");
            pitStopController.atStart = false;
            pitStopController.pitStopOnePassed = true;
            SceneManager.LoadScene(4);
        }
    }
}
