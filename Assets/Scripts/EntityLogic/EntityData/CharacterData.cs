using System;
using UnityEngine;

[Serializable]
public class CharacterData : EntityData
{
    [SerializeField]
    public CharacterType charType = CharacterType.Character;
    public CampType camp= CampType.Unknown;
    public int pvpId = 0;
    public Vector3 birthPoint;
    public Vector3 birthRotation;
    public CharacterState characterState = CharacterState.Character_Normal;

    public CenterStarInt LevelCur = new CenterStarInt(1);//当前等级
    public CenterStarInt HpMax = new CenterStarInt(1);//HP最大值
    public CenterStarInt HpCur = new CenterStarInt(1);//当前HP
    public CenterStarInt Attack = new CenterStarInt(0);//攻击
    public CenterStarInt Defend = new CenterStarInt(0);//防御

    public CharacterData(int entityId, int typeId)
        : base(entityId, typeId)
    {
    }

    public void init()
    {

    }

    public void reset()
    {

    }
}
