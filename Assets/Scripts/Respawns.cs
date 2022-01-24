using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawns : MonoBehaviour
{
    [SerializeField] private LayerMask Checkpoints;
    [SerializeField] private LayerMask KillLayer;
    private Player_Base playerBase;
    private Rigidbody2D rigidbody2d;
    private BoxCollider2D boxCollider2d;
    private Checkpoint checkpoint;
    public Vector2 spawn;

    private void Awake()
    {
        playerBase = gameObject.GetComponent<Player_Base>();
        rigidbody2d = transform.GetComponent<Rigidbody2D>();
        boxCollider2d = transform.GetComponent<BoxCollider2D>();
        checkpoint = gameObject.GetComponent<Checkpoint>();
    }

    private void Update()
    {
        if (Chckpoint())
        {
            spawn = checkpoint.transform.position;
        }
        if (Death())
        {
            Respawn();
        }
    }

    
    public void Respawn()
    {
        rigidbody2d.velocity = new Vector2(0f, 0f);
        transform.position = spawn;
    }

    public bool Death()
    {
        RaycastHit2D raycastHit2d = Physics2D.BoxCast(boxCollider2d.bounds.center, boxCollider2d.bounds.size, 0f, Vector2.down, 0f, KillLayer);
        return raycastHit2d.collider != null;
    }

    public bool Chckpoint()
    {
        RaycastHit2D raycastHit2d = Physics2D.BoxCast(boxCollider2d.bounds.center, boxCollider2d.bounds.size, 0f, Vector2.down, 0f, Checkpoints);
        return raycastHit2d.collider != null;
    }
}
