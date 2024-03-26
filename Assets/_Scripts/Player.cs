using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //  horizontalAxis = "Horizontal" Left and Right values, verticalAxis = "Vertical"; // Up and Down values;
    [SerializeField]
    private string _horizontalAxis = "Horizontal",  _verticalAxis = "Vertical"; 
    [SerializeField]
    private Rigidbody2D _rb2d;
    
    private Vector2 _input; // Declare the input
    private void FixedUpdate() {
        _rb2d.velocity = _input; // After that assign _input to _rb2d.velocity 
    }

    /*
      Use input.GetAxisRaw 
        "Since input is not smoothed, keyboard input will always be either(returns) -1, 0 or 1 "
      
      Refer to the Project Settings -> Input Manager (incase if you want to update the key bindings)

      Horizontal => positive: Right and negative: Left
      Vertical => positive: Up and negative: Down

      We use _(Underscore) because it's an indication that it is a private value and no changes should be made.

      Rigidbody2D :-
            Adding a Rigidbody2D component to a sprite puts it under the control of the physics engine. 
      
    */

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxisRaw(_horizontalAxis); // Left and Right
        float VerticalInput = Input.GetAxisRaw(_verticalAxis); // Up and Down
        _input = new Vector2(horizontalInput, VerticalInput); // Store the above two in the variable _input
    }
}
