using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject player;


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Hookable")
        {
            player.GetComponent<GrapplingHook>().hooked = true;
        }
    }
}
