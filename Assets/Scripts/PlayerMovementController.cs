using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(BoxCollider2D))]
public class PlayerMovementController : MonoBehaviour
{
    public float speed = 1.0f;

    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        Debug.Assert(gameObject.CompareTag("Player") == true);
    }

    void Update() 
    {
        Vector3 pos = transform.position;
        pos.x += Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime;
        transform.position = pos;

        if (Input.GetAxis("Horizontal") > 0.0f)
            spriteRenderer.flipX = true;
        else if (Input.GetAxis("Horizontal") < 0.0f)
            spriteRenderer.flipX = false;
    }
}
