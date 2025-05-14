using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
// NavMeshAgent를 이용 해서플레이어가 추적 범위안에 들어오면 추적하고 공격 범위안에 들어오면 공격하는 로직 구현과 애니메이션 연동
// 추적 범위 공격범위를 구하려면 거리를 구해야함 플레이어랑 좀비의 위치를 알아야함
[RequireComponent(typeof(NavMeshAgent))]
[RequireComponent(typeof(Animator))]

public class ZombieCrtl : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private Transform zombieTr;
    [SerializeField] private NavMeshAgent navi;
    private readonly string PLAYER = "PLAYER";
                      // 동적할당과 동시 문자열을 읽어서 정수로 변환
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
                   // 하이라키에서 player라는 태그를 가진 오브젝트의 트랜스폼을 가져옴
    }
    void Update()
    {
        float dist = Vector3.Distance(zombieTr.position,playerTr.position);
        if (dist <= attackDist) // 공격중일때
        {
            animator.SetBool(hashAttack, true);
            navi.isStopped = true; // 공격중일 때 네비 추적정지
        }
        else if (dist <= traceDist) // 추적중일때
        {
            animator.SetBool(hashAttack, false);
            animator.SetBool(hashTrace, true);
            navi.isStopped = false; // 추적 범위 안에 들어오면 네비 추적 시작
            navi.destination = playerTr.position;
        }
        else // 공격도 아니고 추적도 아닐때
        {
            animator.SetBool(hashTrace, false);
            navi.isStopped = true; // 추적 범위 밖일 때 정지
        }
    }
}
