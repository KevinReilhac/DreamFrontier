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
                    ""expectedControlType"": ""Stick"",
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
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""af92e81f-b073-4da2-9daf-0351a445158d"",
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
                    ""id"": ""c642d97a-c932-4711-b50c-7aff42032e0d"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movements"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
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
                    ""id"": ""5dca8674-dc7c-41e0-8476-a57a3220ad04"",
                    ""path"": ""<Gamepad>/buttonSouth"",
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
                },
                {
                    ""name"": """",
                    ""id"": ""87c467c7-34b6-40f4-b222-672257ae16ba"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""08798fe5-f75b-47aa-9077-37ffafa2706c"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""76cf2f4b-e85f-4d31-84b1-1af6e5fcce0e"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""PauseMenu"",
            ""id"": ""7b4d1895-590b-4c60-af13-9ea3bd83910e"",
            ""actions"": [
                {
                    ""name"": ""Navigate"",
                    ""type"": ""Button"",
                    ""id"": ""e7279bb5-a347-4d91-893a-26c6b91803f3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Cancel"",
                    ""type"": ""Button"",
                    ""id"": ""6979f97e-f451-4e3c-abe0-be389a9120b9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Validate"",
                    ""type"": ""Button"",
                    ""id"": ""eea72d55-15b6-4272-9253-8e41fbc9cdf2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""2ffdcb18-e599-4ef3-9763-a237404862e9"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""a94309a7-efa4-4cfe-9287-d0ffb2531b9f"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""cf02fe1f-8b9c-44c4-a4f4-34aae4259e90"",
                    ""path"": ""<VirtualMouse>/scroll"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""0debabf8-54f5-4f86-bdcd-94c8d32968f1"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""d040346d-9b0c-48df-9c4d-40ac584f4a09"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""0f78f98f-a20c-472b-9fbd-4d19ca7259c7"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Dpad"",
                    ""id"": ""ba41ef7e-fddb-410b-989a-e33e68d9ac17"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""749fcda6-3346-4dad-80c5-fd195189ff3f"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""96f18539-99f2-4f80-a203-34e3a31ce7e3"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Stick"",
                    ""id"": ""22fb64f8-417c-4ca9-84b3-90d69b5728ce"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""b50ad32e-30cc-4cea-b50f-5b0c8673aad3"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""c82a242e-2a8e-4811-87ef-1769d4c56436"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""ace4788b-9a79-4e96-a811-c65e0d401dae"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f93ae685-a939-423b-9a32-c5d94a6a57d5"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""efaf28be-ea54-4d6a-ad96-a091d3f2e044"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Validate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6b527300-ce99-4010-b01f-f6b45cbbbbea"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Validate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""10d429c7-ba1a-49ce-b37c-e8206f3fa4b4"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Validate"",
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
        m_MainGameplay_Pause = m_MainGameplay.FindAction("Pause", throwIfNotFound: true);
        // PauseMenu
        m_PauseMenu = asset.FindActionMap("PauseMenu", throwIfNotFound: true);
        m_PauseMenu_Navigate = m_PauseMenu.FindAction("Navigate", throwIfNotFound: true);
        m_PauseMenu_Cancel = m_PauseMenu.FindAction("Cancel", throwIfNotFound: true);
        m_PauseMenu_Validate = m_PauseMenu.FindAction("Validate", throwIfNotFound: true);
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
    private readonly InputAction m_MainGameplay_Pause;
    public struct MainGameplayActions
    {
        private @PlayerControls m_Wrapper;
        public MainGameplayActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movements => m_Wrapper.m_MainGameplay_Movements;
        public InputAction @Interact => m_Wrapper.m_MainGameplay_Interact;
        public InputAction @Attack => m_Wrapper.m_MainGameplay_Attack;
        public InputAction @Pause => m_Wrapper.m_MainGameplay_Pause;
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
                @Pause.started -= m_Wrapper.m_MainGameplayActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_MainGameplayActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_MainGameplayActionsCallbackInterface.OnPause;
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
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
            }
        }
    }
    public MainGameplayActions @MainGameplay => new MainGameplayActions(this);

    // PauseMenu
    private readonly InputActionMap m_PauseMenu;
    private IPauseMenuActions m_PauseMenuActionsCallbackInterface;
    private readonly InputAction m_PauseMenu_Navigate;
    private readonly InputAction m_PauseMenu_Cancel;
    private readonly InputAction m_PauseMenu_Validate;
    public struct PauseMenuActions
    {
        private @PlayerControls m_Wrapper;
        public PauseMenuActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Navigate => m_Wrapper.m_PauseMenu_Navigate;
        public InputAction @Cancel => m_Wrapper.m_PauseMenu_Cancel;
        public InputAction @Validate => m_Wrapper.m_PauseMenu_Validate;
        public InputActionMap Get() { return m_Wrapper.m_PauseMenu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PauseMenuActions set) { return set.Get(); }
        public void SetCallbacks(IPauseMenuActions instance)
        {
            if (m_Wrapper.m_PauseMenuActionsCallbackInterface != null)
            {
                @Navigate.started -= m_Wrapper.m_PauseMenuActionsCallbackInterface.OnNavigate;
                @Navigate.performed -= m_Wrapper.m_PauseMenuActionsCallbackInterface.OnNavigate;
                @Navigate.canceled -= m_Wrapper.m_PauseMenuActionsCallbackInterface.OnNavigate;
                @Cancel.started -= m_Wrapper.m_PauseMenuActionsCallbackInterface.OnCancel;
                @Cancel.performed -= m_Wrapper.m_PauseMenuActionsCallbackInterface.OnCancel;
                @Cancel.canceled -= m_Wrapper.m_PauseMenuActionsCallbackInterface.OnCancel;
                @Validate.started -= m_Wrapper.m_PauseMenuActionsCallbackInterface.OnValidate;
                @Validate.performed -= m_Wrapper.m_PauseMenuActionsCallbackInterface.OnValidate;
                @Validate.canceled -= m_Wrapper.m_PauseMenuActionsCallbackInterface.OnValidate;
            }
            m_Wrapper.m_PauseMenuActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Navigate.started += instance.OnNavigate;
                @Navigate.performed += instance.OnNavigate;
                @Navigate.canceled += instance.OnNavigate;
                @Cancel.started += instance.OnCancel;
                @Cancel.performed += instance.OnCancel;
                @Cancel.canceled += instance.OnCancel;
                @Validate.started += instance.OnValidate;
                @Validate.performed += instance.OnValidate;
                @Validate.canceled += instance.OnValidate;
            }
        }
    }
    public PauseMenuActions @PauseMenu => new PauseMenuActions(this);
    public interface IMainGameplayActions
    {
        void OnMovements(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
    }
    public interface IPauseMenuActions
    {
        void OnNavigate(InputAction.CallbackContext context);
        void OnCancel(InputAction.CallbackContext context);
        void OnValidate(InputAction.CallbackContext context);
    }
}
