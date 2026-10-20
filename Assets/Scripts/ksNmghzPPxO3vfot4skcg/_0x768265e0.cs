using System.Collections.Generic;
using TMPro;
using UnityEngine;

// TmpContrastGuard.cs — staged into every Unity app by approve-pipeline-unity.sh
// (stage 5c3, rule C.14 in CLAUDE-unity.md). Do not edit the copy inside a project;
// edit scripts/lib/unity/TmpContrastGuard.cs.
//
// WHY: every TMP label gets an outline (C.10), and by default that outline is dark.
// A dark face colour on a dark outline merges into a smudge — the label is not
// readable on any backing (ANDROID-3627: PLAY drawn Deep #12151E on the #12151E
// outline read as a black blob). enforce-text-contrast.sh fixes colours SERIALISED
// in scenes/prefabs, but labels built at runtime from C# (UiKit.Cta, VaultUi.Caption,
// label.color = Palette.X ...) never reach a scene file, so that pass cannot see them.
//
// WHAT: after any TMP text is regenerated, compare its face colour with the outline
// colour of the material it actually renders with. Below WCAG 4.5:1 the face is
// blended toward white (dark outline) or black (light outline) until it reaches 7:1.
// Hue is kept; alpha is kept. A label whose outline was deliberately switched to a
// light colour (TextReadability-style per-label material) is measured against THAT
// outline, so intentionally dark text on a light rim is left alone. Labels without
// an outline are left alone too.
public sealed class _0x768265e0 : MonoBehaviour
{
    private const float MinRatio = 4.5f;
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Boot()
    {
        if (_0x6e507cc0 != null)
            return;
        GameObject _0x6695c93d = new GameObject(_0x77b5e030._0x966f82cc(new byte[16] { 31, 38, 59, 8, 36, 37, 63, 57, 42, 56, 63, 12, 62, 42, 57, 47 }, 75));
        _0x6695c93d.hideFlags = HideFlags.HideInHierarchy;
        DontDestroyOnLoad(_0x6695c93d);
        _0x6e507cc0 = _0x6695c93d.AddComponent<_0x768265e0>();
    }

    private void OnDisable()
    {
        if (this._0xf97f6ed1 != null)
            TMPro_EventManager.TEXT_CHANGED_EVENT.Remove(this._0xf97f6ed1);
    }

    private void OnEnable()
    {
        if (this._0xf97f6ed1 == null)
            this._0xf97f6ed1 = _0x4a220e6c => this._0xddc7c053(_0x4a220e6c);
        TMPro_EventManager.TEXT_CHANGED_EVENT.Add(this._0xf97f6ed1);
    }

    private const float TargetRatio = 7f;
    private const float MinOutlineWidth = 0.01f;
    private static _0x768265e0 _0x6e507cc0;
    private readonly List<TMP_Text> _0x06afe299 = new List<TMP_Text>();
    // The event fires from inside the canvas rebuild. Changing the colour right there
    // would re-dirty the graphic mid-rebuild, which Unity rejects — so queue it and
    // apply in LateUpdate, which runs before the next frame's rebuild.
    private void _0xddc7c053(Object _0x85a9e01f)
    {
        TMP_Text _0xd4beb33c = _0x85a9e01f as TMP_Text;
        if (_0xd4beb33c != null)
            this._0xcfd93972.Add(_0xd4beb33c);
    }

    private readonly HashSet<TMP_Text> _0xcfd93972 = new HashSet<TMP_Text>();
    private static float Ratio(Color _0xa93174f4, Color _0x26584def)
    {
        float _0x3e7b443b = Luminance(_0xa93174f4);
        float _0x9e7d6ffd = Luminance(_0x26584def);
        return (Mathf.Max(_0x3e7b443b, _0x9e7d6ffd) + 0.05f) / (Mathf.Min(_0x3e7b443b, _0x9e7d6ffd) + 0.05f);
    }

    private static float Linear(float _0x6064ec5b)
    {
        _0x6064ec5b = Mathf.Clamp01(_0x6064ec5b);
        return _0x6064ec5b <= 0.03928f ? _0x6064ec5b / 12.92f : Mathf.Pow((_0x6064ec5b + 0.055f) / 1.055f, 2.4f);
    }

    // A lambda held in a field, never the bare method group: Plana renames the method
    // declaration but not a method-group reference (verify-unity-buttons.sh, CS0103).
    // The field keeps Add and Remove on the same delegate instance.
    private System.Action<Object> _0xf97f6ed1;
    // WCAG relative luminance of an sRGB colour, and the contrast ratio of two.
    private static float Luminance(Color _0x6b4b3afc)
    {
        return 0.2126f * Linear(_0x6b4b3afc.r) + 0.7152f * Linear(_0x6b4b3afc.g) + 0.0722f * Linear(_0x6b4b3afc.b);
    }

    private void LateUpdate()
    {
        if (this._0xcfd93972.Count == 0)
            return;
        this._0x06afe299.Clear();
        this._0x06afe299.AddRange(this._0xcfd93972);
        this._0xcfd93972.Clear();
        for (int _0x4d67f044 = 0; _0x4d67f044 < this._0x06afe299.Count; _0x4d67f044++)
            Fix(this._0x06afe299[_0x4d67f044]);
    }

    private static void Fix(TMP_Text _0xa6e130ef)
    {
        if (_0xa6e130ef == null || !_0xa6e130ef.isActiveAndEnabled)
            return;
        Material _0xbf7083ae = _0xa6e130ef.fontSharedMaterial;
        if (_0xbf7083ae == null || !_0xbf7083ae.HasProperty(ShaderUtilities.ID_OutlineColor) || !_0xbf7083ae.HasProperty(ShaderUtilities.ID_OutlineWidth))
            return;
        if (_0xbf7083ae.GetFloat(ShaderUtilities.ID_OutlineWidth) < MinOutlineWidth)
            return;
        Color _0x2ee5b2b5 = _0xa6e130ef.color;
        if (_0x2ee5b2b5.a <= 0f)
            return;
        Color _0x59c848e2 = _0xbf7083ae.GetColor(ShaderUtilities.ID_OutlineColor);
        if (Ratio(_0x2ee5b2b5, _0x59c848e2) >= MinRatio)
            return;
        Color _0xbf81e968 = Luminance(_0x59c848e2) < 0.5f ? Color.white : Color.black;
        Color _0x16c56cea;
        if (Ratio(_0xbf81e968, _0x59c848e2) < TargetRatio)
        {
            _0x16c56cea = _0xbf81e968;
        }
        else
        {
            // Smallest blend that reaches the target: contrast grows monotonically
            // with t, so a short bisection keeps as much of the hue as possible.
            float _0xe2dce932 = 0f;
            float _0x4263ef5e = 1f;
            for (int _0xcdf353a2 = 0; _0xcdf353a2 < 20; _0xcdf353a2++)
            {
                float _0x1ddfff82 = (_0xe2dce932 + _0x4263ef5e) * 0.5f;
                if (Ratio(Color.Lerp(_0x2ee5b2b5, _0xbf81e968, _0x1ddfff82), _0x59c848e2) >= TargetRatio)
                    _0x4263ef5e = _0x1ddfff82;
                else
                    _0xe2dce932 = _0x1ddfff82;
            }

            _0x16c56cea = Color.Lerp(_0x2ee5b2b5, _0xbf81e968, _0x4263ef5e);
        }

        _0x16c56cea.a = _0x2ee5b2b5.a;
        _0xa6e130ef.color = _0x16c56cea;
    }
}

internal static class _0x77b5e030
{
    internal static string _0x966f82cc(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}