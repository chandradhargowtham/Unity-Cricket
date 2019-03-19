using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamemanager : MonoBehaviour
{
    Rigidbody rb;
    public GameObject ball1;
    public GameObject ballpresent;
    public GameObject ballpast;
    float speed = 1f;
    static bool flag = false;
    
   
    // Start is called before the first frame update
    void Start()
    {
        //if () check and remove old
        { }
        rb = GetComponent<Rigidbody>();
        //Destroy(ball1);
        //newBall();
        //paceBowl();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {if(flag==true)
            {
                Debug.Log("Still Alive"); 
            }else
            newBall();
        }
        StartCoroutine(killa());
    }
    public void paceBowl()
    {
        rb.AddForce(new Vector3(Random.Range(600, 1000), Random.Range(80, 200), Random.Range(-50, 60)));
        

    }
    public void spinBowl()
    {
        rb.AddForce(new Vector3(Random.Range(600, 1000), Random.Range(180, 260), Random.Range(-50, 60)));
    }
    public void newBall()
    {
        if (ballpresent == null)
        {
             flag = false;
        }
            if (flag == true)
        {
            
            Destroy(ballpast);
            flag = false;
        }
        else
        {
            ballpast = ballpresent;
            ballpresent =Instantiate(ball1, new Vector3(-8.5f, 08, -1), Quaternion.identity);

            flag = true;
            //spinBowl();
            paceBowl();
            
        }
    }
    IEnumerator killa()
    {
        yield return new WaitForSeconds(6);
        Destroy(ball1);
        flag = false;
    }

    }
