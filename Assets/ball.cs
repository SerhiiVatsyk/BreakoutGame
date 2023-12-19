using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEditor;
using UnityEngine;

public class ball : MonoBehaviour
{
    float speed = 4f;

    Rigidbody ballRigidbody;

    Vector3 velocity;
   
   

    private void Start()
    {
       ballRigidbody = GetComponent<Rigidbody>();
        ballRigidbody.velocity = Vector3.down * speed;
        
       
    }

    // Update is called once per frame
    void Update()
    {

        
        
        float speed = 4;
        ballRigidbody.velocity = ballRigidbody.velocity.normalized * speed;
        if (gameObject.transform.position == (new Vector3(0, 4.9f, 0)))
        {
            gameObject.transform.position = (new Vector3(0, 6.5f, 0));
        }
    }
    
    public void OnCollisionEnter(Collision collision)
    {
        GameObject otherGameObject = collision.gameObject;
        Enemy hitEnemy = otherGameObject.GetComponent<Enemy>();

        if (hitEnemy != null)
        {
            hitEnemy.TakeDamge();
        }
        
        
    }
  
       



}
