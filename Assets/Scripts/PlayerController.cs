using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;

    private StartRaceManager startRaceManager;
    public PitStopController pitStopController;

    private float horizontalInput;
    private float verticalInput;
    public float kartSpeed = 20f;
    private float turnSpeed = 90f;
    private float jumpForce = 375f;

    public bool inAir = false;
    public bool jumpPowerUpActivated = false;

    public AudioSource accelEngineSound;
    public AudioSource turboEngineSound;
    public AudioSource jumpSound;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();

        pitStopController = GameObject.FindObjectOfType<PitStopController>();
    }

    // Update is called once per frame
    void Update()
    {
        //Getting Input Axis for player control
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        //Setting Movement tied to player controls
        if (pitStopController.raceStarted == true)
        {
            transform.Translate(Vector3.forward * verticalInput * kartSpeed * Time.deltaTime);
            transform.Rotate(Vector3.up * horizontalInput * turnSpeed * Time.deltaTime);
        }
        
        if(Input.GetKey(KeyCode.Space) && jumpPowerUpActivated == true && inAir == false)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            inAir = true;
            jumpSound.Play();
        }

        if(Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
            Debug.Log("Game Exited");
        }

        if(Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            accelEngineSound.Play();
        }

        else if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.DownArrow))
        {
            accelEngineSound.Stop();
        }
    }

    public void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Track"))
        {
            inAir = false;
            jumpSound.Stop();
        }
    }
}
