using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // This line of code is used for the "Left to Right" inputs in-game
        float horizontal = Input.GetAxis("Horizontal");

        // This line of code is used for the "Up to Down" inputs in-game
        float vertical = Input.GetAxis("Vertical");


        Vector2 position = transform.position;


        // This line of code is determining the speed the sprite moves from left to right
        // The number in front of "f" will determine the speed
        position.x = position.x + 3.0f * horizontal * Time.deltaTime;

        // This line of code is determining the speed the sprite moves from up to down
        // The number in front of "f" will determine the speed
        position.y = position.y + 3.0f * vertical * Time.deltaTime;

        transform.position = position;
    }
}
