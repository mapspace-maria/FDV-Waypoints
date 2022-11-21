using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followme : MonoBehaviour
{
   [SerializeField]
   private Transform _goal;


   [SerializeField]
   private float _speed = 2f;
    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 v3;
        v3 = Vector3.MoveTowards(transform.position, _goal.position, _speed * Time.deltaTime);
        this.transform.position =v3;
        
    }
}
