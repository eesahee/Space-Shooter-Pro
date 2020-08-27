using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //public or private reference
    //data type (int, float, bool, string)
    //every variable has a name
    //optional value assigned
    private float _speed = 3.5f;

    // Start is called before the first frame update
    void Start()
    {
        //take the current position = new position (0, 0, 0)
        transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {            
        CalculateMovement();

        //if i hit a space key
        //spawn gameObject



    }

    void CalculateMovement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        //new Vector(1, 0, 0) * speed * real time
        //transform.Translate(Vector3.right * horizontalInput * _speed * Time.deltaTime);
        //transform.Translate(Vector3.up * verticalInput * _speed * Time.deltaTime);
        Vector3 direction = new Vector3(horizontalInput, verticalInput, 0);

        transform.Translate(direction * _speed * Time.deltaTime);

        //if player position on the y is greater than 6
        //y position = 6
        //else if position on the y is less than -4
        //y pos = -4

        

        if (transform.position.y >=0)
        {
            transform.position = new Vector3(transform.position.x, 0, 0);
        }
        else if(transform.position.y <=-4)
        {
            transform.position = new Vector3(transform.position.x, -4,0);
        }

        

        //if player position on the x is greater than 9.2
        //x position is 9.2
        //else if position on the x is less than -9.2f
        //x pos = -9.2f

        /*

        if (transform.position.x >=9.2f)
        {
            transform.position = new Vector3(9.2f, transform.position.y, 0);
        }
        else if (transform.position.x <= -9.2f)
        {
            transform.position = new Vector3(-9.2f, transform.position.y, 0);
        }

        */
   
        /*

        Challenge: instead of creating bounds for x and y, we create a wrap effect

        cube disappears at x: -11.3f & 11.3f
        cube disappears at y: -5.6f & 7

        if player position on the x is greater than 11.3f
        then x position = -11.29f
        else if postion on the x is less than -11.3f
        then x position = 11.29f

        */

        if (transform.position.x >= 11.3f)
        {
            transform.position = new Vector3(-11.29f, transform.position.y, 0);
        }
        else if (transform.position.x <= -11.3f)
        {
            transform.position = new Vector3(11.29f, transform.position.y, 0);
        }

        /*

        if player position on the y axis is greater than 7
        then y position = -5.59f
        else if position on the y axis is less than -5.6f
        then y position = 6.99f

        

        if (transform.position.y >= 7)
        {
            transform.position = new Vector3(transform.position.x, -5.59f, 0);
        }
        else if (transform.position.y <=-5.6f)
        {
            transform.position = new Vector3(transform.position.x, 6.99f, 0);
        }
        */
    }
}
