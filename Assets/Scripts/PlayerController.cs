using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;

    private float horizontalInput;
    private float verticalInput;
    public float kartSpeed = 20f;
    public float turnSpeed = 10f;
    public float jumpForce = 10f;

    public bool inAir = false;
    public bool jumpPowerUpActivated = false;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Getting Input Axis for player control
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        //Setting Movement tied to player controls
        transform.Translate(Vector3.forward * verticalInput * kartSpeed * Time.deltaTime);
        transform.Rotate(Vector3.up * horizontalInput * turnSpeed * Time.deltaTime);

        if(Input.GetKey(KeyCode.Space) && jumpPowerUpActivated == true && inAir == false)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            inAir = true;
        }
    }

    public void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Track"))
        {
            inAir = false;
        }
    }
}
