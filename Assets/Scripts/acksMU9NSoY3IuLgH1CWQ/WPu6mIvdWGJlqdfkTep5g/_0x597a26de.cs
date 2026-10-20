using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Canvas))]
public class _0x597a26de : MonoBehaviour
{
    private void Awake()
    {
        if (!_0xb2dcae6f.Contains(this))
            _0xb2dcae6f.Add(this);
        this._0x8846cb6a = this.GetComponent<Canvas>();
        this._0xa219d26f = this.GetComponent<RectTransform>();
        this._0x84141111 = this.transform.Find(_0x01e1bc41._0x295fddd7(new byte[8] { 223, 237, 234, 233, 205, 254, 233, 237 }, 140)) as RectTransform;
        if (!_0x7a651b26)
        {
            _0x5a8d29c0 = Screen.orientation;
            _0x05b56032.x = Screen.width;
            _0x05b56032.y = Screen.height;
            _0x46e4bfb4 = Screen.safeArea;
            _0x7a651b26 = true;
        }

        this._0x48f91e08();
    }

    private static ScreenOrientation _0x5a8d29c0 = ScreenOrientation.LandscapeLeft;
    private static void SafeAreaChanged()
    {
        _0x46e4bfb4 = Screen.safeArea;
        for (int _0x7e2b86e9 = 0; _0x7e2b86e9 < _0xb2dcae6f.Count; _0x7e2b86e9++)
            _0xb2dcae6f[_0x7e2b86e9]._0x48f91e08();
    }

    private static Vector2 _0x05b56032 = Vector2.zero;
    private void Update()
    {
        if (_0xb2dcae6f[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0x5a8d29c0)
            OrientationChanged();
        if (Screen.safeArea != _0x46e4bfb4)
            SafeAreaChanged();
        if (Screen.width != _0x05b56032.x || Screen.height != _0x05b56032.y)
            ResolutionChanged();
    }

    private RectTransform _0xa219d26f;
    private static Rect _0x46e4bfb4 = Rect.zero;
    private void _0x48f91e08()
    {
        if (this._0x84141111 == null)
            return;
        Rect _0xaf250367 = Screen.safeArea;
        Vector2 _0x796624f6 = _0xaf250367.position;
        Vector2 _0x7434fb75 = _0xaf250367.position + _0xaf250367.size;
        _0x796624f6.x /= this._0x8846cb6a.pixelRect.width;
        _0x796624f6.y /= this._0x8846cb6a.pixelRect.height;
        _0x7434fb75.x /= this._0x8846cb6a.pixelRect.width;
        _0x7434fb75.y /= this._0x8846cb6a.pixelRect.height;
        this._0x84141111.anchorMin = _0x796624f6;
        this._0x84141111.anchorMax = _0x7434fb75;
    }

    private static UnityEvent _0xfab7f3ed = new();
    private static bool _0x7a651b26;
    private Canvas _0x8846cb6a;
    private static readonly List<_0x597a26de> _0xb2dcae6f = new();
    private RectTransform _0x84141111;
    private void OnDestroy()
    {
        if (_0xb2dcae6f != null && _0xb2dcae6f.Contains(this))
            _0xb2dcae6f.Remove(this);
    }

    private static void OrientationChanged()
    {
        _0x5a8d29c0 = Screen.orientation;
        _0x05b56032.x = Screen.width;
        _0x05b56032.y = Screen.height;
        _0xfab7f3ed.Invoke();
    }

    private static void ResolutionChanged()
    {
        _0x05b56032.x = Screen.width;
        _0x05b56032.y = Screen.height;
        _0xfab7f3ed.Invoke();
    }
}

internal static class _0x01e1bc41
{
    internal static string _0x295fddd7(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}