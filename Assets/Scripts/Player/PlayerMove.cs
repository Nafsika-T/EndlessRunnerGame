using System.Collections;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 3;
    public float upDownSpeed = 4;
    public float jumpHeight = 6;
    public Transform groundCheck;
    public float groundCheckRadius = 0.2f;
    public LayerMask groundLayer;
    public GameObject playerObject;

    private bool isJumping = false;
    private bool comingDown = false;
    private bool isGrounded;
    public AudioSource jump;


    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundCheckRadius, groundLayer);

        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed, Space.World);

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            if (transform.position.y < LevelBoundary.topSide)
            {
                transform.Translate(Vector3.up * Time.deltaTime * upDownSpeed);
            }
        }

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            if (transform.position.y > LevelBoundary.bottomSide)
            {
                transform.Translate(Vector3.down * Time.deltaTime * upDownSpeed);
            }
        }

        if (Input.GetKey(KeyCode.Space) )
        {
            if (!isJumping)
            {
                isJumping = true;
                playerObject.GetComponent<Animator>().Play("Running_Jump");
                StartCoroutine(runningJump());
            }
        }

        if (isJumping)
        {
            if (!comingDown)
            {
                transform.Translate(Vector3.up * Time.deltaTime * jumpHeight, Space.World);
            }
            else
            {
                transform.Translate(Vector3.up * Time.deltaTime * -jumpHeight, Space.World);
            }
        }
    }

    IEnumerator runningJump()
    {
        jump.Play();

        yield return new WaitForSeconds(0.45f);
        comingDown = true;
        yield return new WaitForSeconds(0.45f);
        isJumping = false;
        comingDown = false;
        playerObject.GetComponent<Animator>().Play("Run_Static");
    }
}
