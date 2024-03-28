
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
        Vector3 spawnPosition = SelectRandomPosition();
        Debug.Log(spawnPosition);
    }

    private Vector3 SelectRandomPosition()
    {
        Transform selectedTransform = null;

        // Returns a random float within [minInclusive..maxInclusive]
        int randomValue = Random.Range(0,4); // 0,1,2,3 (_spawnTopLeft, _spawnTopRight, _spawnBottomLeft, _spawnBottomRight;)
        switch(randomValue) // switch statement brackets is not required(optional).
        {
          case 0: 
               selectedTransform = _spawnTopLeft; // for auto completion ctrl + spacebar
               break;
          case 1:
               selectedTransform = _spawnTopRight;
               break;
          case 2:
              selectedTransform = _spawnBottomLeft;
              break;
          case 3:
              selectedTransform = _spawnBottomRight;
              break;
          default:
              selectedTransform = _spawnTopLeft; 
               break;
                
        }
        return selectedTransform.position;
    }



    // Update is called once per frame
    void Update()
    {
      
    }
}
