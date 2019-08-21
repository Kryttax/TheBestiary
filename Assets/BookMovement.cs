using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookMovement : MonoBehaviour
{
    public GameObject bookRef;
    AutoFlip flip;
    
    private void Awake()
    {
        
        flip = bookRef.GetComponent<AutoFlip>();       
    }

    private void FixedUpdate()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
            Application.Quit();

            //FlipPages();
    }

    void FlipPages()
    {
    
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            flip.FlipRightPage();
        }
        else if(Input.GetKeyUp(KeyCode.LeftArrow))
            flip.FlipLeftPage();
    }
}
