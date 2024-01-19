using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Sorting : MonoBehaviour
{
    public GameObject[] tubes;
    int min;
    GameObject obj;
    Vector3 objPosition;
    public void StartSort()
    {
        SelectionSort(tubes);     
    }
    public void Reset()
    {
        SceneManager.LoadScene(0);
    }
    public void SelectionSort(GameObject[] Array)
    {
        for(int i=0; i < Array.Length; i++)
        {
            min = i;

            for (int j = i + 1; j < Array.Length; j++)
            {
                if (Array[j].transform.localScale.y <  Array[min].transform.localScale.y)
                {
                    min = j;
                }
            }
            if(min != i)
            {
                obj = Array[i];
                Array[i] = Array[min];
                Array[min] = obj;

                objPosition = Array[i].transform.position;
                Array[i].transform.position = new Vector3(Array[min].transform.position.x, objPosition.y, objPosition.z);
                Array[min].transform.position = new Vector3(objPosition.x, Array[min].transform.position.y, Array[min].transform.position.z); 
            }
        }
    }
    
}
