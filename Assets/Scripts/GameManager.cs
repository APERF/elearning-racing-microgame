using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Player;

    public PitStopController pitStopController;

    public Vector3 playerStart;

    public Quaternion playerStartRotation;
    public Quaternion otherStartRotation;

    // Start is called before the first frame update
    void Start()
    {
        pitStopController = GameObject.FindObjectOfType<PitStopController>();

        playerStart = new Vector3(0, 0.21f, -1996);
        
        playerStartRotation = Quaternion.Euler(0f, 0f, 0f);
        otherStartRotation = Quaternion.Euler(0f, -90f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && gameObject.CompareTag("Ground") && pitStopController.atStart == true)
        {
            Debug.Log("On Ground & At Start");
            other.gameObject.transform.position = playerStart;
            other.gameObject.transform.rotation = playerStartRotation;
        }

        if (other.gameObject.CompareTag("Player") && gameObject.CompareTag("Ground") && pitStopController.pitStopOnePassed == true)
        {
            Debug.Log("On Ground & First Pitstop Passed");
            other.gameObject.transform.position = pitStopController.pitStopOne;
            other.gameObject.transform.rotation = otherStartRotation;
        }

        if (other.gameObject.CompareTag("Player") && gameObject.CompareTag("Ground") && pitStopController.pitStopTwoPassed == true)
        {
            Debug.Log("On Ground & Second Pitstop Passed");
            other.gameObject.transform.position = pitStopController.pitStopTwo;
            other.gameObject.transform.rotation = playerStartRotation;
        }

        if (other.gameObject.CompareTag("Player") && gameObject.CompareTag("Ground") && pitStopController.pitStopThreePassed == true)
        {
            Debug.Log("On Ground & Third Pitstop Passed");
            other.gameObject.transform.position = pitStopController.pitStopThree;
            other.gameObject.transform.rotation = otherStartRotation;
        }

        if (other.gameObject.CompareTag("Player") && gameObject.CompareTag("Ground") && pitStopController.pitStopFourPassed == true)
        {
            Debug.Log("On Ground & Fourth Pitstop Passed");
            other.gameObject.transform.position = pitStopController.pitStopFour;
            other.gameObject.transform.rotation = playerStartRotation;
        }
    }
}
