using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muzik_sustur : MonoBehaviour
{
    AudioSource muzik;
    void Start()
    {
        muzik = this.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        { muzik.mute = !(muzik.mute); }
    }
}
