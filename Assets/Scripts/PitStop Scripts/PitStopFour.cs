using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PitStopFour : MonoBehaviour
{
    public PitStopController pitStopController;

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
        if(other.gameObject.CompareTag("Player") && gameObject.CompareTag("Pit Stop 4"))
        {
            Debug.Log("Load Question 4 Triggered");
            pitStopController.pitStopFourPassed = true;
            pitStopController.pitStopThreePassed = false;
            SceneManager.LoadScene(7);
        }
    }
}
