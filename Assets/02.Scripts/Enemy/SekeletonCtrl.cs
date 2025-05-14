using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
// NavMeshAgent를 이용 해서플레이어가 추적 범위안에 들어오면 추적하고 공격 범위안에 들어오면 공격하는 로직 구현과 애니메이션 연동
// 추적 범위 공격범위를 구하려면 거리를 구해야함 플레이어랑 좀비의 위치를 알아야함
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
        // 하이라키에서 player라는 태그를 가진 오브젝트의 트랜스폼을 가져옴
    }
    void Update()
    {
        float dist = Vector3.Distance(skulTr.position, playerTr1.position);
        if (dist <= attackDist1) // 공격중일때
        {
            animator1.SetBool(hashAttack_S, true);
            navi1.isStopped = true; // 공격중일 때 네비 추적정지
        }
        else if (dist <= traceDist1) // 추적중일때
        {
            animator1.SetBool(hashAttack_S, false);
            animator1.SetBool(hashTrace_S, true);
            navi1.isStopped = false; // 추적 범위 안에 들어오면 네비 추적 시작
            navi1.destination = playerTr1.position;
        }
        else // 공격도 아니고 추적도 아닐때
        {
            animator1.SetBool(hashTrace_S, false);
            navi1.isStopped = true; // 추적 범위 밖일 때 정지
        }
    }
}
