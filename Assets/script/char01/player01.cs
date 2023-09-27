using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player01 : MonoBehaviour
{
    public float speed;
    public float jump;

    public LayerMask ground;
    public LayerMask deathGround;

    private Rigidbody2D RigidBody;
    private Collider2D playerCollider;
    private Animator animator;


    public AudioSource JumpSound;
    public AudioSource DeathSound;

    public GameManager gameManager;


    public float MileStone;
    private float MileStoneCount;
    public float SpeedMultipier;

    // Start is called before the first frame update

    void Start()
    {
        RigidBody = GetComponent<Rigidbody2D>();
        playerCollider = GetComponent<Collider2D>();
        animator = GetComponent<Animator>();
        MileStoneCount = MileStone;
    }

    // Update is called once per frame
    void Update()
    {
        bool death = Physics2D.IsTouchingLayers(playerCollider, deathGround);

        if(death)
        {
            GameOver();
        }



        if (transform.position.x>MileStone)
        {
            MileStoneCount += MileStone;
            speed = speed * SpeedMultipier;
            MileStone += MileStone * SpeedMultipier;

        }

        RigidBody.velocity = new Vector2(speed, RigidBody.velocity.y);
        bool grounded=Physics2D.IsTouchingLayers(playerCollider,ground);

        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Z))
        {
            if (grounded)
            {
                JumpSound.Play();
                RigidBody.velocity = new Vector2(RigidBody.velocity.x, jump);
            }
        }

        animator.SetBool("Grounded", grounded);


    }
    void GameOver()
    {
        gameManager.GameOver();
    }
}
