using TMPro;
using UnityEngine;
using UnityEngine.UI;

// The tilt readout: a track, a needle for the tray's current angle, a ghost marker
// for the angle the next plume asks for, and a warning wash that grows with the
// mismatch between belt and tray.
public sealed class _0xf0d8a1bb : MonoBehaviour
{
    public void _0xf33177ba(float _0x1faf2faa, float _0x24a65718, float _0xab4f243a, bool _0x4c15613b)
    {
        if (this._0xb0e5335c != null)
        {
            float _0x930b1e05 = Mathf.Clamp(_0x1faf2faa / _0x12a0c0f8.TiltMax, -1f, 1f);
            this._0xb0e5335c.anchoredPosition = new Vector2(_0x930b1e05 * this._0xa93385e7, 0f);
        }

        if (this._0x047dde45 != null)
        {
            this._0x047dde45.gameObject.SetActive(_0x4c15613b);
            float _0x54302632 = Mathf.Clamp(_0xab4f243a / _0x12a0c0f8.TiltMax, -1f, 1f);
            this._0x047dde45.anchoredPosition = new Vector2(_0x54302632 * this._0xa93385e7, 0f);
        }

        if (this._0x55208525 != null)
        {
            float _0xb406c527 = Mathf.Clamp01(Mathf.Abs(_0x24a65718 - _0x1faf2faa) / 12f);
            this._0x55208525.color = _0x3edf515c.WithAlpha(_0x3edf515c.Terracotta, _0xb406c527 * 0.5f);
        }

        if (this._0x627db1fe != null)
        {
            if (_0x4c15613b)
            {
                this._0x627db1fe.text = _0xf579c312._0xde971a5a(new byte[9] { 152, 132, 157, 133, 141, 232, 137, 156, 232 }, 200) + Mathf.RoundToInt(_0xab4f243a) + _0xf579c312._0xde971a5a(new byte[4] { 170, 206, 207, 205 }, 138);
                this._0x627db1fe.color = _0x3edf515c.Sun;
            }
            else if (Mathf.Abs(_0x1faf2faa) < 1.2f)
            {
                this._0x627db1fe.text = _0xf579c312._0xde971a5a(new byte[10] { 39, 33, 50, 42, 83, 63, 54, 37, 54, 63 }, 115);
                this._0x627db1fe.color = _0x3edf515c.Cream;
            }
            else
            {
                this._0x627db1fe.text = _0xf579c312._0xde971a5a(new byte[8] { 73, 79, 92, 68, 61, 92, 73, 61 }, 29) + Mathf.RoundToInt(_0x1faf2faa) + _0xf579c312._0xde971a5a(new byte[4] { 165, 193, 192, 194 }, 133);
                this._0x627db1fe.color = _0x3edf515c.Cream;
            }
        }
    }

    private RectTransform _0x047dde45;
    private Image _0x55208525;
    private TextMeshProUGUI _0x627db1fe;
    public void _0x8cbb2e3f(Transform _0x4a19b81e, Vector2 _0xeea429cd, Vector2 _0x01b97f47, Sprite _0x03a4cc55, TMP_FontAsset _0x3c17d090)
    {
        this._0x4d81e2cc = _0x6d11a8af.Node(_0x4a19b81e, _0xf579c312._0xde971a5a(new byte[9] { 83, 110, 107, 115, 83, 117, 102, 100, 108 }, 7), _0xeea429cd, Vector2.zero, _0x01b97f47);
        _0x6d11a8af.Plate(this._0x4d81e2cc, _0xf579c312._0xde971a5a(new byte[13] { 150, 171, 174, 182, 150, 176, 163, 161, 169, 128, 163, 161, 169 }, 194), new Vector2(0.5f, 0.5f), Vector2.zero, _0x01b97f47, _0x3edf515c.WithAlpha(_0x3edf515c.SlateDeep, 0.88f), _0x03a4cc55, 2.4f);
        this._0x55208525 = _0x6d11a8af.Plate(this._0x4d81e2cc, _0xf579c312._0xde971a5a(new byte[10] { 7, 58, 63, 39, 0, 39, 33, 50, 58, 61 }, 83), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(_0x01b97f47.x - 14f, _0x01b97f47.y - 14f), _0x3edf515c.WithAlpha(_0x3edf515c.Terracotta, 0f), _0x03a4cc55, 2.6f);
        this._0xa93385e7 = (_0x01b97f47.x - 60f) * 0.5f;
        this._0x047dde45 = _0x6d11a8af.Node(this._0x4d81e2cc, _0xf579c312._0xde971a5a(new byte[9] { 136, 180, 173, 181, 189, 149, 185, 170, 179 }, 216), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(14f, _0x01b97f47.y - 20f));
        Image _0x8b470128 = this._0x047dde45.gameObject.AddComponent<Image>();
        _0x8b470128.color = _0x3edf515c.WithAlpha(_0x3edf515c.Sky, 0.9f);
        _0x8b470128.raycastTarget = false;
        _0x8b470128.sprite = _0x03a4cc55;
        _0x8b470128.type = Image.Type.Sliced;
        _0x8b470128.pixelsPerUnitMultiplier = 5.5f;
        this._0xb0e5335c = _0x6d11a8af.Node(this._0x4d81e2cc, _0xf579c312._0xde971a5a(new byte[10] { 168, 149, 144, 136, 178, 153, 153, 152, 144, 153 }, 252), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(18f, _0x01b97f47.y + 16f));
        Image _0xa64bb32d = this._0xb0e5335c.gameObject.AddComponent<Image>();
        _0xa64bb32d.color = _0x3edf515c.Cream;
        _0xa64bb32d.raycastTarget = false;
        _0xa64bb32d.sprite = _0x03a4cc55;
        _0xa64bb32d.type = Image.Type.Sliced;
        _0xa64bb32d.pixelsPerUnitMultiplier = 5.5f;
        this._0x627db1fe = _0x6d11a8af.Label(this._0x4d81e2cc, _0xf579c312._0xde971a5a(new byte[11] { 27, 38, 35, 59, 12, 46, 63, 59, 38, 32, 33 }, 79), new Vector2(0.5f, 1f), new Vector2(0f, 34f), new Vector2(_0x01b97f47.x, 44f), _0xf579c312._0xde971a5a(new byte[10] { 181, 179, 160, 184, 193, 173, 164, 183, 164, 173 }, 225), 26f, _0x3edf515c.Cream, _0x3c17d090, TextAlignmentOptions.Center);
    }

    private RectTransform _0xb0e5335c;
    private float _0xa93385e7;
    private RectTransform _0x4d81e2cc;
}

internal static class _0xf579c312
{
    internal static string _0xde971a5a(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}