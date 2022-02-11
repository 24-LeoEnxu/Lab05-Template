using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static int coins = 0;
    public float time = 40f;
    float timeLeft;
    public Text coinsLeft;
    public Text timer;

    // Start is called before the first frame update
    void Start()
    {
        coins = 0;
        time = 40f;
    }

    // Update is called once per frame
    void Update()
    {
        coinsLeft.text = "Coins Left: " + coins + "/6";

        timeLeft = time -= Time.deltaTime;

        timer.text = "Time Left: " + timeLeft.ToString("0.00");

        if (coins >= 6)
        {
            SceneManager.LoadScene("WinScene");
        }

        if (timeLeft <= 0)
        {
            SceneManager.LoadScene("LoseScene");
        }
    }
}
