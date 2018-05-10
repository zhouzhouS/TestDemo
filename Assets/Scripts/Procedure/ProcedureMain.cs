using System.Collections.Generic;
using UnityGameFramework.Runtime;
using ProcedureOwner = GameFramework.Fsm.IFsm<GameFramework.Procedure.IProcedureManager>;


public class ProcedureMain : ProcedureBaseS
{
    private const float GameOverDelayedSeconds = 2f;
    private bool m_GotoMenu = false;
    private float m_GotoMenuDelaySeconds = 0f;

    public override bool UseNativeDialog
    {
        get
        {
            return false;
        }
    }

    public void GotoMenu()
    {
        m_GotoMenu = true;
    }

    protected override void OnInit(ProcedureOwner procedureOwner)
    {
        base.OnInit(procedureOwner);


    }

    protected override void OnDestroy(ProcedureOwner procedureOwner)
    {
        base.OnDestroy(procedureOwner);


    }

    protected override void OnEnter(ProcedureOwner procedureOwner)
    {
        base.OnEnter(procedureOwner);

    }

    protected override void OnLeave(ProcedureOwner procedureOwner, bool isShutdown)
    {

        base.OnLeave(procedureOwner, isShutdown);
    }

    protected override void OnUpdate(ProcedureOwner procedureOwner, float elapseSeconds, float realElapseSeconds)
    {
        base.OnUpdate(procedureOwner, elapseSeconds, realElapseSeconds);
    }
}

