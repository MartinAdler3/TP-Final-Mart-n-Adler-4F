using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelManager : MonoBehaviour
{
    public GameObject[] modelos;
    public int CurrentIndex = -1;
    // Start is called before the first frame update
    void Start()
    {
        DeactibateAll();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            CurrentIndex++;
            if (CurrentIndex >= modelos.Length)
            {
                CurrentIndex = 0;
            }
            DeactibateAll();
            ActibateByIndex(CurrentIndex);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            CurrentIndex--;
            if (CurrentIndex <= 0)
            {
                CurrentIndex = modelos.Length-1;
            }
            DeactibateAll();
            ActibateByIndex(CurrentIndex);
        }
    }

    void DeactibateAll()
    {
        for (int i = 0; i < modelos.Length; i++)
        {
            modelos[i].SetActive(false);
        }
    }

    void ActibateByIndex(int index)
    {
        modelos[index].SetActive(true);
    }
}
