﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class DG_Tweening_TweenTypeWrap
{
	public static void Register(LuaState L)
	{
		L.BeginEnum(typeof(DG.Tweening.TweenType));
		L.RegVar("Tweener", get_Tweener, null);
		L.RegVar("Sequence", get_Sequence, null);
		L.RegVar("Callback", get_Callback, null);
		L.RegFunction("IntToEnum", IntToEnum);
		L.EndEnum();
		TypeTraits<DG.Tweening.TweenType>.Check = CheckType;
		StackTraits<DG.Tweening.TweenType>.Push = Push;
	}

	static void Push(IntPtr L, DG.Tweening.TweenType arg)
	{
		ToLua.Push(L, arg);
	}

	static bool CheckType(IntPtr L, int pos)
	{
		return TypeChecker.CheckEnumType(typeof(DG.Tweening.TweenType), L, pos);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Tweener(IntPtr L)
	{
		ToLua.Push(L, DG.Tweening.TweenType.Tweener);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Sequence(IntPtr L)
	{
		ToLua.Push(L, DG.Tweening.TweenType.Sequence);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Callback(IntPtr L)
	{
		ToLua.Push(L, DG.Tweening.TweenType.Callback);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		DG.Tweening.TweenType o = (DG.Tweening.TweenType)arg0;
		ToLua.Push(L, o);
		return 1;
	}
}

