using UnityEngine;

public class MainCameraController : MonoBehaviour
{
    public Transform player; // �÷��̾� Transform
    public Vector2 minCameraBoundary; // ī�޶� �ּ� ����
    public Vector2 maxCameraBoundary; // ī�޶� �ִ� ����

    [SerializeField] private float smoothSpeed = 0.125f; // ī�޶� �̵� �ӵ�
    [SerializeField] private Vector2 offset; // ī�޶��� ��ġ ������ (�÷��̾���� �Ÿ�)

    private void Update()
    {
        if (player == null) return;

        // ī�޶��� ��ǥ ��ġ ��� (�÷��̾� + ������)
        Vector3 desiredPosition = new Vector3(player.position.x + offset.x, player.position.y + offset.y, transform.position.z);

        // ī�޶��� ��ġ�� �ε巴�� �̵�
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        // ī�޶��� ��ġ�� ������ ����� �ʵ��� ����
        float clampedX = Mathf.Clamp(smoothedPosition.x, minCameraBoundary.x, maxCameraBoundary.x);
        float clampedY = Mathf.Clamp(smoothedPosition.y, minCameraBoundary.y, maxCameraBoundary.y);

        transform.position = new Vector3(clampedX, clampedY, transform.position.z); // Z���� ����
    }
}
