using DG.Tweening;
using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class DGColorizer : MonoBehaviour
{
    [SerializeField] private Color _color;
    [SerializeField] private float _duration;

    private Material _material;

    private void Awake()
    {
        _material = GetComponent<Renderer>().material;
    }

    private void Start()
    {
        _material.DOColor(_color, _duration).SetLoops(-1, LoopType.Yoyo);
    }
}