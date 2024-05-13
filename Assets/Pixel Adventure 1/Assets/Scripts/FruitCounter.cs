using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class FruitCounter : MonoBehaviour
{
    public static FruitCounter instance;
    public TMP_Text fruitText;
    public int currentFruit = 0;
    public GameOverScreen gameOverScreen;
   
    public void GameOver()
    {
        gameOverScreen.Setup(currentFruit);
    }
    void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        fruitText.text = "Fruits: " + currentFruit.ToString();
    }

    public void IncreaseFruits(int v)
    {
        currentFruit += v;
        fruitText.text = "Fruits: " + currentFruit.ToString();
    }
}
