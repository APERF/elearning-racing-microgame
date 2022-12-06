using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OilBarrelController : MonoBehaviour
{
    public PlayerController playerController;

    public bool barrelSlowdown = false;

    public float barrelSpeedDuration = 2f; 

    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.FindObjectOfType<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            barrelSlowdown = true;
            playerController.kartSpeed = 5f;
            StartCoroutine(BarrelSlowdown());
        }
    }

    IEnumerator BarrelSlowdown()
    {
        yield return new WaitForSeconds(barrelSpeedDuration);
        barrelSlowdown = false;
        playerController.kartSpeed = 20f;
    }
}
