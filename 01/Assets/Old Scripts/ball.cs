using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    Vector3 reset = new Vector3(0, 0, 0);
    public Rigidbody rb;
    public GameObject sphere;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        bowl();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.R))
        {
            rb.AddForce(new Vector3(0, 0, 0));
            transform.position = new Vector3(-10.4f, 2.5f, 1);
            
            bowl();
        }


    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "wk")
        {
            rb.AddForce(new Vector3(0, 0, 0));
            transform.position = new Vector3(-10.4f, 2.5f, 1);


        }
    }
    void bowl()
    {
        transform.position = new Vector3(-10.4f, 2.5f, 1);
        rb.AddForce(new Vector3(150, 0, 0));
    }

}
