using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LongSpeedUp : MonoBehaviour
{
    private float longPowerUpDuration = 5.8f;

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
            playerController.kartSpeed = 40f;
            playerController.turboEngineSound.Play();
            StartCoroutine(LongPowerUpEffect());
        }
    }

    IEnumerator LongPowerUpEffect()
    {
        yield return new WaitForSeconds(longPowerUpDuration);
        longSpeedUpActivated = false;
        playerController.kartSpeed = 20f;
        playerController.turboEngineSound.Stop();
    }
}
