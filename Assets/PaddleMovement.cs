using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PaddleMovement : MonoBehaviour
    
{
    float moveSpeed = 5f;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
       
        rb = GetComponent<Rigidbody>();
       
        //paddleRigidbody = GetComponent<Rigidbody>();
        //transform.position = new Vector3(0, 4.96f, 0);


    }

    // Update is called once per frame
    void Update()
    {
        float horizontalIn = 0f;
        float verticalInt = 0f;

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            horizontalIn = 1f;
        }
        else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            horizontalIn = -1f;
        }

        Vector3 movement = new Vector3(horizontalIn, 0f, verticalInt) * moveSpeed * Time.deltaTime;
        rb.MovePosition(rb.position + movement);


    }
    private void FixedUpdate()
    {
        //if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        //{
          //  transform.position += new Vector3(5, 0, 0) * Time.deltaTime;
        //}
        //if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        //{
          //  transform.position += new Vector3(-5, 0, 0) * Time.deltaTime;
        //}
    }

}
