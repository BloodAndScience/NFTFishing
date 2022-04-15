using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boat : MonoBehaviour
{
    [SerializeField]
    private float _deAcceleration = 0.9f;
    [SerializeField]
    private float _speed = 1;
    [SerializeField]
    private float _acceleration = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void MoveLeft()
    {
        _speed -= _acceleration;}

    public void MoveRight()
    {
        _speed += _acceleration;}
    // Update is called once per frame
    void Update()
    {
        _speed = (_speed * _deAcceleration);
        transform.Translate(_speed*Time.deltaTime,0,0); 

    }
}
