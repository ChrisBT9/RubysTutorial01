using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
   [SerializeField]
    public Text scoreText;


    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Fixed Robots: " + 0;
    }

    // Update is called once per frame
    void UpdateScore(int score)
    {
        scoreText.text = "Fixed Robots: " + score.ToString();
    }



}
