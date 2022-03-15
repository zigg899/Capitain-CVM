using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;

public class PlateformDeath : MonoBehaviour
{
    [SerializeField]
    

    private bool _estDessus = false;

    
    // Start is called before the first frame update
    void Start()
    {
         Timer timer = new Timer(500);
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if(_estDessus== true)
        {


        }
    }

    private void FixedUpdate()
    {
        Collider2D[] _hitColliders = Physics2D.OverlapBoxAll(this.transform.position, this.transform.localScale * 3.8f, 0);
        Transform playerTrouve = null;
        for (int i = 0; i < _hitColliders.Length; i++)
            if (_hitColliders[i].CompareTag("Player"))
            {
                _estDessus = true;
                break;
            }

        
    }




}
