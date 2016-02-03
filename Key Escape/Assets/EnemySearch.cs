using UnityEngine;
using System.Collections;

public class EnemySearch : MonoBehaviour {

    [SerializeField]
    Transform[] searching;
    public static Vector3 target;

    void Start()
    {
        InvokeRepeating("Search", 1, 10);
    }

    void Search ()
    {
        int index = Random.Range(0, searching.Length);
        target = searching[index].position;
    }
}
