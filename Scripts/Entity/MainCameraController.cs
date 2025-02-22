using UnityEngine;

public class MainCameraController : MonoBehaviour
{
    public Transform player; // 플레이어 Transform
    public Vector2 minCameraBoundary; // 카메라 최소 범위
    public Vector2 maxCameraBoundary; // 카메라 최대 범위

    [SerializeField] private float smoothSpeed = 0.125f; // 카메라 이동 속도
    [SerializeField] private Vector2 offset; // 카메라의 위치 오프셋 (플레이어와의 거리)

    private void Update()
    {
        if (player == null) return;

        // 카메라의 목표 위치 계산 (플레이어 + 오프셋)
        Vector3 desiredPosition = new Vector3(player.position.x + offset.x, player.position.y + offset.y, transform.position.z);

        // 카메라의 위치를 부드럽게 이동
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        // 카메라의 위치가 범위를 벗어나지 않도록 제한
        float clampedX = Mathf.Clamp(smoothedPosition.x, minCameraBoundary.x, maxCameraBoundary.x);
        float clampedY = Mathf.Clamp(smoothedPosition.y, minCameraBoundary.y, maxCameraBoundary.y);

        transform.position = new Vector3(clampedX, clampedY, transform.position.z); // Z축은 고정
    }
}
