using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LongSpeedUp : MonoBehaviour
{
    [SerializeField] private float longPowerUpDuration = 5f;

    public PlayerController playerController;
    
    public bool longSpeedUpActivated = false;

    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.FindObjectOfType<PlayerController>();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            longSpeedUpActivated = true;
            playerController.kartSpeed = 35f;
            StartCoroutine(LongPowerUpEffect());
        }
    }

    IEnumerator LongPowerUpEffect()
    {
        yield return new WaitForSeconds(longPowerUpDuration);
        longSpeedUpActivated = false;
        playerController.kartSpeed = 20f;
    }
}
