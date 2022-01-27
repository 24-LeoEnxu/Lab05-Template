using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static int coins = 0;

    // Start is called before the first frame update
    void Start()
    {
        coins = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (coins >= 6)
        {
            SceneManager.LoadScene("WinScene");
        }
    }
}
