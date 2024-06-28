using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform_Sabitleme : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Karakter")
        {
            collision.gameObject.transform.SetParent(this.transform);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Karakter")
        {
            collision.gameObject.transform.SetParent(null);

        }
    }

}
