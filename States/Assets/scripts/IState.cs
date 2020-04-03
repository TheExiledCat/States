///////////////Attribution Notice://///////////////////////////////
///This program was written by Armando Roerdinkveldboom, 2019/////
///Contact at kazekage2002@gmail.com/////////////////////////////
///Intended for educational use.////////////////////////////////
///Rights reserved under Academic Free License v3.0////////////
//////////////////////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IState 
{
     void Enter();
     void Execute();
     void Exit();
}