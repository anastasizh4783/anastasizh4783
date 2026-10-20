using UnityEngine;
using UnityEngine.UI;

public class _0x2ff07bd5 : MonoBehaviour
{
    public int PopToShowIndex;
    private void Start()
    {
        if (this.IsShowLastPop)
            this.Button.onClick.AddListener(() =>
            {
                _0xae24774e.Instance._0x5826703b();
            });
        else if (this.IsHideAllPops)
            this.Button.onClick.AddListener(() => _0xae24774e.Instance._0x6a384f5d());
        else
            this.Button.onClick.AddListener(() => _0xae24774e.Instance._0x2e2888c9(this.PopToShowIndex));
    }

    public bool IsShowLastPop;
    public bool IsHideAllPops;
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    public Button Button;
}