using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleController : MonoBehaviour
{
    [SerializeField] private PieceController[] cubes; //NO MODIFICAR

    [SerializeField] int _currentPosition = 0; //NO MODIFICAR

    private bool _canAct = true; //NO MODIFICAR

    //012
    //345
    //678

    //NO MODIFICAR
    private void Start()
    {
        cubes[_currentPosition].Select();
    }

    public void PressUp()
    {
        if (!_canAct) return; //NO MODIFICAR

        cubes[_currentPosition].Unselect(); //NO MODIFICAR

        cubes[_currentPosition].Select(); //NO MODIFICAR
    }

    public void PressDown()
    {
        if (!_canAct) return; //NO MODIFICAR

        cubes[_currentPosition].Unselect(); //NO MODIFICAR

        cubes[_currentPosition].Select(); //NO MODIFICAR
    }

    public void PressLeft()
    {
        if (!_canAct) return; //NO MODIFICAR

        cubes[_currentPosition].Unselect(); //NO MODIFICAR

        cubes[_currentPosition].Select(); //NO MODIFICAR
    }

    public void PressRight()
    {
        if (!_canAct) return; //NO MODIFICAR

        cubes[_currentPosition].Unselect(); //NO MODIFICAR

        cubes[_currentPosition].Select(); //NO MODIFICAR
    }

    //NO MODIFICAR
    public void PressRotateLeft()
    {
        if (!_canAct) return;

        cubes[_currentPosition].RotateLeft();
    }

    //NO MODIFICAR
    public void PressRotateRight()
    {
        if (!_canAct) return;

        cubes[_currentPosition].RotateRight();
    }

    //NO MODIFICAR
    public void DisableAction()
    {
        _canAct = false;
    }

    //NO MODIFICAR
    public void AllowAction()
    {
        _canAct = true;
    }
}
