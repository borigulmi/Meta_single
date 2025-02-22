using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; } // ? ½Ì±ÛÅæ ÆÐÅÏ Àû¿ë

    public GameObject endPanel;
    public Text scoreText;
    public Text nowScoreText;
    public Text bestScoreText;
    public Button retryBtn;
    public Animator anime;

    private int currentScore = 0;
    private int bestScore = 0;
    private int nowScore = 0;

    private void Awake()
    {
        if (Instance == null)  // ? ½Ì±ÛÅæ ÆÐÅÏ ¼³Á¤
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        bestScore = PlayerPrefs.GetInt("BestScore", 0);
    }

    private void Start()
    {
        scoreText.text = "Score: " + currentScore.ToString("N2");
        bestScoreText.text = "Best Score: " + bestScore.ToString("N2");
        retryBtn.onClick.AddListener(RestartGame);
    }

    public void AddScore(int score)
    {
        currentScore += score;
        scoreText.text = "Score: " + currentScore.ToString("N2");
    }

    public void GameOver()
    {
        nowScore = currentScore;
        nowScoreText.text = "Now Score: " + nowScore.ToString("N2");

        if (nowScore > bestScore)
        {
            bestScore = nowScore;
            PlayerPrefs.SetInt("BestScore", bestScore);
            PlayerPrefs.Save();
        }

        bestScoreText.text = "Best Score: " + bestScore.ToString("N2");
        anime.SetBool("isDie", true);
        endPanel.SetActive(true);
        Time.timeScale = 0.0f;
    }

    public void RestartGame()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
