using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    private int score = 0;

    private Rigidbody playerRigidBody;
    private void Start()
    {
        playerRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);
        playerRigidBody.velocity = movement * speed;
    }

    private void OnTriggerEnter(Collider other) 
    {
        score++;
        Debug.Log("Score: " + score);
        Destroy(other.gameObject);
    }
}
