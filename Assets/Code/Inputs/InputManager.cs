using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : Singleton<InputManager>
{
    private PlayerInputActions playerInputActions;
    private PlayerInputActions.UIActions gameplayInputs;

    public bool ClickPressed { get; private set; }


    protected override void Awake()
    {
        base.Awake();
  
        playerInputActions = new PlayerInputActions();

        // string overrides = PlayerPrefs.GetString("remapped-hotkeys", "");
        // if (!string.IsNullOrEmpty(overrides))
        // {
        //     playerInputActions.asset.LoadBindingOverridesFromJson(overrides);
        // }

        gameplayInputs = playerInputActions.UI;
    }

    private void OnEnable()
    {
        playerInputActions.Enable();
    }

    private void OnDisable()
    {
        if (Instance == this && playerInputActions != null)
        {
            playerInputActions.Disable();
        }
    }

    private void Update()
    {
        ClickPressed = gameplayInputs.Click.WasPressedThisFrame();
    }
}
