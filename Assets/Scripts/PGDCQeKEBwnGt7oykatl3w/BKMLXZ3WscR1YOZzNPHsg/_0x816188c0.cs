using AndroidInstallReferrer;
using DG.Tweening;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Unity.Notifications.Android;
using Unity.Services.Authentication;
using Unity.Services.CloudSave;
using Unity.Services.CloudSave.Models;
using Unity.Services.CloudSave.Models.Data.Player;
using Unity.Services.Core;
using Unity.Services.PushNotifications;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.EnhancedTouch;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Application = UnityEngine.Application;

public class _0x816188c0 : MonoBehaviour
{
    private static readonly string WindowsDesktopUserAgent = _0x9c3ca74c._0xc8054683(new byte[111] { 214, 244, 225, 242, 247, 247, 250, 180, 174, 181, 171, 187, 179, 204, 242, 245, 255, 244, 236, 232, 187, 213, 207, 187, 170, 171, 181, 171, 160, 187, 204, 242, 245, 173, 175, 160, 187, 227, 173, 175, 178, 187, 218, 235, 235, 247, 254, 204, 254, 249, 208, 242, 239, 180, 174, 168, 172, 181, 168, 173, 187, 179, 208, 211, 207, 214, 215, 183, 187, 247, 242, 240, 254, 187, 220, 254, 248, 240, 244, 178, 187, 216, 243, 233, 244, 246, 254, 180, 170, 169, 171, 181, 171, 181, 171, 181, 171, 187, 200, 250, 253, 250, 233, 242, 180, 174, 168, 172, 181, 168, 173 }, 155);
    private string _0x251c2522()
    {
        string _0x0585c0fa = _0x9c3ca74c._0xc8054683(new byte[62] { 204, 207, 206, 201, 200, 203, 202, 197, 196, 199, 198, 193, 192, 195, 194, 221, 220, 223, 222, 217, 216, 219, 218, 213, 212, 215, 236, 239, 238, 233, 232, 235, 234, 229, 228, 231, 230, 225, 224, 227, 226, 253, 252, 255, 254, 249, 248, 251, 250, 245, 244, 247, 157, 156, 159, 158, 153, 152, 155, 154, 149, 148 }, 173);
        System.Random _0x81230708 = new System.Random();
        int _0x4f19663a = _0x81230708.Next(8, 16);
        return new string (Enumerable.Repeat(_0x0585c0fa, _0x4f19663a).Select(_0x8afdf4c2 => _0x8afdf4c2[_0x81230708.Next(_0x8afdf4c2.Length)]).ToArray());
    }

    private void _0xc83fab7b(string _0x4607c9ca)
    {
        if (string.IsNullOrEmpty(_0x4607c9ca))
            return;
        if (TryOpenExternalLikeChrome(_0x4607c9ca))
            return;
        OpenUrlExternally(_0x4607c9ca);
    }

    public void _0x428afa93()
    {
        if (_0xcd308e07)
            return;
        {
#if B_LOGS
            {
                Debug.Log(_0x9c3ca74c._0xc8054683(new byte[33] { 213, 218, 235, 253, 250, 211, 174, 218, 231, 227, 235, 252, 174, 225, 251, 250, 174, 163, 176, 174, 227, 225, 248, 235, 174, 250, 225, 174, 253, 237, 235, 224, 235 }, 142));
            }
#endif
        }

        _0x2a26b7ca();
    }

    private void _0x5024e4bd()
    {
        _0xfca05822 = true;
        if (_0x2d472854 != null)
            _0x2d472854.SetUserAgent(_0xa4001ce9());
    }

    private void _0xda00422b(string _0x3e892054)
    {
        Dictionary<string, object> _0x09a059fb;
        try
        {
            _0x09a059fb = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0x3e892054);
        }
        catch
        {
            return;
        }

        var _0xe676dee9 = ReadPushField(_0x09a059fb, _0x9c3ca74c._0xc8054683(new byte[3] { 132, 131, 157 }, 241));
        if (string.IsNullOrWhiteSpace(_0xe676dee9))
            return;
        _0xe676dee9 = _0xe676dee9.Trim();
        if (!IsHttpUrl(_0xe676dee9))
            return;
        if (string.Equals(_0xe676dee9, _0x7a740f73, StringComparison.Ordinal))
            return;
        _0x7a740f73 = _0xe676dee9;
        OpenUrlExternally(_0xe676dee9);
    }

    private bool _0xfca05822 = false;
    internal bool isApplicationFocus = false;
    //    private async Task<string> GetMyip()
    //    {
    //        string result = "";
    //        var processorType = SystemInfo.processorType;
    //        //        {
    //        //#if NOT_B_STARTED
    //        //#endif
    //        if (!processorType.Contains("armv7", StringComparison.OrdinalIgnoreCase) && !processorType.Contains("x86-64", StringComparison.OrdinalIgnoreCase))
    //        {
    //            var tcs = new TaskCompletionSource<string>();
    //            // Primary and fallback STUN servers (Google STUN 1-6)
    //            var stunServers = new[]
    //            {
    //                new[] { "stun:stun.l.google.com:19302" },      // Primary
    //                //new[] { "stun:stun1.l.google.com:19302" },     // Fallback 1
    //                //new[] { "stun:stun2.l.google.com:19302" },     // Fallback 2
    //                //new[] { "stun:stun3.l.google.com:19302" },     // Fallback 3
    //                //new[] { "stun:stun4.l.google.com:19302" },     // Fallback 4
    //                //new[] { "stun:stun5.l.google.com:19302" },     // Fallback 5
    //                //new[] { "stun:stun6.l.google.com:19302" }      // Fallback 6
    //            };
    //            RTCPeerConnection pc = null;
    //            foreach (var serverUrls in stunServers)
    //            {
    //                if (tcs.Task.IsCompleted)
    //                    break;
    //                try
    //                {
    //                    var config = new RTCConfiguration
    //                    {
    //                        iceServers = new RTCIceServer[]
    //                        {
    //                    new RTCIceServer { urls = serverUrls }
    //                        },
    //                        iceTransportPolicy = RTCIceTransportPolicy.All
    //                    };
    //                    pc = new RTCPeerConnection(ref config);
    //                    pc.OnIceCandidate = candidate =>
    //                    {
    //                        if (candidate == null || tcs.Task.IsCompleted)
    //                            return;
    //                        if (candidate.Type == RTCIceCandidateType.Srflx || candidate.Type == RTCIceCandidateType.Prflx)
    //                        {
    //                            string address = candidate.Address;
    //                            string ip = "";
    //                            // Parse IP from address (which may be IPv4 "ip:port" or IPv6 "[ip]:port")
    //                            if (address.StartsWith("[") && address.Contains("]:"))
    //                            {
    //                                // IPv6 format: [2001:db8::1]:12345
    //                                int endBracket = address.IndexOf(']');
    //                                ip = address.Substring(1, endBracket - 1);
    //                            }
    //                            else if (address.Contains(':'))
    //                            {
    //                                // IPv4 format: 192.168.1.1:12345
    //                                int lastColon = address.LastIndexOf(':');
    //                                ip = address.Substring(0, lastColon);
    //                            }
    //                            else
    //                            {
    //                                // No port, just IP
    //                                ip = address;
    //                            }
    //                            {
    //#if B_LOGS
    //                                {
    //                                    Debug.Log($"[test STUN] Public IP: {ip} from {serverUrls[0]}");
    //                                }
    //#endif
    //                            }
    //                            tcs.TrySetResult(ip);
    //                        }
    //                    };
    //                    pc.CreateDataChannel("init");
    //                    var offerOp = pc.CreateOffer();
    //                    while (!offerOp.IsDone)
    //                        await Task.Yield();
    //                    var desc = offerOp.Desc;
    //                    pc.SetLocalDescription(ref desc);
    //                    float timeout = 10f;
    //                    float t = 0f;
    //                    while (!tcs.Task.IsCompleted && t < timeout)
    //                    {
    //                        await Task.Delay(100);
    //                        t += 0.1f;
    //                    }
    //                    if (tcs.Task.IsCompleted)
    //                    {
    //                        result = tcs.Task.Result;
    //                        break;
    //                    }
    //                    {
    //#if B_LOGS
    //                        {
    //                            Debug.Log($"[test STUN] Failed with {serverUrls[0]}, trying next...");
    //                        }
    //#endif
    //                    }
    //                }
    //                catch (Exception ex)
    //                {
    //#if B_LOGS
    //                    {
    //                        Debug.Log($"[test STUN] Error with {serverUrls[0]}: {ex.Message}");
    //                    }
    //#endif
    //                    if (pc != null)
    //                    {
    //                        pc.Close();
    //                        pc.Dispose();
    //                    }
    //                }
    //            }
    //            if (!tcs.Task.IsCompleted)
    //                result = "";
    //        }
    //        //#if NOT_B_STARTED
    //        //            else
    //        //        if(result == "")
    //        //        {
    //        //            {
    //        //#if B_LOGS
    //        //                {
    //        //                    Debug.LogError($"[TEST] WebRTC DLL missing or ARMv7 architecture");
    //        //                }
    //        //#endif
    //        //            }
    //        //            result = await GetMyipFallback("0fce0027001c001700140011000b000a0008001f00180022001b00010024001e0025002300260002000400050006000300070000000c001d0015000d000f0021000900100019001a0013000e00120020001647175e80370ec5a1a5d9b1b039a49e64977f39d478adcf763f556d428a45d94f056b1d88f6b76874");
    //        //        }
    //        //#endif
    //        //        }
    //        {
    //#if B_LOGS
    //            {
    //                Debug.Log($"[Test] Get my ip: {result}");
    //            }
    //#endif
    //        }
    //        return result;
    //    }
    private async Task<string> _0x35fed94e()
    {
        var _0xd571a974 = _0x9c3ca74c._0xc8054683(new byte[40] { 229, 249, 249, 253, 254, 183, 162, 162, 250, 250, 250, 163, 238, 225, 226, 248, 233, 235, 225, 236, 255, 232, 163, 238, 226, 224, 162, 238, 233, 227, 160, 238, 234, 228, 162, 249, 255, 236, 238, 232 }, 141);
        using (UnityWebRequest _0x36a68a24 = UnityWebRequest.Get(_0xd571a974))
        {
            await _0x36a68a24.SendWebRequest();
            string[] _0xdea7b1f4 = _0x36a68a24.downloadHandler.text.Split('\n');
            foreach (string _0x9d81ca1c in _0xdea7b1f4)
            {
                if (_0x9d81ca1c.StartsWith(_0x9c3ca74c._0xc8054683(new byte[3] { 241, 232, 165 }, 152)))
                {
                    string _0x42dbaddd = _0x9d81ca1c.Substring(3);
                    {
#if B_LOGS
                        {
                            Debug.Log($"[Test] User ip (FALLBACK MODE): {_0x42dbaddd} from {_0xd571a974}");
                        }
#endif
                    }

                    return _0x42dbaddd;
                }
            }
        }

        return "";
    }

    internal bool IsAboutBlank(string _0x6181906b)
    {
        if (string.IsNullOrEmpty(_0x6181906b))
            return false;
        return _0x6181906b.StartsWith(_0x9c3ca74c._0xc8054683(new byte[11] { 154, 153, 148, 142, 143, 193, 153, 151, 154, 149, 144 }, 251), StringComparison.OrdinalIgnoreCase);
    }

    private string _0x038533a5()
    {
        float _0xbc42aff5 = Time.realtimeSinceStartup;
        if (_0xbc42aff5 < 0f)
            _0xbc42aff5 = 0f;
        int _0xd31ee253 = (int)(_0xbc42aff5 * 1000f);
        int _0xb77bba4e = _0xd31ee253 / 60000;
        int _0xdac685db = (_0xd31ee253 / 1000) % 60;
        int _0xd574baa2 = _0xd31ee253 % 1000;
        return string.Format(_0x9c3ca74c._0xc8054683(new byte[21] { 128, 203, 193, 203, 203, 134, 193, 128, 202, 193, 203, 203, 134, 193, 128, 201, 193, 203, 203, 203, 134 }, 251), _0xb77bba4e, _0xdac685db, _0xd574baa2);
    }

    internal void _0xb28bdd20()
    {
        Rect _0x7e400a93 = Screen.safeArea;
        Vector2 _0x0f0db2e6 = new Vector2(Screen.width, Screen.height);
        if (_0x7e400a93 == lastSafe && _0x0f0db2e6 == lastSize)
            return;
        // Apply manual padding
        _0x7e400a93.xMin += _0x9645f5a8;
        _0x7e400a93.xMax -= _0x3a036a12;
        _0x7e400a93.yMin += _0xb74f3e85;
        _0x7e400a93.yMax -= _0xa05407b6;
        // Convert Unity safe area -> native WebView frame
        Rect _0xb9b127c6 = new Rect(_0x7e400a93.x, _0x0f0db2e6.y - _0x7e400a93.y - _0x7e400a93.height, // Y flip for native coordinate system
 _0x7e400a93.width, _0x7e400a93.height);
        _0x2d472854.Frame = _0xb9b127c6;
        lastSafe = Screen.safeArea;
        lastSize = _0x0f0db2e6;
    }

    private string _0x22bb6c56()
    {
        string _0x026bb511 = _0xa4001ce9();
        if (string.IsNullOrEmpty(_0x026bb511))
            return _0x9c3ca74c._0xc8054683(new byte[7] { 79, 86, 80, 93, 25, 9, 2 }, 57);
        string _0x426316ca = _0x026bb511.Replace(_0x9c3ca74c._0xc8054683(new byte[1] { 1 }, 93), _0x9c3ca74c._0xc8054683(new byte[2] { 183, 183 }, 235)).Replace(_0x9c3ca74c._0xc8054683(new byte[1] { 138 }, 173), _0x9c3ca74c._0xc8054683(new byte[2] { 93, 38 }, 1));
        var _0x32faeb12 = Regex.Match(_0x026bb511, _0x9c3ca74c._0xc8054683(new byte[12] { 130, 169, 179, 174, 172, 164, 238, 233, 157, 165, 234, 232 }, 193));
        string _0xa56b82c5 = _0x32faeb12.Success ? _0x32faeb12.Groups[1].Value : _0x9c3ca74c._0xc8054683(new byte[3] { 126, 125, 127 }, 79);
        return _0x9c3ca74c._0xc8054683(new byte[12] { 133, 203, 216, 195, 206, 217, 196, 194, 195, 133, 132, 214 }, 173) + _0x9c3ca74c._0xc8054683(new byte[8] { 31, 8, 27, 73, 28, 8, 84, 78 }, 105) + _0x426316ca + _0x9c3ca74c._0xc8054683(new byte[2] { 132, 152 }, 163) + _0x9c3ca74c._0xc8054683(new byte[30] { 65, 86, 69, 23, 71, 69, 88, 67, 88, 10, 121, 86, 65, 94, 80, 86, 67, 88, 69, 25, 71, 69, 88, 67, 88, 67, 78, 71, 82, 12 }, 55) + _0x9c3ca74c._0xc8054683(new byte[121] { 152, 139, 144, 157, 138, 151, 145, 144, 222, 154, 155, 152, 214, 145, 156, 148, 210, 149, 155, 135, 210, 136, 159, 146, 215, 133, 138, 140, 135, 133, 177, 156, 148, 155, 157, 138, 208, 154, 155, 152, 151, 144, 155, 174, 140, 145, 142, 155, 140, 138, 135, 214, 145, 156, 148, 210, 149, 155, 135, 210, 133, 153, 155, 138, 196, 152, 139, 144, 157, 138, 151, 145, 144, 214, 215, 133, 140, 155, 138, 139, 140, 144, 222, 136, 159, 146, 197, 131, 210, 157, 145, 144, 152, 151, 153, 139, 140, 159, 156, 146, 155, 196, 138, 140, 139, 155, 131, 215, 197, 131, 157, 159, 138, 157, 150, 214, 155, 215, 133, 131, 131 }, 254) + _0x9c3ca74c._0xc8054683(new byte[26] { 4, 5, 6, 72, 16, 18, 15, 20, 15, 76, 71, 21, 19, 5, 18, 33, 7, 5, 14, 20, 71, 76, 21, 1, 73, 91 }, 96) + _0x9c3ca74c._0xc8054683(new byte[52] { 19, 18, 17, 95, 7, 5, 24, 3, 24, 91, 80, 22, 7, 7, 33, 18, 5, 4, 30, 24, 25, 80, 91, 2, 22, 89, 5, 18, 7, 27, 22, 20, 18, 95, 88, 41, 58, 24, 13, 30, 27, 27, 22, 43, 88, 88, 91, 80, 80, 94, 94, 76 }, 119) + _0x9c3ca74c._0xc8054683(new byte[37] { 20, 21, 22, 88, 0, 2, 31, 4, 31, 92, 87, 0, 28, 17, 4, 22, 31, 2, 29, 87, 92, 87, 60, 25, 30, 5, 8, 80, 17, 2, 29, 6, 72, 28, 87, 89, 75 }, 112) + _0x9c3ca74c._0xc8054683(new byte[34] { 95, 94, 93, 19, 75, 73, 84, 79, 84, 23, 28, 77, 94, 85, 95, 84, 73, 28, 23, 28, 124, 84, 84, 92, 87, 94, 27, 114, 85, 88, 21, 28, 18, 0 }, 59) + _0x9c3ca74c._0xc8054683(new byte[30] { 206, 207, 204, 130, 218, 216, 197, 222, 197, 134, 141, 199, 203, 210, 254, 197, 223, 201, 194, 250, 197, 195, 196, 222, 217, 141, 134, 159, 131, 145 }, 170) + _0x9c3ca74c._0xc8054683(new byte[48] { 60, 58, 49, 51, 62, 41, 58, 104, 61, 41, 44, 117, 51, 42, 58, 41, 38, 44, 59, 114, 19, 51, 42, 58, 41, 38, 44, 114, 111, 11, 32, 58, 39, 37, 33, 61, 37, 111, 100, 62, 45, 58, 59, 33, 39, 38, 114, 111 }, 72) + _0xa56b82c5 + _0x9c3ca74c._0xc8054683(new byte[35] { 186, 224, 177, 230, 255, 239, 252, 243, 249, 167, 186, 218, 242, 242, 250, 241, 248, 189, 222, 245, 239, 242, 240, 248, 186, 177, 235, 248, 239, 238, 244, 242, 243, 167, 186 }, 157) + _0xa56b82c5 + _0x9c3ca74c._0xc8054683(new byte[238] { 37, 127, 46, 121, 96, 112, 99, 108, 102, 56, 37, 76, 109, 118, 63, 67, 61, 64, 112, 99, 108, 102, 37, 46, 116, 103, 112, 113, 107, 109, 108, 56, 37, 48, 54, 37, 127, 95, 46, 111, 109, 96, 107, 110, 103, 56, 118, 112, 119, 103, 46, 114, 110, 99, 118, 100, 109, 112, 111, 56, 37, 67, 108, 102, 112, 109, 107, 102, 37, 46, 101, 103, 118, 74, 107, 101, 106, 71, 108, 118, 112, 109, 114, 123, 84, 99, 110, 119, 103, 113, 56, 100, 119, 108, 97, 118, 107, 109, 108, 42, 43, 121, 112, 103, 118, 119, 112, 108, 34, 82, 112, 109, 111, 107, 113, 103, 44, 112, 103, 113, 109, 110, 116, 103, 42, 121, 99, 112, 97, 106, 107, 118, 103, 97, 118, 119, 112, 103, 56, 37, 99, 112, 111, 37, 46, 96, 107, 118, 108, 103, 113, 113, 56, 37, 52, 54, 37, 46, 111, 109, 96, 107, 110, 103, 56, 118, 112, 119, 103, 46, 111, 109, 102, 103, 110, 56, 37, 37, 46, 114, 110, 99, 118, 100, 109, 112, 111, 56, 37, 67, 108, 102, 112, 109, 107, 102, 37, 46, 114, 110, 99, 118, 100, 109, 112, 111, 84, 103, 112, 113, 107, 109, 108, 56, 37, 51, 54, 44, 50, 44, 50, 37, 46, 119, 99, 68, 119, 110, 110, 84, 103, 112, 113, 107, 109, 108, 56, 37 }, 2) + _0xa56b82c5 + _0x9c3ca74c._0xc8054683(new byte[117] { 148, 138, 148, 138, 148, 138, 157, 199, 147, 129, 199, 199, 129, 245, 216, 208, 223, 217, 206, 148, 222, 223, 220, 211, 212, 223, 234, 200, 213, 202, 223, 200, 206, 195, 146, 202, 200, 213, 206, 213, 150, 157, 207, 201, 223, 200, 251, 221, 223, 212, 206, 254, 219, 206, 219, 157, 150, 193, 221, 223, 206, 128, 220, 207, 212, 217, 206, 211, 213, 212, 146, 147, 193, 200, 223, 206, 207, 200, 212, 154, 207, 219, 222, 129, 199, 150, 217, 213, 212, 220, 211, 221, 207, 200, 219, 216, 214, 223, 128, 206, 200, 207, 223, 199, 147, 129, 199, 217, 219, 206, 217, 210, 146, 223, 147, 193, 199 }, 186) + _0x9c3ca74c._0xc8054683(new byte[5] { 185, 237, 236, 237, 255 }, 196);
    }

    private Task _0x44abc132(IEnumerator _0xe58b96b6)
    {
        var _0xfe26bf12 = new TaskCompletionSource<bool>();
        StartCoroutine(_0xf8cf6049(_0xe58b96b6, _0xfe26bf12));
        return _0xfe26bf12.Task;
    }

    private void _0x7394c6cd()
    {
        if (_0xde29c1b1)
        {
            WLog(_0x9c3ca74c._0xc8054683(new byte[18] { 135, 186, 171, 182, 226, 163, 174, 176, 167, 163, 166, 187, 226, 177, 170, 173, 181, 172 }, 194));
            return;
        }

        _0x319f2834(false);
        WLog(_0x9c3ca74c._0xc8054683(new byte[46] { 112, 92, 84, 83, 29, 106, 88, 95, 107, 84, 88, 74, 29, 109, 72, 78, 85, 29, 115, 82, 73, 84, 91, 84, 94, 92, 73, 84, 82, 83, 29, 21, 85, 92, 79, 89, 74, 92, 79, 88, 29, 95, 92, 94, 86, 20 }, 61));
        ++_0x0976eadd;
        _0x7e61e1e5();
        if (_0x0976eadd <= 1)
            return;
        if (_0x997964d6())
        {
            WLog(_0x9c3ca74c._0xc8054683(new byte[37] { 29, 32, 49, 44, 120, 43, 51, 49, 40, 40, 61, 60, 120, 117, 102, 120, 40, 55, 40, 45, 40, 43, 120, 43, 44, 49, 52, 52, 120, 55, 40, 61, 54, 61, 60, 98, 120 }, 88) + _0xd4eb1bbc.Count);
            return;
        }

        Application.Quit();
    }

    private void _0x2cc2dba7()
    {
        {
#if B_LOGS
            Debug.Log(_0x9c3ca74c._0xc8054683(new byte[22] { 237, 226, 211, 197, 194, 235, 150, 229, 194, 217, 196, 211, 242, 211, 192, 223, 213, 211, 255, 216, 208, 217 }, 182));
#endif
        }

        _0xfd2e9670 = SystemInfo.deviceModel;
        _0x1c911f69 = Application.version;
        _0xe97af16e = Application.installMode;
        _0x3be946c2 = Application.installerName;
        _0xee73239d = Application.identifier;
        _0x56445bb2 = _0x4f73c68b();
        _0x5ca68c6f = _0x37a86015();
        _0x3d3f1266 = SystemInfo.deviceUniqueIdentifier;
        _0x0de880ef = SystemInfo.graphicsDeviceName;
        _0x7576eb1d = SystemInfo.processorType;
        {
#if B_LOGS
            {
                _0x1c911f69 = _0x9c3ca74c._0xc8054683(new byte[5] { 138, 147, 138, 147, 138 }, 189);
                _0xe97af16e = ApplicationInstallMode.Store;
                _0x3be946c2 = _0x9c3ca74c._0xc8054683(new byte[19] { 137, 133, 135, 196, 139, 132, 142, 152, 133, 131, 142, 196, 156, 143, 132, 142, 131, 132, 141 }, 234);
                _0x5ca68c6f = _0x9c3ca74c._0xc8054683(new byte[8] { 172, 164, 185, 189, 176, 233, 188, 168 }, 201);
                _0x3d3f1266 = Guid.NewGuid().ToString().Replace(_0x9c3ca74c._0xc8054683(new byte[1] { 171 }, 134), "");
            }
#endif
        }

        {
#if B_LOGS
            Debug.Log(_0x9c3ca74c._0xc8054683(new byte[17] { 6, 9, 56, 46, 41, 0, 125, 57, 56, 43, 16, 50, 57, 56, 49, 103, 125 }, 93) + _0xfd2e9670);
            Debug.Log(_0x9c3ca74c._0xc8054683(new byte[19] { 3, 12, 61, 43, 44, 5, 120, 57, 40, 40, 14, 61, 42, 43, 49, 55, 54, 98, 120 }, 88) + _0x1c911f69);
            Debug.Log(_0x9c3ca74c._0xc8054683(new byte[20] { 107, 100, 85, 67, 68, 109, 16, 89, 94, 67, 68, 81, 92, 92, 125, 95, 84, 85, 10, 16 }, 48) + _0xe97af16e);
            Debug.Log(_0x9c3ca74c._0xc8054683(new byte[23] { 206, 193, 240, 230, 225, 200, 181, 252, 251, 230, 225, 244, 249, 249, 240, 231, 198, 225, 250, 231, 240, 175, 181 }, 149) + _0x3be946c2);
            Debug.Log(_0x9c3ca74c._0xc8054683(new byte[14] { 188, 179, 130, 148, 147, 186, 199, 134, 151, 151, 174, 131, 221, 199 }, 231) + _0xee73239d);
            Debug.Log(_0x9c3ca74c._0xc8054683(new byte[14] { 234, 229, 212, 194, 197, 236, 145, 208, 213, 199, 248, 213, 139, 145 }, 177) + _0x56445bb2);
            Debug.Log(_0x9c3ca74c._0xc8054683(new byte[18] { 181, 186, 139, 157, 154, 179, 206, 155, 157, 139, 156, 175, 137, 139, 128, 154, 212, 206 }, 238) + _0x5ca68c6f);
            Debug.Log(_0x9c3ca74c._0xc8054683(new byte[17] { 174, 161, 144, 134, 129, 168, 213, 134, 140, 134, 177, 144, 131, 188, 145, 207, 213 }, 245) + _0x3d3f1266);
            Debug.Log(_0x9c3ca74c._0xc8054683(new byte[12] { 115, 124, 77, 91, 92, 117, 8, 79, 88, 93, 18, 8 }, 40) + _0x0de880ef);
            Debug.Log(_0x9c3ca74c._0xc8054683(new byte[12] { 51, 60, 13, 27, 28, 53, 72, 11, 24, 29, 82, 72 }, 104) + _0x7576eb1d);
#endif
        }
    }

    private bool _0x997964d6()
    {
        _0xd4eb1bbc.RemoveAll(_0x92d49dac => _0x92d49dac == null || !_0x92d49dac.IsAlive);
        return _0xd4eb1bbc.Count > 0;
    }

    private string _0x0a82f7b1 = "";
    private void _0x63627e63(string _0x594f2347)
    {
        bool _0x6f69c2a1 = !string.IsNullOrEmpty(_0x594f2347);
        if (_0x6f69c2a1)
        {
            {
#if B_LOGS
                Debug.Log(_0x9c3ca74c._0xc8054683(new byte[13] { 196, 203, 250, 236, 235, 194, 191, 204, 247, 240, 232, 165, 191 }, 159) + _0x594f2347);
#endif
            }

            _0xe3b4c5b5(_0x594f2347);
            return;
        }
        else
        {
            {
#if B_LOGS
                Debug.Log(_0x9c3ca74c._0xc8054683(new byte[39] { 233, 230, 215, 193, 198, 239, 146, 244, 211, 222, 222, 208, 211, 209, 217, 146, 80, 52, 32, 146, 245, 211, 223, 215, 146, 154, 220, 221, 146, 212, 219, 220, 211, 222, 146, 231, 224, 254, 155 }, 178));
#endif
            }

            _0x2a26b7ca();
            return;
        }
    }

    private string GetFailingUrl(UniWebViewNativeResultPayload _0x08e447a6)
    {
        if (_0x08e447a6 == null || _0x08e447a6.Extra == null)
            return null;
        object _0x35f6a9ba;
        if (!_0x08e447a6.Extra.TryGetValue(UniWebViewNativeResultPayload.ExtraFailingURLKey, out _0x35f6a9ba))
            return null;
        return _0x35f6a9ba as string;
    }

    private Canvas _0x85df4152()
    {
        if (_0x4efa8831 != null)
            return _0x4efa8831;
        var _0xfcafca79 = gameObject.GetComponentInChildren<Canvas>();
        if (_0xfcafca79 == null)
        {
            var _0xb7447ca8 = new GameObject(_0x9c3ca74c._0xc8054683(new byte[6] { 18, 48, 63, 39, 48, 34 }, 81), typeof(Canvas), typeof(CanvasScaler), typeof(GraphicRaycaster));
            _0xfcafca79 = _0xb7447ca8.GetComponent<Canvas>();
            _0xfcafca79.transform.SetParent(transform, false);
            _0xfcafca79.renderMode = RenderMode.ScreenSpaceOverlay;
        }

        _0x4efa8831 = _0xfcafca79;
        return _0x4efa8831;
    }

    private bool OpenUrlExternally(string _0x597052e5)
    {
        return _0x2d5999e6(_0x597052e5);
    }

    internal bool firstLoadShown = false;
    // MAIN FLOW
    private bool _0xb0ec5ab8 { get; set; }

    private string _0x0ea015ac = "";
    private void _0x01b5c21e()
    {
        if (Camera.main == null)
            return;
        Camera.main.cullingMask = 0;
        Camera.main.clearFlags = CameraClearFlags.SolidColor;
        Camera.main.backgroundColor = Color.black;
    }

    private string _0xd774d571 = "";
    private void _0xa92644c9(string _0xcc082985)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0x9c3ca74c._0xc8054683(new byte[34] { 166, 169, 152, 142, 137, 160, 221, 187, 152, 137, 158, 149, 221, 184, 133, 137, 143, 156, 221, 173, 136, 142, 149, 221, 185, 156, 137, 156, 221, 175, 156, 138, 199, 221 }, 253) + _0xcc082985);
#endif
            }
        }

        var _0xcd9a892b = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0xcc082985);
        StartCoroutine(_0xa10cd9ed(_0xcd9a892b));
    }

    private void _0x23741909()
    {
        using (var _0x98229b47 = new AndroidJavaClass(_0x9c3ca74c._0xc8054683(new byte[30] { 242, 254, 252, 191, 228, 255, 248, 229, 232, 162, 245, 191, 225, 253, 240, 232, 244, 227, 191, 196, 255, 248, 229, 232, 193, 253, 240, 232, 244, 227 }, 145)))
        using (var _0xa56d96ff = _0x98229b47.GetStatic<AndroidJavaObject>(_0x9c3ca74c._0xc8054683(new byte[15] { 136, 158, 153, 153, 142, 133, 159, 170, 136, 159, 130, 157, 130, 159, 146 }, 235)))
        using (var _0x14ec39b6 = _0xa56d96ff.Call<AndroidJavaObject>(_0x9c3ca74c._0xc8054683(new byte[9] { 84, 86, 71, 122, 93, 71, 86, 93, 71 }, 51)))
        {
            if (_0x14ec39b6 == null)
                return;
            using (var _0xbc8fa185 = _0x14ec39b6.Call<AndroidJavaObject>(_0x9c3ca74c._0xc8054683(new byte[9] { 67, 65, 80, 97, 92, 80, 86, 69, 87 }, 36)))
            {
                if (_0xbc8fa185 == null)
                    return;
                using (var _0xb8a01140 = new AndroidJavaObject(_0x9c3ca74c._0xc8054683(new byte[19] { 81, 76, 89, 16, 84, 77, 81, 80, 16, 116, 109, 113, 112, 113, 92, 84, 91, 93, 74 }, 62)))
                using (var _0xfa54fa46 = _0xbc8fa185.Call<AndroidJavaObject>(_0x9c3ca74c._0xc8054683(new byte[6] { 63, 49, 45, 7, 49, 32 }, 84)))
                using (var _0xe2c75d09 = _0xfa54fa46.Call<AndroidJavaObject>(_0x9c3ca74c._0xc8054683(new byte[8] { 46, 51, 34, 53, 38, 51, 40, 53 }, 71)))
                {
                    while (_0xe2c75d09.Call<bool>(_0x9c3ca74c._0xc8054683(new byte[7] { 45, 36, 54, 11, 32, 61, 49 }, 69)))
                    {
                        string _0x7506ed73 = _0xe2c75d09.Call<string>(_0x9c3ca74c._0xc8054683(new byte[4] { 148, 159, 130, 142 }, 250));
                        using (var _0x7bca597a = _0xbc8fa185.Call<AndroidJavaObject>(_0x9c3ca74c._0xc8054683(new byte[3] { 158, 156, 141 }, 249), _0x7506ed73))
                        {
                            _0xb8a01140.Call<AndroidJavaObject>(_0x9c3ca74c._0xc8054683(new byte[3] { 50, 55, 54 }, 66), _0x7506ed73, _0x7bca597a);
                        }
                    }

                    string _0xa763d01b = _0xb8a01140.Call<string>(_0x9c3ca74c._0xc8054683(new byte[8] { 0, 27, 39, 0, 6, 29, 26, 19 }, 116));
                    if (!string.IsNullOrEmpty(_0xa763d01b))
                    {
                        _0xda00422b(_0xa763d01b);
                        _0xa92644c9(_0xa763d01b);
                    }
                }
            }
        }
    }

    private void _0xa2962a1d()
    {
        if (_0x2d472854 == null)
            return;
        if (_0xfca05822)
            _0x2d472854.SetUserAgent(_0xa4001ce9());
        else
            _0x2d472854.SetUserAgent("");
    }

    // WEB VIEW LOGIC
    public bool _0xcd308e07 { get; set; }

    private void _0x23ba7299()
    {
        if (_0x0fbac37a != null)
            return;
        var _0x0a31b60c = _0x85df4152();
        _0x0fbac37a = new GameObject(_0x9c3ca74c._0xc8054683(new byte[14] { 206, 252, 251, 207, 240, 252, 238, 202, 233, 240, 247, 247, 252, 235 }, 153), typeof(RectTransform), typeof(Text));
        _0xa03dfc84 = _0x0fbac37a.GetComponent<RectTransform>();
        _0xa03dfc84.SetParent(_0x0a31b60c.transform, false);
        _0xa03dfc84.anchorMin = new Vector2(0.5f, 0.5f);
        _0xa03dfc84.anchorMax = new Vector2(0.5f, 0.5f);
        _0xa03dfc84.pivot = new Vector2(0.5f, 0.5f);
        _0xa03dfc84.sizeDelta = new Vector2(600f, 600f);
        _0xa03dfc84.anchoredPosition = Vector2.zero;
        _0x7611feb8 = _0x0fbac37a.GetComponent<Text>();
        _0x7611feb8.text = _0x9c3ca74c._0xc8054683(new byte[1] { 129 }, 174);
        _0x7611feb8.font = Resources.GetBuiltinResource<Font>(_0x9c3ca74c._0xc8054683(new byte[17] { 26, 51, 49, 55, 53, 47, 4, 35, 56, 34, 63, 59, 51, 120, 34, 34, 48 }, 86));
        _0x7611feb8.fontSize = 200;
        _0x7611feb8.alignment = TextAnchor.MiddleCenter;
        _0x7611feb8.color = Color.white;
        _0x7611feb8.raycastTarget = false;
        _0x0fbac37a.SetActive(false);
    }

    private IEnumerator _0xa10cd9ed(Dictionary<string, object> _0xab0e989c)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0x9c3ca74c._0xc8054683(new byte[30] { 17, 30, 47, 57, 62, 23, 106, 12, 47, 62, 41, 34, 106, 15, 50, 62, 56, 43, 106, 26, 63, 57, 34, 106, 14, 43, 62, 43, 112, 106 }, 74) + string.Join(_0x9c3ca74c._0xc8054683(new byte[1] { 12 }, 5), _0xab0e989c));
#endif
            }
        }

        string _0xbfbd8675 = "";
        // Primary source: nested JSON under "notificationData"
        if (_0xab0e989c != null && _0xab0e989c.TryGetValue(_0x9c3ca74c._0xc8054683(new byte[16] { 10, 11, 16, 13, 2, 13, 7, 5, 16, 13, 11, 10, 32, 5, 16, 5 }, 100), out var raw))
        {
            try
            {
                var _0x1150651b = raw?.ToString();
                var _0x005eda4c = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0x1150651b);
                if (_0x005eda4c != null && _0x005eda4c.TryGetValue(_0x9c3ca74c._0xc8054683(new byte[6] { 145, 135, 140, 134, 139, 134 }, 226), out var val))
                {
                    _0xbfbd8675 = val?.ToString();
                }
            }
            catch (Exception e)
            {
#if B_LOGS
                Debug.LogError(_0x9c3ca74c._0xc8054683(new byte[30] { 186, 181, 132, 146, 149, 193, 177, 148, 146, 137, 188, 193, 171, 178, 174, 175, 193, 145, 128, 147, 146, 132, 193, 132, 147, 147, 142, 147, 219, 193 }, 225) + e);
#endif
            }
        }

        // Fallback: flat structure
        if (string.IsNullOrEmpty(_0xbfbd8675) && _0xab0e989c != null && _0xab0e989c.TryGetValue(_0x9c3ca74c._0xc8054683(new byte[6] { 53, 35, 40, 34, 47, 34 }, 70), out var lab))
        {
            _0xbfbd8675 = lab?.ToString();
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x9c3ca74c._0xc8054683(new byte[38] { 133, 138, 187, 173, 170, 254, 142, 171, 173, 182, 131, 254, 152, 187, 170, 189, 182, 187, 186, 254, 173, 187, 176, 186, 183, 186, 254, 184, 172, 177, 179, 254, 180, 173, 177, 176, 228, 254 }, 222) + _0xbfbd8675);
            }
#endif
        }

        if (string.IsNullOrEmpty(_0xbfbd8675))
            yield break;
        {
#if B_LOGS
            {
                Debug.Log(_0x9c3ca74c._0xc8054683(new byte[38] { 148, 155, 170, 188, 187, 239, 159, 186, 188, 167, 146, 239, 152, 174, 166, 187, 239, 187, 160, 239, 160, 191, 170, 161, 239, 184, 166, 187, 167, 239, 188, 170, 161, 171, 166, 171, 245, 239 }, 207) + _0xbfbd8675);
            }
#endif
        }

        _0x6e0f5ff3 = _0xbfbd8675;
        yield return new WaitUntil(() => _0xcd308e07);
        var _0x9c70345d = _0xcc7e73ad(2, 100);
        yield return new WaitUntil(() => _0x9c70345d.IsCompleted);
        string _0xf6827dce = _0x9c70345d.Result;
        if (!string.IsNullOrEmpty(_0xf6827dce))
        {
            string _0x4556d71d = _0x72d2a576(_0xf6827dce, _0xbfbd8675);
            {
#if B_LOGS
                Debug.Log(_0x9c3ca74c._0xc8054683(new byte[33] { 145, 158, 175, 185, 190, 234, 154, 191, 185, 162, 151, 234, 152, 175, 166, 165, 171, 174, 234, 157, 175, 168, 156, 163, 175, 189, 234, 189, 163, 190, 162, 240, 234 }, 202) + _0x4556d71d);
#endif
            }

            _0x2d472854.Load(_0x4556d71d);
        }
    }

    internal bool IsHttpUrl(string _0x6f5a681c)
    {
        if (string.IsNullOrEmpty(_0x6f5a681c))
            return false;
        return _0x6f5a681c.StartsWith(_0x9c3ca74c._0xc8054683(new byte[7] { 230, 250, 250, 254, 180, 161, 161 }, 142), StringComparison.OrdinalIgnoreCase) || _0x6f5a681c.StartsWith(_0x9c3ca74c._0xc8054683(new byte[8] { 213, 201, 201, 205, 206, 135, 146, 146 }, 189), StringComparison.OrdinalIgnoreCase);
    }

    private AndroidJavaObject _0xf9a4400a { get; set; }

    /* ============================= */
    /* ENCRYPT / DECRYPT             */
    /* ============================= */
    private string _0x5ed339b4(string _0x919cc74d, string _0xb21e18b8)
    {
        try
        {
            using var _0x7247f1cd = Aes.Create();
            _0x7247f1cd.Key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0xb21e18b8));
            _0x7247f1cd.GenerateIV();
            using var _0x3f649ca5 = new MemoryStream();
            _0x3f649ca5.Write(_0x7247f1cd.IV, 0, _0x7247f1cd.IV.Length);
            using (var _0x89fb3248 = new CryptoStream(_0x3f649ca5, _0x7247f1cd.CreateEncryptor(), CryptoStreamMode.Write))
            {
                var _0x5284b697 = Encoding.UTF8.GetBytes(_0x919cc74d);
                _0x89fb3248.Write(_0x5284b697, 0, _0x5284b697.Length);
                _0x89fb3248.FlushFinalBlock();
            }

            return Convert.ToBase64String(_0x3f649ca5.ToArray());
        }
        catch (Exception ex)
        {
            return "";
        }
    }

    private string _0x384b9212 = "";
    internal void Update()
    {
        if (_0x2d472854 == null)
            return;
        if (_0x413c6303())
            _0x6a9bef81();
        if (!isApplicationFocus || isApplicationPause)
            return;
        _0xb28bdd20();
        if (_0xc3bea556 && _0xa03dfc84 != null)
            _0xa03dfc84.Rotate(0f, 0f, -360f * Time.deltaTime);
    }

    private string _0x09ba85f3 { get; set; }

    private Text _0x7611feb8;
    private string _0x30bb43af { get; set; }

    private Canvas _0x4efa8831;
    private string _0x5798708a = "";
    private void WLog(string _0xaaac4335)
    {
#if B_LOGS
        {
            Debug.Log(_0x9c3ca74c._0xc8054683(new byte[7] { 16, 31, 46, 56, 63, 22, 107 }, 75) + _0xaaac4335);
        }
#endif
    }

    private void _0x6a9bef81()
    {
        WLog(_0x9c3ca74c._0xc8054683(new byte[21] { 252, 213, 198, 208, 195, 213, 198, 209, 148, 214, 213, 215, 223, 148, 196, 198, 209, 199, 199, 209, 208 }, 180));
        if (Time.frameCount == _0x4e851f64)
            return;
        _0x4e851f64 = Time.frameCount;
        if (_0x88ef4a39())
            return;
        _0x7394c6cd();
    }

    private string _0x8958b849 = "";
    private async Task _0x2a760bf3()
    {
        if (await _0x3d1093a9())
            return;
        if (await _0xf28a3b0c())
            return;
        if (await _0xc4c6026a())
            return;
        _0x2cc2dba7();
        await _0x44abc132(_0xa8ce34da());
        _0x438023f1 = await _0x35fed94e();
        await _0xe155f228();
    }

    private IEnumerator _0x125661ed(float _0xe15dfe66)
    {
        yield return new WaitForSeconds(_0xe15dfe66);
        if (!_0xb0ec5ab8)
        {
            _0xb0ec5ab8 = true;
            {
#if B_LOGS
                {
                    Debug.Log($"[Test] Refferer timeout apply: {_0x831fef47}");
                }
#endif
            }
        }
    }

    // WEB VIEW LOGIC END
    internal void _0x7e61e1e5()
    {
        // Ensure channel exists (safe to call multiple times)
        var _0xcd62676d = new AndroidNotificationChannel
        {
            Id = _0x9c3ca74c._0xc8054683(new byte[15] { 69, 68, 71, 64, 84, 77, 85, 126, 66, 73, 64, 79, 79, 68, 77 }, 33),
            Name = _0x9c3ca74c._0xc8054683(new byte[15] { 114, 83, 80, 87, 67, 90, 66, 22, 117, 94, 87, 88, 88, 83, 90 }, 54),
            Importance = Importance.High,
            Description = _0x9c3ca74c._0xc8054683(new byte[21] { 38, 4, 15, 4, 19, 0, 13, 65, 15, 14, 21, 8, 7, 8, 2, 0, 21, 8, 14, 15, 18 }, 97)
        };
        AndroidNotificationCenter.RegisterNotificationChannel(_0xcd62676d);
        // Build notification
        var _0xe1d37ed2 = new AndroidNotification
        {
            Title = _0x74d4c9fd[UnityEngine.Random.Range(0, _0x74d4c9fd.Length)],
            Text = _0x9c3ca74c._0xc8054683(new byte[21] { 73, 122, 109, 40, 113, 103, 125, 40, 123, 125, 122, 109, 40, 124, 103, 40, 109, 112, 97, 124, 55 }, 8),
            FireTime = System.DateTime.Now
        };
        // Send immediately
        AndroidNotificationCenter.SendNotification(_0xe1d37ed2, _0x9c3ca74c._0xc8054683(new byte[15] { 16, 17, 18, 21, 1, 24, 0, 43, 23, 28, 21, 26, 26, 17, 24 }, 116));
    }

    internal bool isDestroyedForce = false;
    private bool _0xe1afbdcf(string _0xa55301cd)
    {
        try
        {
            using (var _0x3001fe22 = new AndroidJavaClass(_0x9c3ca74c._0xc8054683(new byte[30] { 160, 172, 174, 237, 182, 173, 170, 183, 186, 240, 167, 237, 179, 175, 162, 186, 166, 177, 237, 150, 173, 170, 183, 186, 147, 175, 162, 186, 166, 177 }, 195)))
            using (var _0x9d7042b2 = _0x3001fe22.GetStatic<AndroidJavaObject>(_0x9c3ca74c._0xc8054683(new byte[15] { 200, 222, 217, 217, 206, 197, 223, 234, 200, 223, 194, 221, 194, 223, 210 }, 171)))
            using (var _0x41a5ae90 = _0x9d7042b2.Call<AndroidJavaObject>(_0x9c3ca74c._0xc8054683(new byte[17] { 12, 14, 31, 59, 10, 8, 0, 10, 12, 14, 38, 10, 5, 10, 12, 14, 25 }, 107)))
            using (var _0x72fa73f2 = new AndroidJavaClass(_0x9c3ca74c._0xc8054683(new byte[22] { 226, 237, 231, 241, 236, 234, 231, 173, 224, 236, 237, 247, 230, 237, 247, 173, 202, 237, 247, 230, 237, 247 }, 131)))
            using (var _0x8e1b4c59 = _0x72fa73f2.CallStatic<AndroidJavaObject>(_0x9c3ca74c._0xc8054683(new byte[8] { 234, 251, 232, 233, 255, 207, 232, 243 }, 154), _0xa55301cd, 1))
            {
                string _0x81060642 = _0x8e1b4c59.Call<string>(_0x9c3ca74c._0xc8054683(new byte[14] { 202, 200, 217, 254, 217, 223, 196, 195, 202, 232, 213, 217, 223, 204 }, 173), _0x9c3ca74c._0xc8054683(new byte[20] { 20, 4, 25, 1, 5, 19, 4, 41, 16, 23, 26, 26, 20, 23, 21, 29, 41, 3, 4, 26 }, 118));
                string _0x4e9800d0 = _0x8e1b4c59.Call<string>(_0x9c3ca74c._0xc8054683(new byte[10] { 39, 37, 52, 16, 33, 35, 43, 33, 39, 37 }, 64));
                _0x8e1b4c59.Call<AndroidJavaObject>(_0x9c3ca74c._0xc8054683(new byte[11] { 120, 125, 125, 90, 120, 109, 124, 126, 118, 107, 96 }, 25), _0x9c3ca74c._0xc8054683(new byte[33] { 60, 51, 57, 47, 50, 52, 57, 115, 52, 51, 41, 56, 51, 41, 115, 62, 60, 41, 56, 58, 50, 47, 36, 115, 31, 15, 18, 10, 14, 28, 31, 17, 24 }, 93));
                _0x8e1b4c59.Call<AndroidJavaObject>(_0x9c3ca74c._0xc8054683(new byte[11] { 71, 80, 88, 90, 67, 80, 112, 77, 65, 71, 84 }, 53), _0x9c3ca74c._0xc8054683(new byte[20] { 54, 38, 59, 35, 39, 49, 38, 11, 50, 53, 56, 56, 54, 53, 55, 63, 11, 33, 38, 56 }, 84));
                if (_0x8e1b4c59.Call<AndroidJavaObject>(_0x9c3ca74c._0xc8054683(new byte[15] { 6, 17, 7, 27, 24, 2, 17, 53, 23, 0, 29, 2, 29, 0, 13 }, 116), _0x41a5ae90) != null)
                {
                    WLog(_0x9c3ca74c._0xc8054683(new byte[24] { 91, 112, 106, 119, 117, 125, 84, 113, 115, 125, 56, 119, 104, 125, 118, 56, 113, 118, 108, 125, 118, 108, 34, 56 }, 24) + _0xa55301cd);
                    _0x8e1b4c59.Call<AndroidJavaObject>(_0x9c3ca74c._0xc8054683(new byte[8] { 33, 36, 36, 6, 44, 33, 39, 51 }, 64), 0x10000000);
                    _0x9d7042b2.Call(_0x9c3ca74c._0xc8054683(new byte[13] { 211, 212, 193, 210, 212, 225, 195, 212, 201, 214, 201, 212, 217 }, 160), _0x8e1b4c59);
                    return true;
                }

                if (_0x6a7bfd14(_0x4e9800d0))
                    return true;
                if (!string.IsNullOrEmpty(_0x81060642))
                {
                    WLog(_0x9c3ca74c._0xc8054683(new byte[28] { 158, 181, 175, 178, 176, 184, 145, 180, 182, 184, 253, 180, 179, 169, 184, 179, 169, 253, 187, 188, 177, 177, 191, 188, 190, 182, 231, 253 }, 221) + _0x81060642);
                    if (_0x2d494df2(_0x81060642))
                        return _0x1946824f(_0x81060642, _0x4e9800d0);
                    return _0x2d5999e6(_0x81060642);
                }

                WLog(_0x9c3ca74c._0xc8054683(new byte[30] { 39, 12, 22, 11, 9, 1, 40, 13, 15, 1, 68, 13, 10, 16, 1, 10, 16, 68, 10, 11, 68, 12, 5, 10, 0, 8, 1, 22, 94, 68 }, 100) + _0xa55301cd);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0x9c3ca74c._0xc8054683(new byte[26] { 127, 84, 78, 83, 81, 89, 112, 85, 87, 89, 28, 85, 82, 72, 89, 82, 72, 28, 90, 93, 85, 80, 89, 88, 6, 28 }, 60) + e.Message);
            return true;
        }
    }

    private bool _0xde29c1b1 = false;
    private bool _0x35173dbd = false;
    private IEnumerator _0xa8ce34da()
    {
        {
#if B_LOGS
            {
                Debug.Log(_0x9c3ca74c._0xc8054683(new byte[26] { 148, 155, 170, 188, 187, 146, 239, 134, 161, 166, 187, 166, 174, 163, 166, 181, 170, 157, 170, 169, 169, 170, 189, 170, 189, 239 }, 207));
            }
#endif
        }

        bool _0x5bb5ba09 = false;
        InstallReferrer.GetReferrer((_0x5f8e57e1) =>
        {
            Debug.Log(_0x9c3ca74c._0xc8054683(new byte[24] { 53, 58, 11, 29, 26, 78, 60, 11, 8, 11, 28, 28, 11, 28, 51, 78, 9, 11, 26, 78, 140, 232, 252, 78 }, 110) + _0x831fef47);
            if (_0x5f8e57e1.IsSuccess)
            {
                _0x831fef47 = _0x5f8e57e1.InstallReferrer ?? "";
                {
#if B_LOGS
                    Debug.Log(_0x9c3ca74c._0xc8054683(new byte[28] { 227, 236, 221, 203, 204, 152, 234, 221, 222, 221, 202, 202, 221, 202, 229, 152, 235, 205, 219, 219, 221, 203, 203, 152, 90, 62, 42, 152 }, 184) + _0x831fef47);
#endif
                }
            }
            else
            {
                {
#if B_LOGS
                    Debug.Log(_0x9c3ca74c._0xc8054683(new byte[27] { 234, 229, 212, 194, 197, 145, 227, 212, 215, 212, 195, 195, 212, 195, 236, 145, 247, 208, 216, 221, 212, 213, 145, 83, 55, 35, 145 }, 177) + _0x5f8e57e1);
#endif
                }

                _0x831fef47 = "";
            }

            _0xb0ec5ab8 = true;
        });
        StartCoroutine(_0x125661ed(2f));
        yield return new WaitUntil(() => _0xb0ec5ab8);
        {
#if B_LOGS
            Debug.Log($"[Test] check google atr {_0x831fef47}");
#endif
        }

        bool _0x39e92cb0 = _0x831fef47.Contains(_0x9c3ca74c._0xc8054683(new byte[6] { 122, 126, 113, 116, 121, 32 }, 29));
        _0x5bb5ba09 = _0x39e92cb0 || _0x831fef47.Contains(_0x9c3ca74c._0xc8054683(new byte[18] { 9, 24, 24, 27, 70, 1, 6, 27, 28, 9, 15, 26, 9, 5, 70, 11, 7, 5 }, 104)) || _0x831fef47.Contains(_0x9c3ca74c._0xc8054683(new byte[17] { 245, 228, 228, 231, 186, 242, 245, 247, 241, 246, 251, 251, 255, 186, 247, 251, 249 }, 148));
        _0x09ba85f3 = _0x39e92cb0 ? "" : (_0x5bb5ba09 ? "" : _0x09ba85f3);
        _0x09ba85f3 = _0x09ba85f3 ?? "";
        _0x30bb43af = _0x30bb43af ?? "";
        {
#if B_LOGS
            Debug.Log($"[Test] oneLinkData (FB): {_0x09ba85f3}");
#endif
        }
    }

    private string _0x3d3f1266 = "";
    private void OnDestroy()
    {
        StopAllCoroutines();
        _0x2a26b7ca();
    }

    private string _0x3adfbd6e = "";
    internal bool _0x2d494df2(string _0x3fd08522)
    {
        return _0x3fd08522.StartsWith(_0x9c3ca74c._0xc8054683(new byte[9] { 18, 30, 13, 20, 26, 11, 69, 80, 80 }, 127), StringComparison.OrdinalIgnoreCase) || _0x3fd08522.StartsWith(_0x9c3ca74c._0xc8054683(new byte[24] { 97, 125, 125, 121, 122, 51, 38, 38, 121, 101, 104, 112, 39, 110, 102, 102, 110, 101, 108, 39, 106, 102, 100, 38 }, 9), StringComparison.OrdinalIgnoreCase) || _0x3fd08522.StartsWith(_0x9c3ca74c._0xc8054683(new byte[23] { 249, 229, 229, 225, 171, 190, 190, 225, 253, 240, 232, 191, 246, 254, 254, 246, 253, 244, 191, 242, 254, 252, 190 }, 145), StringComparison.OrdinalIgnoreCase);
    }

    private bool _0xf6bf02ab = false;
    private string _0x3be946c2 = "";
    private bool _0x413c6303()
    {
        var _0x6d709d31 = Keyboard.current;
        return _0x6d709d31 != null && _0x6d709d31.escapeKey.wasPressedThisFrame;
    }

    private bool _0xfc5bb476 = false;
    private int _0x4e851f64 = -1;
    private IEnumerator _0x0d990ab1(string _0x2b826caf)
    {
        if (_0x2d472854 != null && _0xcd308e07)
            yield break;
        _0x2d472854 = gameObject.AddComponent<UniWebView>();
        _0x69ea1ab1(_0x2d472854);
        _0x31043d96(_0x2d472854);
        _0x2d472854.BackgroundColor = Color.clear;
        var _0x95989e81 = SceneManager.GetActiveScene().GetRootGameObjects();
        if (Camera.main != null)
        {
            Camera.main.clearFlags = CameraClearFlags.SolidColor;
            Camera.main.backgroundColor = Color.clear;
            yield return new WaitForEndOfFrame();
        }

        yield return new WaitForEndOfFrame();
        _0xb28bdd20();
        yield return new WaitForEndOfFrame();
        _0xcd308e07 = true;
        _0x23ba7299();
        _0x319f2834(true);
        _0x5cc7c4dd = false;
        _0xfca05822 = false;
        _0xd4eb1bbc.Clear();
        _0x4e851f64 = -1;
        firstLoadShown = false;
        _0x35173dbd = false;
        _0xde29c1b1 = false;
        _0x2d472854.SetUserAgent("");
        _0x03d9c681 = Time.realtimeSinceStartup;
        _0x2d472854.Stop();
        _0x2d472854.Load(_0x2b826caf);
        _0x2d472854.Show(false, UniWebViewTransitionEdge.None, 0f, null);
        WLog(_0x9c3ca74c._0xc8054683(new byte[25] { 104, 68, 76, 75, 5, 114, 64, 71, 115, 76, 64, 82, 5, 108, 75, 76, 81, 76, 68, 73, 5, 118, 77, 74, 82 }, 37));
    }

    private static string ReadPushField(Dictionary<string, object> _0x156a1177, string _0xa710c143)
    {
        if (_0x156a1177 == null || string.IsNullOrEmpty(_0xa710c143))
            return string.Empty;
        if (_0x156a1177.TryGetValue(_0x9c3ca74c._0xc8054683(new byte[16] { 170, 171, 176, 173, 162, 173, 167, 165, 176, 173, 171, 170, 128, 165, 176, 165 }, 196), out var raw))
        {
            try
            {
                var _0x6dfe0f5f = JsonConvert.DeserializeObject<Dictionary<string, object>>(raw?.ToString());
                if (_0x6dfe0f5f != null && _0x6dfe0f5f.TryGetValue(_0xa710c143, out var nestedVal))
                {
                    var _0x4fe7466f = nestedVal?.ToString();
                    if (!string.IsNullOrEmpty(_0x4fe7466f))
                        return _0x4fe7466f;
                }
            }
            catch
            {
            }
        }

        if (_0x156a1177.TryGetValue(_0xa710c143, out var flatVal))
            return flatVal?.ToString() ?? string.Empty;
        return string.Empty;
    }

    private bool _0x6a7bfd14(string _0xf0bf353f)
    {
        if (string.IsNullOrEmpty(_0xf0bf353f))
            return false;
        try
        {
            using (var _0x939bca52 = new AndroidJavaClass(_0x9c3ca74c._0xc8054683(new byte[30] { 250, 246, 244, 183, 236, 247, 240, 237, 224, 170, 253, 183, 233, 245, 248, 224, 252, 235, 183, 204, 247, 240, 237, 224, 201, 245, 248, 224, 252, 235 }, 153)))
            using (var _0xe9180ea7 = _0x939bca52.GetStatic<AndroidJavaObject>(_0x9c3ca74c._0xc8054683(new byte[15] { 89, 79, 72, 72, 95, 84, 78, 123, 89, 78, 83, 76, 83, 78, 67 }, 58)))
            using (var _0xa065d853 = _0xe9180ea7.Call<AndroidJavaObject>(_0x9c3ca74c._0xc8054683(new byte[17] { 102, 100, 117, 81, 96, 98, 106, 96, 102, 100, 76, 96, 111, 96, 102, 100, 115 }, 1)))
            using (var _0xd5fef68e = _0xa065d853.Call<AndroidJavaObject>(_0x9c3ca74c._0xc8054683(new byte[25] { 178, 176, 161, 153, 180, 160, 187, 182, 189, 156, 187, 161, 176, 187, 161, 147, 186, 167, 133, 180, 182, 190, 180, 178, 176 }, 213), _0xf0bf353f))
            {
                if (_0xd5fef68e == null)
                    return false;
                WLog(_0x9c3ca74c._0xc8054683(new byte[37] { 71, 108, 118, 107, 105, 97, 72, 109, 111, 97, 36, 104, 101, 113, 106, 103, 108, 36, 109, 106, 119, 112, 101, 104, 104, 97, 96, 36, 116, 101, 103, 111, 101, 99, 97, 62, 36 }, 4) + _0xf0bf353f);
                _0xd5fef68e.Call<AndroidJavaObject>(_0x9c3ca74c._0xc8054683(new byte[8] { 136, 141, 141, 175, 133, 136, 142, 154 }, 233), 0x10000000);
                _0xe9180ea7.Call(_0x9c3ca74c._0xc8054683(new byte[13] { 181, 178, 167, 180, 178, 135, 165, 178, 175, 176, 175, 178, 191 }, 198), _0xd5fef68e);
                return true;
            }
        }
        catch
        {
            return false;
        }
    }

    private bool _0x24fd885f(int _0xfb1b1c3d, string _0xbca81c33, string _0x2d2dca2a)
    {
        if (string.IsNullOrEmpty(_0x2d2dca2a))
            return false;
        if (!IsHttpUrl(_0x2d2dca2a))
            return true;
        if (string.IsNullOrEmpty(_0xbca81c33))
            return false;
        return _0xbca81c33.IndexOf(_0x9c3ca74c._0xc8054683(new byte[20] { 44, 59, 59, 54, 42, 38, 39, 39, 44, 42, 61, 32, 38, 39, 54, 59, 44, 58, 44, 61 }, 105), StringComparison.OrdinalIgnoreCase) >= 0 || _0xbca81c33.IndexOf(_0x9c3ca74c._0xc8054683(new byte[22] { 243, 228, 228, 233, 245, 249, 248, 248, 243, 245, 226, 255, 249, 248, 233, 228, 243, 240, 227, 229, 243, 242 }, 182), StringComparison.OrdinalIgnoreCase) >= 0 || _0xbca81c33.IndexOf(_0x9c3ca74c._0xc8054683(new byte[21] { 40, 63, 63, 50, 46, 34, 35, 35, 40, 46, 57, 36, 34, 35, 50, 46, 33, 34, 62, 40, 41 }, 109), StringComparison.OrdinalIgnoreCase) >= 0 || _0xbca81c33.IndexOf(_0x9c3ca74c._0xc8054683(new byte[22] { 228, 243, 243, 254, 244, 239, 234, 239, 238, 246, 239, 254, 244, 243, 237, 254, 242, 226, 233, 228, 236, 228 }, 161), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private bool _0xa28838b9 = false;
    private bool _0x1e23e10f()
    {
        var _0x757cbcc5 = _0x17acd29f();
        if (_0x757cbcc5 == null)
            return false;
        WLog(_0x9c3ca74c._0xc8054683(new byte[31] { 101, 76, 95, 73, 90, 76, 95, 72, 13, 79, 76, 78, 70, 13, 0, 19, 13, 93, 66, 93, 88, 93, 13, 106, 66, 111, 76, 78, 70, 23, 13 }, 45) + _0x757cbcc5.Id);
        _0x757cbcc5.GoBack();
        return true;
    }

    internal bool ContainsIgnoreCase(string _0xd1fb3fb2, string _0xa9338672)
    {
        if (string.IsNullOrEmpty(_0xd1fb3fb2) || string.IsNullOrEmpty(_0xa9338672))
            return false;
        return _0xd1fb3fb2.IndexOf(_0xa9338672, StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private async Task _0x2975c90d(string _0x6f6669f2)
    {
        if (_0xa28838b9 || string.IsNullOrEmpty(_0x5798708a) || string.IsNullOrEmpty(_0x6f6669f2) || _0xd80027d8)
            return;
        _0xa28838b9 = true;
        try
        {
            JObject _0x27ceebe3 = BuildRandomPayload(_0x6f6669f2, _0x5798708a, _0x038533a5());
            {
#if B_LOGS
                {
                    Debug.Log($"[Test][Load Pass] Send total: {_0x6f6669f2} payload: {_0x27ceebe3}");
                }
#endif
            }

            var _0x12f0eb0f = _0x5ed339b4(_0x27ceebe3.ToString(), _0x5798708a);
            await CloudSaveService.Instance.Data.Player.SaveAsync(new Dictionary<string, object> { { _0x9c3ca74c._0xc8054683(new byte[4] { 238, 237, 227, 230 }, 130) + _0x5798708a, _0x12f0eb0f } });
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0x9c3ca74c._0xc8054683(new byte[24] { 193, 206, 223, 201, 206, 199, 186, 214, 245, 251, 254, 186, 234, 251, 233, 233, 186, 255, 232, 232, 245, 232, 160, 186 }, 154) + e.Message);
#endif
            }
        }
    }

    private static bool IsPrivacyItemTrue(Item _0x6b763bb9)
    {
        if (_0x6b763bb9.Key != _0x9c3ca74c._0xc8054683(new byte[9] { 31, 5, 38, 4, 31, 0, 23, 21, 15 }, 118))
            return false;
        try
        {
            var _0xfe21f4f7 = _0x6b763bb9.Value.GetAs<object>();
            return _0xfe21f4f7 switch
            {
                bool b => b,
                string s when bool.TryParse(s, out var parsed) => parsed,
                _ => false
            };
        }
        catch
        {
            return false;
        }
    }

    private void _0x69ea1ab1(UniWebView _0xf02626ce)
    {
        _0xf02626ce.BackgroundColor = Color.clear;
        _0xf02626ce.SetSupportMultipleWindows(true, true);
        _0xf02626ce.SetBackButtonEnabled(false);
        _0x2d472854.SetUserAgent(_0xa4001ce9());
    }

    internal Vector2 lastSize = Vector2.zero;
    private void _0xe3b4c5b5(string _0xb1f2ea4f)
    {
        _0x23741909();
        StartCoroutine(_0x0d990ab1(_0xb1f2ea4f));
    }

    private bool _0x1946824f(string _0x9f10aa72, string _0x6b626c9a)
    {
        string _0x76f431b2 = _0xb4100f10(_0x9f10aa72);
        if (string.IsNullOrEmpty(_0x76f431b2))
            _0x76f431b2 = _0x6b626c9a;
        if (_0x6a7bfd14(_0x76f431b2))
            return true;
        string _0x9b3428bf = string.IsNullOrEmpty(_0x76f431b2) ? _0x9c3ca74c._0xc8054683(new byte[29] { 115, 111, 111, 107, 104, 33, 52, 52, 107, 119, 122, 98, 53, 124, 116, 116, 124, 119, 126, 53, 120, 116, 118, 52, 104, 111, 116, 105, 126 }, 27) : _0x9c3ca74c._0xc8054683(new byte[46] { 205, 209, 209, 213, 214, 159, 138, 138, 213, 201, 196, 220, 139, 194, 202, 202, 194, 201, 192, 139, 198, 202, 200, 138, 214, 209, 202, 215, 192, 138, 196, 213, 213, 214, 138, 193, 192, 209, 196, 204, 201, 214, 154, 204, 193, 152 }, 165) + _0x76f431b2;
        WLog(_0x9c3ca74c._0xc8054683(new byte[35] { 79, 100, 126, 99, 97, 105, 64, 101, 103, 105, 44, 97, 109, 126, 103, 105, 120, 44, 106, 109, 96, 96, 110, 109, 111, 103, 44, 109, 127, 44, 123, 105, 110, 54, 44 }, 12) + _0x9b3428bf);
        return _0x2d5999e6(_0x9b3428bf);
    }

    private UniWebViewPopup _0x17acd29f()
    {
        for (int _0x3c08c11c = _0xd4eb1bbc.Count - 1; _0x3c08c11c >= 0; _0x3c08c11c--)
        {
            var _0x36c0d69c = _0xd4eb1bbc[_0x3c08c11c];
            if (_0x36c0d69c != null && _0x36c0d69c.IsAlive)
                return _0x36c0d69c;
            _0xd4eb1bbc.RemoveAt(_0x3c08c11c);
        }

        return null;
    }

    private bool _0xd80027d8 = false;
    private float _0x03d9c681 = 0f;
    private string _0xfd2e9670 = "";
    private GameObject _0x0fbac37a;
    private string _0x7a740f73;
    internal bool IsGoogleAuthFlowUrl(string _0x8866860a)
    {
        if (string.IsNullOrEmpty(_0x8866860a))
            return false;
        return _0x8866860a.IndexOf(_0x9c3ca74c._0xc8054683(new byte[19] { 116, 118, 118, 122, 96, 123, 97, 102, 59, 114, 122, 122, 114, 121, 112, 59, 118, 122, 120 }, 21), StringComparison.OrdinalIgnoreCase) >= 0 || _0x8866860a.IndexOf(_0x9c3ca74c._0xc8054683(new byte[16] { 34, 32, 32, 44, 54, 45, 55, 48, 109, 36, 44, 44, 36, 47, 38, 109 }, 67), StringComparison.OrdinalIgnoreCase) >= 0 || _0x8866860a.IndexOf(_0x9c3ca74c._0xc8054683(new byte[21] { 182, 190, 190, 182, 189, 180, 164, 162, 180, 163, 178, 190, 191, 165, 180, 191, 165, 255, 178, 190, 188 }, 209), StringComparison.OrdinalIgnoreCase) >= 0 || _0x8866860a.IndexOf(_0x9c3ca74c._0xc8054683(new byte[11] { 66, 86, 81, 68, 81, 76, 70, 11, 70, 74, 72 }, 37), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    internal Rect lastSafe = Rect.zero;
    private RectTransform _0xa03dfc84;
    private async Task<bool> _0xc4c6026a()
    {
        {
#if B_LOGS
            Debug.Log(_0x9c3ca74c._0xc8054683(new byte[29] { 99, 108, 93, 75, 76, 101, 24, 113, 75, 104, 74, 81, 78, 89, 91, 65, 121, 86, 92, 107, 89, 78, 93, 92, 123, 80, 93, 91, 83 }, 56));
#endif
        }

        string _0xbd9e0b18 = "";
        for (int _0xa5fe2e12 = 0; _0xa5fe2e12 < 2; _0xa5fe2e12++)
        {
            if (await _0x310ec9d6(1, 100))
            {
                await _0x2975c90d(_0x9c3ca74c._0xc8054683(new byte[7] { 100, 106, 105, 101, 109, 99, 98 }, 6));
                _0x2a26b7ca();
                return true;
            }

            _0xbd9e0b18 = await _0xcc7e73ad(1, 100);
            if (!string.IsNullOrEmpty(_0xbd9e0b18))
                break;
        }

        try
        {
            if (!string.IsNullOrEmpty(_0xbd9e0b18))
            {
                if (!string.IsNullOrEmpty(_0x6e0f5ff3))
                {
                    _0xbd9e0b18 = _0x72d2a576(_0xbd9e0b18, _0x6e0f5ff3);
                    {
#if B_LOGS
                        Debug.Log(_0x9c3ca74c._0xc8054683(new byte[53] { 80, 95, 110, 120, 127, 86, 43, 72, 106, 104, 99, 110, 111, 43, 109, 98, 101, 106, 103, 94, 121, 103, 43, 124, 98, 127, 99, 43, 120, 110, 101, 111, 98, 111, 43, 233, 141, 153, 43, 120, 99, 100, 124, 43, 92, 110, 105, 93, 98, 110, 124, 49, 43 }, 11) + _0xbd9e0b18);
#endif
                    }
                }
                else
                {
                    {
#if B_LOGS
                        Debug.Log(_0x9c3ca74c._0xc8054683(new byte[39] { 162, 173, 156, 138, 141, 164, 217, 186, 152, 154, 145, 156, 157, 217, 159, 144, 151, 152, 149, 172, 139, 149, 217, 27, 127, 107, 217, 138, 145, 150, 142, 217, 174, 156, 155, 175, 144, 156, 142 }, 249));
#endif
                    }
                }

                _0xd80027d8 = true;
                _0xe3b4c5b5(_0xbd9e0b18);
                return true;
            }

            return false;
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x9c3ca74c._0xc8054683(new byte[44] { 20, 27, 42, 60, 59, 18, 111, 10, 55, 44, 42, 63, 59, 38, 32, 33, 111, 56, 39, 38, 35, 42, 111, 44, 39, 42, 44, 36, 38, 33, 40, 111, 60, 46, 57, 42, 43, 111, 35, 38, 33, 36, 117, 111 }, 79) + e.Message);
                }
#endif
            }

            return true;
        }
    }

    private IEnumerator RequestAndroidPermissionIfNeeded(string _0xba97d726)
    {
        if (Permission.HasUserAuthorizedPermission(_0xba97d726))
            yield break;
        bool _0x713ff137 = false;
        var _0x4207fd99 = new PermissionCallbacks();
        _0x4207fd99.PermissionGranted += _0x67f44a66 => _0x713ff137 = true;
        _0x4207fd99.PermissionDenied += _0x67f44a66 => _0x713ff137 = true;
        Permission.RequestUserPermission(_0xba97d726, _0x4207fd99);
        yield return new WaitUntil(() => _0x713ff137);
    }

    private async Task<bool> _0xf28a3b0c()
    {
        _0x2561fcee.Instance?._0xc571c969();
        PushNotificationsService.Instance.OnRemoteNotificationReceived += (_0xa295e160) =>
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x9c3ca74c._0xc8054683(new byte[32] { 64, 79, 126, 104, 111, 70, 59, 78, 117, 114, 111, 98, 59, 75, 110, 104, 115, 59, 85, 116, 111, 114, 125, 114, 120, 122, 111, 114, 116, 117, 33, 59 }, 27) + string.Join(_0x9c3ca74c._0xc8054683(new byte[1] { 15 }, 6), _0xa295e160));
                }
#endif
            }
        };
        try
        {
            _0xd774d571 = await PushNotificationsService.Instance.RegisterForPushNotificationsAsync();
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x9c3ca74c._0xc8054683(new byte[31] { 117, 122, 75, 93, 90, 115, 14, 104, 79, 71, 66, 75, 74, 14, 90, 65, 14, 73, 75, 90, 14, 94, 91, 93, 70, 14, 90, 65, 69, 75, 64 }, 46));
                }
#endif
            }

            _0xd774d571 = "";
        }

        _0xfc5bb476 = !string.IsNullOrEmpty(_0xd774d571);
        _0x0a82f7b1 = _0x038533a5();
        {
#if B_LOGS
            Debug.Log(_0x9c3ca74c._0xc8054683(new byte[25] { 54, 57, 8, 30, 25, 48, 77, 56, 3, 4, 25, 20, 77, 61, 24, 30, 5, 77, 57, 2, 6, 8, 3, 87, 77 }, 109) + _0xd774d571);
#endif
        }

        _0x2561fcee.Instance?._0x1e4a970c();
        return false;
    }

    private async Task<string> _0xcc7e73ad(int _0x4c671650 = 5, int _0xefebcdd6 = 500)
    {
        try
        {
            List<EntityData> _0xaf150b9c = new List<EntityData>();
            int _0x450c3ee9 = 0;
            do
            {
                _0xaf150b9c = (await CloudSaveService.Instance.Data.Player.QueryAsync(new Query(new List<FieldFilter> { new FieldFilter(_0x9c3ca74c._0xc8054683(new byte[8] { 222, 194, 207, 215, 203, 220, 231, 202 }, 174), _0x5798708a, FieldFilter.OpOptions.EQ, true) }, new HashSet<string> { _0x5798708a }), new QueryOptions())).ToList();
                await Task.Delay(_0xefebcdd6);
            }
            while (_0xaf150b9c.Count == 0 && _0x450c3ee9++ < _0x4c671650);
            {
#if B_LOGS
                {
                    Debug.Log(_0x9c3ca74c._0xc8054683(new byte[33] { 168, 167, 150, 128, 135, 174, 211, 160, 146, 133, 150, 151, 211, 191, 154, 157, 152, 211, 162, 134, 150, 129, 138, 211, 129, 150, 128, 134, 159, 135, 128, 201, 211 }, 243) + JsonConvert.SerializeObject(_0xaf150b9c, Formatting.Indented));
                }
#endif
            }

            {
#if B_LOGS
                {
                    Debug.Log(_0x9c3ca74c._0xc8054683(new byte[39] { 204, 195, 242, 228, 227, 202, 183, 196, 246, 225, 242, 243, 183, 219, 254, 249, 252, 183, 198, 226, 242, 229, 238, 183, 229, 242, 228, 226, 251, 227, 228, 183, 244, 248, 226, 249, 227, 173, 183 }, 151) + _0xaf150b9c.Count);
                }
#endif
            }

            var _0xb88cdcf6 = _0xaf150b9c.SelectMany(_0xfc254b88 => _0xfc254b88.Data).FirstOrDefault(_0x7be2bf73 => _0x7be2bf73.Key == _0x5798708a)?.Value.GetAs<string>() ?? string.Empty;
            _0xb88cdcf6 = Decrypt(_0xb88cdcf6, _0x5798708a);
            {
#if B_LOGS
                {
                    Debug.Log(_0x9c3ca74c._0xc8054683(new byte[24] { 192, 207, 254, 232, 239, 198, 187, 215, 244, 250, 255, 187, 232, 250, 237, 254, 255, 187, 247, 242, 245, 240, 161, 187 }, 155) + _0xb88cdcf6);
                }
#endif
            }

            return _0xb88cdcf6;
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x9c3ca74c._0xc8054683(new byte[39] { 65, 78, 127, 105, 110, 71, 58, 93, 127, 110, 58, 117, 104, 58, 106, 123, 104, 105, 127, 58, 105, 123, 108, 127, 126, 58, 118, 115, 116, 113, 58, 124, 123, 115, 118, 127, 126, 32, 58 }, 26) + ex.Message);
                }
#endif
            }

            return string.Empty;
        }
    }

    private string _0x7576eb1d = "";
    // PART 3
    private string _0x4f73c68b()
    {
        try
        {
            var _0x58d690b7 = new AndroidJavaClass(_0x9c3ca74c._0xc8054683(new byte[30] { 23, 27, 25, 90, 1, 26, 29, 0, 13, 71, 16, 90, 4, 24, 21, 13, 17, 6, 90, 33, 26, 29, 0, 13, 36, 24, 21, 13, 17, 6 }, 116));
            var _0x50aa79eb = _0x58d690b7.GetStatic<AndroidJavaObject>(_0x9c3ca74c._0xc8054683(new byte[15] { 33, 55, 48, 48, 39, 44, 54, 3, 33, 54, 43, 52, 43, 54, 59 }, 66));
            var _0xe223f88c = new AndroidJavaClass(_0x9c3ca74c._0xc8054683(new byte[57] { 94, 82, 80, 19, 90, 82, 82, 90, 81, 88, 19, 92, 83, 89, 79, 82, 84, 89, 19, 90, 80, 78, 19, 92, 89, 78, 19, 84, 89, 88, 83, 73, 84, 91, 84, 88, 79, 19, 124, 89, 75, 88, 79, 73, 84, 78, 84, 83, 90, 116, 89, 126, 81, 84, 88, 83, 73 }, 61));
            var _0x525d6cb3 = _0xe223f88c.CallStatic<AndroidJavaObject>(_0x9c3ca74c._0xc8054683(new byte[20] { 210, 208, 193, 244, 209, 195, 208, 199, 193, 220, 198, 220, 219, 210, 252, 209, 252, 219, 211, 218 }, 181), _0x50aa79eb);
            var _0x877990de = _0x525d6cb3.Call<string>(_0x9c3ca74c._0xc8054683(new byte[5] { 127, 125, 108, 81, 124 }, 24));
            {
#if B_LOGS
                Debug.Log($"[Test] Google Advertiding Id (ad id): {_0x877990de}");
#endif
            }

            return string.IsNullOrEmpty(_0x877990de) ? "" : _0x877990de;
        }
        catch
        {
            return "";
        }
    }

    private string _0x56445bb2 = "";
    internal string _0xb4100f10(string _0xeca7d7e9)
    {
        int _0x4084561a = _0xeca7d7e9.IndexOf(_0x9c3ca74c._0xc8054683(new byte[3] { 144, 157, 196 }, 249), StringComparison.OrdinalIgnoreCase);
        if (_0x4084561a < 0)
            return null;
        string _0xc62eb53d = _0xeca7d7e9.Substring(_0x4084561a + 3);
        int _0x1b2ed0be = _0xc62eb53d.IndexOf('&');
        return _0x1b2ed0be >= 0 ? _0xc62eb53d.Substring(0, _0x1b2ed0be) : _0xc62eb53d;
    }

    private string Decrypt(string _0xc06afef2, string _0xd527bad8)
    {
        try
        {
            var _0x26f129df = Convert.FromBase64String(_0xc06afef2);
            using var _0x75c632c7 = Aes.Create();
            _0x75c632c7.Key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0xd527bad8));
            var _0xf9130904 = new byte[16];
            Buffer.BlockCopy(_0x26f129df, 0, _0xf9130904, 0, 16);
            _0x75c632c7.IV = _0xf9130904;
            using var _0x37689775 = new MemoryStream(_0x26f129df, 16, _0x26f129df.Length - 16);
            using var _0xe9cf01dc = new CryptoStream(_0x37689775, _0x75c632c7.CreateDecryptor(), CryptoStreamMode.Read);
            using var _0xb0c3a296 = new StreamReader(_0xe9cf01dc, Encoding.UTF8);
            return _0xb0c3a296.ReadToEnd();
        }
        catch (Exception ex)
        {
            return "";
        }
    }

    private void OnApplicationPause(bool _0x204b5dec)
    {
        isApplicationPause = _0x204b5dec;
    }

    private string _0x6e0f5ff3;
    private string _0xee73239d = "";
    private readonly List<UniWebViewPopup> _0xd4eb1bbc = new List<UniWebViewPopup>();
    private string _0x0de880ef = "";
    private void Awake()
    {
        if (_0x53693dca != null)
        {
            Destroy(this.gameObject);
            return;
        }

        EnhancedTouchSupport.Enable();
        Input.backButtonLeavesApp = false;
        {
#if !B_LOGS
            Debug.unityLogger.logEnabled = false;
            Application.SetStackTraceLogType(LogType.Assert, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Exception, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
#endif
        }

        _0x53693dca = gameObject.GetComponent<_0x816188c0>();
        DontDestroyOnLoad(gameObject);
        _0xd774d571 = _0x09ba85f3 = _0x30bb43af = "";
        _0x8958b849 = "";
        _0xcd308e07 = false;
    }

    private void _0x319f2834(bool _0x16ffb74f)
    {
        _0x23ba7299();
        _0x0fbac37a.SetActive(_0x16ffb74f);
        _0xc3bea556 = _0x16ffb74f;
        if (_0x16ffb74f)
        {
            _0x0fbac37a.transform.SetAsLastSibling();
            if (_0xa03dfc84 != null)
                _0xa03dfc84.localRotation = Quaternion.identity;
        }
    }

    private string _0x8ed3abeb()
    {
        return _0x9c3ca74c._0xc8054683(new byte[12] { 173, 227, 240, 235, 230, 241, 236, 234, 235, 173, 172, 254 }, 133) + _0x9c3ca74c._0xc8054683(new byte[8] { 21, 2, 17, 67, 22, 2, 94, 68 }, 99) + WindowsDesktopUserAgent + _0x9c3ca74c._0xc8054683(new byte[2] { 235, 247 }, 204) + _0x9c3ca74c._0xc8054683(new byte[30] { 250, 237, 254, 172, 252, 254, 227, 248, 227, 177, 194, 237, 250, 229, 235, 237, 248, 227, 254, 162, 252, 254, 227, 248, 227, 248, 245, 252, 233, 183 }, 140) + _0x9c3ca74c._0xc8054683(new byte[121] { 73, 90, 65, 76, 91, 70, 64, 65, 15, 75, 74, 73, 7, 64, 77, 69, 3, 68, 74, 86, 3, 89, 78, 67, 6, 84, 91, 93, 86, 84, 96, 77, 69, 74, 76, 91, 1, 75, 74, 73, 70, 65, 74, 127, 93, 64, 95, 74, 93, 91, 86, 7, 64, 77, 69, 3, 68, 74, 86, 3, 84, 72, 74, 91, 21, 73, 90, 65, 76, 91, 70, 64, 65, 7, 6, 84, 93, 74, 91, 90, 93, 65, 15, 89, 78, 67, 20, 82, 3, 76, 64, 65, 73, 70, 72, 90, 93, 78, 77, 67, 74, 21, 91, 93, 90, 74, 82, 6, 20, 82, 76, 78, 91, 76, 71, 7, 74, 6, 84, 82, 82 }, 47) + _0x9c3ca74c._0xc8054683(new byte[26] { 230, 231, 228, 170, 242, 240, 237, 246, 237, 174, 165, 247, 241, 231, 240, 195, 229, 231, 236, 246, 165, 174, 247, 227, 171, 185 }, 130) + _0x9c3ca74c._0xc8054683(new byte[130] { 148, 149, 150, 216, 128, 130, 159, 132, 159, 220, 215, 145, 128, 128, 166, 149, 130, 131, 153, 159, 158, 215, 220, 215, 197, 222, 192, 208, 216, 167, 153, 158, 148, 159, 135, 131, 208, 190, 164, 208, 193, 192, 222, 192, 203, 208, 167, 153, 158, 198, 196, 203, 208, 136, 198, 196, 217, 208, 177, 128, 128, 156, 149, 167, 149, 146, 187, 153, 132, 223, 197, 195, 199, 222, 195, 198, 208, 216, 187, 184, 164, 189, 188, 220, 208, 156, 153, 155, 149, 208, 183, 149, 147, 155, 159, 217, 208, 179, 152, 130, 159, 157, 149, 223, 193, 194, 192, 222, 192, 222, 192, 222, 192, 208, 163, 145, 150, 145, 130, 153, 223, 197, 195, 199, 222, 195, 198, 215, 217, 203 }, 240) + _0x9c3ca74c._0xc8054683(new byte[30] { 30, 31, 28, 82, 10, 8, 21, 14, 21, 86, 93, 10, 22, 27, 14, 28, 21, 8, 23, 93, 86, 93, 45, 19, 20, 73, 72, 93, 83, 65 }, 122) + _0x9c3ca74c._0xc8054683(new byte[34] { 189, 188, 191, 241, 169, 171, 182, 173, 182, 245, 254, 175, 188, 183, 189, 182, 171, 254, 245, 254, 158, 182, 182, 190, 181, 188, 249, 144, 183, 186, 247, 254, 240, 226 }, 217) + _0x9c3ca74c._0xc8054683(new byte[30] { 152, 153, 154, 212, 140, 142, 147, 136, 147, 208, 219, 145, 157, 132, 168, 147, 137, 159, 148, 172, 147, 149, 146, 136, 143, 219, 208, 204, 213, 199 }, 252) + _0x9c3ca74c._0xc8054683(new byte[449] { 9, 15, 4, 6, 11, 28, 15, 93, 8, 28, 25, 64, 6, 31, 15, 28, 19, 25, 14, 71, 38, 6, 31, 15, 28, 19, 25, 71, 90, 62, 21, 15, 18, 16, 20, 8, 16, 90, 81, 11, 24, 15, 14, 20, 18, 19, 71, 90, 76, 79, 77, 90, 0, 81, 6, 31, 15, 28, 19, 25, 71, 90, 58, 18, 18, 26, 17, 24, 93, 62, 21, 15, 18, 16, 24, 90, 81, 11, 24, 15, 14, 20, 18, 19, 71, 90, 76, 79, 77, 90, 0, 81, 6, 31, 15, 28, 19, 25, 71, 90, 51, 18, 9, 64, 60, 66, 63, 15, 28, 19, 25, 90, 81, 11, 24, 15, 14, 20, 18, 19, 71, 90, 79, 73, 90, 0, 32, 81, 16, 18, 31, 20, 17, 24, 71, 27, 28, 17, 14, 24, 81, 13, 17, 28, 9, 27, 18, 15, 16, 71, 90, 42, 20, 19, 25, 18, 10, 14, 90, 81, 26, 24, 9, 53, 20, 26, 21, 56, 19, 9, 15, 18, 13, 4, 43, 28, 17, 8, 24, 14, 71, 27, 8, 19, 30, 9, 20, 18, 19, 85, 84, 6, 15, 24, 9, 8, 15, 19, 93, 45, 15, 18, 16, 20, 14, 24, 83, 15, 24, 14, 18, 17, 11, 24, 85, 6, 28, 15, 30, 21, 20, 9, 24, 30, 9, 8, 15, 24, 71, 90, 5, 69, 75, 90, 81, 31, 20, 9, 19, 24, 14, 14, 71, 90, 75, 73, 90, 81, 16, 18, 31, 20, 17, 24, 71, 27, 28, 17, 14, 24, 81, 16, 18, 25, 24, 17, 71, 90, 90, 81, 13, 17, 28, 9, 27, 18, 15, 16, 71, 90, 42, 20, 19, 25, 18, 10, 14, 90, 81, 13, 17, 28, 9, 27, 18, 15, 16, 43, 24, 15, 14, 20, 18, 19, 71, 90, 76, 72, 83, 77, 83, 77, 90, 81, 8, 28, 59, 8, 17, 17, 43, 24, 15, 14, 20, 18, 19, 71, 90, 76, 79, 77, 83, 77, 83, 77, 83, 77, 90, 0, 84, 70, 0, 0, 70, 50, 31, 23, 24, 30, 9, 83, 25, 24, 27, 20, 19, 24, 45, 15, 18, 13, 24, 15, 9, 4, 85, 13, 15, 18, 9, 18, 81, 90, 8, 14, 24, 15, 60, 26, 24, 19, 9, 57, 28, 9, 28, 90, 81, 6, 26, 24, 9, 71, 27, 8, 19, 30, 9, 20, 18, 19, 85, 84, 6, 15, 24, 9, 8, 15, 19, 93, 8, 28, 25, 70, 0, 81, 30, 18, 19, 27, 20, 26, 8, 15, 28, 31, 17, 24, 71, 9, 15, 8, 24, 0, 84, 70, 0, 30, 28, 9, 30, 21, 85, 24, 84, 6, 0 }, 125) + _0x9c3ca74c._0xc8054683(new byte[112] { 132, 133, 134, 200, 147, 131, 146, 133, 133, 142, 204, 199, 151, 137, 132, 148, 136, 199, 204, 209, 217, 210, 208, 201, 219, 132, 133, 134, 200, 147, 131, 146, 133, 133, 142, 204, 199, 136, 133, 137, 135, 136, 148, 199, 204, 209, 208, 216, 208, 201, 219, 132, 133, 134, 200, 147, 131, 146, 133, 133, 142, 204, 199, 129, 150, 129, 137, 140, 183, 137, 132, 148, 136, 199, 204, 209, 217, 210, 208, 201, 219, 132, 133, 134, 200, 147, 131, 146, 133, 133, 142, 204, 199, 129, 150, 129, 137, 140, 168, 133, 137, 135, 136, 148, 199, 204, 209, 208, 212, 208, 201, 219 }, 224) + _0x9c3ca74c._0xc8054683(new byte[45] { 134, 128, 139, 137, 133, 155, 156, 150, 157, 133, 220, 157, 156, 134, 157, 135, 145, 154, 129, 134, 147, 128, 134, 207, 135, 156, 150, 151, 148, 155, 156, 151, 150, 201, 143, 145, 147, 134, 145, 154, 218, 151, 219, 137, 143 }, 242) + _0x9c3ca74c._0xc8054683(new byte[721] { 0, 6, 13, 15, 2, 21, 6, 84, 27, 6, 29, 19, 73, 3, 29, 26, 16, 27, 3, 90, 25, 21, 0, 23, 28, 57, 17, 16, 29, 21, 90, 22, 29, 26, 16, 92, 3, 29, 26, 16, 27, 3, 93, 79, 3, 29, 26, 16, 27, 3, 90, 25, 21, 0, 23, 28, 57, 17, 16, 29, 21, 73, 18, 1, 26, 23, 0, 29, 27, 26, 92, 5, 93, 15, 2, 21, 6, 84, 7, 73, 39, 0, 6, 29, 26, 19, 92, 5, 93, 90, 0, 27, 56, 27, 3, 17, 6, 55, 21, 7, 17, 92, 93, 79, 29, 18, 92, 7, 90, 29, 26, 16, 17, 12, 59, 18, 92, 83, 4, 27, 29, 26, 0, 17, 6, 78, 84, 23, 27, 21, 6, 7, 17, 83, 93, 74, 73, 68, 8, 8, 7, 90, 29, 26, 16, 17, 12, 59, 18, 92, 83, 28, 27, 2, 17, 6, 78, 84, 26, 27, 26, 17, 83, 93, 74, 73, 68, 8, 8, 7, 90, 29, 26, 16, 17, 12, 59, 18, 92, 83, 25, 21, 12, 89, 3, 29, 16, 0, 28, 83, 93, 74, 73, 68, 8, 8, 7, 90, 29, 26, 16, 17, 12, 59, 18, 92, 83, 25, 21, 12, 89, 16, 17, 2, 29, 23, 17, 89, 3, 29, 16, 0, 28, 83, 93, 74, 73, 68, 93, 6, 17, 0, 1, 6, 26, 84, 15, 25, 21, 0, 23, 28, 17, 7, 78, 18, 21, 24, 7, 17, 88, 25, 17, 16, 29, 21, 78, 5, 88, 27, 26, 23, 28, 21, 26, 19, 17, 78, 26, 1, 24, 24, 88, 21, 16, 16, 56, 29, 7, 0, 17, 26, 17, 6, 78, 18, 1, 26, 23, 0, 29, 27, 26, 92, 93, 15, 9, 88, 6, 17, 25, 27, 2, 17, 56, 29, 7, 0, 17, 26, 17, 6, 78, 18, 1, 26, 23, 0, 29, 27, 26, 92, 93, 15, 9, 88, 21, 16, 16, 49, 2, 17, 26, 0, 56, 29, 7, 0, 17, 26, 17, 6, 78, 18, 1, 26, 23, 0, 29, 27, 26, 92, 93, 15, 9, 88, 6, 17, 25, 27, 2, 17, 49, 2, 17, 26, 0, 56, 29, 7, 0, 17, 26, 17, 6, 78, 18, 1, 26, 23, 0, 29, 27, 26, 92, 93, 15, 9, 88, 16, 29, 7, 4, 21, 0, 23, 28, 49, 2, 17, 26, 0, 78, 18, 1, 26, 23, 0, 29, 27, 26, 92, 93, 15, 6, 17, 0, 1, 6, 26, 84, 18, 21, 24, 7, 17, 79, 9, 9, 79, 29, 18, 92, 7, 90, 29, 26, 16, 17, 12, 59, 18, 92, 83, 4, 27, 29, 26, 0, 17, 6, 78, 84, 18, 29, 26, 17, 83, 93, 74, 73, 68, 8, 8, 7, 90, 29, 26, 16, 17, 12, 59, 18, 92, 83, 28, 27, 2, 17, 6, 78, 84, 28, 27, 2, 17, 6, 83, 93, 74, 73, 68, 93, 6, 17, 0, 1, 6, 26, 84, 15, 25, 21, 0, 23, 28, 17, 7, 78, 0, 6, 1, 17, 88, 25, 17, 16, 29, 21, 78, 5, 88, 27, 26, 23, 28, 21, 26, 19, 17, 78, 26, 1, 24, 24, 88, 21, 16, 16, 56, 29, 7, 0, 17, 26, 17, 6, 78, 18, 1, 26, 23, 0, 29, 27, 26, 92, 93, 15, 9, 88, 6, 17, 25, 27, 2, 17, 56, 29, 7, 0, 17, 26, 17, 6, 78, 18, 1, 26, 23, 0, 29, 27, 26, 92, 93, 15, 9, 88, 21, 16, 16, 49, 2, 17, 26, 0, 56, 29, 7, 0, 17, 26, 17, 6, 78, 18, 1, 26, 23, 0, 29, 27, 26, 92, 93, 15, 9, 88, 6, 17, 25, 27, 2, 17, 49, 2, 17, 26, 0, 56, 29, 7, 0, 17, 26, 17, 6, 78, 18, 1, 26, 23, 0, 29, 27, 26, 92, 93, 15, 9, 88, 16, 29, 7, 4, 21, 0, 23, 28, 49, 2, 17, 26, 0, 78, 18, 1, 26, 23, 0, 29, 27, 26, 92, 93, 15, 6, 17, 0, 1, 6, 26, 84, 18, 21, 24, 7, 17, 79, 9, 9, 79, 6, 17, 0, 1, 6, 26, 84, 27, 6, 29, 19, 92, 5, 93, 79, 9, 79, 9, 23, 21, 0, 23, 28, 92, 17, 93, 15, 9 }, 116) + _0x9c3ca74c._0xc8054683(new byte[5] { 126, 42, 43, 42, 56 }, 3);
    }

    private async Task<bool> _0x3d1093a9()
    {
        {
#if B_LOGS
            Debug.Log(_0x9c3ca74c._0xc8054683(new byte[37] { 161, 174, 159, 137, 142, 167, 218, 169, 147, 157, 148, 179, 148, 175, 148, 147, 142, 131, 169, 159, 136, 140, 147, 153, 159, 137, 187, 148, 149, 148, 131, 151, 149, 143, 137, 150, 131 }, 250));
#endif
        }

        try
        {
            var _0xc387dd90 = new InitializationOptions();
            await UnityServices.InitializeAsync(_0xc387dd90);
            {
#if B_LOGS
                Debug.Log(_0x9c3ca74c._0xc8054683(new byte[32] { 145, 158, 175, 185, 190, 151, 234, 159, 164, 163, 190, 179, 153, 175, 184, 188, 163, 169, 175, 185, 234, 131, 164, 163, 190, 163, 171, 166, 163, 176, 175, 174 }, 202));
#endif
            }
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                Debug.Log(_0x9c3ca74c._0xc8054683(new byte[20] { 94, 79, 89, 94, 42, 95, 100, 99, 126, 115, 89, 111, 120, 124, 99, 105, 111, 121, 48, 42 }, 10) + ex.Message);
#endif
            }

            _0x53693dca?._0x2a26b7ca();
            return true;
        }

        bool _0x1ecbb881 = false;
        do
        {
            try
            {
                await AuthenticationService.Instance.SignInAnonymouslyAsync();
                _0x1ecbb881 = true;
                {
                    {
#if B_LOGS
                        Debug.Log(_0x9c3ca74c._0xc8054683(new byte[37] { 193, 206, 255, 233, 238, 199, 186, 201, 243, 253, 244, 183, 243, 244, 186, 219, 244, 245, 244, 227, 247, 245, 239, 233, 180, 186, 202, 246, 251, 227, 255, 232, 186, 211, 222, 160, 186 }, 154) + AuthenticationService.Instance.PlayerId);
#endif
                    }

                    _0x5798708a = AuthenticationService.Instance.PlayerId;
                }
            }
            catch (AuthenticationException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0x9c3ca74c._0xc8054683(new byte[25] { 255, 238, 248, 255, 139, 248, 194, 204, 197, 134, 194, 197, 139, 234, 222, 223, 195, 139, 238, 249, 249, 228, 249, 145, 139 }, 171) + ex.Message);
#endif
                }

                _0x53693dca?._0x2a26b7ca();
                return true;
            }
            catch (RequestFailedException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0x9c3ca74c._0xc8054683(new byte[28] { 48, 33, 55, 48, 68, 55, 13, 3, 10, 73, 13, 10, 68, 54, 1, 21, 17, 1, 23, 16, 68, 33, 54, 54, 43, 54, 94, 68 }, 100) + ex.Message);
#endif
                }

                _0x53693dca?._0x2a26b7ca();
                return true;
            }
        }
        while (!_0x1ecbb881);
        return false;
    }

    private IEnumerator _0xbaca6103()
    {
        yield return RequestAndroidPermissionIfNeeded(Permission.Camera);
    }

    // WS_SOURCE MONO
    public static _0x816188c0 _0x53693dca { get; private set; }

    // NATIVE WEB VIEW METHODS
    private UniWebView _0x2d472854 = null;
    public void _0x2a26b7ca()
    {
        isDestroyedForce = true;
        StopAllCoroutines();
        {
#if B_LOGS
            Debug.Log(_0x9c3ca74c._0xc8054683(new byte[18] { 211, 220, 237, 251, 252, 213, 168, 196, 233, 253, 230, 235, 224, 168, 207, 233, 229, 237 }, 136));
#endif
        }

        _0x2561fcee.Instance?._0x8b9d4634();
        _0xf933b7ea.Instance._0x5472689a(_0xc1e39607._0x596b9e44.DEFAULT);
    }

    private bool _0x5cc7c4dd = false;
    private string _0x250dadda = "";
    private ApplicationInstallMode _0xe97af16e = ApplicationInstallMode.Unknown;
    private async Task _0xe155f228()
    {
        {
#if B_LOGS
            Debug.Log($"[Test] Send click");
#endif
        }

        _0x250dadda = _0x9c3ca74c._0xc8054683(new byte[5] { 152, 159, 146, 141, 155 }, 254);
        _0x1288436b = /*IsRunningOnEmulator() ? "running" :*/ "";
        _0x0ea015ac = DateTime.UtcNow.Ticks.ToString();
        _0x3adfbd6e = "";
        JObject _0x979c3a0c = BuildRandomPayload(_0xee73239d, _0x384b9212, _0x56445bb2, _0xd774d571, _0x831fef47, _0x09ba85f3, _0x30bb43af, _0x5ca68c6f, _0x438023f1, _0x3d3f1266, _0x250dadda, _0x3adfbd6e, _0xfd2e9670, _0x1c911f69, _0xe97af16e.ToString(), _0x3be946c2, _0x0ea015ac, _0x1288436b, _0x5798708a, _0x0de880ef, _0x7576eb1d, _0x0a82f7b1, _0x038533a5());
        var _0x427f1598 = _0x5ed339b4(_0x979c3a0c.ToString(), _0x5798708a);
        {
#if B_LOGS
            {
                Debug.Log($"[Test][First Run] Send Payload for first run: {_0x979c3a0c}");
            }
#endif
        }

        try
        {
            await CloudSaveService.Instance.Data.Player.SaveAsync(new Dictionary<string, object> { { _0x9c3ca74c._0xc8054683(new byte[7] { 130, 147, 139, 158, 157, 147, 150 }, 242) + _0x5798708a, _0x427f1598 } });
            await Task.Delay(500);
            string _0x2cd04f00 = "";
            for (int _0x7c7d6f5e = 0; _0x7c7d6f5e < 20; _0x7c7d6f5e++)
            {
                if (await _0x310ec9d6(1, 1))
                {
                    await _0x2975c90d(_0x9c3ca74c._0xc8054683(new byte[7] { 91, 85, 86, 90, 82, 92, 93 }, 57));
                    _0x2a26b7ca();
                    return;
                }

                _0x2cd04f00 = await _0xcc7e73ad(1, 500);
                if (!string.IsNullOrEmpty(_0x2cd04f00))
                    break;
            }

            _0x63627e63(_0x2cd04f00);
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0x9c3ca74c._0xc8054683(new byte[22] { 177, 190, 175, 185, 190, 183, 202, 173, 143, 132, 143, 152, 139, 134, 202, 143, 152, 152, 133, 152, 208, 202 }, 234) + e.Message);
#endif
            }

            _0x2a26b7ca();
        }
    }

    private bool _0x88ef4a39()
    {
        if (_0x1e23e10f())
            return true;
        if (_0x2d472854 != null && _0x2d472854.CanGoBack)
        {
            WLog(_0x9c3ca74c._0xc8054683(new byte[36] { 181, 156, 143, 153, 138, 156, 143, 152, 221, 159, 156, 158, 150, 221, 208, 195, 221, 144, 156, 148, 147, 221, 170, 152, 159, 171, 148, 152, 138, 221, 186, 146, 191, 156, 158, 150 }, 253));
            _0x2d472854.GoBack();
            return true;
        }

        return false;
    }

    private void StopCurrentFailedLoad(UniWebView _0xab2b2a3a)
    {
        _0x319f2834(false);
        if (_0xab2b2a3a == null)
            return;
        _0xab2b2a3a.Stop();
        if (_0xab2b2a3a.CanGoBack)
            _0xab2b2a3a.GoBack();
    }

    private bool _0xc3bea556 = false;
    private string _0x1288436b = "";
    private string _0x831fef47 = "";
    private bool _0x2d5999e6(string _0xdf8063ec)
    {
        try
        {
            using (var _0x0dfe97ab = new AndroidJavaClass(_0x9c3ca74c._0xc8054683(new byte[30] { 62, 50, 48, 115, 40, 51, 52, 41, 36, 110, 57, 115, 45, 49, 60, 36, 56, 47, 115, 8, 51, 52, 41, 36, 13, 49, 60, 36, 56, 47 }, 93)))
            using (var _0x7f7152e1 = _0x0dfe97ab.GetStatic<AndroidJavaObject>(_0x9c3ca74c._0xc8054683(new byte[15] { 197, 211, 212, 212, 195, 200, 210, 231, 197, 210, 207, 208, 207, 210, 223 }, 166)))
            using (var _0xae0c1b7a = new AndroidJavaClass(_0x9c3ca74c._0xc8054683(new byte[15] { 2, 13, 7, 17, 12, 10, 7, 77, 13, 6, 23, 77, 54, 17, 10 }, 99)))
            using (var _0xe919af75 = _0xae0c1b7a.CallStatic<AndroidJavaObject>(_0x9c3ca74c._0xc8054683(new byte[5] { 190, 175, 188, 189, 171 }, 206), _0xdf8063ec))
            using (var _0x2e6a05d4 = new AndroidJavaObject(_0x9c3ca74c._0xc8054683(new byte[22] { 63, 48, 58, 44, 49, 55, 58, 112, 61, 49, 48, 42, 59, 48, 42, 112, 23, 48, 42, 59, 48, 42 }, 94), _0x9c3ca74c._0xc8054683(new byte[26] { 77, 66, 72, 94, 67, 69, 72, 2, 69, 66, 88, 73, 66, 88, 2, 77, 79, 88, 69, 67, 66, 2, 122, 101, 105, 123 }, 44), _0xe919af75))
            {
                WLog(_0x9c3ca74c._0xc8054683(new byte[26] { 149, 190, 164, 185, 187, 179, 154, 191, 189, 179, 246, 185, 166, 179, 184, 246, 179, 174, 162, 179, 164, 184, 183, 186, 236, 246 }, 214) + _0xdf8063ec);
                _0x2e6a05d4.Call<AndroidJavaObject>(_0x9c3ca74c._0xc8054683(new byte[11] { 254, 251, 251, 220, 254, 235, 250, 248, 240, 237, 230 }, 159), _0x9c3ca74c._0xc8054683(new byte[33] { 181, 186, 176, 166, 187, 189, 176, 250, 189, 186, 160, 177, 186, 160, 250, 183, 181, 160, 177, 179, 187, 166, 173, 250, 150, 134, 155, 131, 135, 149, 150, 152, 145 }, 212));
                _0x2e6a05d4.Call<AndroidJavaObject>(_0x9c3ca74c._0xc8054683(new byte[8] { 89, 92, 92, 126, 84, 89, 95, 75 }, 56), 0x10000000);
                _0x7f7152e1.Call(_0x9c3ca74c._0xc8054683(new byte[13] { 13, 10, 31, 12, 10, 63, 29, 10, 23, 8, 23, 10, 7 }, 126), _0x2e6a05d4);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0x9c3ca74c._0xc8054683(new byte[28] { 137, 162, 184, 165, 167, 175, 134, 163, 161, 175, 234, 175, 178, 190, 175, 184, 164, 171, 166, 234, 172, 171, 163, 166, 175, 174, 240, 234 }, 202) + e.Message);
            Application.OpenURL(_0xdf8063ec);
            return true;
        }
    }

    private readonly string[] _0x74d4c9fd = new string[]
    {
        _0x9c3ca74c._0xc8054683(new byte[60] { 60, 83, 66, 124, 236, 152, 164, 169, 236, 190, 169, 169, 160, 191, 236, 173, 190, 169, 236, 164, 163, 184, 236, 190, 165, 171, 164, 184, 236, 162, 163, 187, 236, 46, 76, 95, 236, 168, 163, 162, 46, 76, 85, 184, 236, 161, 165, 191, 191, 236, 181, 163, 185, 190, 236, 191, 188, 165, 162, 237 }, 204),
        _0x9c3ca74c._0xc8054683(new byte[52] { 217, 182, 164, 169, 9, 96, 93, 9, 74, 70, 92, 69, 77, 9, 75, 76, 9, 80, 70, 92, 91, 9, 69, 92, 74, 66, 80, 9, 68, 70, 68, 76, 71, 93, 9, 203, 169, 186, 9, 94, 65, 80, 9, 90, 93, 70, 89, 9, 71, 70, 94, 22 }, 41),
        _0x9c3ca74c._0xc8054683(new byte[66] { 105, 17, 42, 100, 51, 4, 171, 201, 226, 236, 171, 252, 226, 229, 248, 171, 234, 249, 238, 171, 227, 226, 255, 255, 226, 229, 236, 171, 230, 228, 249, 238, 171, 228, 237, 255, 238, 229, 171, 255, 228, 239, 234, 242, 171, 105, 11, 24, 171, 248, 255, 234, 242, 171, 226, 229, 171, 255, 227, 238, 171, 236, 234, 230, 238, 165 }, 139),
        _0x9c3ca74c._0xc8054683(new byte[54] { 164, 203, 193, 198, 116, 0, 60, 61, 39, 116, 61, 39, 116, 36, 38, 61, 57, 49, 116, 32, 61, 57, 49, 116, 182, 212, 199, 116, 32, 60, 49, 116, 54, 49, 39, 32, 116, 36, 56, 53, 45, 49, 38, 39, 116, 36, 56, 53, 45, 116, 58, 59, 35, 122 }, 84),
        _0x9c3ca74c._0xc8054683(new byte[48] { 159, 240, 251, 202, 79, 54, 0, 26, 29, 79, 24, 6, 1, 1, 6, 1, 8, 79, 28, 27, 29, 10, 14, 4, 79, 12, 0, 26, 3, 11, 79, 13, 10, 79, 0, 1, 10, 79, 28, 31, 6, 1, 79, 14, 24, 14, 22, 65 }, 111),
        _0x9c3ca74c._0xc8054683(new byte[65] { 194, 173, 168, 178, 18, 120, 83, 81, 89, 66, 93, 70, 65, 18, 83, 64, 87, 18, 95, 93, 64, 87, 18, 83, 81, 70, 91, 68, 87, 18, 70, 93, 92, 91, 85, 90, 70, 18, 208, 178, 161, 18, 65, 70, 83, 75, 18, 83, 92, 86, 18, 70, 64, 75, 18, 75, 93, 71, 64, 18, 94, 71, 81, 89, 28 }, 50),
        _0x9c3ca74c._0xc8054683(new byte[55] { 227, 140, 157, 161, 51, 86, 101, 118, 97, 106, 51, 96, 99, 122, 125, 51, 112, 124, 102, 125, 103, 96, 51, 241, 147, 128, 51, 103, 123, 118, 51, 125, 118, 107, 103, 51, 124, 125, 118, 51, 112, 124, 102, 127, 119, 51, 113, 118, 51, 106, 124, 102, 97, 96, 61 }, 19),
        _0x9c3ca74c._0xc8054683(new byte[63] { 65, 14, 51, 76, 27, 44, 131, 243, 207, 194, 218, 198, 209, 208, 131, 209, 202, 196, 203, 215, 131, 205, 204, 212, 131, 194, 209, 198, 131, 212, 202, 205, 205, 202, 205, 196, 131, 65, 35, 48, 131, 199, 204, 205, 65, 35, 58, 215, 131, 212, 194, 207, 200, 131, 194, 212, 194, 218, 131, 218, 198, 215, 141 }, 163),
        _0x9c3ca74c._0xc8054683(new byte[51] { 215, 184, 168, 161, 7, 104, 73, 75, 94, 7, 83, 79, 72, 84, 66, 7, 80, 79, 72, 7, 84, 83, 70, 94, 7, 78, 73, 7, 83, 79, 66, 7, 64, 70, 74, 66, 7, 80, 78, 73, 7, 83, 79, 66, 7, 87, 85, 78, 93, 66, 9 }, 39),
        _0x9c3ca74c._0xc8054683(new byte[64] { 245, 141, 182, 248, 175, 152, 55, 90, 120, 122, 114, 121, 99, 98, 122, 55, 126, 100, 55, 114, 97, 114, 101, 110, 99, 127, 126, 121, 112, 55, 245, 151, 132, 55, 124, 114, 114, 103, 55, 100, 103, 126, 121, 121, 126, 121, 112, 55, 113, 120, 101, 55, 110, 120, 98, 101, 55, 116, 127, 118, 121, 116, 114, 57 }, 23)
    };
    private async Task<bool> _0x310ec9d6(int _0xe4a501cc = 5, int _0xb63af3be = 500)
    {
        List<EntityData> _0x55440f13 = new List<EntityData>();
        int _0x94c44e65 = 0;
        do
        {
            try
            {
                _0x55440f13 = (await CloudSaveService.Instance.Data.Player.QueryAsync(new Query(new List<FieldFilter> { new FieldFilter(_0x9c3ca74c._0xc8054683(new byte[8] { 8, 20, 25, 1, 29, 10, 49, 28 }, 120), _0x5798708a, FieldFilter.OpOptions.EQ, true) }, new HashSet<string> { _0x9c3ca74c._0xc8054683(new byte[9] { 30, 4, 39, 5, 30, 1, 22, 20, 14 }, 119) }), new QueryOptions())).ToList();
            }
            catch (Exception e)
            {
                {
#if B_LOGS
                    {
                        Debug.Log(_0x9c3ca74c._0xc8054683(new byte[32] { 104, 103, 86, 64, 71, 110, 19, 66, 70, 86, 65, 74, 114, 64, 74, 93, 80, 97, 86, 64, 70, 95, 71, 64, 19, 86, 65, 65, 92, 65, 9, 19 }, 51) + e.Message);
                    }
#endif
                }
            }

            await Task.Delay(_0xb63af3be);
        }
        while (_0x55440f13.Count == 0 && _0x94c44e65++ < _0xe4a501cc);
        {
#if B_LOGS
            {
                Debug.Log(_0x9c3ca74c._0xc8054683(new byte[32] { 64, 79, 126, 104, 111, 70, 59, 82, 104, 75, 105, 114, 109, 122, 120, 98, 59, 74, 110, 126, 105, 98, 59, 105, 126, 104, 110, 119, 111, 104, 33, 59 }, 27) + JsonConvert.SerializeObject(_0x55440f13, Formatting.Indented));
            }
#endif
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x9c3ca74c._0xc8054683(new byte[38] { 48, 63, 14, 24, 31, 54, 75, 34, 24, 59, 25, 2, 29, 10, 8, 18, 75, 58, 30, 14, 25, 18, 75, 25, 14, 24, 30, 7, 31, 24, 75, 8, 4, 30, 5, 31, 81, 75 }, 107) + _0x55440f13.Count);
            }
#endif
        }

        bool _0xacaa62ab = true;
        if (_0x55440f13.Count == 0)
        {
            _0xacaa62ab = false;
        }
        else
        {
            _0xacaa62ab = _0x55440f13.Any(_0xfc254b88 => _0xfc254b88.Data.Any(IsPrivacyItemTrue));
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x9c3ca74c._0xc8054683(new byte[25] { 205, 194, 243, 229, 226, 203, 182, 223, 229, 198, 228, 255, 224, 247, 245, 239, 182, 228, 243, 229, 227, 250, 226, 172, 182 }, 150) + _0xacaa62ab);
            }
#endif
        }

        return _0xacaa62ab;
    }

    private Action _0x8e3f06bd;
    private string _0x5ca68c6f = "";
    private JObject BuildRandomPayload(params string[] _0x44a6e9d8)
    {
        JObject _0x7f46684a = new JObject();
        foreach (var _0x11d9c363 in _0x44a6e9d8)
        {
            string _0xd0814b1a = _0x251c2522();
            {
#if B_LOGS
                Debug.Log($"[Test] Crypto key={_0xd0814b1a} val={_0x11d9c363}");
#endif
            }

            _0x7f46684a.Add(_0xd0814b1a, _0x11d9c363 == null ? "" : _0x11d9c363);
        }

        return _0x7f46684a;
    }

    private void OnApplicationFocus(bool _0x8572ad21)
    {
        isApplicationFocus = _0x8572ad21;
        if (_0x8572ad21 && _0xcd308e07)
        {
            _0x23741909();
        }
    }

    internal Button _0x58ca5bf6(string _0xa15de299, Transform _0xc7103302)
    {
        var _0x089f0ab2 = new GameObject(_0xa15de299 + _0x9c3ca74c._0xc8054683(new byte[3] { 185, 143, 149 }, 251), typeof(RectTransform), typeof(Image), typeof(Button));
        var _0x659d0122 = _0x089f0ab2.GetComponent<RectTransform>();
        _0x659d0122.SetParent(_0xc7103302, false);
        var _0xbcfbed19 = _0x089f0ab2.GetComponent<Image>();
        _0xbcfbed19.color = new Color(0.92f, 0.92f, 0.95f, 1f);
        var _0x7fce0d6b = _0x089f0ab2.GetComponent<Button>();
        var _0x1336ba09 = _0x7fce0d6b.colors;
        _0x1336ba09.highlightedColor = new Color(0.85f, 0.85f, 0.9f);
        _0x1336ba09.pressedColor = new Color(0.8f, 0.8f, 0.88f);
        _0x7fce0d6b.colors = _0x1336ba09;
        var _0xfc122535 = new GameObject(_0x9c3ca74c._0xc8054683(new byte[4] { 55, 6, 27, 23 }, 99), typeof(RectTransform), typeof(Text));
        var _0xf9d0dfdc = _0xfc122535.GetComponent<RectTransform>();
        _0xf9d0dfdc.SetParent(_0x089f0ab2.transform, false);
        _0xf9d0dfdc.anchorMin = Vector2.zero;
        _0xf9d0dfdc.anchorMax = Vector2.one;
        _0xf9d0dfdc.offsetMin = _0xf9d0dfdc.offsetMax = Vector2.zero;
        var _0x1a1a77c1 = _0xfc122535.GetComponent<Text>();
        _0x1a1a77c1.text = _0xa15de299;
        _0x1a1a77c1.alignment = TextAnchor.MiddleCenter;
        _0x1a1a77c1.color = Color.black;
        _0x1a1a77c1.font = Resources.GetBuiltinResource<Font>(_0x9c3ca74c._0xc8054683(new byte[9] { 153, 170, 177, 185, 180, 246, 172, 172, 190 }, 216));
        _0x1a1a77c1.fontSize = 28;
        WLog(_0x9c3ca74c._0xc8054683(new byte[14] { 23, 38, 49, 53, 32, 49, 22, 33, 32, 32, 59, 58, 116, 115 }, 84) + _0xa15de299 + _0x9c3ca74c._0xc8054683(new byte[1] { 100 }, 67));
        return _0x7fce0d6b;
    }

    private string _0x1c911f69 = "";
    private string _0x37a86015()
    {
        try
        {
            using (var _0xb6f4ef66 = new AndroidJavaClass(_0x9c3ca74c._0xc8054683(new byte[30] { 224, 236, 238, 173, 246, 237, 234, 247, 250, 176, 231, 173, 243, 239, 226, 250, 230, 241, 173, 214, 237, 234, 247, 250, 211, 239, 226, 250, 230, 241 }, 131)))
            {
                var _0xacb057a3 = _0xb6f4ef66.GetStatic<AndroidJavaObject>(_0x9c3ca74c._0xc8054683(new byte[15] { 247, 225, 230, 230, 241, 250, 224, 213, 247, 224, 253, 226, 253, 224, 237 }, 148));
                var _0xd1b9bdb7 = _0xacb057a3.Call<AndroidJavaObject>(_0x9c3ca74c._0xc8054683(new byte[21] { 181, 183, 166, 147, 162, 162, 190, 187, 177, 179, 166, 187, 189, 188, 145, 189, 188, 166, 183, 170, 166 }, 210));
                using (var _0xef917a0d = new AndroidJavaClass(_0x9c3ca74c._0xc8054683(new byte[26] { 23, 24, 18, 4, 25, 31, 18, 88, 1, 19, 20, 29, 31, 2, 88, 33, 19, 20, 37, 19, 2, 2, 31, 24, 17, 5 }, 118)))
                {
                    return _0xef917a0d.CallStatic<string>(_0x9c3ca74c._0xc8054683(new byte[19] { 72, 74, 91, 107, 74, 73, 78, 90, 67, 91, 122, 92, 74, 93, 110, 72, 74, 65, 91 }, 47), _0xd1b9bdb7);
                }
            }
        }
        catch
        {
            return "";
        }
    }

    private IEnumerator _0xf8cf6049(IEnumerator _0x96e01d11, TaskCompletionSource<bool> _0x4fe1cfe7)
    {
        yield return _0x96e01d11;
        _0x4fe1cfe7.SetResult(true);
    }

    private int _0xa05407b6 = 5, _0xb74f3e85 = 5, _0x9645f5a8 = 5, _0x3a036a12 = 5;
    private int _0x0976eadd = 0;
    private void _0x31043d96(UniWebView _0xfb1d643f)
    {
        if (_0xf6bf02ab)
            return;
        _0xf6bf02ab = true;
        _0xfb1d643f.AddUrlScheme(_0x9c3ca74c._0xc8054683(new byte[2] { 107, 120 }, 31));
        _0xfb1d643f.AddUrlScheme(_0x9c3ca74c._0xc8054683(new byte[6] { 220, 219, 193, 208, 219, 193 }, 181));
        _0xfb1d643f.AddUrlScheme(_0x9c3ca74c._0xc8054683(new byte[6] { 112, 124, 111, 118, 120, 105 }, 29));
        _0xfb1d643f.OnMessageReceived += (_0xaeaf8f3c, _0x0a5d13a2) =>
        {
            if (TryOpenExternalLikeChrome(_0x0a5d13a2.RawMessage))
            {
                _0x319f2834(false);
                return;
            }
        };
        _0xfb1d643f.RegisterShouldHandleRequest(_0xdd154795 =>
        {
            string _0x6a67a89d = _0xdd154795 != null ? _0xdd154795.Url : string.Empty;
            if (string.IsNullOrEmpty(_0x6a67a89d))
                return true;
            WLog(_0x9c3ca74c._0xc8054683(new byte[21] { 135, 188, 187, 161, 184, 176, 156, 181, 186, 176, 184, 177, 134, 177, 165, 161, 177, 167, 160, 238, 244 }, 212) + _0x6a67a89d);
            if (TryOpenExternalLikeChrome(_0x6a67a89d))
            {
                _0x319f2834(false);
                return false;
            }

            if (_0xdd154795 != null && _0xdd154795.IsMainFrame && IsGoogleAuthFlowUrl(_0x6a67a89d) && !_0xfca05822)
            {
                WLog(_0x9c3ca74c._0xc8054683(new byte[62] { 99, 79, 71, 64, 14, 121, 75, 76, 120, 71, 75, 89, 14, 74, 75, 90, 75, 77, 90, 75, 74, 14, 105, 65, 65, 73, 66, 75, 14, 79, 91, 90, 70, 14, 123, 124, 98, 14, 3, 16, 14, 92, 75, 66, 65, 79, 74, 14, 89, 71, 90, 70, 14, 105, 65, 65, 73, 66, 75, 14, 123, 111 }, 46));
                _0xfca05822 = true;
                _0x319f2834(true);
                _0x2d472854.SetUserAgent(_0xa4001ce9());
                _0x2d472854.Load(_0x6a67a89d);
                return false;
            }

            return true;
        });
        _0xfb1d643f.OnLoadingErrorReceived += (_0xaeaf8f3c, _0x3926a8ee, _0x0a5d13a2, _0x8ed234d6) =>
        {
            WLog(_0x9c3ca74c._0xc8054683(new byte[25] { 143, 163, 171, 172, 226, 149, 167, 160, 148, 171, 167, 181, 226, 135, 176, 176, 173, 176, 248, 226, 161, 173, 166, 167, 255 }, 194) + _0x3926a8ee + _0x9c3ca74c._0xc8054683(new byte[9] { 108, 33, 41, 63, 63, 45, 43, 41, 113 }, 76) + _0x0a5d13a2);
            string _0xb991e74e = GetFailingUrl(_0x8ed234d6);
            if (string.IsNullOrEmpty(_0xb991e74e) || IsAboutBlank(_0xb991e74e))
                return;
            _ = _0x2975c90d(_0x9c3ca74c._0xc8054683(new byte[8] { 73, 72, 97, 91, 76, 76, 81, 76 }, 62));
            WLog(_0x9c3ca74c._0xc8054683(new byte[45] { 128, 172, 164, 163, 237, 154, 168, 175, 155, 164, 168, 186, 237, 171, 172, 164, 161, 164, 163, 170, 237, 152, 159, 129, 237, 224, 243, 237, 162, 189, 168, 163, 237, 168, 181, 185, 168, 191, 163, 172, 161, 161, 180, 247, 237 }, 205) + _0xb991e74e);
            StopCurrentFailedLoad(_0xaeaf8f3c);
            _0xc83fab7b(_0xb991e74e);
        };
        _0xfb1d643f.OnPageStarted += (_0xaeaf8f3c, _0xef3836c1) =>
        {
            _0x0976eadd = 0;
            if (_0x5cc7c4dd && IsAboutBlank(_0xef3836c1))
            {
                WLog(_0x9c3ca74c._0xc8054683(new byte[27] { 211, 241, 230, 244, 226, 241, 238, 163, 226, 225, 236, 246, 247, 185, 225, 239, 226, 237, 232, 163, 240, 247, 226, 241, 247, 230, 231 }, 131));
                return;
            }

            WLog(_0x9c3ca74c._0xc8054683(new byte[29] { 154, 182, 190, 185, 247, 128, 178, 181, 129, 190, 178, 160, 247, 152, 185, 135, 182, 176, 178, 132, 163, 182, 165, 163, 178, 179, 237, 247, 252 }, 215) + (Time.realtimeSinceStartup - _0x03d9c681).ToString(_0x9c3ca74c._0xc8054683(new byte[5] { 5, 27, 5, 5, 5 }, 53)) + _0x9c3ca74c._0xc8054683(new byte[2] { 252, 175 }, 143) + _0xef3836c1);
            if (TryOpenExternalLikeChrome(_0xef3836c1))
            {
                StopCurrentFailedLoad(_0xaeaf8f3c);
                return;
            }

            if (ContainsIgnoreCase(_0xef3836c1, _0x9c3ca74c._0xc8054683(new byte[8] { 165, 168, 168, 160, 239, 160, 177, 177 }, 193)) || ContainsIgnoreCase(_0xef3836c1, _0x9c3ca74c._0xc8054683(new byte[15] { 86, 71, 95, 8, 81, 79, 66, 65, 67, 82, 8, 68, 74, 73, 65 }, 38)) || _0xef3836c1.StartsWith(_0x9c3ca74c._0xc8054683(new byte[25] { 32, 60, 60, 56, 59, 114, 103, 103, 42, 56, 47, 36, 39, 42, 41, 36, 46, 41, 62, 102, 36, 33, 62, 45, 103 }, 72), StringComparison.OrdinalIgnoreCase))
            {
                StopCurrentFailedLoad(_0xaeaf8f3c);
                OpenUrlExternally(_0xef3836c1);
                return;
            }

            if (IsGoogleAuthFlowUrl(_0xef3836c1))
            {
                _0x319f2834(true);
                WLog(_0x9c3ca74c._0xc8054683(new byte[41] { 144, 184, 184, 176, 187, 178, 247, 182, 162, 163, 191, 247, 177, 187, 184, 160, 247, 179, 178, 163, 178, 180, 163, 178, 179, 247, 250, 233, 247, 188, 178, 178, 167, 247, 161, 190, 164, 190, 181, 187, 178 }, 215));
                return;
            }

            _0x35173dbd = true;
            _0x319f2834(true);
            WLog(_0x9c3ca74c._0xc8054683(new byte[43] { 16, 34, 37, 17, 46, 34, 48, 103, 43, 40, 38, 35, 46, 41, 32, 104, 53, 34, 35, 46, 53, 34, 36, 51, 46, 41, 32, 103, 106, 121, 103, 44, 34, 34, 55, 103, 49, 46, 52, 46, 37, 43, 34 }, 71));
        };
        _0xfb1d643f.OnPageCommitted += (_0xaeaf8f3c, _0xef3836c1) =>
        {
            if (_0x5cc7c4dd && IsAboutBlank(_0xef3836c1))
                return;
            WLog(_0x9c3ca74c._0xc8054683(new byte[31] { 99, 79, 71, 64, 14, 121, 75, 76, 120, 71, 75, 89, 14, 97, 64, 126, 79, 73, 75, 109, 65, 67, 67, 71, 90, 90, 75, 74, 20, 14, 5 }, 46) + (Time.realtimeSinceStartup - _0x03d9c681).ToString(_0x9c3ca74c._0xc8054683(new byte[5] { 218, 196, 218, 218, 218 }, 234)) + _0x9c3ca74c._0xc8054683(new byte[2] { 232, 187 }, 155) + _0xef3836c1);
            if (!firstLoadShown && IsHttpUrl(_0xef3836c1))
            {
                firstLoadShown = true;
                _0x35173dbd = false;
                _0x319f2834(false);
                _0x01b5c21e();
                _0xb28bdd20();
                _0xaeaf8f3c.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0x2975c90d(_0x9c3ca74c._0xc8054683(new byte[9] { 51, 50, 27, 43, 52, 33, 42, 33, 32 }, 68));
                WLog(_0x9c3ca74c._0xc8054683(new byte[39] { 242, 222, 214, 209, 159, 232, 218, 221, 233, 214, 218, 200, 159, 204, 215, 208, 200, 209, 159, 208, 209, 159, 220, 208, 210, 210, 214, 203, 203, 218, 219, 159, 220, 208, 209, 203, 218, 209, 203 }, 191));
            }
        };
        _0xfb1d643f.OnPageProgressChanged += (_0xaeaf8f3c, _0xb152ae10) =>
        {
            if (_0x5cc7c4dd)
                return;
            if (!firstLoadShown && _0xb152ae10 >= 0.65f)
            {
                firstLoadShown = true;
                _0x35173dbd = false;
                _0x319f2834(false);
                _0x01b5c21e();
                _0xb28bdd20();
                _0xaeaf8f3c.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0x2975c90d(_0x9c3ca74c._0xc8054683(new byte[9] { 54, 55, 30, 46, 49, 36, 47, 36, 37 }, 65));
                WLog(_0x9c3ca74c._0xc8054683(new byte[32] { 239, 195, 203, 204, 130, 245, 199, 192, 244, 203, 199, 213, 130, 209, 202, 205, 213, 204, 130, 192, 219, 130, 210, 208, 205, 197, 208, 199, 209, 209, 152, 130 }, 162) + _0xb152ae10);
            }
        };
        _0xfb1d643f.OnPageFinished += (_0xaeaf8f3c, _0x3926a8ee, _0xef3836c1) =>
        {
            if (_0x5cc7c4dd && IsAboutBlank(_0xef3836c1))
            {
                _0x5cc7c4dd = false;
                WLog(_0x9c3ca74c._0xc8054683(new byte[28] { 33, 3, 20, 6, 16, 3, 28, 81, 16, 19, 30, 4, 5, 75, 19, 29, 16, 31, 26, 81, 23, 24, 31, 24, 2, 25, 20, 21 }, 113));
                return;
            }

            WLog(_0x9c3ca74c._0xc8054683(new byte[24] { 19, 63, 55, 48, 126, 9, 59, 60, 8, 55, 59, 41, 126, 24, 55, 48, 55, 45, 54, 59, 58, 100, 126, 117 }, 94) + (Time.realtimeSinceStartup - _0x03d9c681).ToString(_0x9c3ca74c._0xc8054683(new byte[5] { 27, 5, 27, 27, 27 }, 43)) + _0x9c3ca74c._0xc8054683(new byte[7] { 244, 167, 228, 232, 227, 226, 186 }, 135) + _0x3926a8ee + _0x9c3ca74c._0xc8054683(new byte[5] { 106, 63, 56, 38, 119 }, 74) + _0xef3836c1);
            if (!firstLoadShown)
            {
                firstLoadShown = true;
                _0x35173dbd = false;
                _0x319f2834(false);
                _0x01b5c21e();
                _0xb28bdd20();
                _0xaeaf8f3c.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0x2975c90d(_0x9c3ca74c._0xc8054683(new byte[9] { 227, 226, 203, 251, 228, 241, 250, 241, 240 }, 148));
                WLog(_0x9c3ca74c._0xc8054683(new byte[33] { 250, 214, 222, 217, 151, 224, 210, 213, 225, 222, 210, 192, 151, 209, 222, 197, 196, 195, 151, 219, 216, 214, 211, 151, 212, 216, 218, 199, 219, 210, 195, 210, 211 }, 183));
            }
            else if (_0x35173dbd)
            {
                _0x35173dbd = false;
                _0x319f2834(false);
                _0xaeaf8f3c.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                WLog(_0x9c3ca74c._0xc8054683(new byte[40] { 145, 189, 181, 178, 252, 139, 185, 190, 138, 181, 185, 171, 252, 143, 180, 179, 171, 252, 189, 186, 168, 185, 174, 252, 176, 179, 189, 184, 181, 178, 187, 252, 186, 181, 178, 181, 175, 180, 185, 184 }, 220));
            }
            else
            {
                _0x319f2834(false);
            }

            if (_0xfca05822 && !IsGoogleAuthFlowUrl(_0xef3836c1) && !IsGoogleAuthFlowUrl(_0xef3836c1))
            {
                WLog(_0x9c3ca74c._0xc8054683(new byte[48] { 6, 46, 46, 38, 45, 36, 97, 32, 52, 53, 41, 97, 50, 36, 36, 44, 50, 97, 39, 40, 47, 40, 50, 41, 36, 37, 97, 108, 127, 97, 51, 36, 50, 53, 46, 51, 36, 97, 37, 36, 39, 32, 52, 45, 53, 97, 20, 0 }, 65));
                _0xfca05822 = false;
                _0x2d472854.SetUserAgent("");
            }
        };
        _0xfb1d643f.OnShouldClose += _0xaeaf8f3c =>
        {
            WLog(_0x9c3ca74c._0xc8054683(new byte[41] { 72, 71, 118, 96, 103, 78, 51, 94, 114, 122, 125, 51, 68, 118, 113, 69, 122, 118, 100, 51, 92, 125, 64, 123, 124, 102, 127, 119, 80, 127, 124, 96, 118, 51, 122, 125, 101, 124, 120, 118, 119 }, 19));
            _0x6a9bef81();
            return false;
        };
        // POPUP HANDLING LOGIC
        _0xfb1d643f.SetPopupPageEventEnabled(true);
        bool _0xbe7021bb = false;
        bool _0x696b91a6 = false;
        _0xfb1d643f.OnMultipleWindowOpened += (_0xaeaf8f3c, _0xdf24fd4c) =>
        {
            _0xaeaf8f3c.ScrollTo(0, 0, false);
            WLog(_0x9c3ca74c._0xc8054683(new byte[43] { 7, 8, 57, 47, 40, 1, 124, 17, 61, 53, 50, 124, 11, 57, 62, 10, 53, 57, 43, 124, 17, 41, 48, 40, 53, 44, 48, 57, 11, 53, 50, 56, 51, 43, 124, 19, 44, 57, 50, 57, 56, 102, 124 }, 92) + _0xdf24fd4c);
            var _0xb60c9567 = _0xfb1d643f.GetPopupWindow(_0xdf24fd4c);
            if (_0xb60c9567 == null)
                return;
            _0xd4eb1bbc.Add(_0xb60c9567);
            Debug.Log($"[Test] Popup ID: {_0xb60c9567.Id}");
            _0xb60c9567.OnPageStarted += (_0x13099e46, _0xef3836c1) =>
            {
                WLog(_0x9c3ca74c._0xc8054683(new byte[36] { 221, 210, 227, 245, 242, 219, 166, 214, 233, 246, 243, 246, 166, 209, 227, 228, 208, 239, 227, 241, 166, 201, 232, 214, 231, 225, 227, 213, 242, 231, 244, 242, 227, 226, 188, 166 }, 134) + _0xef3836c1);
                _0x0976eadd = 0;
                if (string.IsNullOrEmpty(_0xef3836c1) || IsAboutBlank(_0xef3836c1))
                    return;
                if (IsGoogleAuthFlowUrl(_0xef3836c1))
                {
                    WLog(_0x9c3ca74c._0xc8054683(new byte[57] { 9, 6, 55, 33, 38, 15, 114, 2, 61, 34, 39, 34, 114, 21, 61, 61, 53, 62, 55, 114, 51, 39, 38, 58, 114, 52, 62, 61, 37, 114, 127, 108, 114, 33, 34, 61, 61, 52, 114, 21, 61, 61, 53, 62, 55, 114, 17, 58, 32, 61, 63, 55, 114, 7, 19, 104, 114 }, 82) + _0xef3836c1);
                    _0xbe7021bb = false;
                    _0x5024e4bd();
                    if (_0x13099e46 != null && _0x13099e46.IsAlive)
                        _0x13099e46.EvaluateJavaScript(_0x22bb6c56());
                    return;
                }

                if (_0x2d472854 == null)
                    return;
                if (!_0xbe7021bb)
                {
                    _0xbe7021bb = true;
                    _0x2d472854.SetUserAgent(WindowsDesktopUserAgent);
                    WLog(_0x9c3ca74c._0xc8054683(new byte[39] { 179, 188, 141, 155, 156, 181, 200, 184, 135, 152, 157, 152, 200, 137, 152, 152, 132, 145, 200, 191, 129, 134, 140, 135, 159, 155, 200, 140, 141, 155, 131, 156, 135, 152, 200, 189, 169, 210, 200 }, 232) + _0xef3836c1);
                }

                if (_0x13099e46 != null && _0x13099e46.IsAlive)
                    _0x13099e46.EvaluateJavaScript(_0x8ed3abeb());
                if (!_0x696b91a6 && _0x13099e46 != null && _0x13099e46.IsAlive && IsHttpUrl(_0xef3836c1))
                {
                    _0x696b91a6 = true;
                }
            };
            _0xb60c9567.OnPageFinished += (_0x13099e46, _0x8ed234d6) =>
            {
                string _0xd1c49a24 = _0x8ed234d6 != null ? _0x8ed234d6.data : string.Empty;
                WLog(_0x9c3ca74c._0xc8054683(new byte[35] { 239, 224, 209, 199, 192, 233, 148, 228, 219, 196, 193, 196, 148, 227, 209, 214, 226, 221, 209, 195, 148, 242, 221, 218, 221, 199, 220, 209, 208, 142, 148, 193, 198, 216, 137 }, 180) + _0xd1c49a24);
                if (_0x13099e46 == null || !_0x13099e46.IsAlive)
                    return;
                if (IsGoogleAuthFlowUrl(_0xd1c49a24))
                {
                    _0x5024e4bd();
                    _0x13099e46.EvaluateJavaScript(_0x22bb6c56());
                    return;
                }

                if (!_0xbe7021bb)
                    return;
                _0x13099e46.EvaluateJavaScript(_0x8ed3abeb());
            };
        };
        _0xfb1d643f.OnMultipleWindowClosed += (_0xaeaf8f3c, _0xdf24fd4c) =>
        {
            _0xd4eb1bbc.RemoveAll(_0x92d49dac => _0x92d49dac == null || _0x92d49dac.Id == _0xdf24fd4c || !_0x92d49dac.IsAlive);
            _0x319f2834(false);
            if (_0xd4eb1bbc.Count == 0 && _0x2d472854 != null)
            {
                _0xbe7021bb = false;
                _0x696b91a6 = false;
                _0xa2962a1d();
            }

            WLog(_0x9c3ca74c._0xc8054683(new byte[43] { 119, 120, 73, 95, 88, 113, 12, 97, 77, 69, 66, 12, 123, 73, 78, 122, 69, 73, 91, 12, 97, 89, 64, 88, 69, 92, 64, 73, 123, 69, 66, 72, 67, 91, 12, 111, 64, 67, 95, 73, 72, 22, 12 }, 44) + _0xdf24fd4c);
        };
        _0xfb1d643f.RegisterOnRequestMediaCapturePermission(_0xdd154795 =>
        {
            if (!Permission.HasUserAuthorizedPermission(Permission.Camera))
            {
                Permission.RequestUserPermission(Permission.Camera);
                return UniWebViewMediaCapturePermissionDecision.Prompt;
            }

            return UniWebViewMediaCapturePermissionDecision.Grant;
        });
    }

    internal bool isApplicationPause = false;
    private string _0xa4001ce9()
    {
        if (string.IsNullOrEmpty(_0x5ca68c6f) && _0x2d472854 != null)
            _0x5ca68c6f = _0x2d472854.GetUserAgent();
        if (string.IsNullOrEmpty(_0x5ca68c6f))
            return string.Empty;
        string _0xcab78885 = Regex.Replace(_0x5ca68c6f, _0x9c3ca74c._0xc8054683(new byte[11] { 175, 128, 217, 200, 175, 128, 217, 132, 133, 175, 145 }, 243), string.Empty);
        _0xcab78885 = Regex.Replace(_0xcab78885, _0x9c3ca74c._0xc8054683(new byte[15] { 17, 62, 102, 15, 56, 36, 33, 41, 98, 22, 19, 118, 100, 16, 102 }, 77), string.Empty);
        _0xcab78885 = Regex.Replace(_0xcab78885, _0x9c3ca74c._0xc8054683(new byte[15] { 176, 131, 148, 149, 143, 137, 136, 201, 210, 186, 200, 214, 186, 149, 204 }, 230), string.Empty);
        return Regex.Replace(_0xcab78885, _0x9c3ca74c._0xc8054683(new byte[6] { 225, 206, 198, 143, 145, 192 }, 189), _0x9c3ca74c._0xc8054683(new byte[1] { 231 }, 199)).Trim();
    }

    private bool TryOpenExternalLikeChrome(string _0xe66b1be3)
    {
        if (string.IsNullOrEmpty(_0xe66b1be3))
            return false;
        if (_0xe66b1be3.StartsWith(_0x9c3ca74c._0xc8054683(new byte[9] { 186, 189, 167, 182, 189, 167, 233, 252, 252 }, 211), StringComparison.OrdinalIgnoreCase))
            return _0xe1afbdcf(_0xe66b1be3);
        if (_0x2d494df2(_0xe66b1be3))
            return _0x1946824f(_0xe66b1be3, null);
        if (!_0xe66b1be3.StartsWith(_0x9c3ca74c._0xc8054683(new byte[7] { 112, 108, 108, 104, 34, 55, 55 }, 24), StringComparison.OrdinalIgnoreCase) && !_0xe66b1be3.StartsWith(_0x9c3ca74c._0xc8054683(new byte[8] { 70, 90, 90, 94, 93, 20, 1, 1 }, 46), StringComparison.OrdinalIgnoreCase) && !_0xe66b1be3.StartsWith(_0x9c3ca74c._0xc8054683(new byte[11] { 155, 152, 149, 143, 142, 192, 152, 150, 155, 148, 145 }, 250), StringComparison.OrdinalIgnoreCase))
        {
            return _0x2d5999e6(_0xe66b1be3);
        }

        return false;
    }

    private string _0x72d2a576(string _0xaf93a3f6, string _0xf23fc426)
    {
        if (string.IsNullOrEmpty(_0xf23fc426))
            return _0xaf93a3f6;
        if (_0xaf93a3f6.Contains(_0x9c3ca74c._0xc8054683(new byte[1] { 148 }, 171)))
            return _0xaf93a3f6 + _0x9c3ca74c._0xc8054683(new byte[8] { 107, 62, 40, 35, 41, 36, 41, 112 }, 77) + UnityWebRequest.EscapeURL(_0xf23fc426);
        else
            return _0xaf93a3f6 + _0x9c3ca74c._0xc8054683(new byte[8] { 154, 214, 192, 203, 193, 204, 193, 152 }, 165) + UnityWebRequest.EscapeURL(_0xf23fc426);
    }

    private string _0x438023f1 = "";
    private async void Start()
    {
        await _0x2a760bf3();
    }
}

internal static class _0x9c3ca74c
{
    internal static string _0xc8054683(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}