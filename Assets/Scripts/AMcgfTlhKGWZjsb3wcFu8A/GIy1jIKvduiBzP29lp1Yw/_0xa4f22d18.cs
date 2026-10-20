using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static _0xc1e39607;

public class _0xa4f22d18 : MonoBehaviour
{
    public void _0x629d171f()
    {
        _0x84a193a9._0xb384774b = true;
    }

    public void LoadSceneByIndex(int _0xdb4c2258)
    {
        //if (SceneManager.GetActiveScene().buildIndex == sceneIndex)
        //    AdsInitializer.Instance?.ShowAd();
        this.StartCoroutine(this._0xbf81884c(_0xdb4c2258));
    }

    public static bool IsAfterLevelFailed = false;
    public void _0xe01c8542()
    {
        foreach (_0x3385fd5f _0x43cdeb03 in this.MoneyCountContainers)
            _0x43cdeb03._0xa00e67ac();
    }

    public void _0x0c134fc0(bool _0x26d2997b)
    {
        this._0x81e7c22d = _0x26d2997b;
        this._0x58bbf54d(!this._0x81e7c22d);
        Physics2D.simulationMode = this._0x81e7c22d ? SimulationMode2D.FixedUpdate : SimulationMode2D.Script;
        if (this.EnvironmentWithTweensToToggle != null)
            this._0xcf155bc1(this.EnvironmentWithTweensToToggle);
    }

    [HideInInspector]
    public GameObject RootGameObject; // tag - "Root"
    private static void MakeGrid(List<RectTransform> _0xff30c277, AspectRatioFitter _0xb6bd9fb3, float _0xd099441e, int _0xfc2cb99d, int _0xef85b484)
    {
        _0xb6bd9fb3.aspectMode = AspectRatioFitter.AspectMode.WidthControlsHeight;
        _0xb6bd9fb3.aspectRatio = _0xd099441e;
        foreach (RectTransform _0x33bc403d in _0xff30c277)
        {
            int _0x23a6c195 = _0x33bc403d.transform.GetSiblingIndex();
            _0x33bc403d.anchorMin = new Vector3(Mathf.FloorToInt((float)_0x23a6c195 % _0xfc2cb99d) * (1f / _0xfc2cb99d), (_0xef85b484 - (Mathf.FloorToInt((float)_0x23a6c195 / _0xfc2cb99d) % _0xef85b484 + 1f)) * (1f / _0xef85b484));
            _0x33bc403d.anchorMax = new Vector3(Mathf.FloorToInt((float)_0x23a6c195 % _0xfc2cb99d + 1f) * (1f / _0xfc2cb99d), (_0xef85b484 - Mathf.FloorToInt((float)_0x23a6c195 / _0xfc2cb99d) % _0xef85b484) * (1f / _0xef85b484));
            _0x33bc403d.offsetMin = Vector2.zero;
            _0x33bc403d.offsetMax = Vector2.zero;
        }
    }

    private IEnumerator _0x88a217c3(string _0x0f6144d7)
    {
        _0xf933b7ea.Instance._0x5472689a(_0x596b9e44.SPLASH);
        //AudioController.Instance.SaveLastMusicTimes();
        AsyncOperation _0x5e621753 = SceneManager.LoadSceneAsync(_0x0f6144d7);
        while (!_0x5e621753.isDone)
            yield return null;
    }

    private void _0xf49db5bb()
    {
        IsAfterLevelComplete = true;
        Instance.LoadSceneByIndex(_0xfa7cc12d.SCENE_0);
    }

    public Button ShowResetTutorialButton;
    private IEnumerator _0xbf81884c(int _0xdf1c0b70)
    {
        _0xf933b7ea.Instance._0x5472689a(_0x596b9e44.SPLASH);
        AsyncOperation _0x8a5c6ddc = SceneManager.LoadSceneAsync(_0xdf1c0b70);
        while (!_0x8a5c6ddc.isDone)
            yield return null;
    }

    private static _0x61e57228 GAME_INDEX_SETTINGS(int _0x741417e2)
    {
        return _0x61e57228.ALL_SCENES_SETTING_SINGLETONS[_0x741417e2];
    }

    private void _0x58bbf54d(bool _0xa91592bf)
    {
        Rigidbody2D[] _0xef1b3c9e = this.RootGameObject.GetComponentsInChildren<Rigidbody2D>(true);
        foreach (Rigidbody2D _0xb6e6b02c in _0xef1b3c9e)
            if (_0xa91592bf)
                _0xb6e6b02c.constraints = RigidbodyConstraints2D.FreezeAll;
            else
                _0xb6e6b02c.constraints = RigidbodyConstraints2D.None;
    }

    public static _0x61e57228 _0x84a193a9 => _0x61e57228.ALL_SCENES_SETTING_SINGLETONS[Instance._0x1a25e84a];

    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0xa4f22d18>();
        this.RootGameObject = GameObject.FindWithTag(_0xe78c1d32._0xaa4b6c21(new byte[4] { 19, 46, 46, 53 }, 65));
        if (this._0x1a25e84a == _0xfa7cc12d.SCENE_0)
            this._0x0c134fc0(true);
        else
            this._0x0c134fc0(false);
        this.MoneyCountContainers = this.RootGameObject.GetComponentsInChildren<_0x3385fd5f>(true).ToList();
    }

    public bool _0x81e7c22d { get; private set; }

    public static _0xa4f22d18 Instance;
    public Button DeleteProgressDataButton;
    [HideInInspector]
    public List<_0x3385fd5f> MoneyCountContainers = new();
    public Transform Environment;
    public int _0x1a25e84a => SceneManager.GetActiveScene().buildIndex;

    public Canvas MainCanvas;
    private void _0xcf155bc1(Transform _0xb803fc29)
    {
        Transform[] _0xa8f4b9d5 = _0xb803fc29.GetComponentsInChildren<Transform>();
        foreach (Transform _0x18a59987 in _0xa8f4b9d5)
            if (_0x18a59987 != null && DOTween.IsTweening(_0x18a59987))
            {
                if (this._0x81e7c22d)
                    DOTween.Play(_0x18a59987);
                else
                    DOTween.Pause(_0x18a59987);
            }
    }

    private static _0x61e57228 _0x8f77eddc => _0x61e57228.ALL_SCENES_SETTING_SINGLETONS[0];

    public static bool IsAfterLevelComplete;
    public Transform EnvironmentWithTweensToToggle;
    public void _0x9280a04d()
    {
        this.LoadSceneByIndex(SceneManager.GetActiveScene().buildIndex);
    }

    private static void ExitGame()
    {
        Application.Quit();
    }

    private void Start()
    {
        if (this._0x1a25e84a != _0xfa7cc12d.SCENE_0)
            Screen.orientation = ScreenOrientation.Portrait;
        this.DeleteProgressDataButton?.onClick.AddListener(() =>
        {
            PlayerPrefs.DeleteAll();
            //AudioController.Instance.UpdateMusics();
            //AudioController.Instance.UpdateSfxes();
            Instance.LoadSceneByIndex(_0xfa7cc12d.SCENE_0);
        });
        this.ShowResetTutorialButton?.onClick.AddListener(() =>
        {
            _0x84a193a9._0xb384774b = false;
            _0xae24774e.Instance._0x6a384f5d();
            _0xf933b7ea.Instance._0x5472689a(_0x596b9e44.TUTORIAL0);
        });
    }
}

internal static class _0xe78c1d32
{
    internal static string _0xaa4b6c21(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}