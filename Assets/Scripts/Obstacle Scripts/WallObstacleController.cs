using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallObstacleController : MonoBehaviour
{
    public GameManager gameManager;
    public PitStopController pitStopController;
    
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.FindObjectOfType<GameManager>();
        pitStopController = GameObject.FindObjectOfType<PitStopController>();
    }

    public void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.CompareTag("Player") && pitStopController.pitStopOnePassed == true)
        {
            Debug.Log("Hit Wall & First Pitstop Passed");
            other.gameObject.transform.position = pitStopController.pitStopOne;
            other.gameObject.transform.rotation = gameManager.otherStartRotation;
        }

        if (other.gameObject.CompareTag("Player") && pitStopController.pitStopTwoPassed == true)
        {
            Debug.Log("Hit Wall & Second Pitstop Passed");
            other.gameObject.transform.position = pitStopController.pitStopTwo;
            other.gameObject.transform.rotation = gameManager.playerStartRotation;
        }

        if (other.gameObject.CompareTag("Player") && pitStopController.pitStopFourPassed == true)
        {
            Debug.Log("Hit Wall & Fourth Pitstop Passed");
            other.gameObject.transform.position = pitStopController.pitStopFour;
            other.gameObject.transform.rotation = gameManager.playerStartRotation;
        }
    }
}
