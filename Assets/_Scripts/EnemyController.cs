
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

/*
  What is a Prefab ?
   => Unity’s Prefab system allows you to create, configure, and store a GameObject
      complete with all its components, property values, and child GameObjects as a reusable Asset. 
      The Prefab Asset acts as a template from which you can create new Prefab instances in the Scene.
*/

/*
  What are Enums ?
   => Are used to give meaningful names to some values
    Refer to this site: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/enum

  For casting and conversions refer this https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/casting-and-type-conversions
*/

public class EnemyController : MonoBehaviour
{
    [SerializeField]
    private GameObject _enemyPrefab; 

    [SerializeField]
    private int _enemyCount = 5;
    
    [SerializeField]

    private Transform _spawnTopLeft, _spawnTopRight, _spawnBottomLeft, _spawnBottomRight;
    void Start()
    {
        for(int i = 0; i < _enemyCount; i++)
        {
           SpawnEnemy();
        }
    }

    private void SpawnEnemy()
    { 
        // To instantiate a Prefab at run time, your code needs a reference to that Prefab. You can make this reference by creating a public 
        // variable in your code to hold the Prefab reference. 
        //The public variable in your code appears as an assignable field in the Inspector.

        Vector3 spawnPosition = SelectRandomPosition();

        // quaternion corresponds to "no rotation" - the object is perfectly aligned with the world or parent axes.

        GameObject enemyObject 
                = Instantiate(_enemyPrefab, spawnPosition, Quaternion.identity);
    }

    private Vector3 SelectRandomPosition()
    {
        Transform selectedTransform = null;

        // Returns a random float within [minInclusive..maxInclusive]
        int randomValue = Random.Range(0,4); // 0,1,2,3 (_spawnTopLeft, _spawnTopRight, _spawnBottomLeft, _spawnBottomRight;)
        SpawnPointType spawnType = (SpawnPointType)randomValue; // Explicit type conversion
        switch(spawnType) // switch statement brackets is not required(optional).
        {
          case SpawnPointType.TopLeft: 
               selectedTransform = _spawnTopLeft; // for auto completion ctrl + spacebar
               break;
          case SpawnPointType.TopRight:
               selectedTransform = _spawnTopRight;
               break;
          case SpawnPointType.BottomLeft:
              selectedTransform = _spawnBottomLeft;
              break;
          case SpawnPointType.BottomRight:
              selectedTransform = _spawnBottomRight;
              break;
          default:
              selectedTransform = _spawnTopLeft; 
               break;
                
        }
        return selectedTransform.position + (Vector3)Random.insideUnitCircle;
    }



    // Update is called once per frame
    void Update()
    {
      
    }

}

    public enum SpawnPointType
    {

       // Not necessarily required to put 0,1,2,3 we can put any number as we like
       TopLeft = 0 ,
       TopRight = 1,
       BottomLeft = 2,
       BottomRight = 3
    }
