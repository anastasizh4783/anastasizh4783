using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Canvas))]
public class _0x49fcf9bc : MonoBehaviour
{
    private static void ApplySafeAreaToAll()
    {
        for (int _0xc241c210 = 0; _0xc241c210 < _0x0ef8bcbc.Count; _0xc241c210++)
            _0x0ef8bcbc[_0xc241c210]._0xc9e2a14a();
    }

    private static ScreenOrientation _0x0da4874f = ScreenOrientation.LandscapeLeft;
    private CanvasScaler _0x984ace01;
    private static readonly List<_0x49fcf9bc> _0x0ef8bcbc = new();
    private static bool _0x8d03ffdd;
    private static UnityEvent _0x7bb9cea2 = new();
    private static Vector2 _0xa75181c0 = Vector2.zero;
    private void OnDestroy()
    {
        if (_0x0ef8bcbc != null && _0x0ef8bcbc.Contains(this))
            _0x0ef8bcbc.Remove(this);
    }

    private RectTransform _0x92072fa6;
    private Vector2 _0x6ea6554e;
    private static void SafeAreaChanged()
    {
        _0x8b5d83dc = Screen.safeArea;
        ApplySafeAreaToAll();
    }

    private static void OrientationChanged()
    {
        _0x0da4874f = Screen.orientation;
        _0xa75181c0.x = Screen.width;
        _0xa75181c0.y = Screen.height;
        _0x8b5d83dc = Screen.safeArea;
        ApplySafeAreaToAll();
        _0x7bb9cea2.Invoke();
    }

    private void _0xc9e2a14a()
    {
        if (this._0x92072fa6 == null)
            return;
        float screenWidth = Screen.width;
        float screenHeight = Screen.height;
        if (screenWidth <= 0f || screenHeight <= 0f)
            return;
        Rect _0x66b3fe08 = Screen.safeArea;
        Vector2 _0x212f7f4f = _0x66b3fe08.position;
        Vector2 _0x222f3008 = _0x66b3fe08.position + _0x66b3fe08.size;
        _0x212f7f4f.x /= screenWidth;
        _0x212f7f4f.y /= screenHeight;
        _0x222f3008.x /= screenWidth;
        _0x222f3008.y /= screenHeight;
        this._0x92072fa6.anchorMin = _0x212f7f4f;
        this._0x92072fa6.anchorMax = _0x222f3008;
        this._0x92072fa6.offsetMin = Vector2.zero;
        this._0x92072fa6.offsetMax = Vector2.zero;
        if (this._0x984ace01 == null)
            return;
        Vector2 _0x0042b8c1 = _0x222f3008 - _0x212f7f4f;
        float _0xbc5d0b5f = 2f - _0x0042b8c1.x;
        float _0xceeceeac = 2f - _0x0042b8c1.y;
        this._0x984ace01.referenceResolution = this._0x6ea6554e * new Vector2(_0xbc5d0b5f, _0xceeceeac);
    }

    private void Update()
    {
        if (_0x0ef8bcbc.Count == 0 || _0x0ef8bcbc[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0x0da4874f)
            OrientationChanged();
        if (Screen.safeArea != _0x8b5d83dc)
            SafeAreaChanged();
        if (Screen.width != _0xa75181c0.x || Screen.height != _0xa75181c0.y)
            ResolutionChanged();
    }

    private void Start()
    {
    }

    private static void ResolutionChanged()
    {
        _0xa75181c0.x = Screen.width;
        _0xa75181c0.y = Screen.height;
        _0x8b5d83dc = Screen.safeArea;
        ApplySafeAreaToAll();
        _0x7bb9cea2.Invoke();
    }

    private RectTransform _0xc9cbafe6;
    private void Awake()
    {
        if (!_0x0ef8bcbc.Contains(this))
            _0x0ef8bcbc.Add(this);
        this._0x0c506e26 = this.GetComponent<Canvas>();
        this._0x984ace01 = this.GetComponent<CanvasScaler>();
        if (this._0x984ace01 != null)
            this._0x6ea6554e = this._0x984ace01.referenceResolution;
        this._0xc9cbafe6 = this.GetComponent<RectTransform>();
        this._0x92072fa6 = this.transform.Find(_0xbbd4e8b6._0x3f8e507d(new byte[8] { 201, 251, 252, 255, 219, 232, 255, 251 }, 154)) as RectTransform;
        if (!_0x8d03ffdd)
        {
            _0x0da4874f = Screen.orientation;
            _0xa75181c0.x = Screen.width;
            _0xa75181c0.y = Screen.height;
            _0x8b5d83dc = Screen.safeArea;
            _0x8d03ffdd = true;
        }

        this._0xc9e2a14a();
    }

    private Canvas _0x0c506e26;
    private static Rect _0x8b5d83dc = Rect.zero;
}

internal static class _0xbbd4e8b6
{
    internal static string _0x3f8e507d(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}