using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    [SerializeField] public Canvas settings;

  

  

    private void Update() {

        if(Input.GetKeyDown(KeyCode.Escape)){

            settings.enabled = !settings.enabled;

        }

    }
        
     public void Quitting()
    {
        Application.Quit();
    }
        
    
    public void Restart(){
        SceneManager.LoadScene("youtets", LoadSceneMode.Single);
       
    }
    public class MenuButton : MonoBehaviour
{
    public void LoadMenu()
    {
        
        SceneManager.LoadScene("menu", LoadSceneMode.Single);
    }
}
   
}
