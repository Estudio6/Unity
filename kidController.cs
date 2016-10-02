using UnityEngine;
using System.Collections;

public class kidController : MonoBehaviour
{
 
   //Variables 
    bool kick ;
    
    Animator myAnim;
    
    bool facingRight;
    
     // Use this for initialization
    void Start()
    {

        myAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        // Para patear

        if (Input.GetKey("x"))
        {
            kick = true;
            myAnim.SetBool("kick", kick);
        } else {


            kick = false;
            myAnim.SetBool("kick", kick);
        }

        // Para Caminar

        float move = Input.GetAxis("Horizontal");
        myAnim.SetFloat("walk", Mathf.Abs(move));

        if (move > 0 && !facingRight) Flip();
        else if (move < 0 && facingRight) Flip();
    }

    void Flip()
    {

        facingRight = !facingRight;
        transform.Rotate(0, 180, 0);
    }
}
