using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bat : MonoBehaviour
{
    

   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector3(0,0,-.1f));
            //transform.Rotate(new Vector3(0, 45, 0));
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //transform.Rotate(new Vector3(0, 45, 0));
            transform.Translate(new Vector3(0, 0, .1f));
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
        }
    }
   



}
