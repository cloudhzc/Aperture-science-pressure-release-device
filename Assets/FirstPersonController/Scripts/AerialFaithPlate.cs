using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class AerialFaithPlate : MonoBehaviour
{
    void Start()
    {
        DOTween.Init();
    }

    void Update()
    {
        if (true)
        {
            transform.DOMoveY(10, 10f,false);
        }
    }
}
