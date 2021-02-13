// GENERATED AUTOMATICALLY FROM 'Assets/Inputs/PlayerInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""629a778c-dcda-42a6-b1a7-65a40454fa6e"",
            ""actions"": [
                {
                    ""name"": ""ThruoghKnife"",
                    ""type"": ""Button"",
                    ""id"": ""59678197-eaa5-402f-b857-ea546ec36e69"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ChooseKnife"",
                    ""type"": ""PassThrough"",
                    ""id"": ""53f911e3-bc04-474b-a7a5-1811054be450"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""07d79518-2755-4297-9d7b-812418a0d299"",
                    ""path"": ""<Touchscreen>/primaryTouch/tap"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""TouchScreen"",
                    ""action"": ""ThruoghKnife"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""75b1272e-7f64-4687-9851-2ed45268e6be"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse"",
                    ""action"": ""ThruoghKnife"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5aca9915-09c0-4729-82c8-a3b374673261"",
                    ""path"": ""<Touchscreen>/delta/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""TouchScreen"",
                    ""action"": ""ChooseKnife"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Mouse"",
            ""bindingGroup"": ""Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""TouchScreen"",
            ""bindingGroup"": ""TouchScreen"",
            ""devices"": [
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_ThruoghKnife = m_Player.FindAction("ThruoghKnife", throwIfNotFound: true);
        m_Player_ChooseKnife = m_Player.FindAction("ChooseKnife", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_ThruoghKnife;
    private readonly InputAction m_Player_ChooseKnife;
    public struct PlayerActions
    {
        private @PlayerInput m_Wrapper;
        public PlayerActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @ThruoghKnife => m_Wrapper.m_Player_ThruoghKnife;
        public InputAction @ChooseKnife => m_Wrapper.m_Player_ChooseKnife;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @ThruoghKnife.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnThruoghKnife;
                @ThruoghKnife.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnThruoghKnife;
                @ThruoghKnife.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnThruoghKnife;
                @ChooseKnife.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChooseKnife;
                @ChooseKnife.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChooseKnife;
                @ChooseKnife.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChooseKnife;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @ThruoghKnife.started += instance.OnThruoghKnife;
                @ThruoghKnife.performed += instance.OnThruoghKnife;
                @ThruoghKnife.canceled += instance.OnThruoghKnife;
                @ChooseKnife.started += instance.OnChooseKnife;
                @ChooseKnife.performed += instance.OnChooseKnife;
                @ChooseKnife.canceled += instance.OnChooseKnife;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    private int m_MouseSchemeIndex = -1;
    public InputControlScheme MouseScheme
    {
        get
        {
            if (m_MouseSchemeIndex == -1) m_MouseSchemeIndex = asset.FindControlSchemeIndex("Mouse");
            return asset.controlSchemes[m_MouseSchemeIndex];
        }
    }
    private int m_TouchScreenSchemeIndex = -1;
    public InputControlScheme TouchScreenScheme
    {
        get
        {
            if (m_TouchScreenSchemeIndex == -1) m_TouchScreenSchemeIndex = asset.FindControlSchemeIndex("TouchScreen");
            return asset.controlSchemes[m_TouchScreenSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnThruoghKnife(InputAction.CallbackContext context);
        void OnChooseKnife(InputAction.CallbackContext context);
    }
}
