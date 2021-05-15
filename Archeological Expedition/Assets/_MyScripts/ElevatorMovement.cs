using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class ElevatorMovement : MonoBehaviour
{
    // This script was used in the VR multiplayer project. 

    public Animator animController;
    public GameObject upButton;
    public GameObject downButton;

    private void OnTriggerEnter(Collider elevator)
    {
        if (elevator.gameObject.tag != "Player")
            return;
        Debug.Log(elevator.gameObject.name + " has entered");
        if (gameObject.tag == "Up Button")
        {
            Debug.Log("Going Up");
            animController.SetBool("going Up", true);
            downButton.GetComponent<BoxCollider>().enabled = true;
        }
        else if (gameObject.tag == "Down Button")
        {
            Debug.Log("Going Down");
            animController.SetBool("going Down", true);
            upButton.GetComponent<BoxCollider>().enabled = true;
        }

        gameObject.GetComponent<BoxCollider>().enabled = false;
    }

    private void OnTriggerExit(Collider elevator)
    {
        if (elevator.gameObject.tag != "Player")
            return;
        Debug.Log(elevator.gameObject.name + "has exited");
        if(gameObject.tag == "Up Button")
        {
            animController.SetBool("going Up", false);
        }
        else if(gameObject.tag == "Down Button")
        {
            animController.SetBool("going Down", false);
        }
    }
}
