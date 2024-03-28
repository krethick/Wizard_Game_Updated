using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class EnemyAI : MonoBehaviour
{

    [SerializeField]
    private float _speed = 1;
    private Rigidbody2D _rb2d;

    private Transform _playerTransform; // To move towards the player

    public bool Stopped = false;

    [SerializeField]
    private GameObject _crabDead;

    /*
      Change the order in layer as 0
    */
    // Start is called before the first frame update 
    void Start()
    {
        _rb2d = GetComponent<Rigidbody2D>();
         Player player = FindObjectOfType<Player>();
         if(player !=null)
         {
           _playerTransform = player.transform;
         }else
         {
            Stopped = true;
         }
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        if(Stopped || _playerTransform == null) 
        {
            _rb2d.velocity = Vector3.zero;
            return;
        }

        Vector3 directionToPlayer = _playerTransform.position - transform.position;
        _rb2d.velocity = directionToPlayer.normalized * _speed;

    }

        private void OnTriggerEnter2D(Collider2D collision) 
        {
            if(collision.CompareTag("Weapon")){ // Collide the weapon
                Instantiate(_crabDead, transform.position, Quaternion.identity);
                Destroy(gameObject); // Destroys the enemyt
            }
        }
}
