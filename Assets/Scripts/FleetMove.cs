using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class FleetMove : MonoBehaviour
{
    private bool isMoving = false;
    private Vector3 position;
    public float speed = 1f;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            SetTargetPosition();
        }
        if(isMoving)
        {
            Move();
        }
    }

    private void SetTargetPosition()
    {
        position = Input.mousePosition;
        //position.x = transform.position.x;

        isMoving = true;
    }

    private void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, position, speed * Time.deltaTime);
        if (transform.position == position)
        {
            isMoving = false;
        }
    }
}
