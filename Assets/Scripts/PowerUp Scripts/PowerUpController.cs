using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpController : MonoBehaviour
{
    public PlayerController playerController;

    [SerializeField] private float powerUpDuration = 2f;
    
    public bool speedUpActivated = false;

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
        if (other.gameObject.CompareTag("Player"))
        {
            speedUpActivated = true;
            playerController.kartSpeed = 35f;
            StartCoroutine(PowerUpEffect());
        }
    }

    IEnumerator PowerUpEffect()
    {
        yield return new WaitForSeconds(powerUpDuration);
        speedUpActivated = false;
        playerController.kartSpeed = 20f;
    }
}
