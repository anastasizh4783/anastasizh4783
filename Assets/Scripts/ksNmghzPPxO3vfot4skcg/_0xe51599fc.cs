using TMPro;
using UnityEngine;

// Rule C.10 / C.14 helper. Labels created from code never reach the scene file, so
// stage 5c3 (enforce-text-contrast) cannot see them: every runtime label gets its
// own material instance with an outline that contrasts with its face colour, word
// wrapping off, autosize on and the readability floor as the minimum size.
public static class _0xe51599fc
{
    public static void ApplyOutline(TMP_Text _0xd3e99217, Color _0x5e550209)
    {
        if (_0xd3e99217 == null)
        {
            return;
        }

        Material _0xbabb894a = _0xd3e99217.fontMaterial;
        if (_0xbabb894a == null)
        {
            return;
        }

        float _0x1756158f = (0.299f * _0x5e550209.r) + (0.587f * _0x5e550209.g) + (0.114f * _0x5e550209.b);
        Color _0x02197ab9 = _0x1756158f < 0.5f ? _0x3edf515c.Cream : _0x3edf515c.Slate;
        _0xbabb894a.EnableKeyword(ShaderUtilities.Keyword_Outline);
        _0xbabb894a.SetColor(ShaderUtilities.ID_OutlineColor, _0x02197ab9);
        _0xbabb894a.SetFloat(ShaderUtilities.ID_OutlineWidth, 0.18f);
        _0xbabb894a.SetFloat(ShaderUtilities.ID_FaceDilate, 0.16f);
    }

    public const float UiFontFloor = 24f;
    public static void Configure(TMP_Text _0xa6110be5, float _0xf1497edd, Color _0x8e2b75fa)
    {
        if (_0xa6110be5 == null)
        {
            return;
        }

        _0xa6110be5.textWrappingMode = TextWrappingModes.NoWrap;
        _0xa6110be5.overflowMode = TextOverflowModes.Overflow;
        _0xa6110be5.enableAutoSizing = true;
        _0xa6110be5.fontSizeMin = UiFontFloor;
        _0xa6110be5.fontSizeMax = Mathf.Max(UiFontFloor, _0xf1497edd);
        _0xa6110be5.fontSize = Mathf.Max(UiFontFloor, _0xf1497edd);
        _0xa6110be5.color = _0x8e2b75fa;
        _0xa6110be5.raycastTarget = false;
        ApplyOutline(_0xa6110be5, _0x8e2b75fa);
    }
}