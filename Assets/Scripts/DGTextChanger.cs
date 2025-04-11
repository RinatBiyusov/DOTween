using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class DGTextChanger : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private float _duration;
    [SerializeField] private float _delay;
    [SerializeField] private string _changeText;
    [SerializeField] private string _additionalText;
    [SerializeField] private string _hackedText;

    private void Start()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(_text.DOText(_changeText, _duration));
        sequence.Append(_text.DOText(_text.text + _additionalText, _duration));
        sequence.Append(_text.DOText(_hackedText, _duration, true, ScrambleMode.All));
        sequence.SetLoops(-1,LoopType.Restart);
        sequence.SetDelay(_delay);
    }
}
