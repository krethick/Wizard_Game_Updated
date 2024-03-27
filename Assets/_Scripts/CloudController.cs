// Refer to the chapter collision https://docs.unity3d.com/Manual/CollidersOverview.html

// A collider’s type is based on the configuration of its GameObject’s Collider and Rigidbody components


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudController : MonoBehaviour
{
 
    [SerializeField] 
    private Transform [] _clouds = new Transform[4]; // Initialising the Array (the list option is created in the inspector)

    [SerializeField] 
    private float _speed = 1.0f;

    [SerializeField] 
    private float _xLimit = 12.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // To move our cloud we use the transform component.
    void Update()
    {
       for(int i = 0; i < _clouds.Length; i++)
       {
         // Get the cloud's position and go to the left with speed and delta time
          _clouds[i].position = 
                         _clouds[i].position + Vector3.right * Time.deltaTime * _speed; 
        
        if(_clouds[i].position.x > _xLimit)
        {
           _clouds[i].position -= new Vector3(2 *_xLimit,0,0); // Move the clouds to the right after that slowly teleports to the left
        }
          
       }
    }
}
