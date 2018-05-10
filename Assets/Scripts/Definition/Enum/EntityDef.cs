

/// <summary>
///实体状态
/// </summary>
public enum EntityStateEnum
{
    Char_Normal = 0, //正常
    Char_Attack = 1,   // 攻击
    Char_Hurt = 2, // 受伤
    Char_Dead = 3, //死亡
//     Char_Freeze = 4, //冰冻;
//     Char_HurtLie = 6,    //受击躺下..躺地..
//     Char_DropItem = 7,      //物品掉落状态.
//     Char_Swoon = 8,     //眩晕;
//     Char_Polymorph = 9,       //变羊;
//     Char_Link = 10           //链接状态.
}

//实体驱动器
public enum EntityDriveEnum
{
    EntityDrive_Visual = 1,    //负责外观
    EntityDrive_Move = 2,      //负责移动
}

public enum EntityMessageEnum
{
    //外观组件
    EntityCommand_SetPos,       // 设置实体位置 参数pos

    //运动组件
    EntityCommand_Move,             // 移动 Move
}
