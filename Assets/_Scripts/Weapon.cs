using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Weapon : MonoBehaviour means Weapon inherits from MonoBehaviour

/*
  What is MonoBehaviour ?
   => MonoBehaviour is a base class that many Unity scripts derive from.
*/
public class Weapon : MonoBehaviour
{
    [SerializeField] // This show the rotationSpeed in the Inspector of the Game object(Weapon) but can't be modified.
    private int rotationSpeed = 200;
    
    [SerializeField]
    private Vector3 rotationPoint = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    

    /*
      What is a method?
        It represents a behaviour that the object can perform
    */
    
    // Update is called once per frame
    void Update()
    {
        // Transform is allows us to move objects in 2d or 3d space which has Position,Rotation and Scale
        // Vector3.zero is the center point for rotation
        // Vector3.forward moves around z axis
        // deltaTime=> The amount of time that passed from the last frame.
        
        // Right click ans select go to definition to check out the variable required

        // Using .(dot) allows us to access data and behaviors of any object defined in our scripts
         
        // While calling CalculateRotationAmount here use Time.deltaTime
        float rotationAmount = CalculateRotationAmount(Time.deltaTime);
        transform.RotateAround(rotationPoint, Vector3.forward, rotationAmount);
    }

    // While creating a method pass delta, we can't repeat the same value
    private float CalculateRotationAmount(float delta)
    {
        return rotationSpeed * delta;
    }
}
