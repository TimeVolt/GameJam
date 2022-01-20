using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillScript : MonoBehaviour
{
    [SerializeField] private LayerMask KillLayer;
    private Player_Base playerBase;
    private Rigidbody2D rigidbody2d;
    private BoxCollider2D boxCollider2d;
    private Respawns respawn;

    void Awake()
    {
        playerBase = gameObject.GetComponent<Player_Base>();
        rigidbody2d = transform.GetComponent<Rigidbody2D>();
        boxCollider2d = transform.GetComponent<BoxCollider2D>();


        respawn = gameObject.GetComponent<Respawns>();
    }

    void Update()
    {
        if (Death())
        {
            respawn.Respawn();
        }
    }

    public bool Death()
    {
        RaycastHit2D raycastHit2d = Physics2D.BoxCast(boxCollider2d.bounds.center, boxCollider2d.bounds.size, 0f, Vector2.down, 0f, KillLayer);
        return raycastHit2d.collider != null;
    }
}