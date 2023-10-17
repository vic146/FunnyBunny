using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileThrower : MonoBehaviour
{
    public GameObject projectilePrefab;

    public void Throw(){
        Instantiate(projectilePrefab, transform.position, Quaternion.identity);
    }
}
