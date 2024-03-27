using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Rigidbody2D.MoveRotation ("The new rotation angle for the Rigidbody object.")
public class WeaponRotation : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D _rb2d;

    [SerializeField]
    private float _speed = 200;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate() // FixedUpdate is usually used for physics calculations
    {
        _rb2d.MoveRotation(_rb2d.rotation + _speed * Time.fixedDeltaTime); // fixedDeltaTime in FixedUpdate() is some ideal (or expected) time interval that physic simulation process should follow.
    }
}
