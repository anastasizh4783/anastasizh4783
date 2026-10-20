using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// The menu. Three boards share the template's DefaultPanel body and are swapped by
// switching our own roots on and off (rule C.2): the welcome board, the how-to-tilt
// board and the delivery picker. The template's own scene-loading button is used as
// the START DELIVERY slot, resized and given a visible face, so there is exactly one
// route into the game scene (rule G.3).
public sealed class _0x9763e9d9 : MonoBehaviour
{
    [SerializeField]
    private Sprite _railArt;
    // The template's scene-loading button becomes the START DELIVERY slot: resized
    // to a real button (rule G.3) and given a face of our own, because the EMPTY
    // variant switches all of its own layers off.
    private void _0xe9532dc3()
    {
        if (this._startDeliveryRect == null)
        {
            return;
        }

        this._startDeliveryRect.anchorMin = new Vector2(0.5f, 0.115f);
        this._startDeliveryRect.anchorMax = new Vector2(0.5f, 0.115f);
        this._startDeliveryRect.pivot = new Vector2(0.5f, 0.5f);
        this._startDeliveryRect.sizeDelta = new Vector2(820f, 180f);
        this._startDeliveryRect.anchoredPosition = Vector2.zero;
        this._startDeliveryRect.localScale = Vector3.one;
        Image _0xa6f42f5d = _0x6d11a8af.Plate(this._startDeliveryRect, _0x0fc18cb6._0x3c96fd2f(new byte[9] { 173, 138, 159, 140, 138, 184, 159, 157, 155 }, 254), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(820f, 180f), _0x3edf515c.Sun, this._plateSprite, 1.5f);
        _0xa6f42f5d.raycastTarget = true;
        _0xa6f42f5d.canvasRenderer.cullTransparentMesh = false;
        _0x6d11a8af.Plate(this._startDeliveryRect, _0x0fc18cb6._0x3c96fd2f(new byte[13] { 101, 66, 87, 68, 66, 112, 87, 85, 83, 116, 89, 82, 79 }, 54), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(800f, 160f), _0x3edf515c.SlateSoft, this._plateSprite, 1.6f);
        _0x6d11a8af.Label(this._startDeliveryRect, _0x0fc18cb6._0x3c96fd2f(new byte[16] { 184, 159, 138, 153, 159, 173, 138, 136, 142, 168, 138, 155, 159, 130, 132, 133 }, 235), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(760f, 120f), _0x0fc18cb6._0x3c96fd2f(new byte[14] { 197, 194, 215, 196, 194, 182, 210, 211, 218, 223, 192, 211, 196, 207 }, 150), 48f, _0x3edf515c.Cream, this._font, TextAlignmentOptions.Center);
    }

    private _0x175f31aa _0x12aca864(Transform _0x09054d3c, int _0xff9b57ec, float _0xf7d9ee8f)
    {
        Vector2 _0xb8053d2f = new Vector2(300f, 120f);
        _0x175f31aa _0xb2b41c4d = new _0x175f31aa();
        _0xb2b41c4d.Rect = _0x6d11a8af.Node(_0x09054d3c, _0x0fc18cb6._0x3c96fd2f(new byte[8] { 125, 76, 78, 72, 110, 69, 68, 93 }, 45) + _0xff9b57ec, new Vector2(_0xf7d9ee8f, 0.340f), Vector2.zero, _0xb8053d2f);
        _0xb2b41c4d.Frame = _0xb2b41c4d.Rect.gameObject.AddComponent<Image>();
        _0xb2b41c4d.Frame.sprite = this._plateSprite;
        _0xb2b41c4d.Frame.type = Image.Type.Sliced;
        _0xb2b41c4d.Frame.pixelsPerUnitMultiplier = 1.8f;
        _0xb2b41c4d.Frame.color = _0x3edf515c.WithAlpha(_0x3edf515c.Sun, 0.4f);
        _0xb2b41c4d.Frame.raycastTarget = true;
        _0x6d11a8af.Plate(_0xb2b41c4d.Rect, _0x0fc18cb6._0x3c96fd2f(new byte[12] { 232, 217, 219, 221, 251, 208, 209, 200, 250, 215, 220, 193 }, 184) + _0xff9b57ec, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(_0xb8053d2f.x - 16f, _0xb8053d2f.y - 16f), _0x3edf515c.WithAlpha(_0x3edf515c.SlateDeep, 0.94f), this._plateSprite, 1.9f);
        _0xb2b41c4d.Title = _0x6d11a8af.Label(_0xb2b41c4d.Rect, _0x0fc18cb6._0x3c96fd2f(new byte[12] { 201, 248, 250, 252, 218, 241, 240, 233, 215, 248, 244, 252 }, 153) + _0xff9b57ec, new Vector2(0.5f, 0.5f), new Vector2(0f, 20f), new Vector2(_0xb8053d2f.x - 40f, 44f), _0xeeffa5e9.Paces[_0xff9b57ec].Title, 28f, _0x3edf515c.Cream, this._font, TextAlignmentOptions.Center);
        _0xb2b41c4d.Pips = new Image[3];
        for (int _0xd343e283 = 0; _0xd343e283 < _0xb2b41c4d.Pips.Length; _0xd343e283++)
        {
            _0xb2b41c4d.Pips[_0xd343e283] = _0x6d11a8af.Picture(_0xb2b41c4d.Rect, _0x0fc18cb6._0x3c96fd2f(new byte[11] { 176, 129, 131, 133, 163, 136, 137, 144, 176, 137, 144 }, 224) + _0xff9b57ec + _0x0fc18cb6._0x3c96fd2f(new byte[1] { 9 }, 113) + _0xd343e283, new Vector2(0.5f, 0.5f), new Vector2(-44f + (_0xd343e283 * 44f), -30f), new Vector2(32f, 22f), this._bandNotchArt, _0x3edf515c.WithAlpha(_0x3edf515c.Sky, 0.8f));
        }

        Button _0xf86c471c = _0xb2b41c4d.Rect.gameObject.AddComponent<Button>();
        _0xf86c471c.targetGraphic = _0xb2b41c4d.Frame;
        ColorBlock _0xba35773a = _0xf86c471c.colors;
        _0xba35773a.normalColor = Color.white;
        _0xba35773a.highlightedColor = Color.white;
        _0xba35773a.pressedColor = new Color(0.78f, 0.78f, 0.78f, 1f);
        _0xba35773a.selectedColor = Color.white;
        _0xba35773a.disabledColor = new Color(0.55f, 0.55f, 0.55f, 0.6f);
        _0xba35773a.fadeDuration = 0.08f;
        _0xf86c471c.colors = _0xba35773a;
        int _0x74ae624c = _0xff9b57ec;
        _0xf86c471c.onClick.AddListener(() => this._0xd623c08b(_0x74ae624c));
        return _0xb2b41c4d;
    }

    [SerializeField]
    private Sprite _iconTiltRight;
    private RectTransform _0x6df0d744;
    [SerializeField]
    private Sprite _bandNotchArt;
    // One delivery card. The pip gutter and the text column never share an x band
    // (rule C.25): the gutter sits at 86 +/- 24 from the card's left edge and the
    // text starts at 156, which clears it by 46.
    private _0xe2e14d05 _0x6c545872(Transform _0xfb7213f4, int _0x54d47187, float _0xb9fda006, bool _0xcd94888d)
    {
        Vector2 _0xcb119605 = new Vector2(1020f, 300f);
        _0xe2e14d05 _0x2243f25d = new _0xe2e14d05();
        _0x2243f25d.Unlocked = _0xcd94888d;
        _0x2243f25d.Rect = _0x6d11a8af.Node(_0xfb7213f4, _0x0fc18cb6._0x3c96fd2f(new byte[9] { 109, 80, 74, 75, 90, 124, 94, 77, 91 }, 63) + _0x54d47187, new Vector2(0.5f, _0xb9fda006), Vector2.zero, _0xcb119605);
        _0x2243f25d.Frame = _0x2243f25d.Rect.gameObject.AddComponent<Image>();
        _0x2243f25d.Frame.sprite = this._plateSprite;
        _0x2243f25d.Frame.type = Image.Type.Sliced;
        _0x2243f25d.Frame.pixelsPerUnitMultiplier = 1.6f;
        _0x2243f25d.Frame.color = _0x3edf515c.WithAlpha(_0x3edf515c.Sun, _0xcd94888d ? 0.45f : 0.3f);
        _0x2243f25d.Frame.raycastTarget = true;
        _0x2243f25d.Body = _0x6d11a8af.Plate(_0x2243f25d.Rect, _0x0fc18cb6._0x3c96fd2f(new byte[13] { 205, 240, 234, 235, 250, 220, 254, 237, 251, 221, 240, 251, 230 }, 159) + _0x54d47187, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(_0xcb119605.x - 18f, _0xcb119605.y - 18f), _0x3edf515c.WithAlpha(_0x3edf515c.SlateDeep, _0xcd94888d ? 0.94f : 0.55f), this._plateSprite, 1.7f);
        int _0xd7252218 = 3 + _0x54d47187;
        _0x2243f25d.Pips = new Image[5];
        float _0x4afc3457 = 34f;
        float _0x5a26a17d = 86f - (_0xcb119605.x * 0.5f);
        float _0x34526714 = -((_0xd7252218 - 1) * _0x4afc3457 * 0.5f);
        for (int _0x350b0e63 = 0; _0x350b0e63 < _0x2243f25d.Pips.Length; _0x350b0e63++)
        {
            Image _0x32690db8 = _0x6d11a8af.Picture(_0x2243f25d.Rect, _0x0fc18cb6._0x3c96fd2f(new byte[12] { 89, 100, 126, 127, 110, 72, 106, 121, 111, 91, 98, 123 }, 11) + _0x54d47187 + _0x0fc18cb6._0x3c96fd2f(new byte[1] { 153 }, 225) + _0x350b0e63, new Vector2(0.5f, 0.5f), new Vector2(_0x5a26a17d, _0x34526714 + (_0x350b0e63 * _0x4afc3457)), new Vector2(38f, 26f), this._bandNotchArt, _0x3edf515c.WithAlpha(_0x3edf515c.Sky, 0.85f));
            _0x32690db8.gameObject.SetActive(_0x350b0e63 < _0xd7252218);
            _0x2243f25d.Pips[_0x350b0e63] = _0x32690db8;
        }

        float _0x667da8d7 = (156f + (760f * 0.5f)) - (_0xcb119605.x * 0.5f);
        _0xeeffa5e9.Route _0xaec778c7 = _0xeeffa5e9.Routes[_0x54d47187];
        _0x2243f25d.Title = _0x6d11a8af.Label(_0x2243f25d.Rect, _0x0fc18cb6._0x3c96fd2f(new byte[13] { 136, 181, 175, 174, 191, 153, 187, 168, 190, 148, 187, 183, 191 }, 218) + _0x54d47187, new Vector2(0.5f, 0.5f), new Vector2(_0x667da8d7, 72f), new Vector2(760f, 56f), _0xaec778c7.Title, 44f, _0xcd94888d ? _0x3edf515c.Cream : _0x3edf515c.WithAlpha(_0x3edf515c.Cream, 0.55f), this._font, TextAlignmentOptions.Left);
        _0x2243f25d.Detail = _0x6d11a8af.Label(_0x2243f25d.Rect, _0x0fc18cb6._0x3c96fd2f(new byte[15] { 84, 105, 115, 114, 99, 69, 103, 116, 98, 66, 99, 114, 103, 111, 106 }, 6) + _0x54d47187, new Vector2(0.5f, 0.5f), new Vector2(_0x667da8d7, 4f), new Vector2(760f, 46f), _0xaec778c7.Stations + _0x0fc18cb6._0x3c96fd2f(new byte[20] { 208, 163, 164, 177, 164, 185, 191, 190, 163, 208, 221, 208, 180, 181, 188, 185, 166, 181, 162, 208 }, 240) + _0xaec778c7.Required + _0x0fc18cb6._0x3c96fd2f(new byte[5] { 122, 21, 28, 122, 105 }, 90), 30f, _0x3edf515c.Sun, this._font, TextAlignmentOptions.Left);
        _0x2243f25d.Best = _0x6d11a8af.Label(_0x2243f25d.Rect, _0x0fc18cb6._0x3c96fd2f(new byte[13] { 105, 84, 78, 79, 94, 120, 90, 73, 95, 121, 94, 72, 79 }, 59) + _0x54d47187, new Vector2(0.5f, 0.5f), new Vector2(_0x667da8d7, -62f), new Vector2(760f, 44f), _0x0fc18cb6._0x3c96fd2f(new byte[10] { 59, 58, 85, 39, 32, 59, 85, 44, 48, 33 }, 117), 28f, _0x3edf515c.Sage, this._font, TextAlignmentOptions.Left);
        if (_0xcd94888d)
        {
            Button _0x2537d412 = _0x2243f25d.Rect.gameObject.AddComponent<Button>();
            _0x2537d412.targetGraphic = _0x2243f25d.Frame;
            ColorBlock _0xd8e1487f = _0x2537d412.colors;
            _0xd8e1487f.normalColor = Color.white;
            _0xd8e1487f.highlightedColor = Color.white;
            _0xd8e1487f.pressedColor = new Color(0.78f, 0.78f, 0.78f, 1f);
            _0xd8e1487f.selectedColor = Color.white;
            _0xd8e1487f.disabledColor = new Color(0.55f, 0.55f, 0.55f, 0.6f);
            _0xd8e1487f.fadeDuration = 0.08f;
            _0x2537d412.colors = _0xd8e1487f;
            int _0x27599e44 = _0x54d47187;
            _0x2537d412.onClick.AddListener(() => this._0x2f3813bd(_0x27599e44));
        }
        else
        {
            _0x2243f25d.Detail.text = _0x0fc18cb6._0x3c96fd2f(new byte[32] { 77, 78, 66, 74, 68, 69, 33, 44, 33, 77, 64, 79, 69, 33, 64, 33, 69, 68, 77, 72, 87, 68, 83, 88, 33, 85, 78, 33, 78, 81, 68, 79 }, 1);
            _0x2243f25d.Detail.color = _0x3edf515c.WithAlpha(_0x3edf515c.Cream, 0.6f);
            _0x2243f25d.Best.text = _0x0fc18cb6._0x3c96fd2f(new byte[12] { 40, 55, 34, 41, 52, 71, 38, 33, 51, 34, 53, 71 }, 103) + _0xaec778c7.UnlockAfterDeliveries + _0x0fc18cb6._0x3c96fd2f(new byte[9] { 202, 174, 175, 166, 163, 188, 175, 184, 179 }, 234);
            _0x2243f25d.Best.color = _0x3edf515c.WithAlpha(_0x3edf515c.Cream, 0.6f);
        }

        return _0x2243f25d;
    }

    private RectTransform _0x44d70984;
    private sealed class _0xe2e14d05
    {
        public RectTransform Rect;
        public Image Frame;
        public Image Body;
        public TextMeshProUGUI Title;
        public TextMeshProUGUI Detail;
        public TextMeshProUGUI Best;
        public Image[] Pips;
        public bool Unlocked;
    }

    [SerializeField]
    private Sprite _plateSprite;
    private void Start()
    {
        this._0x094e3317 = _0x947835d1._0xd9e5de78;
        this._0xbf5508bd = _0x947835d1._0x06cac6a7;
        if (!_0xeeffa5e9.IsUnlocked(this._0x094e3317, _0x947835d1._0x5df25819))
        {
            this._0x094e3317 = 0;
            _0x947835d1._0xd9e5de78 = 0;
        }

        Transform _0xcd2ea83b = this._0x32afdc57();
        if (_0xcd2ea83b == null)
        {
            return;
        }

        this._0x62a01912(_0xcd2ea83b);
        this._0x44d70984 = _0x6d11a8af.Host(_0xcd2ea83b, _0x0fc18cb6._0x3c96fd2f(new byte[12] { 78, 70, 77, 86, 92, 84, 70, 79, 64, 76, 78, 70 }, 3));
        this._0x85e3e53c = _0x6d11a8af.Host(_0xcd2ea83b, _0x0fc18cb6._0x3c96fd2f(new byte[10] { 130, 138, 129, 154, 144, 140, 128, 142, 140, 135 }, 207));
        this._0x6df0d744 = _0x6d11a8af.Host(_0xcd2ea83b, _0x0fc18cb6._0x3c96fd2f(new byte[11] { 171, 163, 168, 179, 185, 180, 169, 179, 178, 163, 181 }, 230));
        this.BuildWelcome(this._0x44d70984);
        this.BuildCoach(this._0x85e3e53c);
        this.BuildRoutes(this._0x6df0d744);
        this._0xe9532dc3();
        this._0xa8313810();
    }

    private TextMeshProUGUI _0x75fc1437;
    private void _0x2f3813bd(int _0x8208fbce)
    {
        if (!_0xeeffa5e9.IsUnlocked(_0x8208fbce, _0x947835d1._0x5df25819))
        {
            return;
        }

        this._0x094e3317 = _0xeeffa5e9.ClampRoute(_0x8208fbce);
        _0x947835d1._0xd9e5de78 = this._0x094e3317;
        _0x947835d1.Flush();
        this._0xa5b6e5ff();
        if (_0x8208fbce < this._0xa3ef6fec.Count && this._0xa3ef6fec[_0x8208fbce].Rect != null)
        {
            this._0xa3ef6fec[_0x8208fbce].Rect.DOPunchScale(new Vector3(0.04f, 0.04f, 0f), 0.18f, 6, 0.6f);
        }
    }

    private Transform _0x32afdc57()
    {
        _0xf933b7ea _0xf77eda0f = _0xf933b7ea.Instance;
        if (_0xf77eda0f == null || _0xf77eda0f.Panels == null)
        {
            return null;
        }

        int _0x5c19e7cb = _0xc1e39607._0x596b9e44.DEFAULT;
        if (_0x5c19e7cb < 0 || _0x5c19e7cb >= _0xf77eda0f.Panels.Count)
        {
            return null;
        }

        _0x52fa1a43 _0x39960e60 = _0xf77eda0f.Panels[_0x5c19e7cb];
        if (_0x39960e60 == null || _0x39960e60.Content == null)
        {
            return null;
        }

        return _0x39960e60.Content.transform;
    }

    private int _0xbf5508bd;
    [SerializeField]
    private Sprite _trayArt;
    // Four visible consequences of one tap (rule C.7): the chosen frame lights up and
    // the others dim, the chosen card's pips turn, the preview is repainted in the
    // route's mood and runs at the chosen pace, and the objective line is rewritten.
    private void _0xa5b6e5ff()
    {
        Color[] _0x81b914c7 = new Color[]
        {
            _0x3edf515c.WithAlpha(_0x3edf515c.Sage, 0.55f),
            _0x3edf515c.WithAlpha(_0x3edf515c.Sun, 0.45f),
            _0x3edf515c.WithAlpha(_0x3edf515c.Sky, 0.50f),
        };
        Color[] _0x383c4abc = new Color[]
        {
            _0x3edf515c.WithAlpha(_0x3edf515c.Cream, 0.90f),
            _0x3edf515c.WithAlpha(_0x3edf515c.Terracotta, 0.85f),
            _0x3edf515c.WithAlpha(_0x3edf515c.Sky, 0.90f),
        };
        for (int _0x116e8f48 = 0; _0x116e8f48 < this._0xa3ef6fec.Count; _0x116e8f48++)
        {
            _0xe2e14d05 _0x3f749f92 = this._0xa3ef6fec[_0x116e8f48];
            bool _0x1e45d841 = _0x116e8f48 == this._0x094e3317;
            if (_0x3f749f92.Frame != null)
            {
                _0x3f749f92.Frame.color = _0x3f749f92.Unlocked ? _0x3edf515c.WithAlpha(_0x3edf515c.Sun, _0x1e45d841 ? 1f : 0.35f) : _0x3edf515c.WithAlpha(_0x3edf515c.Sun, 0.3f);
            }

            if (_0x3f749f92.Body != null)
            {
                _0x3f749f92.Body.color = _0x3edf515c.WithAlpha(_0x3edf515c.SlateDeep, _0x3f749f92.Unlocked ? (_0x1e45d841 ? 0.97f : 0.80f) : 0.55f);
            }

            if (_0x3f749f92.Pips != null)
            {
                int _0xb7b40619 = 3 + _0x116e8f48;
                for (int _0x39f68b13 = 0; _0x39f68b13 < _0x3f749f92.Pips.Length; _0x39f68b13++)
                {
                    if (_0x3f749f92.Pips[_0x39f68b13] == null)
                    {
                        continue;
                    }

                    bool _0x6c0c627d = _0x39f68b13 < _0xb7b40619;
                    _0x3f749f92.Pips[_0x39f68b13].gameObject.SetActive(_0x6c0c627d);
                    if (_0x6c0c627d)
                    {
                        _0x3f749f92.Pips[_0x39f68b13].color = _0x1e45d841 ? _0x3edf515c.WithAlpha(_0x3edf515c.Sage, 0.95f) : _0x3edf515c.WithAlpha(_0x3edf515c.Sky, 0.75f);
                    }
                }
            }

            if (_0x3f749f92.Best != null && _0x3f749f92.Unlocked)
            {
                int _0x9a400f72 = _0x947835d1.BestIntact(_0x116e8f48);
                _0x3f749f92.Best.text = _0x9a400f72 > 0 ? _0x0fc18cb6._0x3c96fd2f(new byte[5] { 38, 33, 55, 48, 68 }, 100) + _0x9a400f72 + _0x0fc18cb6._0x3c96fd2f(new byte[5] { 3, 108, 101, 3, 16 }, 35) : _0x0fc18cb6._0x3c96fd2f(new byte[10] { 214, 215, 184, 202, 205, 214, 184, 193, 221, 204 }, 152);
                _0x3f749f92.Best.color = _0x9a400f72 > 0 ? _0x3edf515c.Sage : _0x3edf515c.WithAlpha(_0x3edf515c.Cream, 0.6f);
            }
        }

        for (int _0x7fcaea26 = 0; _0x7fcaea26 < this._0x4452c2fc.Count; _0x7fcaea26++)
        {
            _0x175f31aa _0x88b9ae4f = this._0x4452c2fc[_0x7fcaea26];
            bool _0x6b9b2153 = _0x7fcaea26 == this._0xbf5508bd;
            if (_0x88b9ae4f.Frame != null)
            {
                _0x88b9ae4f.Frame.color = _0x3edf515c.WithAlpha(_0x3edf515c.Sun, _0x6b9b2153 ? 1f : 0.35f);
            }

            if (_0x88b9ae4f.Title != null)
            {
                _0x88b9ae4f.Title.color = _0x6b9b2153 ? _0x3edf515c.Sun : _0x3edf515c.Cream;
            }

            if (_0x88b9ae4f.Pips != null)
            {
                for (int _0xa75fba3e = 0; _0xa75fba3e < _0x88b9ae4f.Pips.Length; _0xa75fba3e++)
                {
                    if (_0x88b9ae4f.Pips[_0xa75fba3e] == null)
                    {
                        continue;
                    }

                    bool _0xc68391f6 = _0xa75fba3e <= _0x7fcaea26;
                    _0x88b9ae4f.Pips[_0xa75fba3e].color = _0x6b9b2153 && _0xc68391f6 ? _0x3edf515c.Sun : _0x3edf515c.WithAlpha(_0x3edf515c.Sky, _0xc68391f6 ? 0.75f : 0.25f);
                }
            }
        }

        if (this._0x4be316b3 != null)
        {
            this._0x4be316b3._0xa50a965f(_0x81b914c7[this._0x094e3317 % _0x81b914c7.Length], _0x383c4abc[this._0x094e3317 % _0x383c4abc.Length]);
            this._0x4be316b3._0x995c4a1c(_0xeeffa5e9.Paces[this._0xbf5508bd].Multiplier);
        }

        if (this._0x75fc1437 != null)
        {
            _0xeeffa5e9.Route _0x43d718d5 = _0xeeffa5e9.Routes[this._0x094e3317];
            this._0x75fc1437.text = _0x0fc18cb6._0x3c96fd2f(new byte[8] { 75, 74, 67, 70, 89, 74, 93, 47 }, 15) + _0x43d718d5.Required + _0x0fc18cb6._0x3c96fd2f(new byte[8] { 101, 10, 3, 101, 118, 101, 104, 101 }, 69) + _0x43d718d5.Stations + _0x0fc18cb6._0x3c96fd2f(new byte[12] { 12, 127, 120, 109, 120, 101, 99, 98, 127, 12, 1, 12 }, 44) + _0xeeffa5e9.Paces[this._0xbf5508bd].Title;
        }
    }

    private sealed class _0x175f31aa
    {
        public RectTransform Rect;
        public Image Frame;
        public TextMeshProUGUI Title;
        public Image[] Pips;
    }

    [SerializeField]
    private TMP_FontAsset _font;
    private void BuildRoutes(Transform _0xbb3fa22a)
    {
        _0x6d11a8af.Label(_0xbb3fa22a, _0x0fc18cb6._0x3c96fd2f(new byte[10] { 58, 7, 29, 28, 13, 60, 1, 28, 4, 13 }, 104), new Vector2(0.5f, 0.935f), Vector2.zero, new Vector2(1100f, 70f), _0x0fc18cb6._0x3c96fd2f(new byte[18] { 254, 231, 237, 229, 142, 247, 225, 251, 252, 142, 234, 235, 226, 231, 248, 235, 252, 247 }, 174), 46f, _0x3edf515c.Cream, this._font, TextAlignmentOptions.Center);
        float[] _0x5c5e7ffc = new float[]
        {
            0.735f,
            0.605f,
            0.475f
        };
        int _0xddd151f0 = _0x947835d1._0x5df25819;
        for (int _0x4074ce64 = 0; _0x4074ce64 < _0xeeffa5e9.Routes.Length && _0x4074ce64 < _0x5c5e7ffc.Length; _0x4074ce64++)
        {
            this._0xa3ef6fec.Add(this._0x6c545872(_0xbb3fa22a, _0x4074ce64, _0x5c5e7ffc[_0x4074ce64], _0xeeffa5e9.IsUnlocked(_0x4074ce64, _0xddd151f0)));
        }

        float[] _0x0f867424 = new float[]
        {
            0.22f,
            0.50f,
            0.78f
        };
        for (int _0xca3726f7 = 0; _0xca3726f7 < _0xeeffa5e9.Paces.Length && _0xca3726f7 < _0x0f867424.Length; _0xca3726f7++)
        {
            this._0x4452c2fc.Add(this._0x12aca864(_0xbb3fa22a, _0xca3726f7, _0x0f867424[_0xca3726f7]));
        }

        this._0x75fc1437 = _0x6d11a8af.Label(_0xbb3fa22a, _0x0fc18cb6._0x3c96fd2f(new byte[14] { 73, 116, 110, 111, 126, 84, 121, 113, 126, 120, 111, 114, 109, 126 }, 27), new Vector2(0.5f, 0.245f), Vector2.zero, new Vector2(1120f, 52f), _0x0fc18cb6._0x3c96fd2f(new byte[41] { 168, 169, 160, 165, 186, 169, 190, 204, 222, 204, 163, 170, 204, 223, 204, 193, 204, 217, 204, 191, 184, 173, 184, 165, 163, 162, 191, 204, 193, 204, 191, 184, 169, 173, 168, 181, 204, 221, 194, 220, 148 }, 236), 30f, _0x3edf515c.Sun, this._font, TextAlignmentOptions.Center);
        Button _0xd8c0e3e3 = _0x6d11a8af.Cta(_0xbb3fa22a, _0x0fc18cb6._0x3c96fd2f(new byte[9] { 130, 191, 165, 164, 181, 146, 177, 179, 187 }, 208), new Vector2(0.22f, 0.045f), Vector2.zero, new Vector2(360f, 110f), _0x0fc18cb6._0x3c96fd2f(new byte[4] { 22, 21, 23, 31 }, 84), 34f, _0x3edf515c.WithAlpha(_0x3edf515c.Sun, 0.6f), _0x3edf515c.Slate, _0x3edf515c.Cream, this._plateSprite, this._font);
        _0xd8c0e3e3.onClick.AddListener(() => this._0xa8313810());
    }

    private void _0xd623c08b(int _0xbd553a8b)
    {
        this._0xbf5508bd = _0xeeffa5e9.ClampPace(_0xbd553a8b);
        _0x947835d1._0x06cac6a7 = this._0xbf5508bd;
        _0x947835d1.Flush();
        this._0xa5b6e5ff();
        if (_0xbd553a8b < this._0x4452c2fc.Count && this._0x4452c2fc[_0xbd553a8b].Rect != null)
        {
            this._0x4452c2fc[_0xbd553a8b].Rect.DOPunchScale(new Vector3(0.05f, 0.05f, 0f), 0.18f, 6, 0.6f);
        }
    }

    private _0xa016aa85 _0x4be316b3;
    private readonly List<_0xe2e14d05> _0xa3ef6fec = new List<_0xe2e14d05>();
    private void BuildCoach(Transform _0x8b587e59)
    {
        _0x6d11a8af.Label(_0x8b587e59, _0x0fc18cb6._0x3c96fd2f(new byte[10] { 183, 155, 149, 151, 156, 160, 157, 128, 152, 145 }, 244), new Vector2(0.5f, 0.920f), Vector2.zero, new Vector2(1100f, 70f), _0x0fc18cb6._0x3c96fd2f(new byte[18] { 227, 228, 252, 139, 255, 227, 238, 139, 233, 238, 231, 255, 139, 252, 228, 249, 224, 248 }, 171), 46f, _0x3edf515c.Cream, this._font, TextAlignmentOptions.Center);
        RectTransform _0xd51f52b6 = _0x6d11a8af.Node(_0x8b587e59, _0x0fc18cb6._0x3c96fd2f(new byte[12] { 240, 220, 210, 208, 219, 247, 218, 210, 212, 193, 210, 222 }, 179), new Vector2(0.5f, 0.715f), Vector2.zero, new Vector2(1060f, 520f));
        _0x6d11a8af.Plate(_0xd51f52b6, _0x0fc18cb6._0x3c96fd2f(new byte[17] { 245, 217, 215, 213, 222, 242, 223, 215, 209, 196, 215, 219, 230, 218, 215, 194, 211 }, 182), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(1060f, 520f), _0x3edf515c.WithAlpha(_0x3edf515c.SlateDeep, 0.90f), this._plateSprite, 2.4f);
        RectTransform _0xd065419e = _0x6d11a8af.Picture(_0xd51f52b6, _0x0fc18cb6._0x3c96fd2f(new byte[9] { 11, 39, 41, 43, 32, 28, 58, 41, 49 }, 72), new Vector2(0.5f, 0.52f), Vector2.zero, new Vector2(560f, 560f), this._trayArt, Color.white).rectTransform;
        _0xd065419e.localRotation = Quaternion.Euler(0f, 0f, 8f);
        float[] _0x48fda426 = new float[]
        {
            -78f,
            0f,
            78f
        };
        for (int _0xd0375bdc = 0; _0xd0375bdc < _0x48fda426.Length; _0xd0375bdc++)
        {
            _0x6d11a8af.Picture(_0xd065419e, _0x0fc18cb6._0x3c96fd2f(new byte[8] { 77, 97, 111, 109, 102, 75, 105, 105 }, 14) + _0xd0375bdc, new Vector2(0.5f, 0.5f), new Vector2(_0x48fda426[_0xd0375bdc], 26f), new Vector2(64f, 64f), this._eggIntactArt, Color.white);
        }

        _0x6d11a8af.Picture(_0xd51f52b6, _0x0fc18cb6._0x3c96fd2f(new byte[13] { 226, 206, 192, 194, 201, 245, 200, 205, 213, 237, 196, 199, 213 }, 161), new Vector2(0.14f, 0.26f), Vector2.zero, new Vector2(130f, 130f), this._iconTiltLeft, _0x3edf515c.Sun);
        _0x6d11a8af.Picture(_0xd51f52b6, _0x0fc18cb6._0x3c96fd2f(new byte[14] { 194, 238, 224, 226, 233, 213, 232, 237, 245, 211, 232, 230, 233, 245 }, 129), new Vector2(0.86f, 0.26f), Vector2.zero, new Vector2(130f, 130f), this._iconTiltRight, _0x3edf515c.Sun);
        _0x6d11a8af.Picture(_0xd51f52b6, _0x0fc18cb6._0x3c96fd2f(new byte[10] { 83, 127, 113, 115, 120, 64, 124, 101, 125, 117 }, 16), new Vector2(0.74f, 0.80f), Vector2.zero, new Vector2(120f, 120f), this._plumeArt, _0x3edf515c.Sun);
        string[] _0x4e71c67d = new string[]
        {
            _0x0fc18cb6._0x3c96fd2f(new byte[36] { 149, 146, 145, 153, 253, 156, 253, 141, 156, 153, 253, 240, 253, 137, 149, 152, 253, 137, 143, 156, 132, 253, 137, 148, 145, 137, 142, 253, 137, 149, 156, 137, 253, 138, 156, 132 }, 221),
            _0x0fc18cb6._0x3c96fd2f(new byte[38] { 141, 129, 148, 131, 136, 224, 148, 136, 133, 224, 130, 133, 140, 148, 224, 147, 140, 143, 144, 133, 224, 129, 142, 132, 224, 148, 136, 133, 224, 133, 135, 135, 147, 224, 147, 148, 129, 153 }, 192),
            _0x0fc18cb6._0x3c96fd2f(new byte[33] { 99, 97, 116, 99, 104, 0, 97, 0, 112, 108, 117, 109, 101, 0, 97, 116, 0, 105, 116, 115, 0, 109, 97, 114, 107, 101, 100, 0, 97, 110, 103, 108, 101 }, 32),
            _0x0fc18cb6._0x3c96fd2f(new byte[36] { 68, 37, 85, 73, 80, 72, 64, 37, 82, 76, 65, 64, 75, 86, 37, 81, 77, 64, 37, 86, 68, 67, 64, 37, 71, 68, 75, 65, 37, 67, 74, 87, 37, 51, 37, 86 }, 5),
            _0x0fc18cb6._0x3c96fd2f(new byte[30] { 33, 61, 48, 85, 38, 61, 52, 57, 57, 58, 34, 85, 59, 48, 38, 33, 85, 57, 48, 33, 38, 85, 50, 58, 85, 51, 60, 39, 38, 33 }, 117),
        };
        float[] _0x443add40 = new float[]
        {
            0.520f,
            0.465f,
            0.410f,
            0.355f,
            0.300f
        };
        for (int _0xc1e97193 = 0; _0xc1e97193 < _0x4e71c67d.Length; _0xc1e97193++)
        {
            Color _0xc4af9eac = _0xc1e97193 >= 3 ? _0x3edf515c.Sun : _0x3edf515c.Cream;
            _0x6d11a8af.Label(_0x8b587e59, _0x0fc18cb6._0x3c96fd2f(new byte[9] { 95, 115, 125, 127, 116, 80, 117, 114, 121 }, 28) + _0xc1e97193, new Vector2(0.5f, _0x443add40[_0xc1e97193]), Vector2.zero, new Vector2(1120f, 52f), _0x4e71c67d[_0xc1e97193], 32f, _0xc4af9eac, this._font, TextAlignmentOptions.Center);
        }

        Button _0xc3b042b8 = _0x6d11a8af.Cta(_0x8b587e59, _0x0fc18cb6._0x3c96fd2f(new byte[9] { 149, 185, 183, 181, 190, 146, 185, 184, 179 }, 214), new Vector2(0.5f, 0.135f), Vector2.zero, new Vector2(740f, 160f), _0x0fc18cb6._0x3c96fd2f(new byte[21] { 201, 193, 218, 174, 199, 218, 174, 163, 174, 222, 199, 205, 197, 174, 207, 174, 220, 193, 219, 218, 203 }, 142), 38f, _0x3edf515c.Sun, _0x3edf515c.SlateSoft, _0x3edf515c.Cream, this._plateSprite, this._font);
        _0xc3b042b8.onClick.AddListener(() => this._0xd394b747());
    }

    // -- boards -------------------------------------------------------------
    private void BuildWelcome(Transform _0x660ca139)
    {
        _0x6d11a8af.Plate(_0x660ca139, _0x0fc18cb6._0x3c96fd2f(new byte[10] { 187, 142, 131, 131, 150, 188, 155, 157, 134, 159 }, 239), new Vector2(0.5f, 0.925f), Vector2.zero, new Vector2(1120f, 150f), _0x3edf515c.WithAlpha(_0x3edf515c.SlateDeep, 0.92f), this._plateSprite, 2.2f);
        this._0x852b738f = _0x6d11a8af.Label(_0x660ca139, _0x0fc18cb6._0x3c96fd2f(new byte[9] { 65, 116, 121, 121, 108, 80, 114, 114, 102 }, 21), new Vector2(0.325f, 0.925f), Vector2.zero, new Vector2(520f, 56f), _0x0fc18cb6._0x3c96fd2f(new byte[16] { 118, 116, 116, 96, 19, 119, 118, 127, 122, 101, 118, 97, 118, 119, 19, 3 }, 51), 36f, _0x3edf515c.Cream, this._font, TextAlignmentOptions.Center);
        this._0x6bebe7a8 = _0x6d11a8af.Label(_0x660ca139, _0x0fc18cb6._0x3c96fd2f(new byte[9] { 72, 125, 112, 112, 101, 94, 121, 111, 104 }, 28), new Vector2(0.700f, 0.925f), Vector2.zero, new Vector2(420f, 52f), _0x0fc18cb6._0x3c96fd2f(new byte[15] { 237, 234, 252, 251, 143, 253, 250, 225, 143, 159, 143, 224, 233, 143, 156 }, 175), 32f, _0x3edf515c.Sun, this._font, TextAlignmentOptions.Center);
        this._0x4be316b3 = this.gameObject.AddComponent<_0xa016aa85>();
        this._0x4be316b3._0x58b7f2a2(_0x660ca139, this._trayArt, this._eggIntactArt, this._plumeArt, this._railArt, this._hillArt, this._stationArt);
        _0x6d11a8af.Label(_0x660ca139, _0x0fc18cb6._0x3c96fd2f(new byte[11] { 159, 173, 164, 171, 167, 165, 173, 132, 161, 166, 173 }, 200), new Vector2(0.5f, 0.430f), Vector2.zero, new Vector2(1100f, 80f), _0x0fc18cb6._0x3c96fd2f(new byte[16] { 222, 208, 208, 197, 181, 193, 221, 208, 216, 181, 198, 193, 208, 212, 209, 204 }, 149), 56f, _0x3edf515c.Cream, this._font, TextAlignmentOptions.Center);
        _0x6d11a8af.Label(_0x660ca139, _0x0fc18cb6._0x3c96fd2f(new byte[10] { 85, 103, 110, 97, 109, 111, 103, 81, 119, 96 }, 2), new Vector2(0.5f, 0.385f), Vector2.zero, new Vector2(1100f, 52f), _0x0fc18cb6._0x3c96fd2f(new byte[28] { 133, 153, 131, 148, 148, 241, 159, 148, 130, 133, 130, 241, 252, 241, 158, 159, 148, 241, 152, 130, 241, 130, 153, 144, 157, 157, 158, 134 }, 209), 32f, _0x3edf515c.Sun, this._font, TextAlignmentOptions.Center);
        Button _0x7d5290ab = _0x6d11a8af.Cta(_0x660ca139, _0x0fc18cb6._0x3c96fd2f(new byte[11] { 123, 73, 64, 79, 67, 65, 73, 124, 64, 77, 85 }, 44), new Vector2(0.5f, 0.265f), Vector2.zero, new Vector2(770f, 168f), _0x0fc18cb6._0x3c96fd2f(new byte[4] { 67, 95, 82, 74 }, 19), 62f, _0x3edf515c.Sun, _0x3edf515c.SlateSoft, _0x3edf515c.Cream, this._plateSprite, this._font);
        _0x7d5290ab.onClick.AddListener(() => this._0xd394b747());
        _0x7d5290ab.transform.localScale = new Vector3(0.92f, 0.92f, 1f);
        _0x7d5290ab.transform.DOScale(1f, 0.35f).SetEase(Ease.OutBack);
        Button _0x0febc3b2 = _0x6d11a8af.Cta(_0x660ca139, _0x0fc18cb6._0x3c96fd2f(new byte[12] { 111, 93, 84, 91, 87, 85, 93, 123, 87, 89, 91, 80 }, 56), new Vector2(0.5f, 0.160f), Vector2.zero, new Vector2(620f, 132f), _0x0fc18cb6._0x3c96fd2f(new byte[11] { 20, 19, 11, 124, 8, 19, 124, 8, 21, 16, 8 }, 92), 40f, _0x3edf515c.WithAlpha(_0x3edf515c.Sun, 0.7f), _0x3edf515c.Slate, _0x3edf515c.Cream, this._plateSprite, this._font);
        _0x0febc3b2.onClick.AddListener(() => this._0xa4632577());
        for (int _0x76180b9f = 0; _0x76180b9f < 7; _0x76180b9f++)
        {
            _0x6d11a8af.Picture(_0x660ca139, _0x0fc18cb6._0x3c96fd2f(new byte[11] { 144, 162, 171, 164, 168, 170, 162, 149, 166, 174, 171 }, 199) + _0x76180b9f, new Vector2(0.075f + (_0x76180b9f * 0.142f), 0.058f), Vector2.zero, new Vector2(150f, 150f), this._railArt, _0x3edf515c.WithAlpha(_0x3edf515c.Cream, 0.55f));
        }
    }

    private void _0x0f3f05af()
    {
        if (this._0x852b738f != null)
        {
            this._0x852b738f.text = _0x0fc18cb6._0x3c96fd2f(new byte[15] { 168, 170, 170, 190, 205, 169, 168, 161, 164, 187, 168, 191, 168, 169, 205 }, 237) + _0x947835d1._0xe2dd4536;
        }

        if (this._0x6bebe7a8 != null)
        {
            this._0x6bebe7a8.text = _0x0fc18cb6._0x3c96fd2f(new byte[9] { 119, 112, 102, 97, 21, 103, 96, 123, 21 }, 53) + _0x947835d1.BestRunAnywhere() + _0x0fc18cb6._0x3c96fd2f(new byte[5] { 188, 211, 218, 188, 175 }, 156);
        }
    }

    private const float RefWidth = 1242f;
    private int _0x094e3317;
    [SerializeField]
    private Sprite _plumeArt;
    [SerializeField]
    private Sprite _iconTiltLeft;
    [SerializeField]
    private Sprite _stationArt;
    [SerializeField]
    private RectTransform _startDeliveryRect;
    private void _0x8a5a1822(int _0x86c78e3d)
    {
        if (this._0x44d70984 != null)
        {
            this._0x44d70984.gameObject.SetActive(_0x86c78e3d == 0);
        }

        if (this._0x85e3e53c != null)
        {
            this._0x85e3e53c.gameObject.SetActive(_0x86c78e3d == 1);
        }

        if (this._0x6df0d744 != null)
        {
            this._0x6df0d744.gameObject.SetActive(_0x86c78e3d == 2);
        }

        if (this._startDeliveryRect != null)
        {
            this._startDeliveryRect.gameObject.SetActive(_0x86c78e3d == 2);
            if (_0x86c78e3d == 2)
            {
                this._startDeliveryRect.SetAsLastSibling();
            }
        }

        if (_0x86c78e3d == 0)
        {
            this._0x0f3f05af();
        }

        if (_0x86c78e3d == 2)
        {
            this._0xa5b6e5ff();
        }
    }

    private void _0xd394b747()
    {
        this._0x8a5a1822(2);
    }

    private readonly List<_0x175f31aa> _0x4452c2fc = new List<_0x175f31aa>();
    [SerializeField]
    private Sprite _eggIntactArt;
    private TextMeshProUGUI _0x6bebe7a8;
    private TextMeshProUGUI _0x852b738f;
    [SerializeField]
    private Sprite _hillArt;
    private void _0xa4632577()
    {
        this._0x8a5a1822(1);
    }

    // -- board switching and selection --------------------------------------
    private void _0xa8313810()
    {
        this._0x8a5a1822(0);
    }

    private RectTransform _0x85e3e53c;
    // Everything the template left in the menu body is switched off except the
    // scene-loading button, which this game re-uses as its START DELIVERY slot.
    private void _0x62a01912(Transform _0x8023ba0f)
    {
        for (int _0x8d3edbc5 = _0x8023ba0f.childCount - 1; _0x8d3edbc5 >= 0; _0x8d3edbc5--)
        {
            Transform _0x086dc81b = _0x8023ba0f.GetChild(_0x8d3edbc5);
            if (_0x086dc81b == null)
            {
                continue;
            }

            if (this._startDeliveryRect != null && (_0x086dc81b == this._startDeliveryRect || this._startDeliveryRect.IsChildOf(_0x086dc81b)))
            {
                continue;
            }

            _0x086dc81b.gameObject.SetActive(false);
        }
    }
}

internal static class _0x0fc18cb6
{
    internal static string _0x3c96fd2f(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}