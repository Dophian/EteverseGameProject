using UnityEngine;

namespace Demo
{
    public class RayCaster : MonoBehaviour
    {
        // World.
        // Camera.
        [SerializeField]
        private float rayLength = 3f;

        [Tooltip("플레이어가 벽을 밀어내는 힘"), SerializeField]
        private float pushPower = 50f;

        private void Update()
        {
            // Ray를 방출.

            // Ray의 시작지점.
            // Ray의 방향.
            // Ray의 길이.
            // Ray와 부딪힌 물체의 정보를 받기위한 변수(참조로).
            // 레이어마스크.

            // World 기준으로 Ray를 사용하는 예.
            //RaycastHit hit;
            if (Physics.Raycast(
                transform.position,
                transform.forward,
                out RaycastHit hit,
                rayLength))
            {
                Debug.Log($"Ray가 충돌함.{hit.collider.name}");

                // 밀기.
                hit.rigidbody.AddForce(transform.forward * pushPower);
            }
        }

        // Ray가 눈에 안보여서 일부러 그림.
        private void OnDrawGizmos()
        {
            // 기즈모의 색상 설정.
            Gizmos.color = Color.red;

            // Ray 그리기.
            Gizmos.DrawRay(transform.position, transform.forward * rayLength);
        }
    }
}