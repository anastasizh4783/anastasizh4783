using UnityEngine;
using UnityEngine.UI;

public class _0x32f0acff : MonoBehaviour
{
    private bool _0x59318129;
    private void Start()
    {
        if (this._0x59318129)
            this._0x18e59ae4.onClick.AddListener(() => _0xf933b7ea.Instance._0x3a769aa4());
        else
            this._0x18e59ae4.onClick.AddListener(() => _0xf933b7ea.Instance._0x5472689a(this._0xcb3ef53f));
    }

    private void Awake()
    {
        if (this._0x18e59ae4 == null)
            if (!this.TryGetComponent(out this._0x18e59ae4))
                this._0x18e59ae4 = this.GetComponentInChildren<Button>();
    }

    private Button _0x18e59ae4;
    private int _0xcb3ef53f;
}