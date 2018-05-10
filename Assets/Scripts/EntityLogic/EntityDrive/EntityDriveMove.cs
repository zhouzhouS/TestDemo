using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;


public class EntityDriveMove : EntityDrive
{
    public EntityDriveMove(EntityLogicObjView owner)
    {
        m_Owner = owner;
    }

    public void Create()
    {
        RegisterMessageDelegate(EntityMessageEnum.EntityCommand_Move, OnStartMove);
    }

    private object OnStartMove(object param)
    {
     
        return null;
    }

    public override void Close()
    {
        base.Clear();
    }

}
