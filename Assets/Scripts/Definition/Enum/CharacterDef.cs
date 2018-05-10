
/// <summary>
/// 角色类型
/// </summary>
public enum CharacterType
{
    Character = 1,
    Monster = 2,
    Item = 3,
    Boss = 4,
}
public enum CharacterState
{
    Character_Normal = 0, //正常
    Character_Attack = 1,   // 攻击
    Character_Hurt = 2, // 受伤
    Character_Dead = 3, //死亡
    Character_Freeze = 4, //冰冻;
    Character_HurtLie = 5,    //受击躺下..躺地..
    Character_Swoon = 6,     //眩晕;
}
