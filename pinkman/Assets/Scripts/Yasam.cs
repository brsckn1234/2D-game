using System.Collections;
using System.Collections.Generic;
using UnityEngine;


using UnityEngine.SceneManagement;

public class Yasam : MonoBehaviour
{
    Animator durum;
    Rigidbody2D rb;
    [SerializeField] AudioSource olumSes;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        durum = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();

        if(collision.gameObject.CompareTag("Tuzak")==true 
            && GameObject.Find("Bayrak").GetComponent<Bolum_Bitis>().bolumBitti==false)
        {
            olumSes.Play();
            rb.bodyType = RigidbodyType2D.Static;
            durum.SetTrigger("olum");

        
        }
    }

    private void YenidenBasla() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
;
    }
}
