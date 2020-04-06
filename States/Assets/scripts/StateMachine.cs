///////////////Attribution Notice://///////////////////////////////
///This program was written by Armando Roerdinkveldboom, 2019/////
///Contact at kazekage2002@gmail.com/////////////////////////////
///Intended for educational use.////////////////////////////////
///Rights reserved under Academic Free License v3.0////////////
//////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine
{
    public event Action OnChangeState;
    public IState currentState;
    public IState prevState;
    public void ChangeState(IState newState)
    {
        if (currentState != null)
            currentState.Exit();
        prevState = currentState;

       
            currentState = newState;
            currentState.Enter();
        Debug.Log("changing state to: " + newState.GetType().ToString());
        OnChangeState(); 
        
    }

    public void Update()
    {
        if (currentState != null) currentState.Execute();
        
    }
}