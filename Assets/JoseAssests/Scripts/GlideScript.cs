using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlideScript : MonoBehaviour
{
   public float speed = 30.0f;
    
    


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("charcter script added to:" + gameObject);

       

    }

    // Update is called once per frame
    void Update()
    {

        
        {

            transform.Rotate(Input.GetAxis("Vertical"), 0.0f, -Input.GetAxis("Horizontal"));
            transform.position += transform.forward * Time.deltaTime * 90.0f;
            speed -= transform.forward.y * 50.0f;








        }


        if (speed < 35.0f)
        {
            speed = 35.0f;
        }


        
       
    }


       
}
