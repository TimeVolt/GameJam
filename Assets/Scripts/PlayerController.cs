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
    public int jumpMax;
    private int jump;
    public int dashTime;
    //private DashingTime;
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
        if (jump >= jumpMax && Input.GetKeyDown(KeyCode.UpArrow) || jump >= jumpMax && Input.GetKey(KeyCode.W))
        {
            rigidbody2d.velocity = Vector2.up * jumpVelocity;
            jump -= 1;
        }

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            m_Animator.SetBool("L", true);

        }
        else
        {
            m_Animator.SetBool("L", false);
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
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
            jump = jumpMax;
            //DashingTime = dashTime;
        }
    }

    private bool IsGrounded()
    {
        RaycastHit2D raycastHit2d = Physics2D.BoxCast(boxCollider2d.bounds.center, boxCollider2d.bounds.size, 0f, Vector2.down, .001f, platformsLayerMask);
        return raycastHit2d.collider != null;
    }

    private void HandleMovement()
    {
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            rigidbody2d.velocity = new Vector2(-moveSpeed, rigidbody2d.velocity.y);
        }
        else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            rigidbody2d.velocity = new Vector2(+moveSpeed, rigidbody2d.velocity.y);
        }
        else
        {
            rigidbody2d.velocity = new Vector2(0, rigidbody2d.velocity.y);
        }
    }

    private void Dash()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {

            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {

            }
            else
            {

            }
        }
    }
}