using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FleetMove : MonoBehaviour
{
    private RaycastHit raycastHit;
    private GameObject SpaceShip;
    private float distance;
    private Vector3 ObjPosition;
    private bool Bobj;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            var ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
            var hit = Physics.Raycast(ray.origin, ray.direction, out raycastHit);

            if (hit && !Bobj)
            {
                SpaceShip = raycastHit.collider.gameObject;
                distance = raycastHit.distance;
                Debug.Log(SpaceShip.name);
            }

            Bobj = true;
            ObjPosition = ray.origin + distance * ray.direction;
            SpaceShip.transform.position = new Vector3(ObjPosition.x, ObjPosition.y, ObjPosition.z);
        }
        else
        {
            Bobj = false;
            SpaceShip = null;
        }
    }
}
