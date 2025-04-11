using System;
using DG.Tweening;
using UnityEngine;

public class DGRotator : MonoBehaviour
{
    [SerializeField] private float _rotateSpeed;

    private void Start()
    {
        float duration = 360f / _rotateSpeed; 

        transform.DORotate(new Vector3(0, 360, 0), duration, RotateMode.WorldAxisAdd)
            .SetEase(Ease.Linear) 
            .SetLoops(-1, LoopType.Restart)   
            .SetRelative(true);                
    }
}