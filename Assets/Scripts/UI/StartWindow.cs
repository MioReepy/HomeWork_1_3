using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI
{
    public class StartWindow : WindowBase
    {
        [SerializeField] private Button _setingsButton;
        [SerializeField] private Button _startButton;

        public override WindowType Type => WindowType.Start;
        public override bool IsPopup => false;

        private void Start()
        {
            _setingsButton.onClick.AddListener(OnSettingsButtonClick);
            _startButton.onClick.AddListener(OnStartButtonClick);
        }

        private void OnStartButtonClick()
        {
            UISystem.Instance.OpenWindow(WindowType.SelectStage, false);
        }

        private void OnSettingsButtonClick()
        {
            UISystem.Instance.OpenWindow(WindowType.Setting, true);    
        }
    }
}