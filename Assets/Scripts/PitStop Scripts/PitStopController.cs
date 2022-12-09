using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PitStopController : MonoBehaviour
{
    public static PitStopController Instance;

    public bool atStart = true;
    public bool pitStopOnePassed = false;
    public bool pitStopTwoPassed = false;
    public bool pitStopThreePassed = false;
    public bool pitStopFourPassed = false;

    [SerializeField] public Vector3 pitStopOne = new Vector3(-180.4f, 0.32f, -1948.2f);
    [SerializeField] public Vector3 pitStopTwo = new Vector3(-312.7f, 0.32f, -1800.5f);
    [SerializeField] public Vector3 pitStopThree = new Vector3(-464.8f, 0.32f, -1728.3f);
    [SerializeField] public Vector3 pitStopFour = new Vector3(-357.7f, 0.32f, -1531.7f);

    public void Start()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(this.gameObject);
    }
}
