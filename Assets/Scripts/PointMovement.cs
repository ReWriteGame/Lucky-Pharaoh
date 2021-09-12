using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointMovement : MonoBehaviour
{
    [SerializeField] private Transform[] points;
    [SerializeField] private GameObject obj;


    public void MovePoint(int index)
    {
        obj.transform.position = points[index].position;
    }
}
