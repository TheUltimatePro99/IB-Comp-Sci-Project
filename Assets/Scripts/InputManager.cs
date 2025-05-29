using UnityEngine;
using UnityEngine.InputSystem;
public class InputManager : MonoBehaviour
{
    private PlayerInput playerInput;
    private PlayerInput.OnFootActions onFoot;
    void Awake()
    {
        playerInput = new PlayerInput();
        onFoot = playerInput.OnFoot;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnEnable()
    {
        onFoot.Enable();

    }
    private void OnDisable()
    {
        onFoot.Disable();

    }
}
