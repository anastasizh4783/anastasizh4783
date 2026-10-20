using UnityEngine;

// Persistence. The keys are string LITERALS on purpose: a literal is a stable id
// that survives symbol renaming, which nameof() would not.
public static class _0x947835d1
{
    public static int _0xe2dd4536
    {
        get
        {
            return PlayerPrefs.GetInt(_0x8da6fa08._0xbeda501a(new byte[8] { 237, 249, 239, 165, 238, 236, 236, 248 }, 139), 0);
        }

        set
        {
            PlayerPrefs.SetInt(_0x8da6fa08._0xbeda501a(new byte[8] { 210, 198, 208, 154, 209, 211, 211, 199 }, 180), Mathf.Max(0, value));
        }
    }

    public static int _0x5df25819
    {
        get
        {
            return PlayerPrefs.GetInt(_0x8da6fa08._0xbeda501a(new byte[14] { 207, 219, 205, 135, 205, 204, 197, 192, 223, 204, 219, 192, 204, 218 }, 169), 0);
        }

        set
        {
            PlayerPrefs.SetInt(_0x8da6fa08._0xbeda501a(new byte[14] { 47, 59, 45, 103, 45, 44, 37, 32, 63, 44, 59, 32, 44, 58 }, 73), Mathf.Max(0, value));
        }
    }

    public static int _0x86254135
    {
        get
        {
            return PlayerPrefs.GetInt(_0x8da6fa08._0xbeda501a(new byte[12] { 78, 90, 76, 6, 73, 92, 92, 77, 69, 88, 92, 91 }, 40), 0);
        }

        set
        {
            PlayerPrefs.SetInt(_0x8da6fa08._0xbeda501a(new byte[12] { 185, 173, 187, 241, 190, 171, 171, 186, 178, 175, 171, 172 }, 223), Mathf.Max(0, value));
        }
    }

    public static int BestRunAnywhere()
    {
        int _0xcdbdcc30 = 0;
        for (int _0x8c07d2ae = 0; _0x8c07d2ae < _0xeeffa5e9.Routes.Length; _0x8c07d2ae++)
        {
            int _0x68c2da19 = PlayerPrefs.GetInt(_0x8da6fa08._0xbeda501a(new byte[9] { 88, 76, 90, 16, 92, 91, 77, 74, 16 }, 62) + _0x8c07d2ae, 0);
            if (_0x68c2da19 > _0xcdbdcc30)
            {
                _0xcdbdcc30 = _0x68c2da19;
            }
        }

        return _0xcdbdcc30;
    }

    public static void Flush()
    {
        PlayerPrefs.Save();
    }

    public static int _0xd9e5de78
    {
        get
        {
            return _0xeeffa5e9.ClampRoute(PlayerPrefs.GetInt(_0x8da6fa08._0xbeda501a(new byte[9] { 93, 73, 95, 21, 73, 84, 78, 79, 94 }, 59), 0));
        }

        set
        {
            PlayerPrefs.SetInt(_0x8da6fa08._0xbeda501a(new byte[9] { 117, 97, 119, 61, 97, 124, 102, 103, 118 }, 19), _0xeeffa5e9.ClampRoute(value));
        }
    }

    public static void StoreBestIntact(int _0x03c5f679, int _0x5b1e95d3)
    {
        int _0x7e574b69 = _0xeeffa5e9.ClampRoute(_0x03c5f679);
        if (_0x5b1e95d3 > PlayerPrefs.GetInt(_0x8da6fa08._0xbeda501a(new byte[9] { 174, 186, 172, 230, 170, 173, 187, 188, 230 }, 200) + _0x7e574b69, 0))
        {
            PlayerPrefs.SetInt(_0x8da6fa08._0xbeda501a(new byte[9] { 43, 63, 41, 99, 47, 40, 62, 57, 99 }, 77) + _0x7e574b69, _0x5b1e95d3);
        }
    }

    public static int _0x06cac6a7
    {
        get
        {
            return _0xeeffa5e9.ClampPace(PlayerPrefs.GetInt(_0x8da6fa08._0xbeda501a(new byte[8] { 20, 0, 22, 92, 2, 19, 17, 23 }, 114), 0));
        }

        set
        {
            PlayerPrefs.SetInt(_0x8da6fa08._0xbeda501a(new byte[8] { 239, 251, 237, 167, 249, 232, 234, 236 }, 137), _0xeeffa5e9.ClampPace(value));
        }
    }

    public static int BestIntact(int _0x43a09e61)
    {
        return PlayerPrefs.GetInt(_0x8da6fa08._0xbeda501a(new byte[9] { 218, 206, 216, 146, 222, 217, 207, 200, 146 }, 188) + _0xeeffa5e9.ClampRoute(_0x43a09e61), 0);
    }
}

internal static class _0x8da6fa08
{
    internal static string _0xbeda501a(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}