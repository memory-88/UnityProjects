using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// ���� ����Ʈ Ű�� wŰ�� ���ÿ� ������ �� ���� ���� �ִϸ��̼��� ����ϴ� ��ũ��Ʈ ����
// ���� ����Ʈ Ű�� wŰ ���߿� �ϳ��� ���� �ִϸ��̼��� ���߰� ���� �ܴ��� �ִϸ��̼��� ����ǵ��� ����
public class PlayerHandAnimation : MonoBehaviour
{
    public Animation anim;
    private readonly string runAni = "running";
    private readonly string runStopAni = "runStop";
    bool isRunning;
    void Start()
    {          // �ڰ��ڽ��� �ڽ� ù��°(0) ������Ʈ�� ã�� �� ������Ʈ�� ù��° �ڽ� ������Ʈ�� ã�´�.
        anim = transform.GetChild(0).GetChild(0).GetComponent<Animation>();
        //anim = GetComponentInChildren<Animation>();
        //anim = GetComponentInChildren<Animation>()[0];
        isRunning = false;
    }

    void Update()
    {
        RunHandMove();
        PlayerFire();
    }

    public void PlayerFire()
    {
        if (Input.GetMouseButton(0) && !isRunning)
        {
            anim.Play("fire");
        }
    }

    private void RunHandMove()
    {
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.W))
        {
            anim.Play(runAni);
            isRunning = true;
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            anim.Play(runStopAni);
            isRunning = false;
        }

    }
}
