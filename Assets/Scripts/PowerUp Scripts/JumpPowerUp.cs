using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPowerUp : MonoBehaviour
{
    public float jumpDuration = 7.5f;

    public PlayerController playerController;

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
            playerController.jumpPowerUpActivated = true;
            StartCoroutine(JumpPowerEffect());
        }
    }

    IEnumerator JumpPowerEffect()
    {
        yield return new WaitForSeconds(jumpDuration);
        playerController.jumpPowerUpActivated = false;
    }
}
