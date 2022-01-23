using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{

    public int enemiesCount = 0;
    [SerializeField] GameObject[] enemies;


    public bool playerFailCheck = false;

    private void Awake()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
        enemiesCount = enemies.Length;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);        
    }

    public void resumeGame()
    {
        PlayerData data = SaveSystem.LoadPlayer();
        SceneManager.LoadScene(data.levelIndex);
    }

}
