using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[RequireComponent(typeof(Rigidbody),typeof(BoxCollider))]

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    Rigidbody rb;
    [SerializeField]
    Animator animator;
    [SerializeField]
    DynamicJoystick joystick;
    [SerializeField]
    float speed;
    public int countWheat;
    public TMP_Text text;
    public TMP_Text moneyText;
    public int money;

    private void FixedUpdate()
    {
        float h = joystick.Horizontal;
        float v = joystick.Vertical;
        Vector3 directionVector = new Vector3(h, rb.velocity.y, v);
        animator.SetFloat("Speed", Vector3.ClampMagnitude(directionVector, 1).magnitude);
        rb.velocity = Vector3.ClampMagnitude(directionVector, 1) * speed;

        if(joystick.Horizontal != 0 || joystick.Vertical != 0)
        {
            transform.rotation = Quaternion.LookRotation(rb.velocity);
        }
        text.text = $"{countWheat}/40 Wheat.";
        moneyText.text = $"{money}$";
    }
}
