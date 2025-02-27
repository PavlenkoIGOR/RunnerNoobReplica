using System;
using UnityEditor.Animations;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 10.0f;
    [SerializeField] private Rigidbody rb;
    [SerializeField] private Animator animator;
    private string horizAxis = "Horizontal";
    private string vertAxis = "Vertical";

    #region animations
    private string runAnim = "Standard Run";
    private string idleAnim = "Breathing Idle";
    #endregion

    void Start()
    {
        if (rb == null)
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float horizInput = Input.GetAxis(horizAxis);
        float vertInput = Input.GetAxis(vertAxis);

        Vector3 movement = new Vector3(horizInput, 0.0f, 0.0f);

        if (vertInput != 0)
        {
            MovePlayer(movement);
        }
        else
        {
            animator.Play(idleAnim);
        }
    }

    private void MovePlayer(Vector3 movement)
    {
        rb.MovePosition(transform.position + movement * moveSpeed * Time.deltaTime);
        animator.Play(runAnim);
    }
}
