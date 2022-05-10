using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;

public class Player : MonoBehaviour
{
    [Header("Player characteristics")]
    [SerializeField] [Range(1f, 10f)] float Running_speed;
    [SerializeField] [Range(50f, 700f)] float Jump_force;
    [SerializeField] [Range(-0.5f, 2f)] float Shooting_rate;
    [SerializeField] [Range(0, 1000)] int PlayerBullets_number;
    [SerializeField] [Range(0f, 15f)] private float Bullet_speed;
    [SerializeField] private LayerMask WhatIs_ground;


    [Header("Player Sounds")]
    [SerializeField] AudioClip Shooting_sound;
    [SerializeField] AudioClip Jump_sound;
    [SerializeField] AudioClip Dead_sound;
    [SerializeField] AudioClip Win_sound;

    [Header("Player subsystems")]
    [SerializeField] Transform Ground_check;
    [SerializeField] Transform BulletLounchPositionPointer;
    [SerializeField] Transform SleveerLounchPositionPointer;

    [Header("Player subsystems characteristics")]
    [SerializeField] float GroundCheck_radius;

    

    [SerializeField] GameObject Bullet;
    [SerializeField] GameObject Sleveer;

    [HideInInspector] public static UnityEvent<int>  SendPlayerBulletsNumber  = new UnityEvent<int>();
    [HideInInspector] public static UnityEvent SendPlayerDead = new UnityEvent();
    public static UnityEvent PlayerPassedLevel = new UnityEvent();


    private enum State { Playing, Win, Dead }; State currentState = State.Playing;

    private float NextShoot;
    private bool playerGrounded;
    private bool playerFacingRight;
    private bool Shoot;
    private int bulletRot;

    private Rigidbody2D RB;
    private AudioSource AU;
    private Animator AN;


    private void Start()
    {
        RB = GetComponent<Rigidbody2D>();
        AU = GetComponent<AudioSource>();
        AN = GetComponent<Animator>();

        AU.volume = PlayerPrefs.GetFloat("Sounds volume");    }

    private void Update()
    {
      // if (Input.GetKey(KeyCode.Y)) { PlayerPrefs.DeleteKey("Completed_Levels"); }

        PlayerJump();       
    }

    private void FixedUpdate()
    {
        playerGrounded = false;
        Collider2D[] colliders = Physics2D.OverlapCircleAll(Ground_check.position, GroundCheck_radius, WhatIs_ground);
        for(int i = 0; i < colliders.Length; i++)
        {
            if(colliders[i].gameObject != gameObject)
            {
                playerGrounded = true;
            }
        }

        // Player movement code
        float horizontal = Input.GetAxisRaw("Horizontal") * Running_speed;

        if (horizontal < 0 && !playerFacingRight) 
        {
            PlayerFlip(); bulletRot = 180;
        }

        if (horizontal > 0 && playerFacingRight) 
        {
            PlayerFlip(); bulletRot = 0;
        }

        if (Shoot) 
        {
            horizontal = 0; 
        }

        RB.velocity = new Vector2(horizontal, RB.velocity.y);
        AN.SetFloat("PlayerSpeed", Mathf.Abs(horizontal));

        // Player shoot code
        if (Input.GetMouseButton(0) && playerGrounded && currentState == State.Playing)
        {
            Shoot = true;

            if (Time.time > NextShoot && PlayerBullets_number > 0)
            {
                NextShoot = Time.time + Shooting_rate;
                PlayerBullets_number--;
                SendPlayerBulletsNumber.Invoke(PlayerBullets_number);
                AU.PlayOneShot(Shooting_sound);
                AN.SetBool("PlayerShoot", true);

                Instantiate(Bullet, BulletLounchPositionPointer.transform.position, Quaternion.Euler(new Vector3(0, 0, bulletRot)));
                Instantiate(Sleveer, SleveerLounchPositionPointer.transform.position, SleveerLounchPositionPointer.transform.rotation);
            }
        }
        else 
        { 
            AN.SetBool("PlayerShoot", false);
            Shoot = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Gates":
                PlayerWin();
                break;

            case "Slug":
                PlayerDead();
                break;

            case "Lava":
                PlayerDead();
                break;
        }

        AN.SetBool("PlayerJump", false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Stalagmit":
                PlayerDead();
                break;
            case "Canion Ammo":
                PlayerDead();
                break;
            case "Host":
                PlayerDead();
                break;
            case "Spike":
                PlayerDead();
                break;

        }
    }

    private void PlayerJump()
    {
        if (Input.GetKeyDown(KeyCode.W) && playerGrounded && currentState == State.Playing)
        {
            AU.PlayOneShot(Jump_sound);
            AN.SetBool("PlayerJump", true);
            { RB.AddForce(transform.up * Jump_force); }
        }
    }

    private void PlayerFlip()
    {
        playerFacingRight = !playerFacingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

    private void PlayerDead()
    {
        if (currentState == State.Playing)
        {
            AU.PlayOneShot(Dead_sound);
            Running_speed = 0;
            RB.AddForce(transform.up * 8, ForceMode2D.Impulse);
            AN.SetBool("PlayerDead", true);
            SendPlayerDead.Invoke();
            currentState = State.Dead;
        }       
    }

    private void PlayerWin()
    {
        if(currentState == State.Playing)
        {
            AU.PlayOneShot(Win_sound);
            PlayerPassedLevel.Invoke();
            currentState = State.Win;
            Time.timeScale = 0;
            currentState = State.Win;
        }
    }
}
