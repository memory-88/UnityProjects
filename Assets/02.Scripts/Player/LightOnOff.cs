using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// �ݶ��̴��� �ε����� �� ����Ʈ�� �������� ����
// �ݶ��̴� �ۿ� ������ ����Ʈ�� �������� ����
public class LightOnOff : MonoBehaviour
{
    public Light _light;
    private AudioSource source; // ����� �ҽ�
    public AudioClip _lightOnSound; // ����� Ŭ��
    public AudioClip _lightOffSound;
    void Start()
    {
        _light = GetComponent<Light>();
        source = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PLAYER"))
        {
            _light.enabled = true;
            source.PlayOneShot(_lightOnSound);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("PLAYER"))
        {
            _light.enabled = false;
            source.PlayOneShot(_lightOffSound);
        }
    }

}
