using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PitStopThree : MonoBehaviour
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
        if (other.gameObject.CompareTag("Player") && gameObject.CompareTag("Pit Stop 3"))
        {
            Debug.Log("Load Question 3 Triggered");
            pitStopController.pitStopThreePassed = true;
            pitStopController.pitStopTwoPassed = false;
            SceneManager.LoadScene(6);
        }
    }
}
