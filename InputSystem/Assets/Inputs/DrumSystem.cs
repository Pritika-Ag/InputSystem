//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.6.3
//     from Assets/Inputs/DrumSystem.inputactions
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

public partial class @DrumSystem: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @DrumSystem()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""DrumSystem"",
    ""maps"": [
        {
            ""name"": ""DrumKeyboard"",
            ""id"": ""79b9e7da-e082-4f7f-a16c-5f38ab2d8bd6"",
            ""actions"": [
                {
                    ""name"": ""Hi-Hat"",
                    ""type"": ""Button"",
                    ""id"": ""43db0ea7-0a4f-418a-81d6-08e33da1acdc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Crash"",
                    ""type"": ""Button"",
                    ""id"": ""a983ebd0-9881-4693-b8f3-49b61e9125a2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Snare"",
                    ""type"": ""Button"",
                    ""id"": ""c9c1dea1-8ee0-4ef8-bc4d-b4ee22380cb3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Bass"",
                    ""type"": ""Button"",
                    ""id"": ""af4843b7-07e8-49cf-af5f-dc6322b9df00"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""fa068465-897e-4956-9a4e-b941cfb91ab0"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Hi-Hat"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cdfd4720-55a2-4c1f-ac52-fc6e82bebc61"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Hi-Hat"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eeac9586-46b8-49be-a857-a0d68daea1c5"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Crash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e63a6738-0179-4591-a102-574574632b2d"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Crash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b4dda7d2-3e48-4c10-8bdd-7cce3ab95627"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Snare"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c9310e17-249b-42b0-81d1-7987bb2290bf"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Snare"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""467fb2ca-e085-41a1-937f-198b0f8be457"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Bass"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""381bd1dd-ff7e-459e-bd61-4f8c148b6f6f"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Bass"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // DrumKeyboard
        m_DrumKeyboard = asset.FindActionMap("DrumKeyboard", throwIfNotFound: true);
        m_DrumKeyboard_HiHat = m_DrumKeyboard.FindAction("Hi-Hat", throwIfNotFound: true);
        m_DrumKeyboard_Crash = m_DrumKeyboard.FindAction("Crash", throwIfNotFound: true);
        m_DrumKeyboard_Snare = m_DrumKeyboard.FindAction("Snare", throwIfNotFound: true);
        m_DrumKeyboard_Bass = m_DrumKeyboard.FindAction("Bass", throwIfNotFound: true);
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

    // DrumKeyboard
    private readonly InputActionMap m_DrumKeyboard;
    private List<IDrumKeyboardActions> m_DrumKeyboardActionsCallbackInterfaces = new List<IDrumKeyboardActions>();
    private readonly InputAction m_DrumKeyboard_HiHat;
    private readonly InputAction m_DrumKeyboard_Crash;
    private readonly InputAction m_DrumKeyboard_Snare;
    private readonly InputAction m_DrumKeyboard_Bass;
    public struct DrumKeyboardActions
    {
        private @DrumSystem m_Wrapper;
        public DrumKeyboardActions(@DrumSystem wrapper) { m_Wrapper = wrapper; }
        public InputAction @HiHat => m_Wrapper.m_DrumKeyboard_HiHat;
        public InputAction @Crash => m_Wrapper.m_DrumKeyboard_Crash;
        public InputAction @Snare => m_Wrapper.m_DrumKeyboard_Snare;
        public InputAction @Bass => m_Wrapper.m_DrumKeyboard_Bass;
        public InputActionMap Get() { return m_Wrapper.m_DrumKeyboard; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DrumKeyboardActions set) { return set.Get(); }
        public void AddCallbacks(IDrumKeyboardActions instance)
        {
            if (instance == null || m_Wrapper.m_DrumKeyboardActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_DrumKeyboardActionsCallbackInterfaces.Add(instance);
            @HiHat.started += instance.OnHiHat;
            @HiHat.performed += instance.OnHiHat;
            @HiHat.canceled += instance.OnHiHat;
            @Crash.started += instance.OnCrash;
            @Crash.performed += instance.OnCrash;
            @Crash.canceled += instance.OnCrash;
            @Snare.started += instance.OnSnare;
            @Snare.performed += instance.OnSnare;
            @Snare.canceled += instance.OnSnare;
            @Bass.started += instance.OnBass;
            @Bass.performed += instance.OnBass;
            @Bass.canceled += instance.OnBass;
        }

        private void UnregisterCallbacks(IDrumKeyboardActions instance)
        {
            @HiHat.started -= instance.OnHiHat;
            @HiHat.performed -= instance.OnHiHat;
            @HiHat.canceled -= instance.OnHiHat;
            @Crash.started -= instance.OnCrash;
            @Crash.performed -= instance.OnCrash;
            @Crash.canceled -= instance.OnCrash;
            @Snare.started -= instance.OnSnare;
            @Snare.performed -= instance.OnSnare;
            @Snare.canceled -= instance.OnSnare;
            @Bass.started -= instance.OnBass;
            @Bass.performed -= instance.OnBass;
            @Bass.canceled -= instance.OnBass;
        }

        public void RemoveCallbacks(IDrumKeyboardActions instance)
        {
            if (m_Wrapper.m_DrumKeyboardActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IDrumKeyboardActions instance)
        {
            foreach (var item in m_Wrapper.m_DrumKeyboardActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_DrumKeyboardActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public DrumKeyboardActions @DrumKeyboard => new DrumKeyboardActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    public interface IDrumKeyboardActions
    {
        void OnHiHat(InputAction.CallbackContext context);
        void OnCrash(InputAction.CallbackContext context);
        void OnSnare(InputAction.CallbackContext context);
        void OnBass(InputAction.CallbackContext context);
    }
}
