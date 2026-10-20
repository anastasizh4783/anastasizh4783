using System.Collections.Generic;
using UnityEngine;

// Seeded content for one attempt (rule C.11): how many slope segments each
// escalation band holds, which way the belt leans, which nest is the shallow one,
// how many plumes come down and at which angles, and where the stations sit.
// Nothing about the layout is hard-coded except the fallback.
public static class _0xb7f6d730
{
    private static readonly float[] _0x0253b292 = new float[]
    {
        0f,
        22f,
        42f,
        62f
    };
    private static readonly float[] _0x9395451a = new float[]
    {
        2.4f,
        4.7f,
        6.2f,
        8.8f
    };
    private static float Range(System.Random _0xb5980e43, float _0xb3307673, float _0x3b861211)
    {
        return _0xb3307673 + ((_0x3b861211 - _0xb3307673) * (float)_0xb5980e43.NextDouble());
    }

    private static _0x12a0c0f8 Draw(int _0x9bcd7926, int _0x1397599e, int _0x0dae5038)
    {
        int _0x866d6a56 = _0xeeffa5e9.ClampRoute(_0x9bcd7926);
        int _0x1c9993d6 = _0xeeffa5e9.ClampPace(_0x1397599e);
        int _0xd89b5f26 = ((_0x866d6a56 + 1) * 7919) ^ ((_0x0dae5038 + 1) * 104729) ^ ((_0x1c9993d6 + 1) * 61);
        System.Random _0x378688b2 = new System.Random(_0xd89b5f26);
        _0x12a0c0f8 _0x2efbed90 = new _0x12a0c0f8();
        _0x2efbed90.RouteIndex = _0x866d6a56;
        _0x2efbed90.SpeedIndex = _0x1c9993d6;
        _0x2efbed90.Seed = _0xd89b5f26;
        _0x2efbed90.RunSeconds = _0xeeffa5e9.RunSeconds(_0x866d6a56, _0x1c9993d6);
        _0x2efbed90.Stations = _0xeeffa5e9.Routes[_0x866d6a56].Stations;
        _0x2efbed90.Required = _0xeeffa5e9.Routes[_0x866d6a56].Required;
        float _0x8cf3aad7 = _0x378688b2.NextDouble() < 0.5 ? -1f : 1f;
        for (int _0x9e8612c3 = 0; _0x9e8612c3 < _0x0253b292.Length; _0x9e8612c3++)
        {
            float _0xda49c883 = _0x9e8612c3 == 0 ? 0f : _0x0253b292[_0x9e8612c3] + Range(_0x378688b2, -2f, 2f);
            float _0xb015ee3a = _0x9e8612c3 == _0x0253b292.Length - 1 ? Mathf.Max(_0x2efbed90.RunSeconds, _0x0253b292[_0x9e8612c3] + 20f) : _0x0253b292[_0x9e8612c3 + 1];
            float _0x92c39863 = Range(_0x378688b2, _0x9395451a[_0x9e8612c3], _0x12dd44be[_0x9e8612c3]);
            int _0x3b649db9 = 2 + _0x378688b2.Next(3);
            float _0xb67e4ad9 = Mathf.Max(2f, (_0xb015ee3a - _0xda49c883) / _0x3b649db9);
            for (int _0xd6133246 = 0; _0xd6133246 < _0x3b649db9; _0xd6133246++)
            {
                _0x12a0c0f8.SlopeStep step;
                step.StartSeconds = _0xda49c883 + (_0xd6133246 * _0xb67e4ad9);
                step.Degrees = _0x8cf3aad7 * (_0x92c39863 + Range(_0x378688b2, -0.25f, 0.25f));
                _0x2efbed90.Slopes.Add(step);
            }
        }

        _0x2efbed90.Slopes.Sort((_0xea0bcd36, _0xf1400008) => _0xea0bcd36.StartSeconds.CompareTo(_0xf1400008.StartSeconds));
        float[] _0xdede1eaa = new float[]
        {
            _0x12a0c0f8.NestDeep,
            _0x12a0c0f8.NestMid,
            _0x12a0c0f8.NestShallow
        };
        for (int _0x0a9a1c31 = _0xdede1eaa.Length - 1; _0x0a9a1c31 > 0; _0x0a9a1c31--)
        {
            int _0xe1934e7a = _0x378688b2.Next(_0x0a9a1c31 + 1);
            float _0xc4eb7e0d = _0xdede1eaa[_0x0a9a1c31];
            _0xdede1eaa[_0x0a9a1c31] = _0xdede1eaa[_0xe1934e7a];
            _0xdede1eaa[_0xe1934e7a] = _0xc4eb7e0d;
        }

        _0x2efbed90.NestStiffness = _0xdede1eaa;
        int _0x284cf08a = 4 + _0x378688b2.Next(4);
        float _0xaf4bd2fe = 8f + Range(_0x378688b2, 0f, 3f);
        for (int _0x7ee806db = 0; _0x7ee806db < _0x284cf08a && _0xaf4bd2fe < _0x2efbed90.RunSeconds - 4f; _0x7ee806db++)
        {
            _0x12a0c0f8.PlumeDrop _0x0db698ee;
            _0x0db698ee.Seconds = _0xaf4bd2fe;
            _0x0db698ee.CatchDegrees = _0xcfe30085[_0x378688b2.Next(_0xcfe30085.Length)];
            _0x0db698ee.LaneOffset = Range(_0x378688b2, -0.55f, 0.55f);
            _0x2efbed90.Plumes.Add(_0x0db698ee);
            _0xaf4bd2fe += 7f + Range(_0x378688b2, 0f, 5f);
        }

        for (int _0x451221c6 = 1; _0x451221c6 <= _0x2efbed90.Stations; _0x451221c6++)
        {
            float _0x393f2553 = ((_0x2efbed90.RunSeconds * _0x451221c6) / (_0x2efbed90.Stations + 1)) + Range(_0x378688b2, -1.5f, 1.5f);
            _0x2efbed90.StationSeconds.Add(Mathf.Clamp(_0x393f2553, 3f, _0x2efbed90.RunSeconds - 2f));
        }

        _0x2efbed90.StationSeconds.Sort();
        return _0x2efbed90;
    }

    private static readonly float[] _0x12dd44be = new float[]
    {
        3.0f,
        5.2f,
        6.8f,
        9.8f
    };
    private static readonly float[] _0xcfe30085 = new float[]
    {
        -12f,
        -6f,
        0f,
        6f,
        12f
    };
    // Guaranteed layout, used only when twenty draws all failed the two predicates.
    private static _0x12a0c0f8 Fallback(int _0xfae49186, int _0x326adbab)
    {
        int _0xb013a750 = _0xeeffa5e9.ClampRoute(_0xfae49186);
        int _0xb0d1e924 = _0xeeffa5e9.ClampPace(_0x326adbab);
        _0x12a0c0f8 _0x210953ec = new _0x12a0c0f8();
        _0x210953ec.RouteIndex = _0xb013a750;
        _0x210953ec.SpeedIndex = _0xb0d1e924;
        _0x210953ec.Seed = 0;
        _0x210953ec.RunSeconds = _0xeeffa5e9.RunSeconds(_0xb013a750, _0xb0d1e924);
        _0x210953ec.Stations = _0xeeffa5e9.Routes[_0xb013a750].Stations;
        _0x210953ec.Required = _0xeeffa5e9.Routes[_0xb013a750].Required;
        _0x210953ec.NestStiffness = new float[]
        {
            _0x12a0c0f8.NestDeep,
            _0x12a0c0f8.NestMid,
            _0x12a0c0f8.NestShallow
        };
        float[] _0x65895b21 = new float[]
        {
            0f,
            22f,
            42f,
            62f
        };
        float[] _0x81ebec22 = new float[]
        {
            2.7f,
            4.9f,
            6.5f,
            9.2f
        };
        for (int _0xf722c024 = 0; _0xf722c024 < _0x65895b21.Length; _0xf722c024++)
        {
            _0x12a0c0f8.SlopeStep step;
            step.StartSeconds = _0x65895b21[_0xf722c024];
            step.Degrees = _0x81ebec22[_0xf722c024];
            _0x210953ec.Slopes.Add(step);
        }

        float _0xcf6d8559 = 9f;
        for (int _0x86356010 = 0; _0x86356010 < 5 && _0xcf6d8559 < _0x210953ec.RunSeconds - 4f; _0x86356010++)
        {
            _0x12a0c0f8.PlumeDrop _0x8838a590;
            _0x8838a590.Seconds = _0xcf6d8559;
            _0x8838a590.CatchDegrees = _0xcfe30085[_0x86356010 % _0xcfe30085.Length];
            _0x8838a590.LaneOffset = 0f;
            _0x210953ec.Plumes.Add(_0x8838a590);
            _0xcf6d8559 += 9f;
        }

        for (int _0xed844466 = 1; _0xed844466 <= _0x210953ec.Stations; _0xed844466++)
        {
            _0x210953ec.StationSeconds.Add((_0x210953ec.RunSeconds * _0xed844466) / (_0x210953ec.Stations + 1));
        }

        return _0x210953ec;
    }

    public static _0x12a0c0f8 Build(int _0x47f5149a, int _0x0d07af7d, int _0x4aa37806)
    {
        _0x12a0c0f8 _0x5389ac7b = null;
        for (int _0x674045cd = 0; _0x674045cd < 20; _0x674045cd++)
        {
            _0x12a0c0f8 _0x63bfa8c6 = Draw(_0x47f5149a, _0x0d07af7d, _0x4aa37806 + (_0x674045cd * 977));
            if (_0x00b37bfd.PassiveSurvival(_0x63bfa8c6) >= _0x12a0c0f8.SurvivalFloorSeconds && _0x00b37bfd.IsDeliverable(_0x63bfa8c6))
            {
                _0x5389ac7b = _0x63bfa8c6;
                break;
            }
        }

        if (_0x5389ac7b == null)
        {
            _0x5389ac7b = Fallback(_0x47f5149a, _0x0d07af7d);
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x75277beb._0xa9f9d1e1(new byte[11] { 202, 227, 228, 255, 204, 177, 226, 244, 244, 245, 172 }, 145) + _0x5389ac7b.Seed + _0x75277beb._0xa9f9d1e1(new byte[7] { 21, 71, 90, 64, 65, 80, 8 }, 53) + _0x5389ac7b.RouteIndex + _0x75277beb._0xa9f9d1e1(new byte[6] { 198, 150, 135, 133, 131, 219 }, 230) + _0x5389ac7b.SpeedIndex + _0x75277beb._0xa9f9d1e1(new byte[9] { 181, 230, 240, 246, 250, 251, 241, 230, 168 }, 149) + _0x5389ac7b.RunSeconds.ToString(_0x75277beb._0xa9f9d1e1(new byte[2] { 128, 247 }, 198)) + _0x75277beb._0xa9f9d1e1(new byte[8] { 167, 247, 235, 242, 234, 226, 244, 186 }, 135) + _0x5389ac7b.Plumes.Count);
            }
#endif
        }

        return _0x5389ac7b;
    }
}

internal static class _0x75277beb
{
    internal static string _0xa9f9d1e1(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}