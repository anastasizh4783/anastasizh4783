using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x52fa1a43 : MonoBehaviour
{
    public Ease Ease = Ease.OutSine;
    public TMP_Text MainText;
    public void Show()
    {
        this._0x7a279118();
        if (this.Content != null)
        {
            DOTween.Kill(this.Content.transform, true);
            this.Content.SetActive(true);
            this.Content.transform.DOScale(1f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
            {
                _0xf933b7ea.Instance._0x2fd2a263(_0xf933b7ea.Instance.CurrentPanelIndex);
            });
        }
    }

    public void _0xb3a0e90b()
    {
        this._0x25978577();
        this.Content.SetActive(true);
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.localScale = Vector3.one;
        _0xf933b7ea.Instance._0x2fd2a263(_0xf933b7ea.Instance.CurrentPanelIndex);
    }

    private void _0x4a05fced()
    {
        if (this.OuterBackground != null)
        {
            Image _0xa1054e8c = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0xa1054e8c, true);
            _0xa1054e8c.DOFade(0f, this.ScaleDuration);
        }
    }

    public TMP_Text HeaderText;
    public GameObject OuterBackground;
    public float ScaleDuration = 0.4f;
    public GameObject Content;
    public void _0xcbf3bc6f()
    {
        this._0x4a05fced();
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
        {
            this.Content.SetActive(false);
        });
    }

    public bool IsScaledDownOnAwake = true;
    private void _0xc50f4431()
    {
        if (this.OuterBackground != null)
        {
            Image _0xd2633e0f = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0xd2633e0f, true);
            _0xd2633e0f.DOFade(0f, 0.01f);
        }

        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, 0.01f);
    }

    private bool _0x50727ebf => this.Content.transform.localScale.x > 0.5f && this.Content.transform.localScale.y > 0.5f;

    private void _0x7a279118()
    {
        if (this.OuterBackground != null)
        {
            Image _0x36004a95 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x36004a95, true);
            _0x36004a95.DOFade(1f, this.ScaleDuration / 2f);
        }
    }

    private void Awake()
    {
        this.Content.SetActive(true);
        if (this.OuterBackground != null)
            this.OuterBackground.gameObject.SetActive(true);
        if (this.IsScaledDownOnAwake)
            this._0xc50f4431();
    }

    private void _0x25978577()
    {
        if (this.OuterBackground != null)
        {
            Image _0x1366fc17 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x1366fc17, true);
            _0x1366fc17.DOFade(1f, 0f);
        }
    }
}