using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    private float _horizontal;
    public float speed;
    public float jumpforce;
    private Animator _animator;
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
        
        
    }
    private void FixedUpdate()
    {
        _rigidbody2D.velocity = new Vector2(_horizontal, _rigidbody2D.velocity.y);
    }

}
