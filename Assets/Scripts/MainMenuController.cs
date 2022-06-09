using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void PlayGame(){
        Debug.Log("Created by Kevin Reynaldi-149251970100-51");
        SceneManager.LoadScene("MainGame");
    }
    public void OpenAuthor(){
        Debug.Log("Created by Kevin Reynaldi ");
    }
}
