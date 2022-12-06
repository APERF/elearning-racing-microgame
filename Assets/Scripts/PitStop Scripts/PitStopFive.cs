using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PitStopFive : MonoBehaviour
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
        if (other.gameObject.CompareTag("Player") && gameObject.CompareTag("Pit Stop 5"))
        {
            Debug.Log("Load Question 5 Triggered");
            pitStopController.pitStopFivePassed = true;
            pitStopController.pitStopFourPassed = false;
        }
    }
}
