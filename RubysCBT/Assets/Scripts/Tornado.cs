using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Code made by Chris Distorting effect Tornado
public class Tornado : MonoBehaviour
{
    public float speed;
    public bool vertical;
    public float changeTime = 1.0f;

    Rigidbody2D rigidbody2D;
    float timer;
    int direction = 1;


    private RubyController rubyController;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        timer = changeTime;

        GameObject rubyControllerObject = GameObject.FindWithTag("RubyController"); 

        if (rubyControllerObject != null)

        {

            rubyController = rubyControllerObject.GetComponent<RubyController>(); 
            print ("Found the RubyConroller Script!");

        }

        if (rubyController == null)

        {

            print ("Cannot find GameController Script!");
        
        }



    }

    // Update is called once per frame
    void Update()
    {

        timer -= Time.deltaTime;

        if (timer < 0)
        {
            direction = -direction;
            timer = changeTime;
        }
    }

void FixedUpdate()
{
     Vector2 position = rigidbody2D.position;
        
        if (vertical)
        {
            position.y = position.y + Time.deltaTime * speed * direction;;
        }
        else
        {
            position.x = position.x + Time.deltaTime * speed * direction;;
        }
        
        rigidbody2D.MovePosition(position);
}



void OnCollisionEnter2D(Collision2D other)
    {
        RubyController player = other.gameObject.GetComponent<RubyController >();

        if (player != null)
        {
            player.ChangeHealth(-3);
            player.speed = -2.0f;
        }






    }
}
