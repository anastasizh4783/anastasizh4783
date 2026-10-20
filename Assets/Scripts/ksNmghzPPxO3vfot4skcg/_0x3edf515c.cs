using UnityEngine;

// Palette of the delivery belt game. Every colour that can become TEXT is light,
// because the single shared font material carries one dark outline (rule C.14):
// Cream, Sun and Sage clear 4.5:1 against the outline, Slate / Terracotta / Sky
// do not and are therefore surface and graphic colours only.
public static class _0x3edf515c
{
    public static Color WithAlpha(Color _0x6a26f011, float _0xe0b9f31f)
    {
        return new Color(_0x6a26f011.r, _0x6a26f011.g, _0x6a26f011.b, _0xe0b9f31f);
    }

    public static readonly Color Sun = new Color(1.000f, 0.820f, 0.353f, 1f);
    public static readonly Color Sky = new Color(0.384f, 0.659f, 0.859f, 1f);
    public static readonly Color Sage = new Color(0.463f, 0.776f, 0.420f, 1f);
    public static readonly Color Slate = new Color(0.188f, 0.220f, 0.314f, 1f);
    public static readonly Color SlateDeep = new Color(0.137f, 0.165f, 0.243f, 1f);
    public static readonly Color Terracotta = new Color(0.937f, 0.510f, 0.271f, 1f);
    public static readonly Color Cream = new Color(1.000f, 0.973f, 0.902f, 1f);
    public static readonly Color Ink = new Color(0.102f, 0.122f, 0.180f, 1f);
    public static readonly Color Shade = new Color(0.102f, 0.122f, 0.180f, 0.72f);
    public static readonly Color SlateSoft = new Color(0.227f, 0.263f, 0.376f, 1f);
}