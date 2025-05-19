using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class crow_sport : MonoBehaviour
{
    public static crow_sport instance;

    public InputActions inputActions;
    public Vector2 inputDirection;
    public Vector2 currentDirection;
    float moveSpeed;
    public float walkSpeed;
    public float runSpeed;
    public float dashSpeed_walk;
    public float dashSpeed_run;
    private Rigidbody2D cr;
    private SpriteRenderer sr;
    private Animator anim;
    public float inputX, inputY;
    private float stopX, stopY;
    public bool isRunning;
    public bool isDashing;
    public bool canMove = true;
    private bool canDash;
    public float dashTime;
    public float NodashTime;

    public string scenePw;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        inputActions = new InputActions();
        cr = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        isRunning = false;
        isDashing = false;
        canDash = true;
        currentDirection = Vector2.down;
    }

    private void OnEnable()
    {
        inputActions.Enable();
    }

    private void OnDisable()
    {
        inputActions.Disable();
    }

    private void Update()
    {
        if (isDashing)
        {
            return;
        }

        inputDirection = inputActions.Gameplay.moving.ReadValue<Vector2>();

        if (inputDirection != Vector2.zero)
        {
            currentDirection = inputDirection.normalized; 
        }

        if (canMove == true)
        {
            Run();
            StartCoroutine(Dash());
        }
    }

    private void FixedUpdate()
    {
        if (isDashing)
        {
            return;
        }

        if (canMove == true)
        {
            EnableMove(); 
        }
        else if (canMove == false)
        {
            DisableMove();
        }
    }

    public void EnableMove()
    {
        anim.SetBool("isMoving", true);
        SetAnimation();
    }

    public void DisableMove()
    {
        cr.velocity = Vector2.zero;
        anim.SetBool("isMoving", false);
    }

    public void Run()
    {
        if (Input.GetKeyDown(GameManager.GM.run))
        {
            if (isDashing == false)
            {
                if (isRunning == false)
                {
                    isRunning = true;
                    anim.SetBool("isRunning", true);
                }
                else if (isRunning == true)
                {
                    isRunning = false;
                    anim.SetBool("isRunning", false);
                }  
            }
        }
    }

    private IEnumerator Dash()
    {
        if (Input.GetKeyDown(GameManager.GM.dash))
        {
            if (canDash == true && isDashing == false)
            {
                canDash = false;
                isDashing = true;
                anim.SetBool("isDashing", true);
                if (isRunning == false)
                {
                    moveSpeed = dashSpeed_walk;
                }
                else if (isRunning == true)
                {
                    moveSpeed = dashSpeed_run;
                }
                cr.velocity = currentDirection * moveSpeed;
                yield return new WaitForSeconds(dashTime);

                isDashing = false;
                anim.SetBool("isDashing", false);
                cr.velocity = Vector2.zero;
                yield return new WaitForSeconds(NodashTime);
                canDash = true;
            }
        }
    }

    void SetAnimation()
    {
        anim.SetBool("isRunning", isRunning);
        anim.SetBool("isDashing", isDashing);

        inputX = Input.GetAxisRaw("Horizontal");
        inputY = Input.GetAxisRaw("Vertical");

        if (inputX != 0)
        {
            anim.SetFloat("Horizontal", inputX);
            anim.SetFloat("Vertical", 0);
        }
        if (inputY != 0)
        {
            anim.SetFloat("Horizontal", 0);
            anim.SetFloat("Vertical", inputY);
        }

        Vector2 input = new Vector2(inputX, inputY).normalized;
        cr.velocity = inputDirection * moveSpeed;

        if (input != Vector2.zero)
        {
            anim.SetBool("isMoving", true);
            if (isRunning == false && isDashing == false)
            {
                moveSpeed = walkSpeed;
            }
            else if (isRunning == true && isDashing == false)
            {
                moveSpeed = runSpeed;
            }     
            stopX = inputX;
            stopY = inputY;
        }
        else
        {
            anim.SetBool("isMoving", false);
        }

        anim.SetFloat("InputX", stopX);
        anim.SetFloat("InputY", stopY);
    }
}
