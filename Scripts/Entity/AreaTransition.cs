using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // 씬 전환을 위해 추가

public class AreaTransition : MonoBehaviour
{
    public string transferSceneName;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Debug.Log("플레이어가 트리거에 진입했습니다! FlappyPlane 씬으로 이동합니다.");

            // FlappyPlane 씬으로 이동
            SceneManager.LoadScene(transferSceneName);
        }
    }
}
