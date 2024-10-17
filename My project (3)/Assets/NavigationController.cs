using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NavigationController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GoToIntroScene(){
        SceneManager.LoadScene(0);
    }
    public void GoToGameScene(){
        SceneManager.LoadScene(1);
    }
    public void GoToGameOverScene(){
         SceneManager.LoadScene(2);
    }
    public void GoToVictoryScene(){
         SceneManager.LoadScene(3);
    }
    public void Quit(){
         Application.Quit();
    }
}
