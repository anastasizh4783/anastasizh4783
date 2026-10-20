using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public static class _0xc1e39607
{
    public static class _0x537ecd0a
    {
        public static int _0x7ae1d3ca
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0xabcd581d._0x1d9e04e9(new byte[5] { 208, 252, 250, 253, 224 }, 147)))
                    PlayerPrefs.SetInt(_0xabcd581d._0x1d9e04e9(new byte[5] { 93, 113, 119, 112, 109 }, 30), 0);
                return PlayerPrefs.GetInt(_0xabcd581d._0x1d9e04e9(new byte[5] { 197, 233, 239, 232, 245 }, 134));
            }

            set
            {
                PlayerPrefs.SetInt(_0xabcd581d._0x1d9e04e9(new byte[5] { 105, 69, 67, 68, 89 }, 42), value);
                _0xa4f22d18.Instance._0xe01c8542();
            }
        }
    }

    public static class _0xfa7cc12d
    {
        public static readonly int SCENE_0 = 0;
        public static readonly int SCENE_1 = 1;
    }

    public static class _0x596b9e44
    {
        public static readonly int SPLASH = 0;
        public static readonly int DEFAULT = 1;
        public static readonly int EMPTY = 2;
        public static readonly int TUTORIAL0 = 13;
        public static readonly int TUTORIAL1 = 14;
        public static readonly int TUTORIAL2 = 15;
        public static readonly int TUTORIAL3 = 16;
        public static readonly int TUTORIAL4 = 17;
        public static readonly int TUTORIAL5 = 18;
        public static readonly int TUTORIAL6 = 19;
    }

    public class _0x61e57228
    {
        private static readonly _0x61e57228 _0xadc2fd96 = new();
        public static readonly _0x61e57228[] ALL_SCENES_SETTING_SINGLETONS =
        {
            _0xadc2fd96,
            _0xadc2fd96,
            _0xadc2fd96,
        };
        private int _0xdcdf9669 => 0;
        private int _0x77357da5 => 10;
        private string _0x8efb78b5 => _0xabcd581d._0x1d9e04e9(new byte[4] { 33, 9, 2, 25 }, 108);
        private string _0x0d88d6f2 => _0xabcd581d._0x1d9e04e9(new byte[8] { 125, 116, 103, 116, 125, 74, 1, 76 }, 49);

        private int _0xebbba8d8
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0xabcd581d._0x1d9e04e9(new byte[25] { 250, 204, 203, 203, 220, 215, 205, 254, 213, 214, 219, 216, 213, 250, 209, 216, 201, 205, 220, 203, 240, 215, 221, 220, 193 }, 185)))
                    PlayerPrefs.SetInt(_0xabcd581d._0x1d9e04e9(new byte[25] { 227, 213, 210, 210, 197, 206, 212, 231, 204, 207, 194, 193, 204, 227, 200, 193, 208, 212, 197, 210, 233, 206, 196, 197, 216 }, 160), 0);
                return PlayerPrefs.GetInt(_0xabcd581d._0x1d9e04e9(new byte[25] { 115, 69, 66, 66, 85, 94, 68, 119, 92, 95, 82, 81, 92, 115, 88, 81, 64, 68, 85, 66, 121, 94, 84, 85, 72 }, 48));
            }

            set => PlayerPrefs.SetInt(_0xabcd581d._0x1d9e04e9(new byte[25] { 157, 171, 172, 172, 187, 176, 170, 153, 178, 177, 188, 191, 178, 157, 182, 191, 174, 170, 187, 172, 151, 176, 186, 187, 166 }, 222), value);
        }

        public int _0x7962ccf3
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x8efb78b5}CurrentLevelIndex"))
                    PlayerPrefs.SetInt($"{this._0x8efb78b5}CurrentLevelIndex", 0);
                return PlayerPrefs.GetInt($"{this._0x8efb78b5}CurrentLevelIndex");
            }

            set => PlayerPrefs.SetInt($"{this._0x8efb78b5}CurrentLevelIndex", value);
        }

        public int _0xa13bdbe0
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x8efb78b5}BestScore"))
                    this._0xa13bdbe0 = 0;
                return PlayerPrefs.GetInt($"{this._0x8efb78b5}BestScore");
            }

            set => PlayerPrefs.SetInt($"{this._0x8efb78b5}BestScore", value);
        }

        public bool _0xb384774b
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x8efb78b5}IsGameTutorPassed"))
                    PlayerPrefs.SetInt($"{this._0x8efb78b5}IsGameTutorPassed", Convert.ToInt32(false));
                return PlayerPrefs.GetInt($"{this._0x8efb78b5}IsGameTutorPassed") == 1;
            }

            set => PlayerPrefs.SetInt($"{this._0x8efb78b5}IsGameTutorPassed", Convert.ToInt32(value));
        }
    }

    public static class _0x35d20a44
    {
        public static readonly int PAUSE = 6;
        public static readonly int WIN = 7;
        public static readonly int LOSE = 8;
    }
}

internal static class _0xabcd581d
{
    internal static string _0x1d9e04e9(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}