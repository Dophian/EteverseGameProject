using UnityEngine;

namespace Demo
{
    public class PlayerMove : MonoBehaviour
    {
        [SerializeField]
        private float moveSpeed = 10f;

        [SerializeField]
        private float rotationSpeed = 120f;

        private void Update()
        {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");

            transform.position += transform.forward * vertical * moveSpeed * Time.deltaTime;

            transform.rotation *= Quaternion.Euler(
                0f,
                horizontal * rotationSpeed * Time.deltaTime,
                0f);
        }
    }
}