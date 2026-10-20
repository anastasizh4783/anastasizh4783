using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Dresses one BASE_POP instance completely (rule C.3): the template's own card,
// label rows and button strip are switched off and our own card is built inside
// Pop.Content, so no template wording and no sprite-less white square can reach a
// result screen. The close glyph comes in as a serialized Sprite, never a lookup.
public sealed class _0xdfe220f6 : MonoBehaviour
{
    private TextMeshProUGUI _0x094e6b1d;
    private TextMeshProUGUI _0xbbd7af72;
    public void _0x50e8f46b(_0x23c3e20b _0x0547a0cc, Sprite _0x24d20f0f, Sprite _0x28910714, TMP_FontAsset _0x4aec780c, Sprite _0x07359597, string _0xcb98b6f0, string _0xa8f05d52, string _0xd9c9ead3, string _0xdcc26407, string _0x9bdf8337, System.Action _0x47c9391b, System.Action _0xba1a294c)
    {
        if (this._0x318b17b8 || _0x0547a0cc == null || _0x0547a0cc.Content == null)
        {
            return;
        }

        this._0x318b17b8 = true;
        Transform _0x6f49463f = _0x0547a0cc.Content.transform;
        for (int _0x1113a044 = _0x6f49463f.childCount - 1; _0x1113a044 >= 0; _0x1113a044--)
        {
            Transform _0x0fff7dad = _0x6f49463f.GetChild(_0x1113a044);
            if (_0x0fff7dad != null)
            {
                _0x0fff7dad.gameObject.SetActive(false);
            }
        }

        RectTransform _0x4a16cff9 = _0x6d11a8af.Node(_0x6f49463f, _0x6ae8b8f2._0x089ac55a(new byte[11] { 68, 115, 101, 99, 122, 98, 69, 126, 119, 114, 115 }, 22), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(1500f, 3000f));
        Image _0x0c2293e7 = _0x4a16cff9.gameObject.AddComponent<Image>();
        _0x0c2293e7.color = _0x3edf515c.Shade;
        _0x0c2293e7.raycastTarget = true;
        _0x0c2293e7.canvasRenderer.cullTransparentMesh = false;
        Vector2 _0xe61b17b5 = new Vector2(980f, 880f);
        RectTransform _0x064e4fd1 = _0x6d11a8af.Node(_0x6f49463f, _0x6ae8b8f2._0x089ac55a(new byte[10] { 208, 231, 241, 247, 238, 246, 193, 227, 240, 230 }, 130), new Vector2(0.5f, 0.5f), Vector2.zero, _0xe61b17b5);
        Image _0xfff3f7eb = _0x064e4fd1.gameObject.AddComponent<Image>();
        _0xfff3f7eb.color = _0x3edf515c.Sun;
        _0xfff3f7eb.sprite = _0x24d20f0f;
        _0xfff3f7eb.type = Image.Type.Sliced;
        _0xfff3f7eb.pixelsPerUnitMultiplier = 1.5f;
        _0xfff3f7eb.raycastTarget = true;
        _0x6d11a8af.Plate(_0x064e4fd1, _0x6ae8b8f2._0x089ac55a(new byte[10] { 230, 209, 199, 193, 216, 192, 246, 219, 208, 205 }, 180), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(_0xe61b17b5.x - 20f, _0xe61b17b5.y - 20f), _0x3edf515c.WithAlpha(_0x3edf515c.SlateDeep, 0.97f), _0x24d20f0f, 1.6f);
        if (_0x07359597 != null)
        {
            _0x6d11a8af.Picture(_0x064e4fd1, _0x6ae8b8f2._0x089ac55a(new byte[12] { 108, 91, 77, 75, 82, 74, 123, 83, 92, 82, 91, 83 }, 62), new Vector2(0.5f, 0.695f), Vector2.zero, new Vector2(210f, 210f), _0x07359597, _0x3edf515c.Sun);
        }

        this._0xbbd7af72 = _0x6d11a8af.Label(_0x064e4fd1, _0x6ae8b8f2._0x089ac55a(new byte[12] { 35, 20, 2, 4, 29, 5, 57, 20, 16, 21, 20, 3 }, 113), new Vector2(0.5f, 0.890f), Vector2.zero, new Vector2(_0xe61b17b5.x - 170f, 88f), _0xcb98b6f0, 52f, _0x3edf515c.Cream, _0x4aec780c, TextAlignmentOptions.Center);
        this._0x094e6b1d = _0x6d11a8af.Label(_0x064e4fd1, _0x6ae8b8f2._0x089ac55a(new byte[14] { 190, 137, 159, 153, 128, 152, 164, 137, 141, 136, 128, 133, 130, 137 }, 236), new Vector2(0.5f, 0.470f), Vector2.zero, new Vector2(_0xe61b17b5.x - 120f, 70f), _0xa8f05d52, 42f, _0x3edf515c.Sun, _0x4aec780c, TextAlignmentOptions.Center);
        this._0xf56c701e = _0x6d11a8af.Label(_0x064e4fd1, _0x6ae8b8f2._0x089ac55a(new byte[14] { 85, 98, 116, 114, 107, 115, 65, 104, 104, 115, 105, 104, 115, 98 }, 7), new Vector2(0.5f, 0.390f), Vector2.zero, new Vector2(_0xe61b17b5.x - 120f, 56f), _0xd9c9ead3, 30f, _0x3edf515c.Cream, _0x4aec780c, TextAlignmentOptions.Center);
        if (!string.IsNullOrEmpty(_0xdcc26407))
        {
            Button _0xc2c78c57 = _0x6d11a8af.Cta(_0x064e4fd1, _0x6ae8b8f2._0x089ac55a(new byte[13] { 18, 37, 51, 53, 44, 52, 16, 50, 41, 45, 33, 50, 57 }, 64), new Vector2(0.5f, 0.215f), Vector2.zero, new Vector2(680f, 136f), _0xdcc26407, 38f, _0x3edf515c.Sun, _0x3edf515c.SlateSoft, _0x3edf515c.Cream, _0x24d20f0f, _0x4aec780c);
            System.Action _0xc1bb6866 = _0x47c9391b;
            _0xc2c78c57.onClick.AddListener(() => InvokeSafely(_0xc1bb6866));
        }

        if (!string.IsNullOrEmpty(_0x9bdf8337))
        {
            Button _0x95ff5bfb = _0x6d11a8af.Cta(_0x064e4fd1, _0x6ae8b8f2._0x089ac55a(new byte[15] { 217, 238, 248, 254, 231, 255, 216, 238, 232, 228, 229, 239, 234, 249, 242 }, 139), new Vector2(0.5f, 0.090f), Vector2.zero, new Vector2(560f, 118f), _0x9bdf8337, 32f, _0x3edf515c.WithAlpha(_0x3edf515c.Sun, 0.65f), _0x3edf515c.Slate, _0x3edf515c.Cream, _0x24d20f0f, _0x4aec780c);
            System.Action _0x8ac3e310 = _0xba1a294c;
            _0x95ff5bfb.onClick.AddListener(() => InvokeSafely(_0x8ac3e310));
        }

        // The corner glyph repeats the primary action and carries no caption of its
        // own, which is exactly what rule C.17 asks for.
        Button _0x3f895e6e = _0x6d11a8af.IconCta(_0x064e4fd1, _0x6ae8b8f2._0x089ac55a(new byte[11] { 133, 178, 164, 162, 187, 163, 148, 187, 184, 164, 178 }, 215), new Vector2(1f, 1f), new Vector2(-58f, -58f), new Vector2(96f, 96f), _0x28910714, _0x3edf515c.Sun, _0x3edf515c.Slate, _0x3edf515c.Cream, _0x24d20f0f);
        System.Action _0xb6bcee50 = _0x47c9391b;
        _0x3f895e6e.onClick.AddListener(() => InvokeSafely(_0xb6bcee50));
    }

    public void _0x2244170b(string _0xcb979b32, string _0x9520a7b6, string _0x8cd8ac85)
    {
        if (this._0xbbd7af72 != null)
        {
            this._0xbbd7af72.text = _0xcb979b32;
        }

        if (this._0x094e6b1d != null)
        {
            this._0x094e6b1d.text = _0x9520a7b6;
        }

        if (this._0xf56c701e != null)
        {
            this._0xf56c701e.text = _0x8cd8ac85;
        }
    }

    private static void InvokeSafely(System.Action _0xf6b49785)
    {
        if (_0xf6b49785 != null)
        {
            _0xf6b49785.Invoke();
        }
    }

    private bool _0x318b17b8;
    private TextMeshProUGUI _0xf56c701e;
}

internal static class _0x6ae8b8f2
{
    internal static string _0x089ac55a(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}