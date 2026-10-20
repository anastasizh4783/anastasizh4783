using System.Collections.Generic;
using UnityEngine;

// The safe band drawn on the belt: two marker posts at its edges and a row of
// notches between them. Nothing is stretched, so no sprite loses its aspect: the
// band grows by moving the posts apart and lighting more notches (rule F.2a).
public sealed class _0x43e39e14 : MonoBehaviour
{
    private SpriteRenderer _0xb8b22982;
    private float _0x0206ffb3;
    public void _0xcb19fc4d(Camera _0x4e6e87a9, Sprite _0xfd31092a, GameObject _0x752fff24, Sprite _0x1f2461f5, float _0x57531c37)
    {
        float width = _0xf21ad269.ScreenWidth(_0x4e6e87a9);
        float _0x21b33f8f = _0x57531c37;
        this._0x6c288f17 = _0xf21ad269.Make(this.transform, _0xef8be25d._0x3db5e210(new byte[12] { 86, 117, 122, 112, 81, 112, 115, 113, 88, 113, 114, 96 }, 20), _0xfd31092a, _0xf21ad269.BandOrder, width * _0xf21ad269.BandPostWidth);
        this._0xb8b22982 = _0xf21ad269.Make(this.transform, _0xef8be25d._0x3db5e210(new byte[13] { 15, 44, 35, 41, 8, 41, 42, 40, 31, 36, 42, 37, 57 }, 77), _0xfd31092a, _0xf21ad269.BandOrder, width * _0xf21ad269.BandPostWidth);
        this._0x6c288f17.color = _0x3edf515c.Sun;
        this._0xb8b22982.color = _0x3edf515c.Sun;
        this._0x6c288f17.transform.localPosition = new Vector3(-_0x12a0c0f8.SafeHalfBase, _0x21b33f8f, 0f);
        this._0xb8b22982.transform.localPosition = new Vector3(_0x12a0c0f8.SafeHalfBase, _0x21b33f8f, 0f);
        float _0x4c63f0c7 = width * _0xf21ad269.BandNotchWidth;
        this._0x0206ffb3 = _0x4c63f0c7 * 1.9f;
        int _0x9862e924 = Mathf.Clamp(Mathf.CeilToInt((_0x12a0c0f8.SafeHalfCap * 2f) / this._0x0206ffb3) + 1, 5, 15);
        for (int _0xc55aa8b1 = 0; _0xc55aa8b1 < _0x9862e924; _0xc55aa8b1++)
        {
            SpriteRenderer _0xbfbd05cf;
            if (_0x752fff24 != null)
            {
                GameObject _0x909f0a2e = Instantiate(_0x752fff24, this.transform);
                _0xbfbd05cf = _0x909f0a2e.GetComponent<SpriteRenderer>();
                _0x909f0a2e.transform.localScale = Vector3.one;
            }
            else
            {
                _0xbfbd05cf = _0xf21ad269.Make(this.transform, _0xef8be25d._0x3db5e210(new byte[9] { 78, 109, 98, 104, 66, 99, 120, 111, 100 }, 12), _0x1f2461f5, _0xf21ad269.BandOrder, _0x4c63f0c7);
            }

            _0xf21ad269.Dress(_0xbfbd05cf, _0x1f2461f5, _0xf21ad269.BandOrder, _0x4c63f0c7);
            _0xbfbd05cf.transform.localPosition = new Vector3(0f, _0x21b33f8f, 0f);
            _0xbfbd05cf.color = _0x3edf515c.Sage;
            this._0x6cb4ab16.Add(_0xbfbd05cf);
        }
    }

    public void _0xc045e582(float _0x801737d5, bool _0xad19d71d)
    {
        if (this._0x6c288f17 != null)
        {
            Vector3 _0x50279edb = this._0x6c288f17.transform.localPosition;
            this._0x6c288f17.transform.localPosition = new Vector3(-_0x801737d5, _0x50279edb.y, 0f);
        }

        if (this._0xb8b22982 != null)
        {
            Vector3 _0xc284e0e0 = this._0xb8b22982.transform.localPosition;
            this._0xb8b22982.transform.localPosition = new Vector3(_0x801737d5, _0xc284e0e0.y, 0f);
        }

        Color _0x0309dd6c = _0xad19d71d ? _0x3edf515c.Sun : _0x3edf515c.Sage;
        int _0xbedb228d = Mathf.Max(1, Mathf.FloorToInt((_0x801737d5 * 2f) / this._0x0206ffb3));
        float _0x9096cb35 = -((_0xbedb228d - 1) * this._0x0206ffb3) * 0.5f;
        for (int _0xcf5a8424 = 0; _0xcf5a8424 < this._0x6cb4ab16.Count; _0xcf5a8424++)
        {
            SpriteRenderer _0xab3511a0 = this._0x6cb4ab16[_0xcf5a8424];
            if (_0xab3511a0 == null)
            {
                continue;
            }

            bool _0x40668c33 = _0xcf5a8424 < _0xbedb228d;
            _0xab3511a0.gameObject.SetActive(_0x40668c33);
            if (!_0x40668c33)
            {
                continue;
            }

            Vector3 _0x344701ef = _0xab3511a0.transform.localPosition;
            _0xab3511a0.transform.localPosition = new Vector3(_0x9096cb35 + (_0xcf5a8424 * this._0x0206ffb3), _0x344701ef.y, 0f);
            _0xab3511a0.color = _0x3edf515c.WithAlpha(_0x0309dd6c, 0.85f);
        }
    }

    private SpriteRenderer _0x6c288f17;
    private readonly List<SpriteRenderer> _0x6cb4ab16 = new List<SpriteRenderer>();
}

internal static class _0xef8be25d
{
    internal static string _0x3db5e210(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}