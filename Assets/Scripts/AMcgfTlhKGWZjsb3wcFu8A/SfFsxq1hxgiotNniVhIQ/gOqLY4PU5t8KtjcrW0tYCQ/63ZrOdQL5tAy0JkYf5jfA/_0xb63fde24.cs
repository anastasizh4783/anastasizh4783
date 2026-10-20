using UnityEngine;
using UnityEngine.UI;

public class _0xb63fde24 : MonoBehaviour
{
    public int NextTutorialPanelIndex;
    public bool IsTutorialEndPanel;
    public Button TutorialEndButton;
    private void Start()
    {
        if (this.NextTutorialButton != null)
        {
            if (this.IsTutorialEndPanel)
            {
                this.NextTutorialButton.onClick.AddListener(() => _0xf933b7ea.Instance._0x5472689a(this.EndTutorialPanelIndex));
                this.NextTutorialButton.onClick.AddListener(() => _0xa4f22d18.Instance._0x629d171f());
            }
            else
            {
                this.NextTutorialButton.onClick.AddListener(() => _0xf933b7ea.Instance._0x5472689a(this.NextTutorialPanelIndex));
            }
        }

        if (this.TutorialEndButton != null)
        {
            this.TutorialEndButton.onClick.AddListener(() => _0xf933b7ea.Instance._0x5472689a(this.EndTutorialPanelIndex));
            this.TutorialEndButton.onClick.AddListener(() => _0xa4f22d18.Instance._0x629d171f());
        }
    }

    public int EndTutorialPanelIndex = 1;
    public Button NextTutorialButton;
}