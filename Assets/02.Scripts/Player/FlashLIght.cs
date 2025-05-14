using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// FŰ�� ������ ����Ʈ�� ������ �ٽ� FŰ�� ������ ������.
// ���� ������ ���� : audiosource, audioClip

public class FlashLIght : MonoBehaviour
{
    [SerializeField] private Light flashLight;
    [SerializeField] private AudioSource source;
    public AudioClip flashClip;
    void Start()
    {
        flashLight = GetComponent<Light>();
        source = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            flashLight.enabled = !flashLight.enabled;
            source.PlayOneShot(flashClip,1.0f);
        }
    }
}
