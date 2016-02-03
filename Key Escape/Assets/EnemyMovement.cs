using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

    [SerializeField]
    float kspeed;

    void Move()
    {
        transform.position = Vector3.Lerp(transform.position, EnemySearch.target, kspeed * Time.deltaTime);
    }
}
