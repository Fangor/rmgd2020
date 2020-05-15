// GENERATED AUTOMATICALLY FROM 'Assets/Resources/Input/ControllerInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @ControllerInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @ControllerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""ControllerInput"",
    ""maps"": [
        {
            ""name"": ""Cat"",
            ""id"": ""68d9ac36-1472-4bba-86e4-8e267d600bc9"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""8266889d-81f7-4e11-9067-ca078bb318ba"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ButtonNorth"",
                    ""type"": ""Button"",
                    ""id"": ""b33a33b8-e21a-4ff7-850a-62db8dc985f9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ButtonSouth"",
                    ""type"": ""Button"",
                    ""id"": ""86b628ad-ae80-46e3-a554-9f703ef429ff"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ButtonEast"",
                    ""type"": ""Button"",
                    ""id"": ""37370a0e-2a8a-4027-87ab-9daf15fac984"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ButtonWest"",
                    ""type"": ""Button"",
                    ""id"": ""c92059b1-7b63-47d3-bfbd-cb9b440c164b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ButtonStart"",
                    ""type"": ""Button"",
                    ""id"": ""7c5d5b09-8027-49ad-9391-34d629a36e37"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ButtonSelect"",
                    ""type"": ""Button"",
                    ""id"": ""892b4c87-dc93-4eb2-b1a0-cb9bfbb21a75"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ButtonAny"",
                    ""type"": ""Button"",
                    ""id"": ""c412a7de-28aa-4bd3-9c02-a6e0364bd4c4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""09f25fe0-e13e-4b07-9d4e-52a73ad5a456"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0e7dae8e-4b2c-4cd0-8cc0-95fb1081567b"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ButtonNorth"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9d3b6f48-0eff-445f-bf2e-03c19245d7f2"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ButtonSouth"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9ad8b3d4-6694-42a0-803c-1878c6044cac"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ButtonEast"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d8bf3472-db15-4891-85f4-7150ce05e9c8"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ButtonWest"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d5bfabd4-481b-4524-9288-d026a687e3e8"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ButtonStart"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e945768c-9931-4d30-a30e-9dba33025c1b"",
                    ""path"": ""<Gamepad>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ButtonSelect"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8fc545ea-94eb-483a-bf77-ed7c99fc1e8e"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ButtonAny"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Cat
        m_Cat = asset.FindActionMap("Cat", throwIfNotFound: true);
        m_Cat_Move = m_Cat.FindAction("Move", throwIfNotFound: true);
        m_Cat_ButtonNorth = m_Cat.FindAction("ButtonNorth", throwIfNotFound: true);
        m_Cat_ButtonSouth = m_Cat.FindAction("ButtonSouth", throwIfNotFound: true);
        m_Cat_ButtonEast = m_Cat.FindAction("ButtonEast", throwIfNotFound: true);
        m_Cat_ButtonWest = m_Cat.FindAction("ButtonWest", throwIfNotFound: true);
        m_Cat_ButtonStart = m_Cat.FindAction("ButtonStart", throwIfNotFound: true);
        m_Cat_ButtonSelect = m_Cat.FindAction("ButtonSelect", throwIfNotFound: true);
        m_Cat_ButtonAny = m_Cat.FindAction("ButtonAny", throwIfNotFound: true);
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

    // Cat
    private readonly InputActionMap m_Cat;
    private ICatActions m_CatActionsCallbackInterface;
    private readonly InputAction m_Cat_Move;
    private readonly InputAction m_Cat_ButtonNorth;
    private readonly InputAction m_Cat_ButtonSouth;
    private readonly InputAction m_Cat_ButtonEast;
    private readonly InputAction m_Cat_ButtonWest;
    private readonly InputAction m_Cat_ButtonStart;
    private readonly InputAction m_Cat_ButtonSelect;
    private readonly InputAction m_Cat_ButtonAny;
    public struct CatActions
    {
        private @ControllerInput m_Wrapper;
        public CatActions(@ControllerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Cat_Move;
        public InputAction @ButtonNorth => m_Wrapper.m_Cat_ButtonNorth;
        public InputAction @ButtonSouth => m_Wrapper.m_Cat_ButtonSouth;
        public InputAction @ButtonEast => m_Wrapper.m_Cat_ButtonEast;
        public InputAction @ButtonWest => m_Wrapper.m_Cat_ButtonWest;
        public InputAction @ButtonStart => m_Wrapper.m_Cat_ButtonStart;
        public InputAction @ButtonSelect => m_Wrapper.m_Cat_ButtonSelect;
        public InputAction @ButtonAny => m_Wrapper.m_Cat_ButtonAny;
        public InputActionMap Get() { return m_Wrapper.m_Cat; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CatActions set) { return set.Get(); }
        public void SetCallbacks(ICatActions instance)
        {
            if (m_Wrapper.m_CatActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_CatActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_CatActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_CatActionsCallbackInterface.OnMove;
                @ButtonNorth.started -= m_Wrapper.m_CatActionsCallbackInterface.OnButtonNorth;
                @ButtonNorth.performed -= m_Wrapper.m_CatActionsCallbackInterface.OnButtonNorth;
                @ButtonNorth.canceled -= m_Wrapper.m_CatActionsCallbackInterface.OnButtonNorth;
                @ButtonSouth.started -= m_Wrapper.m_CatActionsCallbackInterface.OnButtonSouth;
                @ButtonSouth.performed -= m_Wrapper.m_CatActionsCallbackInterface.OnButtonSouth;
                @ButtonSouth.canceled -= m_Wrapper.m_CatActionsCallbackInterface.OnButtonSouth;
                @ButtonEast.started -= m_Wrapper.m_CatActionsCallbackInterface.OnButtonEast;
                @ButtonEast.performed -= m_Wrapper.m_CatActionsCallbackInterface.OnButtonEast;
                @ButtonEast.canceled -= m_Wrapper.m_CatActionsCallbackInterface.OnButtonEast;
                @ButtonWest.started -= m_Wrapper.m_CatActionsCallbackInterface.OnButtonWest;
                @ButtonWest.performed -= m_Wrapper.m_CatActionsCallbackInterface.OnButtonWest;
                @ButtonWest.canceled -= m_Wrapper.m_CatActionsCallbackInterface.OnButtonWest;
                @ButtonStart.started -= m_Wrapper.m_CatActionsCallbackInterface.OnButtonStart;
                @ButtonStart.performed -= m_Wrapper.m_CatActionsCallbackInterface.OnButtonStart;
                @ButtonStart.canceled -= m_Wrapper.m_CatActionsCallbackInterface.OnButtonStart;
                @ButtonSelect.started -= m_Wrapper.m_CatActionsCallbackInterface.OnButtonSelect;
                @ButtonSelect.performed -= m_Wrapper.m_CatActionsCallbackInterface.OnButtonSelect;
                @ButtonSelect.canceled -= m_Wrapper.m_CatActionsCallbackInterface.OnButtonSelect;
                @ButtonAny.started -= m_Wrapper.m_CatActionsCallbackInterface.OnButtonAny;
                @ButtonAny.performed -= m_Wrapper.m_CatActionsCallbackInterface.OnButtonAny;
                @ButtonAny.canceled -= m_Wrapper.m_CatActionsCallbackInterface.OnButtonAny;
            }
            m_Wrapper.m_CatActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @ButtonNorth.started += instance.OnButtonNorth;
                @ButtonNorth.performed += instance.OnButtonNorth;
                @ButtonNorth.canceled += instance.OnButtonNorth;
                @ButtonSouth.started += instance.OnButtonSouth;
                @ButtonSouth.performed += instance.OnButtonSouth;
                @ButtonSouth.canceled += instance.OnButtonSouth;
                @ButtonEast.started += instance.OnButtonEast;
                @ButtonEast.performed += instance.OnButtonEast;
                @ButtonEast.canceled += instance.OnButtonEast;
                @ButtonWest.started += instance.OnButtonWest;
                @ButtonWest.performed += instance.OnButtonWest;
                @ButtonWest.canceled += instance.OnButtonWest;
                @ButtonStart.started += instance.OnButtonStart;
                @ButtonStart.performed += instance.OnButtonStart;
                @ButtonStart.canceled += instance.OnButtonStart;
                @ButtonSelect.started += instance.OnButtonSelect;
                @ButtonSelect.performed += instance.OnButtonSelect;
                @ButtonSelect.canceled += instance.OnButtonSelect;
                @ButtonAny.started += instance.OnButtonAny;
                @ButtonAny.performed += instance.OnButtonAny;
                @ButtonAny.canceled += instance.OnButtonAny;
            }
        }
    }
    public CatActions @Cat => new CatActions(this);
    public interface ICatActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnButtonNorth(InputAction.CallbackContext context);
        void OnButtonSouth(InputAction.CallbackContext context);
        void OnButtonEast(InputAction.CallbackContext context);
        void OnButtonWest(InputAction.CallbackContext context);
        void OnButtonStart(InputAction.CallbackContext context);
        void OnButtonSelect(InputAction.CallbackContext context);
        void OnButtonAny(InputAction.CallbackContext context);
    }
}
