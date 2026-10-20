using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0x2561fcee : MonoBehaviour
{
    public GameObject Content;
    public float DefaultAnimationTime = 0.4f;
    public void _0x5445bb45()
    {
        this._0xa6a1bd61?.Kill();
        this.AnimationSlider.value = _0x765eb1fb ? this.SecondPassSliderValue : 0.05f;
    }

    public GameObject Error;
    public float FirstAnimationTime = 10.0f;
    private Sequence _0xa6a1bd61;
    public void _0x4f346730()
    {
        this._0x5445bb45();
        bool _0x880b1d38 = _0x765eb1fb;
        this._0xa6a1bd61 = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0x921bfaf2 => this.AnimationSlider.value = _0x921bfaf2, _0x880b1d38 ? 1f : this.SecondPassSliderValue, this.DefaultAnimationTime)).SetEase(Ease.Linear);
        _0x765eb1fb = !_0x765eb1fb;
    }

    public Slider AnimationSlider;
    public float SecondPassSliderValue = 0.5f;
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x2561fcee>();
    }

    private void _0xc0206b60()
    {
        this.AnimationSlider.value = 0.05f;
        _0x765eb1fb = !_0x765eb1fb;
        this._0xa6a1bd61 = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0x921bfaf2 => this.AnimationSlider.value = _0x921bfaf2, 1f, this.FirstAnimationTime)).SetEase(Ease.Linear).OnComplete(() =>
        {
            _0x816188c0._0x53693dca?._0x428afa93();
        });
    }

    public void _0xc571c969()
    {
        this._0xa6a1bd61?.Pause();
    }

    public void _0x8b9d4634()
    {
        {
#if B_LOGS
            {
                Debug.Log($"[Test] Animate Force");
            }
#endif
        }

        this._0xa6a1bd61?.Kill();
        if (AnimationSlider != null)
            this.AnimationSlider.value = 1f;
        _0x765eb1fb = false;
    }

    public static _0x2561fcee Instance;
    private static bool _0x765eb1fb = false;
    public GameObject Background;
    private void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == _0xc1e39607._0xfa7cc12d.SCENE_0 && !_0x765eb1fb)
        {
            this._0xc0206b60();
        }
        else
        {
            this._0x4f346730();
        }
    }

    public void _0x1e4a970c()
    {
        this._0xa6a1bd61?.Play();
    }
}