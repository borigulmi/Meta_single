using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI nowScoreText;
    public TextMeshProUGUI bestScoreText;
    public GameObject retryButton; // Retry 버튼
    public GameObject endPanel;    // 게임 종료 패널 추가

    private void Start()
    {
        if (retryButton == null)
        {
            Debug.LogError("Retry Button is not assigned in the Inspector.");
        }

        if (endPanel == null)
        {
            Debug.LogError("End Panel is not assigned in the Inspector.");
        }

        if (scoreText == null || nowScoreText == null || bestScoreText == null)
        {
            Debug.LogError("ScoreText or Final Score Texts are not assigned in the Inspector.");
            return;
        }

        retryButton.SetActive(false); // 초기 상태에서 버튼 숨김
        endPanel.SetActive(false);    // EndPanel 숨김
    }

    public void SetRestart()
    {
        retryButton.SetActive(true);  // 게임 오버 시 버튼 활성화
        endPanel.SetActive(true);     // EndPanel 활성화
    }

    public void UpdateScore(int score)
    {
        scoreText.text = "Score: " + score.ToString("N2");
    }

    public void UpdateNowScore(int nowScore)
    {
        nowScoreText.text = "Now Score: " + nowScore.ToString("N2");
    }

    public void UpdateBestScore(int bestScore)
    {
        bestScoreText.text = "Best Score: " + bestScore.ToString("N2");
    }
}
