using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraTakip : MonoBehaviour
{

   [SerializeField] Transform takipEdilecekNesne;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(takipEdilecekNesne.position.x,takipEdilecekNesne.position.y,-10);
    }
}
