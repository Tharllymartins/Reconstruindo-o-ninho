using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    // variaves 
    public float forcaPulo;
    public float velocidadeMaxima;

    public int Lifes;
    public int Eggs;

    public Text TextLifes;
    public Text TextEggs;
    // Start is called before the first frame update
    void Start()
    {
        TextLifes.text = Lifes.ToString();
        TextEggs.text = Eggs.ToString();
        
        
    
 
    }

    // Update is called once per frame
    void Update()
         
    {
        // movimento // Player


        float movimento = Input.GetAxis("Horizontal");
        Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.velocity = new Vector3(movimento* velocidadeMaxima, rigidbody.velocity.y);
        //Animação// Player
        if (movimento < 0)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }else if (movimento > 0)
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }

        if (movimento > 0 || movimento < 0)
        {
            GetComponent<Animator>().SetBool("walking", true);
        }
        else
        {
            GetComponent<Animator>().SetBool("walking", false);
        }



        if (Input.GetKeyDown(KeyCode.Space))
            {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0,forcaPulo));
        }
            
           
        
      
    }
    private void OnTriggerEnter2D(Collider2D collision2D)
    {

        if(collision2D.gameObject.CompareTag("Ovo"))
        {
            Destroy(collision2D.gameObject);
            Eggs++;
            TextEggs.text = Eggs.ToString();

            if (Eggs >= 3)
            {
                Application.LoadLevel("final");
            }
        }

    }
    private void OnTriggerExit2D(Collider2D collision2D)
    {
    
    }

    void OnCollisionEnter2D(Collision2D collision2D)
    {
 
    }
   void OnCollisionExit2D(Collision2D collision2D)
    {
        
    }

    

    
}
