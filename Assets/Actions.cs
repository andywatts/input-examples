using System;
using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class Actions : MonoBehaviour
{
    private PlayerInput _playerInput;

    private void Awake()
    {
        _playerInput = GetComponent<PlayerInput>();
    }

    // Game ActionMap
    void OnJump()
    {
        Debug.Log("Got Jump");
    }
    
    void OnOpenDashboard()
    {
        Debug.Log("Open Dashboard");
        _playerInput.SwitchCurrentActionMap("Dashboard");
    }
    
    void OnOpenMenu()
    {
        Debug.Log("Open Menu");
        _playerInput.SwitchCurrentActionMap("Menu");
    }
    
    
    // Dashboard ActionMap
    void OnDashboardExit()
    {
        Debug.Log("Get dashboard exit");
        _playerInput.SwitchCurrentActionMap("Game");
    }
    
    // Menu ActionMap
    void OnMenuExit()
    {
        Debug.Log("Get menu exit");
        _playerInput.SwitchCurrentActionMap("Game");
    }
    
    
}
