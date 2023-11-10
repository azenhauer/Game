using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    public BoxCollider finish;
    public Canvas winner;
    
     
     
     private void Start () {

        winner.enabled = false;
        
     }
     private void OnTriggerEnter(Collider other)
{
    winner.enabled = true;
    Debug.Log("Collision detected!");
    if (other.CompareTag("Collider"))
    {
        winner.enabled = true;
    }
}

    public void NewGame(){
        SceneManager.LoadScene("youtets");
       
    }
}
