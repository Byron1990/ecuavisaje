//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/InputSystem/InputActions.inputactions
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

public partial class @InputActions : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActions"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""e42bbc1d-7d1b-4f92-ba23-1e8077beff24"",
            ""actions"": [
                {
                    ""name"": ""WalkLeft"",
                    ""type"": ""Value"",
                    ""id"": ""c7fa5639-9adb-42f5-b72a-ad984bc77b0e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""WalkRight"",
                    ""type"": ""Value"",
                    ""id"": ""6ed1ddca-ed66-4c95-add2-ed6d6c847e9f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""13a127c2-83cb-460b-b20c-645eb167af54"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Bend"",
                    ""type"": ""Value"",
                    ""id"": ""1eec4b62-a686-49e1-a0c9-0f9d30d99868"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Punch1"",
                    ""type"": ""Button"",
                    ""id"": ""a4c59c96-eb9c-4df3-aef3-842c515ce970"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Punch2"",
                    ""type"": ""Button"",
                    ""id"": ""6c6ffcb5-618a-43e9-8a94-fca716873bee"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Kick1"",
                    ""type"": ""Button"",
                    ""id"": ""831c7768-bc68-4198-b808-5e9f1e20532a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Kick2"",
                    ""type"": ""Button"",
                    ""id"": ""e834c31d-23d0-4f18-ba68-0aff81f0eaec"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Block"",
                    ""type"": ""Value"",
                    ""id"": ""fbe8a047-4a2a-4c81-bc94-fe541e19e9b6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""08f71e4f-9ad6-4c6f-9085-b20f5df83ef4"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""WalkLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""781feada-cde9-425f-bfa0-82dbb3405c9b"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""WalkRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""afe0d7e3-cd91-43bb-9293-b6d5f26fa701"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e125b749-fb34-4b53-8987-7ec7147c9e2f"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Bend"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""39e21162-bfec-458d-b898-d645dbfded21"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Punch1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9c31b9f1-6bc3-494f-8077-847ff4966ea5"",
                    ""path"": ""<Keyboard>/u"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Punch2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f2a91a19-8e96-4210-bc9c-d5d4991abfda"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Kick1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""98823140-d34b-4642-a6d8-3a10435c40cd"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Kick2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d4417250-794f-4148-b044-058a17d63c35"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Block"",
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
            ""devices"": []
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_WalkLeft = m_Player.FindAction("WalkLeft", throwIfNotFound: true);
        m_Player_WalkRight = m_Player.FindAction("WalkRight", throwIfNotFound: true);
        m_Player_Jump = m_Player.FindAction("Jump", throwIfNotFound: true);
        m_Player_Bend = m_Player.FindAction("Bend", throwIfNotFound: true);
        m_Player_Punch1 = m_Player.FindAction("Punch1", throwIfNotFound: true);
        m_Player_Punch2 = m_Player.FindAction("Punch2", throwIfNotFound: true);
        m_Player_Kick1 = m_Player.FindAction("Kick1", throwIfNotFound: true);
        m_Player_Kick2 = m_Player.FindAction("Kick2", throwIfNotFound: true);
        m_Player_Block = m_Player.FindAction("Block", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_WalkLeft;
    private readonly InputAction m_Player_WalkRight;
    private readonly InputAction m_Player_Jump;
    private readonly InputAction m_Player_Bend;
    private readonly InputAction m_Player_Punch1;
    private readonly InputAction m_Player_Punch2;
    private readonly InputAction m_Player_Kick1;
    private readonly InputAction m_Player_Kick2;
    private readonly InputAction m_Player_Block;
    public struct PlayerActions
    {
        private @InputActions m_Wrapper;
        public PlayerActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @WalkLeft => m_Wrapper.m_Player_WalkLeft;
        public InputAction @WalkRight => m_Wrapper.m_Player_WalkRight;
        public InputAction @Jump => m_Wrapper.m_Player_Jump;
        public InputAction @Bend => m_Wrapper.m_Player_Bend;
        public InputAction @Punch1 => m_Wrapper.m_Player_Punch1;
        public InputAction @Punch2 => m_Wrapper.m_Player_Punch2;
        public InputAction @Kick1 => m_Wrapper.m_Player_Kick1;
        public InputAction @Kick2 => m_Wrapper.m_Player_Kick2;
        public InputAction @Block => m_Wrapper.m_Player_Block;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @WalkLeft.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWalkLeft;
                @WalkLeft.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWalkLeft;
                @WalkLeft.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWalkLeft;
                @WalkRight.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWalkRight;
                @WalkRight.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWalkRight;
                @WalkRight.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWalkRight;
                @Jump.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Bend.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBend;
                @Bend.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBend;
                @Bend.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBend;
                @Punch1.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPunch1;
                @Punch1.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPunch1;
                @Punch1.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPunch1;
                @Punch2.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPunch2;
                @Punch2.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPunch2;
                @Punch2.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPunch2;
                @Kick1.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnKick1;
                @Kick1.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnKick1;
                @Kick1.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnKick1;
                @Kick2.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnKick2;
                @Kick2.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnKick2;
                @Kick2.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnKick2;
                @Block.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBlock;
                @Block.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBlock;
                @Block.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBlock;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @WalkLeft.started += instance.OnWalkLeft;
                @WalkLeft.performed += instance.OnWalkLeft;
                @WalkLeft.canceled += instance.OnWalkLeft;
                @WalkRight.started += instance.OnWalkRight;
                @WalkRight.performed += instance.OnWalkRight;
                @WalkRight.canceled += instance.OnWalkRight;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Bend.started += instance.OnBend;
                @Bend.performed += instance.OnBend;
                @Bend.canceled += instance.OnBend;
                @Punch1.started += instance.OnPunch1;
                @Punch1.performed += instance.OnPunch1;
                @Punch1.canceled += instance.OnPunch1;
                @Punch2.started += instance.OnPunch2;
                @Punch2.performed += instance.OnPunch2;
                @Punch2.canceled += instance.OnPunch2;
                @Kick1.started += instance.OnKick1;
                @Kick1.performed += instance.OnKick1;
                @Kick1.canceled += instance.OnKick1;
                @Kick2.started += instance.OnKick2;
                @Kick2.performed += instance.OnKick2;
                @Kick2.canceled += instance.OnKick2;
                @Block.started += instance.OnBlock;
                @Block.performed += instance.OnBlock;
                @Block.canceled += instance.OnBlock;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnWalkLeft(InputAction.CallbackContext context);
        void OnWalkRight(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnBend(InputAction.CallbackContext context);
        void OnPunch1(InputAction.CallbackContext context);
        void OnPunch2(InputAction.CallbackContext context);
        void OnKick1(InputAction.CallbackContext context);
        void OnKick2(InputAction.CallbackContext context);
        void OnBlock(InputAction.CallbackContext context);
    }
}
