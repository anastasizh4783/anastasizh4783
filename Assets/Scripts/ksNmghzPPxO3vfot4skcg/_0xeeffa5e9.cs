// The three deliveries and the three paces. Counts and clocks live here; WHERE the
// slopes, plumes and stations fall is generated per attempt (rule C.11).
public static class _0xeeffa5e9
{
    public static float RunSeconds(int _0xd0f40a78, int _0x2cab9eed)
    {
        return Routes[ClampRoute(_0xd0f40a78)].BaseSeconds / Paces[ClampPace(_0x2cab9eed)].Multiplier;
    }

    public static readonly Route[] Routes = new Route[]
    {
        new Route
        {
            Title = _0x0038c422._0x4115fa98(new byte[12] { 60, 62, 35, 63, 56, 63, 54, 81, 61, 48, 63, 52 }, 113),
            Stations = 5,
            Required = 2,
            BaseSeconds = 95f,
            UnlockAfterDeliveries = 0
        },
        new Route
        {
            Title = _0x0038c422._0x4115fa98(new byte[12] { 255, 226, 243, 248, 241, 226, 244, 144, 252, 249, 254, 245 }, 176),
            Stations = 6,
            Required = 2,
            BaseSeconds = 112f,
            UnlockAfterDeliveries = 0
        },
        new Route
        {
            Title = _0x0038c422._0x4115fa98(new byte[14] { 122, 97, 108, 111, 109, 8, 107, 122, 103, 123, 123, 97, 102, 111 }, 40),
            Stations = 7,
            Required = 3,
            BaseSeconds = 130f,
            UnlockAfterDeliveries = 1
        },
    };
    public struct Route
    {
        public string Title;
        public int Stations;
        public int Required;
        public float BaseSeconds;
        public int UnlockAfterDeliveries;
    }

    public struct Pace
    {
        public string Title;
        public float Multiplier;
    }

    public static int ClampPace(int _0x96b279d4)
    {
        if (_0x96b279d4 < 0)
        {
            return 0;
        }

        return _0x96b279d4 >= Paces.Length ? Paces.Length - 1 : _0x96b279d4;
    }

    public static int ClampRoute(int _0x5563f824)
    {
        if (_0x5563f824 < 0)
        {
            return 0;
        }

        return _0x5563f824 >= Routes.Length ? Routes.Length - 1 : _0x5563f824;
    }

    public static readonly Pace[] Paces = new Pace[]
    {
        new Pace
        {
            Title = _0x0038c422._0x4115fa98(new byte[11] { 104, 111, 126, 122, 127, 98, 27, 10, 21, 11, 67 }, 59),
            Multiplier = 1.00f
        },
        new Pace
        {
            Title = _0x0038c422._0x4115fa98(new byte[11] { 67, 83, 72, 82, 74, 33, 48, 47, 51, 52, 121 }, 1),
            Multiplier = 1.25f
        },
        new Pace
        {
            Title = _0x0038c422._0x4115fa98(new byte[9] { 149, 146, 148, 143, 231, 246, 233, 242, 191 }, 199),
            Multiplier = 1.50f
        },
    };
    public static bool IsUnlocked(int _0x8282b002, int _0x4f8121f3)
    {
        return _0x4f8121f3 >= Routes[ClampRoute(_0x8282b002)].UnlockAfterDeliveries;
    }
}

internal static class _0x0038c422
{
    internal static string _0x4115fa98(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}