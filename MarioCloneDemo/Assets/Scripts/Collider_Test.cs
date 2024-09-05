using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider_Test : MonoBehaviour
{

    private void OnCollisionEnter2D(){
        Debug.Log("Enter");
    }

    private void OnCollisionExit2D(){
        Debug.Log("Exit");
    }
    
    private void OnCollisionStay2D(){
        Debug.Log("Stay");
    }

    private void OnTriggerEnter2D(){
        Debug.Log("Trigger Enter");
    }

    private void OnTriggerExit2D(){
        Debug.Log("Trigger Exit");
    }

    private void OnTriggerStay2D(){
        Debug.Log("Trigger Stay");
    }
}
