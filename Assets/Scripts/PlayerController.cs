using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private LayerMask platformsLayerMask;
    private Player_Base playerBase;
    private Rigidbody2D rigidbody2d;
    private BoxCollider2D boxCollider2d;
    public float jumpVelocity;
    public float moveSpeed;
    private int jump;
    public float hangTime;
    private float hangCounter;
    Animator m_Animator;
    bool m_Right;
    bool m_Left;

    void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();
    }

    private void Awake()
    {
        playerBase = gameObject.GetComponent<Player_Base>();
        rigidbody2d = transform.GetComponent<Rigidbody2D>();
        boxCollider2d = transform.GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
        if (jump >= 2 && Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            rigidbody2d.velocity = Vector2.up * jumpVelocity;
            jump -= 1;
        }
        
        else if (jump >= 2 && hangCounter > 0 && Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody2d.velocity = Vector2.up * jumpVelocity;
            jump -= 1;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            m_Animator.SetBool("L", true);

        }
        else
        {
            m_Animator.SetBool("L", false);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            m_Animator.SetBool("R", true);
        }
        else
        {
            m_Animator.SetBool("R", false);
        }
            HandleMovement();

        if (IsGrounded())
        {
            jump = 2;
            hangCounter = hangTime;
        }
        else
        {
            hangCounter -= Time.deltaTime;
        }
    }

    private bool IsGrounded()
    {
        RaycastHit2D raycastHit2d = Physics2D.BoxCast(boxCollider2d.bounds.center, boxCollider2d.bounds.size, 0f, Vector2.down, .2f, platformsLayerMask);
        return raycastHit2d.collider != null;
    }

    private void HandleMovement()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rigidbody2d.velocity = new Vector2(-moveSpeed, rigidbody2d.velocity.y);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rigidbody2d.velocity = new Vector2(+moveSpeed, rigidbody2d.velocity.y);
        }
        else
        {
            rigidbody2d.velocity = new Vector2(0, rigidbody2d.velocity.y);
        }
    }   
}