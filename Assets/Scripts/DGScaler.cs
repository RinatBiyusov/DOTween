using DG.Tweening;
using UnityEngine;

public class DGScaler : MonoBehaviour
{
    [SerializeField] private Vector3 _size;
    
    private void Start()
    {
        transform.DOScale(_size, 1f)
            .SetEase(Ease.Linear)
            .SetLoops(-1, LoopType.Yoyo);
    }
}