using System.Collections.Generic;
using UnityEngine;

// The belt the tray rides on, the far hills behind it and the station posts that
// mark progress. Segments are recycled around a ring instead of stretching one
// sprite, so every piece keeps the aspect of its own PNG.
public sealed class _0x64b423f5 : MonoBehaviour
{
    private readonly List<Transform> _0x093a548a = new List<Transform>();
    // Station posts glide in from the right so the player sees progress.
    public void _0x12e65524(_0x12a0c0f8 _0x47d8c6e9, float _0xc2221944, Camera _0x114be058)
    {
        float _0x71dd7ae2 = _0xf21ad269.HalfWidth(_0x114be058);
        for (int _0xd6293708 = 0; _0xd6293708 < this._0x2885e7dc.Count && _0xd6293708 < _0x47d8c6e9.StationSeconds.Count; _0xd6293708++)
        {
            SpriteRenderer _0x69ef0d21 = this._0x2885e7dc[_0xd6293708];
            if (_0x69ef0d21 == null)
            {
                continue;
            }

            float _0x83deb01d = _0x47d8c6e9.StationSeconds[_0xd6293708] - _0xc2221944;
            float _0xb0b529cb = _0x83deb01d * (this._0x7855580d <= 0.01f ? 0.5f : this._0x7855580d);
            bool _0xfad514b3 = _0xb0b529cb < _0x71dd7ae2 * 1.4f && _0xb0b529cb > -_0x71dd7ae2 * 1.6f;
            _0x69ef0d21.gameObject.SetActive(_0xfad514b3);
            if (_0xfad514b3)
            {
                Vector3 _0xb5fee023 = _0x69ef0d21.transform.localPosition;
                _0x69ef0d21.transform.localPosition = new Vector3(_0xb0b529cb, _0xb5fee023.y, 0f);
            }
        }
    }

    private void _0x97fd5a17(List<Transform> _0xdd8c6507, float delta, float _0x25c0bea4)
    {
        float _0x7155370d = this._0xd72e46ab * 0.5f;
        for (int _0x300c586f = 0; _0x300c586f < _0xdd8c6507.Count; _0x300c586f++)
        {
            Transform _0xd20bfc3e = _0xdd8c6507[_0x300c586f];
            if (_0xd20bfc3e == null)
            {
                continue;
            }

            Vector3 _0x6b6a8b6b = _0xd20bfc3e.localPosition;
            _0x6b6a8b6b.x -= delta;
            if (_0x6b6a8b6b.x < -_0x7155370d)
            {
                _0x6b6a8b6b.x += _0x25c0bea4 * _0xdd8c6507.Count;
            }

            _0xd20bfc3e.localPosition = _0x6b6a8b6b;
        }
    }

    private float _0xd72e46ab;
    public void _0xd60e7763(float step)
    {
        this._0x758bb4f4 += this._0x7855580d * step;
        this._0x97fd5a17(this._0xbb853df5, this._0x7855580d * step, this._0x61c4f687);
        this._0x97fd5a17(this._0x093a548a, this._0x7855580d * step * 0.28f, this._0xda35f884);
    }

    private readonly List<SpriteRenderer> _0x2885e7dc = new List<SpriteRenderer>();
    private readonly List<Transform> _0xbb853df5 = new List<Transform>();
    private float _0x7855580d;
    private float _0x61c4f687;
    private float _0xda35f884;
    public void _0x1eb0be64(float _0x73167b68)
    {
        this._0x7855580d = _0x73167b68;
    }

    private float _0x758bb4f4;
    public void _0xf5fd8eb4(Camera _0xebb02b08, GameObject _0x7de255f4, Sprite _0x11a2c1d0, Sprite _0xaac9cff5, GameObject _0x35497634, Sprite _0xee7d0793, int _0xf470c216)
    {
        float width = _0xf21ad269.ScreenWidth(_0xebb02b08);
        float _0x9189b074 = _0xf21ad269.HalfHeight(_0xebb02b08);
        this._0xd72e46ab = width + (width * 0.5f);
        float _0x80f94aae = width * _0xf21ad269.RailWidth;
        this._0x61c4f687 = _0x80f94aae * 0.92f;
        int _0xa232293a = Mathf.Clamp(Mathf.CeilToInt(this._0xd72e46ab / this._0x61c4f687) + 2, 6, 40);
        for (int _0xd7cb1b47 = 0; _0xd7cb1b47 < _0xa232293a; _0xd7cb1b47++)
        {
            SpriteRenderer _0x1dd89929;
            if (_0x7de255f4 != null)
            {
                GameObject _0x7c25e1c6 = Instantiate(_0x7de255f4, this.transform);
                _0x7c25e1c6.transform.localScale = Vector3.one;
                _0x1dd89929 = _0x7c25e1c6.GetComponent<SpriteRenderer>();
            }
            else
            {
                _0x1dd89929 = _0xf21ad269.Make(this.transform, _0x443497ac._0x02245217(new byte[11] { 11, 56, 48, 53, 10, 60, 62, 52, 60, 55, 45 }, 89), _0x11a2c1d0, _0xf21ad269.RailOrder, _0x80f94aae);
            }

            _0xf21ad269.Dress(_0x1dd89929, _0x11a2c1d0, _0xf21ad269.RailOrder, _0x80f94aae);
            _0x1dd89929.transform.localPosition = new Vector3(-this._0xd72e46ab * 0.5f + (_0xd7cb1b47 * this._0x61c4f687), _0x9189b074 * _0xf21ad269.BeltHeight, 0f);
            this._0xbb853df5.Add(_0x1dd89929.transform);
        }

        float _0x5c106eaa = width * _0xf21ad269.HillWidth;
        this._0xda35f884 = _0x5c106eaa * 0.78f;
        int _0x885ee5e7 = Mathf.Clamp(Mathf.CeilToInt(this._0xd72e46ab / this._0xda35f884) + 2, 3, 12);
        for (int _0x521f5bda = 0; _0x521f5bda < _0x885ee5e7; _0x521f5bda++)
        {
            SpriteRenderer _0x94500766 = _0xf21ad269.Make(this.transform, _0x443497ac._0x02245217(new byte[7] { 231, 192, 211, 233, 200, 205, 205 }, 161), _0xaac9cff5, _0xf21ad269.HillsOrder, _0x5c106eaa);
            _0x94500766.color = _0x3edf515c.WithAlpha(_0x3edf515c.Sage, 0.55f);
            _0x94500766.transform.localPosition = new Vector3(-this._0xd72e46ab * 0.5f + (_0x521f5bda * this._0xda35f884), _0x9189b074 * _0xf21ad269.HillsHeight, 0f);
            this._0x093a548a.Add(_0x94500766.transform);
        }

        float _0x500f4dad = width * _0xf21ad269.StationWidth;
        int _0xddaadf6b = Mathf.Clamp(_0xf470c216, 1, 12);
        for (int _0x84a596b3 = 0; _0x84a596b3 < _0xddaadf6b; _0x84a596b3++)
        {
            SpriteRenderer _0x801c243a;
            if (_0x35497634 != null)
            {
                GameObject _0xb817f8e1 = Instantiate(_0x35497634, this.transform);
                _0xb817f8e1.transform.localScale = Vector3.one;
                _0x801c243a = _0xb817f8e1.GetComponent<SpriteRenderer>();
            }
            else
            {
                _0x801c243a = _0xf21ad269.Make(this.transform, _0x443497ac._0x02245217(new byte[11] { 152, 191, 170, 191, 162, 164, 165, 155, 164, 184, 191 }, 203), _0xee7d0793, _0xf21ad269.StationOrder, _0x500f4dad);
            }

            _0xf21ad269.Dress(_0x801c243a, _0xee7d0793, _0xf21ad269.StationOrder, _0x500f4dad);
            _0x801c243a.transform.localPosition = new Vector3(this._0xd72e46ab, _0x9189b074 * _0xf21ad269.StationHeight, 0f);
            this._0x2885e7dc.Add(_0x801c243a);
        }
    }
}

internal static class _0x443497ac
{
    internal static string _0x02245217(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}