using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class GameOverScreen : MonoBehaviour{

    
    public TMP_Text finalFruit;
    public void Setup(int score)
    {
        gameObject.SetActive(true);
        finalFruit.text = score.ToString() + "Fruit";
    }
     

}
