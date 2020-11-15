// GENERATED AUTOMATICALLY FROM 'Assets/Controls/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""MainGameplay"",
            ""id"": ""2213bc9e-7e82-4535-ba66-7b9293c152fa"",
            ""actions"": [
                {
                    ""name"": ""Movements"",
                    ""type"": ""Value"",
                    ""id"": ""ee88abf9-013e-4e1c-9f37-344e1dd8264a"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""1c0f419d-dd28-4223-a68e-30263e54b91a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""913de872-e028-4ecf-9453-955585325784"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Keyboard Letters"",
                    ""id"": ""264f4838-ea79-4519-ba6b-2d59e27809fc"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movements"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""4e7df726-f2e8-4717-8047-ecf64646835a"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movements"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""f85b34dc-e6fd-47bf-907a-811c812b7422"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movements"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""bec02159-44f3-4465-8d59-03eee4f0c582"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movements"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""479bc47f-e2dd-4905-ae40-942f0b3fbe4f"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movements"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Keyboard Arrows"",
                    ""id"": ""014473dc-f041-4a54-a197-57e218de443d"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movements"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""01828328-2a2f-4082-ab25-dc0f9eb127a5"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movements"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""4ffe0b09-ab04-4f60-83e7-18283cfe4ba0"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movements"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""eb08d1bb-91ec-4124-8c06-d68a97c18318"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movements"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f7a94cca-1e8b-4e27-a0f5-bf39a1ef315f"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movements"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""03eb04d6-15c4-4c77-a8bb-fca13e5ff8c0"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b3c60062-88df-4ed9-88f4-0dea299755fa"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // MainGameplay
        m_MainGameplay = asset.FindActionMap("MainGameplay", throwIfNotFound: true);
        m_MainGameplay_Movements = m_MainGameplay.FindAction("Movements", throwIfNotFound: true);
        m_MainGameplay_Interact = m_MainGameplay.FindAction("Interact", throwIfNotFound: true);
        m_MainGameplay_Attack = m_MainGameplay.FindAction("Attack", throwIfNotFound: true);
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

    // MainGameplay
    private readonly InputActionMap m_MainGameplay;
    private IMainGameplayActions m_MainGameplayActionsCallbackInterface;
    private readonly InputAction m_MainGameplay_Movements;
    private readonly InputAction m_MainGameplay_Interact;
    private readonly InputAction m_MainGameplay_Attack;
    public struct MainGameplayActions
    {
        private @PlayerControls m_Wrapper;
        public MainGameplayActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movements => m_Wrapper.m_MainGameplay_Movements;
        public InputAction @Interact => m_Wrapper.m_MainGameplay_Interact;
        public InputAction @Attack => m_Wrapper.m_MainGameplay_Attack;
        public InputActionMap Get() { return m_Wrapper.m_MainGameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MainGameplayActions set) { return set.Get(); }
        public void SetCallbacks(IMainGameplayActions instance)
        {
            if (m_Wrapper.m_MainGameplayActionsCallbackInterface != null)
            {
                @Movements.started -= m_Wrapper.m_MainGameplayActionsCallbackInterface.OnMovements;
                @Movements.performed -= m_Wrapper.m_MainGameplayActionsCallbackInterface.OnMovements;
                @Movements.canceled -= m_Wrapper.m_MainGameplayActionsCallbackInterface.OnMovements;
                @Interact.started -= m_Wrapper.m_MainGameplayActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_MainGameplayActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_MainGameplayActionsCallbackInterface.OnInteract;
                @Attack.started -= m_Wrapper.m_MainGameplayActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_MainGameplayActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_MainGameplayActionsCallbackInterface.OnAttack;
            }
            m_Wrapper.m_MainGameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movements.started += instance.OnMovements;
                @Movements.performed += instance.OnMovements;
                @Movements.canceled += instance.OnMovements;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
            }
        }
    }
    public MainGameplayActions @MainGameplay => new MainGameplayActions(this);
    public interface IMainGameplayActions
    {
        void OnMovements(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
    }
}
