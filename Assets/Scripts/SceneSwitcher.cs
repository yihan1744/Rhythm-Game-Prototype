using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    //all public methods, so can be accessed by UI
    public void LoadMenuScene(){
        SceneManager.LoadScene("MenuScene"); 
    }

    public void LoadGameplayScene(){
        SceneManager.LoadScene("GameplayScene"); 
    }

}