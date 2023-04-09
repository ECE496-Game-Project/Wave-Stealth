//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/InputSystem/PlayerControls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerControls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Motion"",
            ""id"": ""59641a3f-95a1-46f5-9741-1cf8bf5c852f"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""0974e410-c0de-4a46-95d9-84c8ee031662"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Connect"",
                    ""type"": ""Button"",
                    ""id"": ""915ac5c6-fad1-4649-8e70-b91b3697061e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Aim"",
                    ""type"": ""Button"",
                    ""id"": ""fff02ff7-281a-4343-83ee-5d9ae36da7e3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SwitchTarget"",
                    ""type"": ""Value"",
                    ""id"": ""02cd976e-bae9-4c86-92cd-000973acc8dc"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""a941dc13-596b-489c-92be-fdad1753b9ea"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""85ea7659-82d3-4a5d-86c6-6b5d83ddd790"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Desktop"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""3f526773-e8f0-49ce-b0bf-7480ca935724"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Desktop"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""e1207e6e-730d-41f4-ad05-d639905ec501"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Desktop"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""c6c6f19a-c85a-4544-8a88-087e8458d969"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Desktop"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""f2d566a5-e284-48a1-89a6-565e200f347b"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Desktop"",
                    ""action"": ""Connect"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3167eeee-1f5f-471a-a599-8fa07ffbc74b"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Desktop"",
                    ""action"": ""Connect"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d0166125-0044-4b09-9050-4df1e7cebcca"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""3d5e9f1b-453c-4b70-adac-374e279863f5"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchTarget"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""09cea7d8-e1d5-4a14-87a8-605995e8b783"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchTarget"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""06a6ceb0-8d5c-4f91-86b1-42ccdf35ddfd"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchTarget"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""8042c184-1797-48e0-869b-438b0d68531d"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchTarget"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""c4111e33-2260-4110-963b-054a557fe766"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchTarget"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Link"",
            ""id"": ""1cf90e9d-2933-4517-8c3f-952ca50d7d95"",
            ""actions"": [
                {
                    ""name"": ""Swing"",
                    ""type"": ""Value"",
                    ""id"": ""a1d9cd29-5f7c-478d-bcee-e9b564c149b1"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Arrows"",
                    ""id"": ""4dc5bdbe-76fd-4960-9a9e-27b1a8d53cdf"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Swing"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""285e5418-bbcf-49cc-ba1b-377743a4ff7f"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Swing"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""32404137-7a76-44b7-b330-4b268a57316f"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Swing"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""da6730cc-4eeb-498b-92d7-96bcd745a8f9"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Swing"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""7e4a916a-5e79-4f96-a6af-f367f0addb89"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Swing"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Wave"",
            ""id"": ""5e45e281-c8c3-4053-8bbd-566807e909d0"",
            ""actions"": [
                {
                    ""name"": ""Waving"",
                    ""type"": ""Button"",
                    ""id"": ""ab02ab0b-76db-44a7-9aa3-a2b1729a4268"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Arrows"",
                    ""id"": ""2708dff0-254e-4f8b-9cac-b45534df9fde"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Waving"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""f14278a9-01ff-4443-b5ee-a46d63f1b56c"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Waving"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""f0936b72-2697-4eb0-a4ec-0a30b1cc4e56"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Waving"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Desktop"",
            ""bindingGroup"": ""Desktop"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Motion
        m_Motion = asset.FindActionMap("Motion", throwIfNotFound: true);
        m_Motion_Move = m_Motion.FindAction("Move", throwIfNotFound: true);
        m_Motion_Connect = m_Motion.FindAction("Connect", throwIfNotFound: true);
        m_Motion_Aim = m_Motion.FindAction("Aim", throwIfNotFound: true);
        m_Motion_SwitchTarget = m_Motion.FindAction("SwitchTarget", throwIfNotFound: true);
        // Link
        m_Link = asset.FindActionMap("Link", throwIfNotFound: true);
        m_Link_Swing = m_Link.FindAction("Swing", throwIfNotFound: true);
        // Wave
        m_Wave = asset.FindActionMap("Wave", throwIfNotFound: true);
        m_Wave_Waving = m_Wave.FindAction("Waving", throwIfNotFound: true);
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
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Motion
    private readonly InputActionMap m_Motion;
    private IMotionActions m_MotionActionsCallbackInterface;
    private readonly InputAction m_Motion_Move;
    private readonly InputAction m_Motion_Connect;
    private readonly InputAction m_Motion_Aim;
    private readonly InputAction m_Motion_SwitchTarget;
    public struct MotionActions
    {
        private @PlayerControls m_Wrapper;
        public MotionActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Motion_Move;
        public InputAction @Connect => m_Wrapper.m_Motion_Connect;
        public InputAction @Aim => m_Wrapper.m_Motion_Aim;
        public InputAction @SwitchTarget => m_Wrapper.m_Motion_SwitchTarget;
        public InputActionMap Get() { return m_Wrapper.m_Motion; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MotionActions set) { return set.Get(); }
        public void SetCallbacks(IMotionActions instance)
        {
            if (m_Wrapper.m_MotionActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_MotionActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_MotionActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_MotionActionsCallbackInterface.OnMove;
                @Connect.started -= m_Wrapper.m_MotionActionsCallbackInterface.OnConnect;
                @Connect.performed -= m_Wrapper.m_MotionActionsCallbackInterface.OnConnect;
                @Connect.canceled -= m_Wrapper.m_MotionActionsCallbackInterface.OnConnect;
                @Aim.started -= m_Wrapper.m_MotionActionsCallbackInterface.OnAim;
                @Aim.performed -= m_Wrapper.m_MotionActionsCallbackInterface.OnAim;
                @Aim.canceled -= m_Wrapper.m_MotionActionsCallbackInterface.OnAim;
                @SwitchTarget.started -= m_Wrapper.m_MotionActionsCallbackInterface.OnSwitchTarget;
                @SwitchTarget.performed -= m_Wrapper.m_MotionActionsCallbackInterface.OnSwitchTarget;
                @SwitchTarget.canceled -= m_Wrapper.m_MotionActionsCallbackInterface.OnSwitchTarget;
            }
            m_Wrapper.m_MotionActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Connect.started += instance.OnConnect;
                @Connect.performed += instance.OnConnect;
                @Connect.canceled += instance.OnConnect;
                @Aim.started += instance.OnAim;
                @Aim.performed += instance.OnAim;
                @Aim.canceled += instance.OnAim;
                @SwitchTarget.started += instance.OnSwitchTarget;
                @SwitchTarget.performed += instance.OnSwitchTarget;
                @SwitchTarget.canceled += instance.OnSwitchTarget;
            }
        }
    }
    public MotionActions @Motion => new MotionActions(this);

    // Link
    private readonly InputActionMap m_Link;
    private ILinkActions m_LinkActionsCallbackInterface;
    private readonly InputAction m_Link_Swing;
    public struct LinkActions
    {
        private @PlayerControls m_Wrapper;
        public LinkActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Swing => m_Wrapper.m_Link_Swing;
        public InputActionMap Get() { return m_Wrapper.m_Link; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(LinkActions set) { return set.Get(); }
        public void SetCallbacks(ILinkActions instance)
        {
            if (m_Wrapper.m_LinkActionsCallbackInterface != null)
            {
                @Swing.started -= m_Wrapper.m_LinkActionsCallbackInterface.OnSwing;
                @Swing.performed -= m_Wrapper.m_LinkActionsCallbackInterface.OnSwing;
                @Swing.canceled -= m_Wrapper.m_LinkActionsCallbackInterface.OnSwing;
            }
            m_Wrapper.m_LinkActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Swing.started += instance.OnSwing;
                @Swing.performed += instance.OnSwing;
                @Swing.canceled += instance.OnSwing;
            }
        }
    }
    public LinkActions @Link => new LinkActions(this);

    // Wave
    private readonly InputActionMap m_Wave;
    private IWaveActions m_WaveActionsCallbackInterface;
    private readonly InputAction m_Wave_Waving;
    public struct WaveActions
    {
        private @PlayerControls m_Wrapper;
        public WaveActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Waving => m_Wrapper.m_Wave_Waving;
        public InputActionMap Get() { return m_Wrapper.m_Wave; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(WaveActions set) { return set.Get(); }
        public void SetCallbacks(IWaveActions instance)
        {
            if (m_Wrapper.m_WaveActionsCallbackInterface != null)
            {
                @Waving.started -= m_Wrapper.m_WaveActionsCallbackInterface.OnWaving;
                @Waving.performed -= m_Wrapper.m_WaveActionsCallbackInterface.OnWaving;
                @Waving.canceled -= m_Wrapper.m_WaveActionsCallbackInterface.OnWaving;
            }
            m_Wrapper.m_WaveActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Waving.started += instance.OnWaving;
                @Waving.performed += instance.OnWaving;
                @Waving.canceled += instance.OnWaving;
            }
        }
    }
    public WaveActions @Wave => new WaveActions(this);
    private int m_DesktopSchemeIndex = -1;
    public InputControlScheme DesktopScheme
    {
        get
        {
            if (m_DesktopSchemeIndex == -1) m_DesktopSchemeIndex = asset.FindControlSchemeIndex("Desktop");
            return asset.controlSchemes[m_DesktopSchemeIndex];
        }
    }
    public interface IMotionActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnConnect(InputAction.CallbackContext context);
        void OnAim(InputAction.CallbackContext context);
        void OnSwitchTarget(InputAction.CallbackContext context);
    }
    public interface ILinkActions
    {
        void OnSwing(InputAction.CallbackContext context);
    }
    public interface IWaveActions
    {
        void OnWaving(InputAction.CallbackContext context);
    }
}
