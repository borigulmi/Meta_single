using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // �� ��ȯ�� ���� �߰�

public class AreaTransition : MonoBehaviour
{
    public string transferSceneName;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Debug.Log("�÷��̾ Ʈ���ſ� �����߽��ϴ�! FlappyPlane ������ �̵��մϴ�.");

            // FlappyPlane ������ �̵�
            SceneManager.LoadScene(transferSceneName);
        }
    }
}
