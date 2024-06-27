using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Sonradan Eklenen K�t�phaneler
using TMPro;
using UnityEngine.UI;

public class Topla : MonoBehaviour
{


    [SerializeField] Text text_normal;
    [SerializeField] TMP_Text text_tmp;
    [SerializeField] AudioSource toplamaSes;
    int skor = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Meyve"))
        {
            toplamaSes.Play();
            Destroy(collision.gameObject);
            skor = skor + 1;
            text_normal.text = "Skor:" + skor;
            
        }
    }
}
