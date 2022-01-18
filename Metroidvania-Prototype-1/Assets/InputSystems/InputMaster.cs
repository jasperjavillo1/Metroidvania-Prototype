// GENERATED AUTOMATICALLY FROM 'Assets/InputSystems/InputMaster.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputMaster : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputMaster()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputMaster"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""effbcb1e-dd0d-4ebc-ba3f-e03d3dbe03ea"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""9d2ded0d-6775-442b-8e06-83c8fc42316f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""065912cf-9664-4bb5-ba8f-351e82a25678"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoot Beam"",
                    ""type"": ""Button"",
                    ""id"": ""85337e9b-89ee-4324-999b-7a89f53b6332"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Crouch"",
                    ""type"": ""Button"",
                    ""id"": ""8428cc81-e067-4682-86d3-06148fe5e02b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Stand"",
                    ""type"": ""Button"",
                    ""id"": ""b66e90eb-22ac-42e3-96d0-7da5dc58bc5f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoot Missiles"",
                    ""type"": ""Button"",
                    ""id"": ""89885dd1-b8ef-48e6-87dd-2dbab3e443b5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""dd4551ac-8d4e-4349-9a55-88953ae2b1bc"",
                    ""path"": ""1DAxis"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""185fc030-bcb2-43c8-8392-68518359c9ff"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""4ff8d826-7efb-46cb-ad92-65a60b1a287d"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""b052e766-befa-4f85-82a6-e38134c54ff4"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d82bf20f-074a-49ee-b5c6-aaf064146f54"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot Beam"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ed2fbfb7-ee56-4a8b-9d66-46bc15213f56"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""22b983cb-2e48-42ef-8768-7594ae84b010"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Stand"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""beb2bfc1-8912-4757-82b5-a21801ef6245"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot Missiles"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Jump = m_Player.FindAction("Jump", throwIfNotFound: true);
        m_Player_Move = m_Player.FindAction("Move", throwIfNotFound: true);
        m_Player_ShootBeam = m_Player.FindAction("Shoot Beam", throwIfNotFound: true);
        m_Player_Crouch = m_Player.FindAction("Crouch", throwIfNotFound: true);
        m_Player_Stand = m_Player.FindAction("Stand", throwIfNotFound: true);
        m_Player_ShootMissiles = m_Player.FindAction("Shoot Missiles", throwIfNotFound: true);
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
    private readonly InputAction m_Player_Jump;
    private readonly InputAction m_Player_Move;
    private readonly InputAction m_Player_ShootBeam;
    private readonly InputAction m_Player_Crouch;
    private readonly InputAction m_Player_Stand;
    private readonly InputAction m_Player_ShootMissiles;
    public struct PlayerActions
    {
        private @InputMaster m_Wrapper;
        public PlayerActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_Player_Jump;
        public InputAction @Move => m_Wrapper.m_Player_Move;
        public InputAction @ShootBeam => m_Wrapper.m_Player_ShootBeam;
        public InputAction @Crouch => m_Wrapper.m_Player_Crouch;
        public InputAction @Stand => m_Wrapper.m_Player_Stand;
        public InputAction @ShootMissiles => m_Wrapper.m_Player_ShootMissiles;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Jump.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Move.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @ShootBeam.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShootBeam;
                @ShootBeam.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShootBeam;
                @ShootBeam.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShootBeam;
                @Crouch.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCrouch;
                @Crouch.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCrouch;
                @Crouch.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCrouch;
                @Stand.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStand;
                @Stand.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStand;
                @Stand.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStand;
                @ShootMissiles.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShootMissiles;
                @ShootMissiles.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShootMissiles;
                @ShootMissiles.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShootMissiles;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @ShootBeam.started += instance.OnShootBeam;
                @ShootBeam.performed += instance.OnShootBeam;
                @ShootBeam.canceled += instance.OnShootBeam;
                @Crouch.started += instance.OnCrouch;
                @Crouch.performed += instance.OnCrouch;
                @Crouch.canceled += instance.OnCrouch;
                @Stand.started += instance.OnStand;
                @Stand.performed += instance.OnStand;
                @Stand.canceled += instance.OnStand;
                @ShootMissiles.started += instance.OnShootMissiles;
                @ShootMissiles.performed += instance.OnShootMissiles;
                @ShootMissiles.canceled += instance.OnShootMissiles;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnShootBeam(InputAction.CallbackContext context);
        void OnCrouch(InputAction.CallbackContext context);
        void OnStand(InputAction.CallbackContext context);
        void OnShootMissiles(InputAction.CallbackContext context);
    }
}
