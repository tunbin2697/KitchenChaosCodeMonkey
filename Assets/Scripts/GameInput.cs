using System;
using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>
/// Handles game input using Unity's new Input System.
/// Following CodeMonkey's Kitchen Chaos tutorial.
/// </summary>
public class GameInput : MonoBehaviour
{
    private PlayerInputActions playerInputActions;

    private void Awake()
    {
        playerInputActions = new PlayerInputActions();
        playerInputActions.Player.Enable();
    }

    private void OnDestroy()
    {
        playerInputActions.Dispose();
    }

    /// <summary>
    /// Gets the normalized movement vector from player input
    /// </summary>
    /// <returns>Normalized 2D movement vector</returns>
    public Vector2 GetMovementVectorNormalized()
    {
        Vector2 inputVector = playerInputActions.Player.Move.ReadValue<Vector2>();
        inputVector = inputVector.normalized;
        return inputVector;
    }
}
