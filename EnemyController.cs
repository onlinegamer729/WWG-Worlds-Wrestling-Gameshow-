using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Transform player;
    public float attackRange = 2.0f;
    public float moveSpeed = 3.0f;
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (!player) return;

        float distance = Vector3.Distance(transform.position, player.position);

        if (distance > attackRange)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.position, moveSpeed * Time.deltaTime);
            transform.LookAt(player);
            if(anim) anim.SetBool("isAttacking", false);
        }
        else
        {
            if(anim) anim.SetBool("isAttacking", true);
        }
    }
}
