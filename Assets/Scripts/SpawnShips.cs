using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnShips : MonoBehaviour
{
    public Transform SpawnPos;
    public GameObject ship;
    private float range = 0;
    public int fleet=-1;
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
        Vector3 pos = new Vector3(SpawnPos.position.x + range, SpawnPos.position.y, z: SpawnPos.position.z);
        range += 0.2f;
        fleet++;
        yield return new WaitForSeconds(1);
        Instantiate(ship, pos, Quaternion.identity);
        Repeat();
    }
}
