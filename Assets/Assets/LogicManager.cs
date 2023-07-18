using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicManage : MonoBehaviour
{
    public int PlayerScore;
    public Text ScoreText;
    public LogicManage logic;
    public bool BooIsActive = true;
    // Start is called before the first frame update
    public GameObject gameoverScreen;
    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        PlayerScore = PlayerScore + scoreToAdd;
        ScoreText.text = PlayerScore.ToString();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManage>();
    }
    public void reStartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameoverScreen.SetActive(true);
    }



}
