using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrapplingHook : MonoBehaviour
{
    public GameObject hook;
    public GameObject hookHolder;

    public float hookTravelSpeed;
    public float playerTravelSpeed;

    public static bool fired;
    public  bool hooked;

    public float maxDistance;
    private float currentDistance;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //firing the hook
        if(Input.GetMouseButton(0) && fired == false)
            fired = true;

        if(fired == true && hooked == false)
        {
            hook.transform.Translate(Vector3.forward * Time.deltaTime * hookTravelSpeed);
            currentDistance = Vector3.Distance(transform.position, hook.transform.position);

            if (currentDistance >= maxDistance)
                ReturnHook();
             
        }


        if (hooked == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, hook.transform.position, playerTravelSpeed);
            float distanceToHook = Vector3.Distance(transform.position, hook.transform.position);

            if (distanceToHook < 1)
                ReturnHook();
        }
        


        

    }

     void ReturnHook()
    {
        hook.transform.position = hookHolder.transform.position;
        fired = false;
        hooked = false;
    }
}
