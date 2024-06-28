using System.Collections;
using System.Collections.Generic;
using UnityEngine;


using UnityEngine.SceneManagement;

public class Bolum_Bitis : MonoBehaviour
{
    public bool bolumBitti = false;
    [SerializeField] AudioSource bitisSes;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Karakter")
        {
            bolumBitti = true;
            bitisSes.Play();
            Invoke("SonrakiBolum",1.5f);
        }
    }

    private void SonrakiBolum()
    {
      
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
       
    }
}
