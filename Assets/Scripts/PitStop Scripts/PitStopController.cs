using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PitStopController : MonoBehaviour
{
    public bool atStart = true;
    public bool pitStopOnePassed = false;
    public bool pitStopTwoPassed = false;
    public bool pitStopThreePassed = false;
    public bool pitStopFourPassed = false;
    public bool pitStopFivePassed = false;

    [SerializeField] public Vector3 pitStopOne = new Vector3(-180.4f, 0.21f, -1948.2f);
    [SerializeField] public Vector3 pitStopTwo = new Vector3(-312.7f, 0.21f, -1800.6f);
    [SerializeField] public Vector3 pitStopThree = new Vector3(-464.8f, 0.21f, -1728.3f);
    [SerializeField] public Vector3 pitStopFour = new Vector3(-357.7f, 0.21f, -1531.7f);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Collision Trigger Function triggers Question Scene(s)
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player") && gameObject.CompareTag("Pit Stop 1"))
        {
            Debug.Log("Load Question 1 Triggered.");
            pitStopOnePassed = true;
            atStart = false;
        }
    }
}
