using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nokta_Takip : MonoBehaviour
{
  

    [SerializeField] GameObject[] noktalar;
    int noktaIndisi = 0;
    [SerializeField] float hiz = 2f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(this.transform.position, noktalar[noktaIndisi].transform.position) < 0.1f)
        {
            noktaIndisi++;
            if (noktaIndisi >= noktalar.Length)
            {
                noktaIndisi = 0;
            }
        }
        
   
        this.transform.position = Vector2.MoveTowards(this.transform.position, noktalar[noktaIndisi].transform.position, Time.deltaTime * hiz);
        
    }
}
