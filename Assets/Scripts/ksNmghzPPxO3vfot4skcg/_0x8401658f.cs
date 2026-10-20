using TMPro;
using UnityEngine;
using UnityEngine.UI;

// The game readout and the two tilt pads, built from our OWN objects inside the
// template's panel body (rule C.2). Nothing is hung on a template placeholder and
// no template slot is referenced, so stage 5da can switch those off safely.
public sealed class _0x8401658f : MonoBehaviour
{
    public void _0x5a3bad04(string _0xb10d4824)
    {
        if (this._0xb665ae54 != null)
        {
            this._0xb665ae54.text = _0xb10d4824;
        }
    }

    public void SetProgress(float _0x6f8e3b2f)
    {
        if (this._0x17c8afa4 != null)
        {
            this._0x17c8afa4.fillAmount = Mathf.Clamp01(_0x6f8e3b2f);
        }
    }

    private Image _0xeb511a97;
    private Sprite _0x40b5db4e;
    public void _0xdd899bb1(Transform _0x02d134d8, _0xf2136a7c _0x4aa9fd20, Sprite _0xc428a763, TMP_FontAsset _0x2afbb880, Sprite _0xa341964d, Sprite _0xf26558aa, Sprite _0x527f2c02, Sprite _0x5493fc66, Sprite _0xc3863a1f, Sprite _0x9d22aa83)
    {
        this._0x40b5db4e = _0xa341964d;
        this._0x5780749b = _0xf26558aa;
        // -- top bar --------------------------------------------------------
        _0x6d11a8af.Plate(_0x02d134d8, _0x5749c31c._0x0d1695a5(new byte[9] { 53, 18, 9, 51, 8, 23, 37, 6, 21 }, 103), new Vector2(0.5f, 0.927f), Vector2.zero, new Vector2(1160f, 150f), _0x3edf515c.WithAlpha(_0x3edf515c.SlateDeep, 0.92f), _0xc428a763, 2.2f);
        this._0x0a1ab253 = _0x6d11a8af.IconCta(_0x02d134d8, _0x5749c31c._0x0d1695a5(new byte[7] { 168, 143, 148, 184, 155, 153, 145 }, 250), new Vector2(0.088f, 0.927f), Vector2.zero, new Vector2(116f, 116f), _0x527f2c02, _0x3edf515c.Sun, _0x3edf515c.SlateDeep, _0x3edf515c.Cream, _0xc428a763);
        this._0xeee3effb = _0x6d11a8af.IconCta(_0x02d134d8, _0x5749c31c._0x0d1695a5(new byte[8] { 37, 2, 25, 39, 22, 2, 4, 18 }, 119), new Vector2(0.912f, 0.927f), Vector2.zero, new Vector2(116f, 116f), _0x5493fc66, _0x3edf515c.Sun, _0x3edf515c.SlateDeep, _0x3edf515c.Cream, _0xc428a763);
        this._0xb665ae54 = _0x6d11a8af.Label(_0x02d134d8, _0x5749c31c._0x0d1695a5(new byte[8] { 22, 49, 42, 22, 43, 49, 48, 33 }, 68), new Vector2(0.5f, 0.940f), Vector2.zero, new Vector2(620f, 48f), _0x5749c31c._0x0d1695a5(new byte[12] { 44, 46, 51, 47, 40, 47, 38, 65, 45, 32, 47, 36 }, 97), 34f, _0x3edf515c.Cream, _0x2afbb880, TextAlignmentOptions.Center);
        this._0xad10da29 = _0x6d11a8af.Label(_0x02d134d8, _0x5749c31c._0x0d1695a5(new byte[10] { 254, 217, 194, 255, 216, 205, 216, 197, 195, 194 }, 172), new Vector2(0.5f, 0.914f), Vector2.zero, new Vector2(520f, 42f), _0x5749c31c._0x0d1695a5(new byte[14] { 164, 163, 182, 163, 190, 184, 185, 215, 199, 215, 184, 177, 215, 194 }, 247), 28f, _0x3edf515c.Sun, _0x2afbb880, TextAlignmentOptions.Center);
        // -- egg row and objective, two x lanes that never meet (rule C.25) -
        float[] _0x9f03a288 = new float[]
        {
            120f / RefWidth,
            236f / RefWidth,
            352f / RefWidth
        };
        for (int _0xcb6d7a9c = 0; _0xcb6d7a9c < this._0xc84a7848.Length; _0xcb6d7a9c++)
        {
            this._0xc84a7848[_0xcb6d7a9c] = _0x6d11a8af.Picture(_0x02d134d8, _0x5749c31c._0x0d1695a5(new byte[6] { 130, 165, 190, 149, 183, 183 }, 208) + _0xcb6d7a9c, new Vector2(_0x9f03a288[_0xcb6d7a9c], 0.862f), Vector2.zero, new Vector2(92f, 92f), _0xa341964d, Color.white);
        }

        _0x6d11a8af.Plate(_0x02d134d8, _0x5749c31c._0x0d1695a5(new byte[12] { 105, 78, 85, 124, 84, 90, 87, 107, 87, 90, 79, 94 }, 59), new Vector2(980f / RefWidth, 0.862f), Vector2.zero, new Vector2(300f, 76f), _0x3edf515c.WithAlpha(_0x3edf515c.SlateDeep, 0.90f), _0xc428a763, 2.0f);
        this._0x1b61acbf = _0x6d11a8af.Label(_0x02d134d8, _0x5749c31c._0x0d1695a5(new byte[7] { 205, 234, 241, 216, 240, 254, 243 }, 159), new Vector2(980f / RefWidth, 0.862f), Vector2.zero, new Vector2(272f, 52f), _0x5749c31c._0x0d1695a5(new byte[14] { 143, 142, 135, 130, 157, 142, 153, 235, 249, 235, 132, 141, 235, 248 }, 203), 28f, _0x3edf515c.Sun, _0x2afbb880, TextAlignmentOptions.Center);
        // -- route progress and plume boost --------------------------------
        _0x6d11a8af.Plate(_0x02d134d8, _0x5749c31c._0x0d1695a5(new byte[16] { 240, 215, 204, 242, 208, 205, 197, 208, 199, 209, 209, 246, 208, 195, 193, 201 }, 162), new Vector2(0.5f, 0.823f), Vector2.zero, new Vector2(1042f, 26f), _0x3edf515c.WithAlpha(_0x3edf515c.Slate, 0.85f), _0xc428a763, 6.5f);
        this._0x17c8afa4 = _0x6d11a8af.Bar(_0x02d134d8, _0x5749c31c._0x0d1695a5(new byte[15] { 89, 126, 101, 91, 121, 100, 108, 121, 110, 120, 120, 77, 98, 103, 103 }, 11), new Vector2(0.5f, 0.823f), Vector2.zero, new Vector2(1034f, 18f), _0x3edf515c.Sky, _0xc428a763, 7.0f);
        this._0x17c8afa4.fillAmount = 0f;
        _0x6d11a8af.Plate(_0x02d134d8, _0x5749c31c._0x0d1695a5(new byte[13] { 120, 95, 68, 104, 69, 69, 89, 94, 126, 88, 75, 73, 65 }, 42), new Vector2(0.5f, 0.800f), Vector2.zero, new Vector2(1042f, 18f), _0x3edf515c.WithAlpha(_0x3edf515c.Slate, 0.85f), _0xc428a763, 7.5f);
        this._0xeb511a97 = _0x6d11a8af.Bar(_0x02d134d8, _0x5749c31c._0x0d1695a5(new byte[12] { 96, 71, 92, 112, 93, 93, 65, 70, 116, 91, 94, 94 }, 50), new Vector2(0.5f, 0.800f), Vector2.zero, new Vector2(1034f, 12f), _0x3edf515c.Sun, _0xc428a763, 8.0f);
        this._0xeb511a97.fillAmount = 0f;
        // -- tilt meter and the permanent control hint (rule C.6) ----------
        this._0xacd81383 = this.gameObject.AddComponent<_0xf0d8a1bb>();
        this._0xacd81383._0x8cbb2e3f(_0x02d134d8, new Vector2(0.5f, 0.200f), new Vector2(900f, 72f), _0xc428a763, _0x2afbb880);
        this._0x3f849623 = _0x6d11a8af.Label(_0x02d134d8, _0x5749c31c._0x0d1695a5(new byte[7] { 53, 18, 9, 47, 14, 9, 19 }, 103), new Vector2(0.5f, 0.152f), Vector2.zero, new Vector2(1100f, 92f), _0x5749c31c._0x0d1695a5(new byte[60] { 131, 132, 135, 143, 235, 138, 235, 155, 138, 143, 235, 159, 132, 235, 159, 130, 135, 159, 235, 159, 131, 142, 235, 159, 153, 138, 146, 193, 136, 138, 159, 136, 131, 235, 155, 135, 158, 134, 142, 152, 235, 138, 159, 235, 159, 131, 142, 235, 134, 138, 153, 128, 142, 143, 235, 138, 133, 140, 135, 142 }, 203), 28f, _0x3edf515c.Cream, _0x2afbb880, TextAlignmentOptions.Center);
        // -- the two pads --------------------------------------------------
        this._0x94e4463c(_0x02d134d8, _0x5749c31c._0x0d1695a5(new byte[11] { 247, 202, 207, 215, 243, 194, 199, 239, 198, 197, 215 }, 163), 0.250f, -1f, _0xc3863a1f, _0xc428a763, _0x4aa9fd20);
        this._0x94e4463c(_0x02d134d8, _0x5749c31c._0x0d1695a5(new byte[12] { 239, 210, 215, 207, 235, 218, 223, 233, 210, 220, 211, 207 }, 187), 0.750f, 1f, _0x9d22aa83, _0xc428a763, _0x4aa9fd20);
    }

    private void _0x94e4463c(Transform _0x895e3706, string _0xc50a1bf5, float _0x459a05be, float _0xe659621b, Sprite _0x91292214, Sprite _0x81cd5d08, _0xf2136a7c _0xd2a9636c)
    {
        Vector2 _0x8297b193 = new Vector2(520f, 280f);
        RectTransform _0xdfb920ec = _0x6d11a8af.Node(_0x895e3706, _0xc50a1bf5, new Vector2(_0x459a05be, 0.0744f), Vector2.zero, _0x8297b193);
        Image _0xdfb93619 = _0xdfb920ec.gameObject.AddComponent<Image>();
        _0xdfb93619.color = _0x3edf515c.WithAlpha(_0x3edf515c.Sun, 0.55f);
        _0xdfb93619.sprite = _0x81cd5d08;
        _0xdfb93619.type = Image.Type.Sliced;
        _0xdfb93619.pixelsPerUnitMultiplier = 1.6f;
        _0xdfb93619.raycastTarget = true;
        _0xdfb93619.canvasRenderer.cullTransparentMesh = false;
        Image _0x074d22df = _0x6d11a8af.Plate(_0xdfb920ec, _0xc50a1bf5 + _0x5749c31c._0x0d1695a5(new byte[4] { 137, 164, 175, 178 }, 203), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(_0x8297b193.x - 18f, _0x8297b193.y - 18f), _0x3edf515c.WithAlpha(_0x3edf515c.SlateDeep, 0.42f), _0x81cd5d08, 1.7f);
        _0x6d11a8af.Picture(_0xdfb920ec, _0xc50a1bf5 + _0x5749c31c._0x0d1695a5(new byte[5] { 3, 40, 61, 52, 44 }, 68), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(150f, 150f), _0x91292214, _0x3edf515c.Cream);
        _0x59507fea _0x50b92421 = _0xdfb920ec.gameObject.AddComponent<_0x59507fea>();
        _0x50b92421._0xb96b1f17(_0xd2a9636c, _0xe659621b, _0xdfb93619, _0x074d22df);
    }

    private TextMeshProUGUI _0x1b61acbf;
    public void _0xd90948f8(int _0x819ea1e9, bool _0x69ab6e1b)
    {
        if (_0x819ea1e9 < 0 || _0x819ea1e9 >= this._0xc84a7848.Length || this._0xc84a7848[_0x819ea1e9] == null)
        {
            return;
        }

        this._0xc84a7848[_0x819ea1e9].sprite = _0x69ab6e1b ? this._0x5780749b : this._0x40b5db4e;
        this._0xc84a7848[_0x819ea1e9].color = _0x69ab6e1b ? _0x3edf515c.WithAlpha(Color.white, 0.35f) : Color.white;
    }

    private Image _0x17c8afa4;
    private _0xf0d8a1bb _0xacd81383;
    public void _0x6f496e64(int _0x4a31dc28, int _0xd07a1635)
    {
        if (this._0xad10da29 != null)
        {
            this._0xad10da29.text = _0x5749c31c._0x0d1695a5(new byte[8] { 103, 96, 117, 96, 125, 123, 122, 20 }, 52) + _0x4a31dc28 + _0x5749c31c._0x0d1695a5(new byte[4] { 169, 198, 207, 169 }, 137) + _0xd07a1635;
        }
    }

    private TextMeshProUGUI _0xad10da29;
    public _0xf0d8a1bb _0x9babd9fd
    {
        get
        {
            return this._0xacd81383;
        }
    }

    public Button _0x8fa81ea7
    {
        get
        {
            return this._0xeee3effb;
        }
    }

    public Button _0x6ea747c8
    {
        get
        {
            return this._0x0a1ab253;
        }
    }

    private Button _0x0a1ab253;
    public void _0xf2344aec(string _0x72419d5a, Color _0x1fedacf7)
    {
        if (this._0x3f849623 != null)
        {
            this._0x3f849623.text = _0x72419d5a;
            this._0x3f849623.color = _0x1fedacf7;
        }
    }

    private TextMeshProUGUI _0xb665ae54;
    public void SetBoost(float _0xaf61f3ab)
    {
        if (this._0xeb511a97 != null)
        {
            this._0xeb511a97.fillAmount = Mathf.Clamp01(_0xaf61f3ab);
        }
    }

    private Button _0xeee3effb;
    private TextMeshProUGUI _0x3f849623;
    public void _0x9512c3dd(int _0x3b2109f1)
    {
        if (this._0x1b61acbf != null)
        {
            this._0x1b61acbf.text = _0x5749c31c._0x0d1695a5(new byte[8] { 161, 160, 169, 172, 179, 160, 183, 197 }, 229) + _0x3b2109f1 + _0x5749c31c._0x0d1695a5(new byte[5] { 47, 64, 73, 47, 60 }, 15);
        }
    }

    private readonly Image[] _0xc84a7848 = new Image[3];
    private Sprite _0x5780749b;
    private const float RefHeight = 2688f;
    private const float RefWidth = 1242f;
}

internal static class _0x5749c31c
{
    internal static string _0x0d1695a5(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}