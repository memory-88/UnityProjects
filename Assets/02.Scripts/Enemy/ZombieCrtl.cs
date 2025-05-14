using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
// NavMeshAgent�� �̿� �ؼ��÷��̾ ���� �����ȿ� ������ �����ϰ� ���� �����ȿ� ������ �����ϴ� ���� ������ �ִϸ��̼� ����
// ���� ���� ���ݹ����� ���Ϸ��� �Ÿ��� ���ؾ��� �÷��̾�� ������ ��ġ�� �˾ƾ���
[RequireComponent(typeof(NavMeshAgent))]
[RequireComponent(typeof(Animator))]

public class ZombieCrtl : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private Transform zombieTr;
    [SerializeField] private NavMeshAgent navi;
    private readonly string PLAYER = "PLAYER";
                      // �����Ҵ�� ���� ���ڿ��� �о ������ ��ȯ
    private readonly int hashAttack = Animator.StringToHash("IsAttack");
    private readonly int hashTrace = Animator.StringToHash("IsTrace");
    public float traceDist = 20.0f;
    public float attackDist = 3.0f;
    public Transform playerTr;
    void Start()
    {
        zombieTr = GetComponent<Transform>();
        animator = GetComponent<Animator>();
        navi = GetComponent<NavMeshAgent>();
        playerTr = GameObject.FindWithTag(PLAYER).transform;
                   // ���̶�Ű���� player��� �±׸� ���� ������Ʈ�� Ʈ�������� ������
    }
    void Update()
    {
        float dist = Vector3.Distance(zombieTr.position,playerTr.position);
        if (dist <= attackDist) // �������϶�
        {
            animator.SetBool(hashAttack, true);
            navi.isStopped = true; // �������� �� �׺� ��������
        }
        else if (dist <= traceDist) // �������϶�
        {
            animator.SetBool(hashAttack, false);
            animator.SetBool(hashTrace, true);
            navi.isStopped = false; // ���� ���� �ȿ� ������ �׺� ���� ����
            navi.destination = playerTr.position;
        }
        else // ���ݵ� �ƴϰ� ������ �ƴҶ�
        {
            animator.SetBool(hashTrace, false);
            navi.isStopped = true; // ���� ���� ���� �� ����
        }
    }
}
