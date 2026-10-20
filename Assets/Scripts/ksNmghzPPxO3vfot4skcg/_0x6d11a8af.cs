using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Small UGUI factory used by both scenes. Everything is built inside the template's
// own panel body, so the chrome of the game is OUR objects (rule C.2) and nothing is
// hung on a template placeholder.
public static class _0x6d11a8af
{
    // A rect anchored to a single point of its parent, sized in reference pixels.
    public static RectTransform Node(Transform _0x08d83c16, string _0xa20787e5, Vector2 _0x8f33fed8, Vector2 _0xbe611797, Vector2 _0x74d86225)
    {
        GameObject _0x85620f79 = new GameObject(_0xa20787e5, typeof(RectTransform));
        RectTransform _0x0d3b40ec = _0x85620f79.GetComponent<RectTransform>();
        _0x0d3b40ec.SetParent(_0x08d83c16, false);
        _0x0d3b40ec.anchorMin = _0x8f33fed8;
        _0x0d3b40ec.anchorMax = _0x8f33fed8;
        _0x0d3b40ec.pivot = new Vector2(0.5f, 0.5f);
        _0x0d3b40ec.sizeDelta = _0x74d86225;
        _0x0d3b40ec.anchoredPosition = _0xbe611797;
        _0x0d3b40ec.localScale = Vector3.one;
        return _0x0d3b40ec;
    }

    // A themed button: gold frame, dark body, light caption. The caption is the LAST
    // child so the body can never cover it (rule C.13 / E.1).
    public static Button Cta(Transform _0x89b2284a, string _0x1177d9d9, Vector2 _0x2e94818d, Vector2 _0x4560c642, Vector2 _0x2398de9f, string _0x9d19cac2, float _0x712be340, Color _0xa686bd84, Color _0x6df49f4f, Color _0xd35399c3, Sprite _0x2d35d3d8, TMP_FontAsset _0x9381fcd4)
    {
        RectTransform _0x07c74221 = Node(_0x89b2284a, _0x1177d9d9, _0x2e94818d, _0x4560c642, _0x2398de9f);
        Image _0x6e647a0a = _0x07c74221.gameObject.AddComponent<Image>();
        _0x6e647a0a.color = _0xa686bd84;
        _0x6e647a0a.raycastTarget = true;
        if (_0x2d35d3d8 != null)
        {
            _0x6e647a0a.sprite = _0x2d35d3d8;
            _0x6e647a0a.type = Image.Type.Sliced;
            _0x6e647a0a.pixelsPerUnitMultiplier = Mathf.Max(1.4f, 170f / Mathf.Max(24f, Mathf.Min(_0x2398de9f.x, _0x2398de9f.y)));
        }

        Image _0x4de74cfe = Plate(_0x07c74221, _0x1177d9d9 + _0x23797e50._0xc528cfd4(new byte[4] { 138, 167, 172, 177 }, 200), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(_0x2398de9f.x - 16f, _0x2398de9f.y - 16f), _0x6df49f4f, _0x2d35d3d8, Mathf.Max(1.4f, 170f / Mathf.Max(24f, Mathf.Min(_0x2398de9f.x, _0x2398de9f.y))));
        _0x4de74cfe.raycastTarget = false;
        if (!string.IsNullOrEmpty(_0x9d19cac2))
        {
            Label(_0x07c74221, _0x1177d9d9 + _0x23797e50._0xc528cfd4(new byte[7] { 131, 161, 176, 180, 169, 175, 174 }, 192), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(_0x2398de9f.x - 54f, _0x2398de9f.y - 30f), _0x9d19cac2, _0x712be340, _0xd35399c3, _0x9381fcd4, TextAlignmentOptions.Center);
        }

        Button _0x90501c9c = _0x07c74221.gameObject.AddComponent<Button>();
        _0x90501c9c.targetGraphic = _0x6e647a0a;
        ColorBlock _0xfaec7d8a = _0x90501c9c.colors;
        _0xfaec7d8a.normalColor = Color.white;
        _0xfaec7d8a.highlightedColor = Color.white;
        _0xfaec7d8a.pressedColor = new Color(0.72f, 0.72f, 0.72f, 1f);
        _0xfaec7d8a.selectedColor = Color.white;
        _0xfaec7d8a.disabledColor = new Color(0.55f, 0.55f, 0.55f, 0.6f);
        _0xfaec7d8a.fadeDuration = 0.08f;
        _0x90501c9c.colors = _0xfaec7d8a;
        return _0x90501c9c;
    }

    // A content picture: the aspect of the generated PNG is preserved (rule F.2a).
    public static Image Picture(Transform _0xf9693056, string _0x0e24a57d, Vector2 _0x2d055997, Vector2 _0x32e806dc, Vector2 _0x4fdafab9, Sprite _0x7ab89957, Color _0x8800d490)
    {
        RectTransform _0xa90bc704 = Node(_0xf9693056, _0x0e24a57d, _0x2d055997, _0x32e806dc, _0x4fdafab9);
        Image _0x9fa51792 = _0xa90bc704.gameObject.AddComponent<Image>();
        _0x9fa51792.sprite = _0x7ab89957;
        _0x9fa51792.color = _0x8800d490;
        _0x9fa51792.type = Image.Type.Simple;
        _0x9fa51792.preserveAspect = true;
        _0x9fa51792.raycastTarget = false;
        return _0x9fa51792;
    }

    // An icon-only button (back, pause, close).
    public static Button IconCta(Transform _0x5b8b64b8, string _0xc77b80ae, Vector2 _0x197d6ca4, Vector2 _0xe4d67de0, Vector2 _0xfcc3ed0d, Sprite _0xf6d3f7e9, Color _0xa94704d3, Color _0xad8b0db8, Color _0x3065e0ae, Sprite _0x238a81ff)
    {
        RectTransform _0x1f6730a4 = Node(_0x5b8b64b8, _0xc77b80ae, _0x197d6ca4, _0xe4d67de0, _0xfcc3ed0d);
        Image _0x8339fd8b = _0x1f6730a4.gameObject.AddComponent<Image>();
        _0x8339fd8b.color = _0xa94704d3;
        _0x8339fd8b.raycastTarget = true;
        if (_0x238a81ff != null)
        {
            _0x8339fd8b.sprite = _0x238a81ff;
            _0x8339fd8b.type = Image.Type.Sliced;
            _0x8339fd8b.pixelsPerUnitMultiplier = Mathf.Max(1.4f, 170f / Mathf.Max(24f, Mathf.Min(_0xfcc3ed0d.x, _0xfcc3ed0d.y)));
        }

        Plate(_0x1f6730a4, _0xc77b80ae + _0x23797e50._0xc528cfd4(new byte[4] { 199, 234, 225, 252 }, 133), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(_0xfcc3ed0d.x - 14f, _0xfcc3ed0d.y - 14f), _0xad8b0db8, _0x238a81ff, Mathf.Max(1.4f, 170f / Mathf.Max(24f, Mathf.Min(_0xfcc3ed0d.x, _0xfcc3ed0d.y))));
        Picture(_0x1f6730a4, _0xc77b80ae + _0x23797e50._0xc528cfd4(new byte[5] { 25, 50, 39, 46, 54 }, 94), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(_0xfcc3ed0d.x * 0.56f, _0xfcc3ed0d.y * 0.56f), _0xf6d3f7e9, _0x3065e0ae);
        Button _0x5f98b154 = _0x1f6730a4.gameObject.AddComponent<Button>();
        _0x5f98b154.targetGraphic = _0x8339fd8b;
        ColorBlock _0x91d76e43 = _0x5f98b154.colors;
        _0x91d76e43.normalColor = Color.white;
        _0x91d76e43.highlightedColor = Color.white;
        _0x91d76e43.pressedColor = new Color(0.72f, 0.72f, 0.72f, 1f);
        _0x91d76e43.selectedColor = Color.white;
        _0x91d76e43.disabledColor = new Color(0.55f, 0.55f, 0.55f, 0.6f);
        _0x91d76e43.fadeDuration = 0.08f;
        _0x5f98b154.colors = _0x91d76e43;
        return _0x5f98b154;
    }

    public static TextMeshProUGUI Label(Transform _0xdbe75ac5, string _0xc6b936dd, Vector2 _0xabf7ec68, Vector2 _0xc169d722, Vector2 _0x6fd50a02, string _0x5fd0b4ec, float _0x3f124f7c, Color _0xff5ede1d, TMP_FontAsset _0xd3cd2379, TextAlignmentOptions _0x46b88061)
    {
        RectTransform _0xd3f90980 = Node(_0xdbe75ac5, _0xc6b936dd, _0xabf7ec68, _0xc169d722, _0x6fd50a02);
        TextMeshProUGUI _0x1b0afcd2 = _0xd3f90980.gameObject.AddComponent<TextMeshProUGUI>();
        if (_0xd3cd2379 != null)
        {
            _0x1b0afcd2.font = _0xd3cd2379;
        }

        _0x1b0afcd2.text = _0x5fd0b4ec;
        _0x1b0afcd2.alignment = _0x46b88061;
        _0xe51599fc.Configure(_0x1b0afcd2, _0x3f124f7c, _0xff5ede1d);
        return _0x1b0afcd2;
    }

    // A tap surface. A fully transparent Image is culled by the raycaster, so the
    // alpha stays just above zero and transparent-mesh culling is switched off.
    public static Image HitLayer(Transform _0x924a1ede, string _0x0b647b7d, Vector2 _0x47d210d9, Vector2 _0x4c8bbe84, Vector2 _0x89974832)
    {
        RectTransform _0xb5294b68 = Node(_0x924a1ede, _0x0b647b7d, _0x47d210d9, _0x4c8bbe84, _0x89974832);
        Image _0x3ac99cb2 = _0xb5294b68.gameObject.AddComponent<Image>();
        _0x3ac99cb2.color = new Color(1f, 1f, 1f, 0.004f);
        _0x3ac99cb2.raycastTarget = true;
        _0x3ac99cb2.canvasRenderer.cullTransparentMesh = false;
        return _0x3ac99cb2;
    }

    // Stretch a freshly created RectTransform over its parent. A GameObject created
    // with typeof(RectTransform) starts 100x100 anchored at the centre, which would
    // resolve every child anchor against 100x100 instead of the reference canvas.
    public static RectTransform Host(Transform _0x5d93b1f0, string _0xb7e46a0b)
    {
        GameObject _0x7026b7e6 = new GameObject(_0xb7e46a0b, typeof(RectTransform));
        RectTransform _0x73a11e93 = _0x7026b7e6.GetComponent<RectTransform>();
        _0x73a11e93.SetParent(_0x5d93b1f0, false);
        _0x73a11e93.anchorMin = Vector2.zero;
        _0x73a11e93.anchorMax = Vector2.one;
        _0x73a11e93.pivot = new Vector2(0.5f, 0.5f);
        _0x73a11e93.offsetMin = Vector2.zero;
        _0x73a11e93.offsetMax = Vector2.zero;
        _0x73a11e93.localScale = Vector3.one;
        return _0x73a11e93;
    }

    public static Image Bar(Transform _0xc0857b73, string _0x6092f779, Vector2 _0xf7af4a7a, Vector2 _0x4184990b, Vector2 _0x88e86d28, Color _0xb6d678db, Sprite _0x2a03648c, float _0x38b0ce46)
    {
        Image _0x983139ea = Plate(_0xc0857b73, _0x6092f779, _0xf7af4a7a, _0x4184990b, _0x88e86d28, _0xb6d678db, _0x2a03648c, _0x38b0ce46);
        _0x983139ea.type = Image.Type.Filled;
        _0x983139ea.fillMethod = Image.FillMethod.Horizontal;
        _0x983139ea.fillOrigin = 0;
        _0x983139ea.fillAmount = 1f;
        return _0x983139ea;
    }

    public static Image Plate(Transform _0x40600ade, string _0x33ad3f8f, Vector2 _0x77431525, Vector2 _0xf6ace7c1, Vector2 _0x0be05bf8, Color _0x0296f30b, Sprite _0xfed65359, float _0x7aa3ac95)
    {
        RectTransform _0x0371b245 = Node(_0x40600ade, _0x33ad3f8f, _0x77431525, _0xf6ace7c1, _0x0be05bf8);
        Image _0x26e95505 = _0x0371b245.gameObject.AddComponent<Image>();
        _0x26e95505.color = _0x0296f30b;
        _0x26e95505.raycastTarget = false;
        if (_0xfed65359 != null)
        {
            _0x26e95505.sprite = _0xfed65359;
            _0x26e95505.type = Image.Type.Sliced;
            _0x26e95505.pixelsPerUnitMultiplier = Mathf.Max(0.6f, _0x7aa3ac95);
        }

        return _0x26e95505;
    }
}

internal static class _0x23797e50
{
    internal static string _0xc528cfd4(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}