using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public float lookRadius = 10f;

    public Animator animator;

    Transform target;
    NavMeshAgent agent;

    public bool isMoving = false;

    public float enemyMovementTimer = 6.0f;

    // Start is called before the first frame update
    void Start()
    {
        target = PlayerManager.instance.player.transform;
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        enemyMovementTimer -= Time.deltaTime;

        float distance = Vector3.Distance(target.position, transform.position);

        if (isMoving == true && !agent.pathPending && agent.remainingDistance <= agent.stoppingDistance)
        {
            // The agent has reached its destination, so set isMoving to false
            animator.SetBool("isMoving", false);
            isMoving = false;
            enemyMovementTimer = 6.0f;
        }

        if (distance <= lookRadius)
        {
            FollowEnemyMovement();
        }
        else
        {
            if (enemyMovementTimer < 0)
                IdleEnemyMovement();
        }
    }

    public void FollowEnemyMovement()
    {
        animator.SetBool("isMoving", true);
        isMoving = true;
        agent.SetDestination(target.position);

        
    }

    public void IdleEnemyMovement()
    {
        animator.SetBool("isMoving", true);
        isMoving = true;

        Vector3 newPosition = new Vector3(UnityEngine.Random.Range(141, 178), 51, UnityEngine.Random.Range(53, 74));

        agent.SetDestination(newPosition);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //PlayerManager.instance.playerHealth--;
            Debug.Log("Lost 1 health");
        }
    }

    public void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }
}