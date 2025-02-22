using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI nowScoreText;
    public TextMeshProUGUI bestScoreText;
    public GameObject retryButton; // Retry ��ư
    public GameObject endPanel;    // ���� ���� �г� �߰�

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

        retryButton.SetActive(false); // �ʱ� ���¿��� ��ư ����
        endPanel.SetActive(false);    // EndPanel ����
    }

    public void SetRestart()
    {
        retryButton.SetActive(true);  // ���� ���� �� ��ư Ȱ��ȭ
        endPanel.SetActive(true);     // EndPanel Ȱ��ȭ
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
