using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hareket : MonoBehaviour
{
    

    [SerializeField] float yatayHiz = 5;
    [SerializeField] float dikeyYon = 10;
    [SerializeField] LayerMask ziplamaKontrol;
    [SerializeField] AudioSource ziplamaSes;
    [SerializeField] Joystick joystick;
    
    

    bool yerdeMi = true;

    Animator animasyonDurumu;
    SpriteRenderer hareketYonu;
    Rigidbody2D rb;
    BoxCollider2D carpma;
    float yatayYon = 0; 





    // Start is called before the first frame update
    void Start()
    {
        
        Debug.Log("Merhaba D�nya");
        animasyonDurumu = this.GetComponent<Animator>();
        hareketYonu = this.GetComponent<SpriteRenderer>();
        rb = this.GetComponent<Rigidbody2D>();
        carpma = this.GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {

        
      

    
       // yatayYon = Input.GetAxisRaw("Horizontal"); 
       yatayYon = joystick.Horizontal;
       
        
      
        rb.velocity = new Vector2(yatayYon * yatayHiz, rb.velocity.y);
 

       
        if (Input.GetButtonDown("Jump") && yerdeMi==true)
        {
            rb.velocity = new Vector2(rb.velocity.x, dikeyYon);
            ziplamaSes.Play();
        }
     
        if(Physics2D.BoxCast(carpma.bounds.center,carpma.bounds.size,0,Vector2.down,0.1f,ziplamaKontrol))
        {
            yerdeMi = true;
        }
        else
        {
            yerdeMi = false;
        
        }
        
        AnimasyonGuncelle();
       
    }

    private void AnimasyonGuncelle() 
    {



        float dikeyHiz = rb.velocity.y;

        if(yatayYon < 0)
        {
            hareketYonu.flipX = true;
        }
        else if (yatayYon > 0)
        {
            hareketYonu.flipX = false;
        }

       
        if (yerdeMi == false)
        {
            if (dikeyHiz > 0.1)
            {
                animasyonDurumu.SetInteger("durum", 2);
                
            }
            else
              if (dikeyHiz < -0.1)
            {
                animasyonDurumu.SetInteger("durum", 3);
            }
            else
            {
                animasyonDurumu.SetInteger("durum", 0);
            }
        }
        else
        {
            if (yatayYon == 0)
            {
                animasyonDurumu.SetInteger("durum", 0);
            }
            else
            {
                animasyonDurumu.SetInteger("durum", 1);
            }
        }
        
    }
}
