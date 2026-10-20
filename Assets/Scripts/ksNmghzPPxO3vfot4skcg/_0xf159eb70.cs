using System.Collections.Generic;
using UnityEngine;

// Sends the plumes down on the schedule the plan drew, keeps one pooled object per
// plume and reports the angle the next one wants so the tilt meter can show a
// ghost marker ahead of time.
public sealed class _0xf159eb70 : MonoBehaviour
{
    private int _0xcb2efa17;
    private float _0xd7f0993f;
    private float _0x395c3027;
    private _0x12a0c0f8 _0xd595ad7f;
    public void _0x5daa7f6a(Camera _0xb924f1c8, _0x12a0c0f8 _0x8331fa47, GameObject _0x39684d8e, Sprite _0x64f624d0)
    {
        this._0x29b7c3db = _0xb924f1c8;
        this._0xd595ad7f = _0x8331fa47;
        this._0x546cb338 = _0x39684d8e;
        this._0xc696741e = _0x64f624d0;
        float width = _0xf21ad269.ScreenWidth(_0xb924f1c8);
        float _0xf6b31fa4 = _0xf21ad269.HalfHeight(_0xb924f1c8);
        this._0xd7f0993f = width * _0xf21ad269.PlumeWidth;
        this._0x395c3027 = _0xf6b31fa4 * _0xf21ad269.PlumeTopHeight;
        this._0x0af40605 = _0xf6b31fa4 * _0xf21ad269.TrayHeight;
        this._0xcb2efa17 = 0;
        this._0x173fd7c6 = 0;
    }

    private int _0x173fd7c6;
    private Camera _0x29b7c3db;
    public int _0x3d48de45
    {
        get
        {
            return this._0x173fd7c6;
        }
    }

    private void _0x387bbf50(_0x12a0c0f8.PlumeDrop _0x8fa30b2d)
    {
        SpriteRenderer _0x0a25914c;
        if (this._0x546cb338 != null)
        {
            GameObject _0x2f2749fc = Instantiate(this._0x546cb338, this.transform);
            _0x2f2749fc.transform.localScale = Vector3.one;
            _0x0a25914c = _0x2f2749fc.GetComponent<SpriteRenderer>();
        }
        else
        {
            _0x0a25914c = _0xf21ad269.Make(this.transform, _0xb5182d5b._0x780b2bd7(new byte[5] { 103, 91, 66, 90, 82 }, 55), this._0xc696741e, _0xf21ad269.PlumeOrder, this._0xd7f0993f);
        }

        if (_0x0a25914c == null)
        {
            return;
        }

        if (_0x0a25914c.sprite == null)
        {
            _0x0a25914c.sprite = this._0xc696741e;
        }

        _0x7b3146fc _0x1bad8557 = _0x0a25914c.gameObject.AddComponent<_0x7b3146fc>();
        float _0x8bd50d06 = _0xf21ad269.HalfWidth(this._0x29b7c3db) * _0x8fa30b2d.LaneOffset;
        _0x1bad8557._0xd4266769(_0x0a25914c, this._0xd7f0993f, _0x8bd50d06, this._0x395c3027, this._0x0af40605, _0x8fa30b2d.CatchDegrees, _0x12a0c0f8.PlumeWarningSeconds);
        this._0x14cafe81.Add(_0x1bad8557);
    }

    public float _0x4c1838f7(float _0xbf75bf0e, out float _0xfc6e88cd)
    {
        _0xfc6e88cd = 99f;
        if (this._0xd595ad7f == null)
        {
            return 0f;
        }

        // Searched from the start, not from the launch cursor: a plume that is
        // already falling is exactly the one the meter must mark.
        for (int _0xa838cf51 = 0; _0xa838cf51 < this._0xd595ad7f.Plumes.Count; _0xa838cf51++)
        {
            float _0x34cfe076 = this._0xd595ad7f.Plumes[_0xa838cf51].Seconds;
            if (_0x34cfe076 >= _0xbf75bf0e)
            {
                _0xfc6e88cd = _0x34cfe076 - _0xbf75bf0e;
                return this._0xd595ad7f.Plumes[_0xa838cf51].CatchDegrees;
            }
        }

        return 0f;
    }

    // Returns how many plumes were caught on this step.
    public int _0x6d401e69(float _0x08df3766, float step, float _0x30b0ea98)
    {
        int _0xd904e667 = 0;
        if (this._0xd595ad7f == null)
        {
            return 0;
        }

        while (this._0xcb2efa17 < this._0xd595ad7f.Plumes.Count && this._0xd595ad7f.Plumes[this._0xcb2efa17].Seconds - _0x12a0c0f8.PlumeWarningSeconds <= _0x08df3766)
        {
            this._0x387bbf50(this._0xd595ad7f.Plumes[this._0xcb2efa17]);
            this._0xcb2efa17++;
        }

        for (int _0xc31eb086 = this._0x14cafe81.Count - 1; _0xc31eb086 >= 0; _0xc31eb086--)
        {
            _0x7b3146fc _0x80fa2c1f = this._0x14cafe81[_0xc31eb086];
            if (_0x80fa2c1f == null)
            {
                this._0x14cafe81.RemoveAt(_0xc31eb086);
                continue;
            }

            if (_0x80fa2c1f._0x012ceb20(step))
            {
                if (Mathf.Abs(_0x30b0ea98 - _0x80fa2c1f._0x57ce7669) <= _0x12a0c0f8.CatchWindowDegrees)
                {
                    _0xd904e667++;
                    this._0x173fd7c6++;
                }

                _0x80fa2c1f._0x85f7a9eb();
                this._0x14cafe81.RemoveAt(_0xc31eb086);
            }
        }

        return _0xd904e667;
    }

    private float _0x0af40605;
    private readonly List<_0x7b3146fc> _0x14cafe81 = new List<_0x7b3146fc>();
    private GameObject _0x546cb338;
    private Sprite _0xc696741e;
}

internal static class _0xb5182d5b
{
    internal static string _0x780b2bd7(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}