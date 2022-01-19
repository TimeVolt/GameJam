using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillScript : MonoBehaviour
{
    [SerializeField] private LayerMask KillLayer;
    private Player_Base playerBase;
    private Rigidbody2D rigidbody2d;
    private BoxCollider2D boxCollider2d;
    public float objx;
    public float objy;

    private void Awake()
    {
        playerBase = gameObject.GetComponent<Player_Base>();
        rigidbody2d = transform.GetComponent<Rigidbody2D>();
        boxCollider2d = transform.GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
        if (Death())
        {
            playerBase.transform.position = new Vector3(objx, objy, 0f);
            rigidbody2d.velocity = new Vector2(0f, 0f);
        }
    }

    private bool Death()
    {
        RaycastHit2D raycastHit2d = Physics2D.BoxCast(boxCollider2d.bounds.center, boxCollider2d.bounds.size, 0f, Vector2.down, .1f, KillLayer);
        Debug.Log($"Death {raycastHit2d.collider} ");
        return raycastHit2d.collider != null;
    }
}