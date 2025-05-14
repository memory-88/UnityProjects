using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
// NavMeshAgent�� �̿� �ؼ��÷��̾ ���� �����ȿ� ������ �����ϰ� ���� �����ȿ� ������ �����ϴ� ���� ������ �ִϸ��̼� ����
// ���� ���� ���ݹ����� ���Ϸ��� �Ÿ��� ���ؾ��� �÷��̾�� ������ ��ġ�� �˾ƾ���
[RequireComponent(typeof(NavMeshAgent))]
[RequireComponent(typeof(Animator))]

public class SkeletonCrtl : MonoBehaviour
{
    [SerializeField] private Animator animator1;
    [SerializeField] private Transform skulTr;
    [SerializeField] private NavMeshAgent navi1;
    private readonly string PLAYER = "PLAYER";
    private readonly int hashAttack_S = Animator.StringToHash("IsAttack_S");
    private readonly int hashTrace_S = Animator.StringToHash("IsTrace_S");
    public float traceDist1 = 20.0f;
    public float attackDist1 = 3.0f;
    public Transform playerTr1;
    void Start()
    {
        skulTr = GetComponent<Transform>();
        animator1 = GetComponent<Animator>();
        navi1 = GetComponent<NavMeshAgent>();
        playerTr1 = GameObject.FindWithTag(PLAYER).transform;
        // ���̶�Ű���� player��� �±׸� ���� ������Ʈ�� Ʈ�������� ������
    }
    void Update()
    {
        float dist = Vector3.Distance(skulTr.position, playerTr1.position);
        if (dist <= attackDist1) // �������϶�
        {
            animator1.SetBool(hashAttack_S, true);
            navi1.isStopped = true; // �������� �� �׺� ��������
        }
        else if (dist <= traceDist1) // �������϶�
        {
            animator1.SetBool(hashAttack_S, false);
            animator1.SetBool(hashTrace_S, true);
            navi1.isStopped = false; // ���� ���� �ȿ� ������ �׺� ���� ����
            navi1.destination = playerTr1.position;
        }
        else // ���ݵ� �ƴϰ� ������ �ƴҶ�
        {
            animator1.SetBool(hashTrace_S, false);
            navi1.isStopped = true; // ���� ���� ���� �� ����
        }
    }
}
