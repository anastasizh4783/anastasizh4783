using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x23c3e20b : MonoBehaviour
{
    private bool _0x0d211f4d => this.Content.transform.localScale.x > 0.5f && this.Content.transform.localScale.y > 0.5f;

    public bool IsScaledDownOnAwake = true;
    public TMP_Text ContentHeaderText;
    public Ease ease = Ease.OutSine;
    private void Start()
    {
    // Content.SetActive(false);
    }

    public GameObject Content;
    public float scaleDuration = 0.4f;
    private void _0xccd60fe0()
    {
        DOTween.Kill(this.Content.transform, true);
        if (this.IsOnlyYScale)
            this.Content.transform.DOScaleY(0f, 0.01f);
        else
            this.Content.transform.DOScale(0f, 0.01f);
        this.Content.SetActive(false);
    }

    public static void HideAllPops()
    {
        _0xae24774e.Instance._0x6a384f5d();
    }

    public TMP_Text ContentMainText;
    private void Awake()
    {
        this.Content.SetActive(true);
        if (this.IsScaledDownOnAwake)
            this._0xccd60fe0();
    }

    public bool IsOnlyYScale;
    public Image ContentImage;
    public void _0x1eefddef()
    {
        if (this.Content.gameObject.activeSelf)
        {
            DOTween.Kill(this.Content.transform, true);
            if (this.IsOnlyYScale)
                this.Content.transform.DOScaleY(0f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
                {
                    this.Content.SetActive(false);
                });
            else
                this.Content.transform.DOScale(0f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
                {
                    this.Content.SetActive(false);
                });
        }
    }

    public TMP_Text ContentAdditionalText;
    public void Show()
    {
        this.Content.SetActive(true);
        if ((DOTween.TweensByTarget(this.Content.transform)?.Count ?? 0) > 0)
            DOTween.Kill(this.Content.transform, true);
        if (this.IsOnlyYScale)
            this.Content.transform.DOScaleY(1f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
            {
            });
        else
            this.Content.transform.DOScale(1f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
            {
            });
    }
}