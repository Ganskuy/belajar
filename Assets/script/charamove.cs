using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charamove : MonoBehaviour
{
    public float JumpForce;
    [SerializeField]
    bool isGrounded = false;
    Rigidbody2D rb;
    private void Awake(){
        rb = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            if(isGrounded == true){
                rb.AddForce(Vector2.up*JumpForce);
                isGrounded = false;
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D col){
        if(col.gameObject.CompareTag("ground")){
            if(isGrounded == false){
                isGrounded = true;
            }
        }
    }
}
