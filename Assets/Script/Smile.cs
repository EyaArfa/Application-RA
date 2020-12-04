using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Smile : MonoBehaviour
{
    public AudioClip smile;
    public AudioSource face;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Smilingwaving()
    {
        
        face.PlayOneShot(smile);
    }
}
