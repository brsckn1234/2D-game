using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpButton : MonoBehaviour
{
    [SerializeField] AudioSource ziplamaSes;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float dikeyYon = 10;
    [SerializeField] BoxCollider2D carpma ;
    [SerializeField] LayerMask ziplamaKontrol;
     bool yerdeMi = true;
    public void jump(){

                 if(Physics2D.BoxCast(carpma.bounds.center,carpma.bounds.size,0,Vector2.down,0.1f,ziplamaKontrol))
        {
            yerdeMi = true;
        }
        else
        {
            yerdeMi = false;
        
        }
            
        if (yerdeMi==true)
        {
            rb.velocity = new Vector2(rb.velocity.x, dikeyYon);
            ziplamaSes.Play();
            
        }


   
        
    }
}
