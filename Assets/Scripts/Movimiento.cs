using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    private float _horizontal;
    private bool _jumping = false;
    private float speed = 2;
    private float jumpforce = 5;
    private Animator animator;
    private Rigidbody2D _rigidbody2D;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }
    
    // Update is called once per frame
    void Update()
    {
        _horizontal = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(_horizontal, 0, 0) * Time.fixedDeltaTime * speed);
        transform.position += new Vector3(_horizontal, 0, 0) * Time.fixedDeltaTime * speed;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _jumping = true;
        }
    }
    private void FixedUpdate()
    {
        if (_jumping)
        {
            _rigidbody2D.AddForce(new Vector2(0, jumpforce), ForceMode2D.Impulse);
            _jumping = false;

        }
        else
        {
            animator.SetBool("Jumping", false);
        }
    }

}
