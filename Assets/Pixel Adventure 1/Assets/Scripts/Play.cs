using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
  public void PlayButton()
    {
        SceneManager.LoadScene("SampleScene");

    
    }
    public void mainMenu()
    {
        SceneManager.LoadScene("start");


    }
}
