using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{

    void Onclick()
    {
        LoadMenu();
    }

    public void LoadMenu()
    {
        
        SceneManager.LoadScene("menu");
    }
}

