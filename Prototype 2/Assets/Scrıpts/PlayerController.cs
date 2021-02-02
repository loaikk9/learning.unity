using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float VerticalInput;
    public float speed = 20f;
    public float xRange = 17.0f;

    public GameObject projectilePrefab;

    void Start()
    {
        
    }

   
    void Update()
    {
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3( -xRange , transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3( xRange , transform.position.y, transform.position.z);
        }

        horizontalInput = Input.GetAxis("Horizontal");
       // VerticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        //transform.Translate(new Vector3(horizontalInput, 0, VerticalInput) * (speed * Time.deltaTime));

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.transform.rotation);
           //yanı copy
        }
    }
}
