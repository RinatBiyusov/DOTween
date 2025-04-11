using DG.Tweening;
using UnityEngine;

public class DGMover : MonoBehaviour
{
    [SerializeField] private float _offsetZ;
    [SerializeField] private float _moveDuration; 
    
    private Vector3 _startPos;
    private Vector3 _offsetPosition;

    private void Start()
    {
        _startPos = transform.position;
        
        Sequence movement = DOTween.Sequence();

        movement
            .Append(transform.DOMoveZ(_startPos.z + _offsetZ, _moveDuration).SetEase(Ease.Linear))
            .Append(transform.DOMoveZ(_startPos.z - _offsetZ, _moveDuration * 2).SetEase(Ease.Linear))
            .Append(transform.DOMoveZ(_startPos.z, _moveDuration).SetEase(Ease.Linear))
            .SetLoops(-1, LoopType.Restart);
    }
}