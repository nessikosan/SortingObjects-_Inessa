using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BSorting : MonoBehaviour
{
    public GameObject[] tubes;
    GameObject obj;
    Vector3 objPosition;
    public void StartSort()
    {
        BubbleSort(tubes);
    }
    public void BubbleSort(GameObject[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length-i-1; j++)
            {
                if (array[j].transform.localScale.y < array[j + 1].transform.localScale.y)
                {
                    obj = array[j];
                    array[j] = array[j+1];
                    array[j+1] = obj;

                    objPosition = array[j].transform.position;
                    array[j].transform.position = new Vector3(array[j + 1].transform.position.x, objPosition.y, objPosition.z);
                    array[j + 1].transform.position = new Vector3(objPosition.x, array[j + 1].transform.position.y, array[j + 1].transform.position.z);
                }
            }    
        }
    }
}
 