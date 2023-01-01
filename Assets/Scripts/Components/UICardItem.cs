using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UICardItem : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler
{
    public enum CardStatus { Busy, ReadyToChoice, ReadyToNext}
    
    [SerializeField] private RectTransform _rect;
    [SerializeField] private Image _content;
    [SerializeField] private TMP_Text _choiceText;
    [SerializeField] private TMP_Text _endChoiceText;

    [Space]
    [SerializeField] private GameObject _contentTextBlock;
    [SerializeField] private GameObject _contentEndTextBlock;

    [Space]
    [SerializeField] private float _openDuration;

    [SerializeField] private CardStatus _cardStatus;

    private void Start()
    {
        _cardStatus = CardStatus.Busy;
        OpenCard();
    }

    private void OpenCard()
    {
        // set data
        
        _contentTextBlock.SetActive(true);
        _contentEndTextBlock.SetActive(false);
        
        var seq = DOTween.Sequence();
        seq.SetUpdate(true);
        seq.Append(_rect.DOScaleX(1, _openDuration).From(0));
        seq.OnComplete(() =>
        {
            _cardStatus = CardStatus.ReadyToChoice;
        });
    }

    private void ChoiceCard()
    {
        // set data
        
        _cardStatus = CardStatus.Busy;
        
        var seq = DOTween.Sequence();
        seq.SetUpdate(true);
        seq.Append(_rect.DOScaleX(0, _openDuration));
        seq.AppendCallback(() =>
        {
            _contentEndTextBlock.SetActive(true);
            _contentTextBlock.SetActive(false);
        });
        seq.Append(_rect.DOScaleX(1, _openDuration));
        seq.OnComplete(() =>
        {
            _cardStatus = CardStatus.ReadyToNext;
        });
    }

    private void NextCard()
    {
        // set data
        
        _cardStatus = CardStatus.Busy;
        
        var seq = DOTween.Sequence();
        seq.SetUpdate(true);
        seq.Append(_rect.DOScaleX(0, _openDuration));
        seq.AppendCallback(() =>
        {
            _contentEndTextBlock.SetActive(false);
            _contentTextBlock.SetActive(true);
        });
        seq.Append(_rect.DOScaleX(1, _openDuration));
        seq.OnComplete(() =>
        {
            _cardStatus = CardStatus.ReadyToChoice;
        });
    }

    public void CloseCard()
    {
        _cardStatus = CardStatus.Busy;
        
        var seq = DOTween.Sequence();
        seq.SetUpdate(true);
        seq.Append(_rect.DOScaleX(0, _openDuration));
        seq.AppendCallback(() =>
        {
            _contentEndTextBlock.SetActive(false);
            _contentTextBlock.SetActive(true);
        });
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        switch (_cardStatus)
        {
            case CardStatus.Busy:
                return;
            case CardStatus.ReadyToChoice:
                ChoiceCard();
                break;
            case CardStatus.ReadyToNext:
                NextCard();
                break;
            default:
                return;
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        
    }
}
