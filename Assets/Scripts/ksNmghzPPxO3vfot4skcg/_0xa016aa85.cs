using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

// The living picture at the top of the menu: a tray with three eggs in nests of
// different depth, a plume drifting down, and a belt that runs behind them. Picking
// a route recolours it and picking a pace changes how fast the belt moves, which is
// the visible confirmation rule C.7 asks for.
public sealed class _0xa016aa85 : MonoBehaviour
{
    public void _0xa50a965f(Color _0xcd4236bd, Color _0x476c3906)
    {
        if (this._0xbfd03165 != null)
        {
            this._0xbfd03165.color = _0xcd4236bd;
        }

        if (this._0x21111a56 != null)
        {
            this._0x21111a56.color = _0x476c3906;
        }
    }

    private RectTransform _0x0e6190e0;
    private float _0x0cd3c943;
    private void Update()
    {
        float delta = 36f * this._0x31fec4d4 * Time.deltaTime;
        for (int _0xc3eb0fdb = 0; _0xc3eb0fdb < this._0xb5bd0331.Count; _0xc3eb0fdb++)
        {
            RectTransform _0xd4aab25c = this._0xb5bd0331[_0xc3eb0fdb];
            if (_0xd4aab25c == null)
            {
                continue;
            }

            Vector2 _0x61ce5dad = _0xd4aab25c.anchoredPosition;
            _0x61ce5dad.x -= delta;
            if (_0x61ce5dad.x < -this._0x0cd3c943)
            {
                _0x61ce5dad.x += this._0x0cd3c943 * this._0xb5bd0331.Count;
            }

            _0xd4aab25c.anchoredPosition = _0x61ce5dad;
        }
    }

    private Image _0x21111a56;
    private float _0x31fec4d4 = 1f;
    public void _0x58b7f2a2(Transform _0x247c43b5, Sprite _0x0d92ecf9, Sprite _0x912434d8, Sprite _0x082f9d08, Sprite _0x7d62ad11, Sprite _0xd6f6af22, Sprite _0x3b889097)
    {
        RectTransform _0xf966a65c = _0x6d11a8af.Node(_0x247c43b5, _0x026db70d._0x7201a6b3(new byte[12] { 113, 83, 68, 87, 72, 68, 86, 103, 83, 64, 76, 68 }, 33), new Vector2(0.5f, 0.700f), Vector2.zero, new Vector2(1120f, 740f));
        this._0xbfd03165 = _0x6d11a8af.Picture(_0xf966a65c, _0x026db70d._0x7201a6b3(new byte[12] { 122, 88, 79, 92, 67, 79, 93, 98, 67, 70, 70, 89 }, 42), new Vector2(0.5f, 0.72f), Vector2.zero, new Vector2(900f, 360f), _0xd6f6af22, _0x3edf515c.WithAlpha(_0x3edf515c.Sage, 0.55f));
        this._0x21111a56 = _0x6d11a8af.Picture(_0xf966a65c, _0x026db70d._0x7201a6b3(new byte[11] { 136, 170, 189, 174, 177, 189, 175, 136, 183, 171, 172 }, 216), new Vector2(0.80f, 0.42f), Vector2.zero, new Vector2(210f, 210f), _0x3b889097, _0x3edf515c.WithAlpha(_0x3edf515c.Cream, 0.9f));
        this._0x0cd3c943 = 170f;
        int _0x7b590684 = 7;
        for (int _0x9b07f28a = 0; _0x9b07f28a < _0x7b590684; _0x9b07f28a++)
        {
            RectTransform _0xfa680281 = _0x6d11a8af.Picture(_0xf966a65c, _0x026db70d._0x7201a6b3(new byte[11] { 205, 239, 248, 235, 244, 248, 234, 207, 252, 244, 241 }, 157) + _0x9b07f28a, new Vector2(0f, 0.26f), new Vector2(_0x9b07f28a * this._0x0cd3c943, 0f), new Vector2(180f, 180f), _0x7d62ad11, _0x3edf515c.Cream).rectTransform;
            this._0xb5bd0331.Add(_0xfa680281);
        }

        this._0x8a12c15d = _0x6d11a8af.Picture(_0xf966a65c, _0x026db70d._0x7201a6b3(new byte[11] { 105, 75, 92, 79, 80, 92, 78, 109, 75, 88, 64 }, 57), new Vector2(0.5f, 0.40f), Vector2.zero, new Vector2(680f, 680f), _0x0d92ecf9, Color.white).rectTransform;
        float[] _0xd8eb2502 = new float[]
        {
            -96f,
            0f,
            96f
        };
        float[] _0xbe8833b7 = new float[]
        {
            34f,
            30f,
            26f
        };
        for (int _0xee889c27 = 0; _0xee889c27 < _0xd8eb2502.Length; _0xee889c27++)
        {
            _0x6d11a8af.Picture(this._0x8a12c15d, _0x026db70d._0x7201a6b3(new byte[10] { 22, 52, 35, 48, 47, 35, 49, 3, 33, 33 }, 70) + _0xee889c27, new Vector2(0.5f, 0.5f), new Vector2(_0xd8eb2502[_0xee889c27], _0xbe8833b7[_0xee889c27]), new Vector2(78f, 78f), _0x912434d8, Color.white);
        }

        this._0x0e6190e0 = _0x6d11a8af.Picture(_0xf966a65c, _0x026db70d._0x7201a6b3(new byte[12] { 177, 147, 132, 151, 136, 132, 150, 177, 141, 148, 140, 132 }, 225), new Vector2(0.30f, 0.86f), Vector2.zero, new Vector2(130f, 130f), _0x082f9d08, _0x3edf515c.Sun).rectTransform;
        this._0x8a12c15d.DOLocalRotate(new Vector3(0f, 0f, 4f), 3.4f).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo).From(new Vector3(0f, 0f, -4f));
        this._0x0e6190e0.DOAnchorPosY(-120f, 4.5f).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);
    }

    private Image _0xbfd03165;
    private readonly List<RectTransform> _0xb5bd0331 = new List<RectTransform>();
    private RectTransform _0x8a12c15d;
    public void _0x995c4a1c(float _0x0fb7d02d)
    {
        this._0x31fec4d4 = Mathf.Clamp(_0x0fb7d02d, 0.5f, 3f);
    }
}

internal static class _0x026db70d
{
    internal static string _0x7201a6b3(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}