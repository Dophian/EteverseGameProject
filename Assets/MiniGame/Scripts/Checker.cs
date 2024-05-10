using UnityEngine;

namespace Game
{
    public class Checker : MonoBehaviour
    {
        // �� ��ü�� ������ �±� ��
        [SerializeField]
        private string wallTag = "Wall";
        
        // ���ӿ� ��ġ�� ���� ����
        [SerializeField]
        private int targetCount = 0;

        // �÷��̾ �о ���� ����.
        [SerializeField]
        private int pushCount = 0;

        // ���� ���� �ð�(����: ��).
        [SerializeField]
        private float gameOverTime = 10f;

        [SerializeField]
        private float remainTime = 0f;

        [SerializeField]
        private bool isGameClear = false;

        private void Awake()
        {
            // ���� ���� ����.
            targetCount = GameObject.FindGameObjectsWithTag(wallTag).Length;

            // ������ ���۵Ǹ� �ð� ä���.
            remainTime = gameOverTime;
        }

        private void Update()
        {
            // ���� Ŭ�����ϸ� �ð� ��� X
            if (isGameClear)
            {
                return;
            }

            // �ð� ī��Ʈ �ٿ�.
            remainTime = remainTime - Time.deltaTime;

            // Ÿ�� ���� Ȯ��
            if (remainTime < 0f)
            {
                Debug.Log("Ÿ�� ����!");
            }
            
        }

        private void OnTriggerEnter(Collider other)
        {
            // �±� Ȯ�� (������)
            if (other.CompareTag(wallTag))
            {
                ++pushCount;

                if (pushCount == targetCount)
                {
                    Debug.Log("���� Ŭ����!");
                    isGameClear = true;
                }
            }
        }
    }
}
