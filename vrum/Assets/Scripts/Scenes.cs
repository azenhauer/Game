using UnityEngine;
using UnityEngine.SceneManagement; 

public class NewBehaviourScript : MonoBehaviour
{
    public void PlayGame()
    {
       
        SceneManager.LoadScene("youtets",LoadSceneMode.Single);
    }

    public void QuitGame()
    {
        
        Application.Quit();
    }
}
