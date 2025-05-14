using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainStop : MonoBehaviour
{
    public GameObject rainPrefab; // �� ������
    public GameObject rainObj; // �� ������Ʈ
    void Start()
    {
        rainObj = Instantiate(rainPrefab); // �� �������� �ν��Ͻ�ȭ�Ͽ� rainObj�� ����
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PLAYER"))
        {
            Destroy(rainObj); // �� ������Ʈ ����
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("PLAYER"))
        {
            rainObj = Instantiate (rainPrefab); // �� �������� �ν��Ͻ�ȭ�Ͽ� rainObj�� ����
        }
    }
}
