using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LowWallController : MonoBehaviour
{
    private PitStopController pitStopController;
    private GameManager gameManager;

    void Start()
    {
        pitStopController = GameObject.FindObjectOfType<PitStopController>();
        gameManager = GameObject.FindObjectOfType<GameManager>();
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            other.gameObject.transform.position = pitStopController.pitStopThree;
            other.gameObject.transform.rotation = gameManager.otherStartRotation;
        }
    }
}
