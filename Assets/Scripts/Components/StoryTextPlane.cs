using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class StoryTextPlane : MonoBehaviour
{
    [SerializeField] private RectTransform _rect;
    [SerializeField] private TMP_Text _storyText;

    [Space]
    [SerializeField] private float _openDuration;


    private void Start()
    {
        OpenCard();
    }

    private void OpenCard()
    {
        // set data
        
        var seq = DOTween.Sequence();
        seq.SetUpdate(true);
        seq.Append(_rect.DOScaleX(1, _openDuration).From(0));
    }

    private void SetStory()
    {
        // set data
        
        var seq = DOTween.Sequence();
        seq.SetUpdate(true);
        seq.Append(_rect.DOScaleX(0, _openDuration));
        seq.AppendCallback(() =>
        {
            _storyText.text = "ChoiceCard";
        });
        seq.Append(_rect.DOScaleX(1, _openDuration));
    }

    private void NextStory()
    {
        // set data
        
        var seq = DOTween.Sequence();
        seq.SetUpdate(true);
        seq.Append(_rect.DOScaleX(0, _openDuration));
        seq.AppendCallback(() =>
        {
            _storyText.text = "NextCard";
        });
        seq.Append(_rect.DOScaleX(1, _openDuration));
    }
}
