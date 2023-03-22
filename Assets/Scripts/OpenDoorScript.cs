using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoorScript : MonoBehaviour
{
    private Animator doorAnimator;
    void Start()
    {
        doorAnimator = GameObject.Find("Door").GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.name.Equals("Player"));
        {
            doorAnimator.SetBool("StartDoorAnim1", true);
        }

    }
}
