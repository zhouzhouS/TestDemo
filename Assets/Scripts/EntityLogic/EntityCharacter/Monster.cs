using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : EntityCharacterObject
{
    protected internal override void OnShow(object userData)
    {
        AddDrive(EntityDriveEnum.EntityDrive_Visual);
        AddDrive(EntityDriveEnum.EntityDrive_Move);
        OnMessage(EntityMessageEnum.EntityCommand_SetPos, charData.birthPoint);
    }
}
