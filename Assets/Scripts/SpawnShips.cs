using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnShips : MonoBehaviour
{
    public Transform SpawnPos;
    public GameObject ship;
    void Start()
    {
        StartCoroutine(SpawnCD());
    }

    void Repeat()
    {
        StartCoroutine(SpawnCD());
    }
    IEnumerator SpawnCD()
    {
        yield return new WaitForSeconds(5);
        Instantiate(ship, SpawnPos.position, Quaternion.identity);
        Repeat();
    }
}
