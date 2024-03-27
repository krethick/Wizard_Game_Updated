using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// _clouds.Length-1 this will represent the last element of the array  Debug.Log("Cloud at index " + _clouds.Length + _clouds[_clouds.Length-1]);
      
      //  Debug.Log("Cloud at index " + _clouds.Length + _clouds[^1]); this is same as _clouds[_clouds.Length-1] which represents the last element of the array.

public class CloudController : MonoBehaviour
{
 
    [SerializeField] 
    private Transform [] _clouds = new Transform[4]; // Initialising the Array (the list option is created in the inspector)
    [SerializeField] 
    private float _speed = 1.0f;
    
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
          _clouds[i].position = _clouds[i].position + Vector3.right * Time.deltaTime * _speed; 
       }
    }
}
