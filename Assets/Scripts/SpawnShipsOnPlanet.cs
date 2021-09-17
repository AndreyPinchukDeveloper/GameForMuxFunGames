using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericSpawnShipsOnPlanet<T> : MonoBehaviour where T : MonoBehaviour
{
    [SerializeField] private T _prefab;
    [SerializeField] private Transform _pointToSpawn;
    private int n = 0;

    public T GetNewInstance()
    {
        Vector3 pos = new Vector3(_pointToSpawn.position.x, _prefab.transform.position.y, z: _pointToSpawn.position.z + n);
        n++;

        return Instantiate(_prefab, pos, Quaternion.identity);
    }
}
