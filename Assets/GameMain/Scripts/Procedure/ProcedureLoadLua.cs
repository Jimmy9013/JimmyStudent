using GameFramework;
using GameFramework.Procedure;
using UnityGameFramework.Runtime;
using ProcedureOwner = GameFramework.Fsm.IFsm<GameFramework.Procedure.IProcedureManager>;


namespace GameMain
{
    public class ProcedureLoadLua : ProcedureBase
    {
        
        protected override void OnEnter(ProcedureOwner procedureOwner)
        {
            XLua.LuaEnv luaenv = new XLua.LuaEnv();
            luaenv.DoString("CS.UnityEngine.Debug.Log('hello world')");

            luaenv.DoString("dofile('Assets/GameMain/LuaScripts/main.lua')");
            luaenv.Dispose();
        }


    }

}

