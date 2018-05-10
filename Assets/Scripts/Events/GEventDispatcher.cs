﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;


public class GEventDispatcher 
{
    public delegate void callback(GEvent e);

    private System.Object m_target=null;
    class EventCallback
    {
        public callback cb = null;
        public object param = null;
    }
    private Dictionary<string, List<EventCallback>> dict;

    public GEventDispatcher()
    {
        dict = new Dictionary<string, List<EventCallback>>();
    }

    public void addEventListener(string type, callback fn, object param = null)
    {
        //如果不存在就创建一个字典  
        if (!dict.ContainsKey(type))
        {
            dict.Add(type, new List<EventCallback>());
        }

        List<EventCallback> list = dict[type] as List<EventCallback>;
        if (list.Find(x => x.cb == fn) != null)
        {
            //重复加入了侦听了
            return;
        }

        EventCallback ecb = new EventCallback();
        ecb.cb = fn;
        ecb.param = param;
        dict[type].Add(ecb);
    }

    //删除一个类型的，一个指定回调
    public void removeEventListener(string type, callback fn)
    {
        if (dict == null) return;
        if (dict.ContainsKey(type))
        {
            List<EventCallback> list = dict[type] as List<EventCallback>;
            list.RemoveAll(x => x.cb == fn);
            if (list.Count <= 0)
            {
                dict.Remove(type);
            }
        }

    }
    //将一个类型的事件都删除
    public virtual void removeEventListenerByType(string type)
    {
        if (dict.ContainsKey(type))
        {
            dict.Remove(type);
        }
    }
    public bool hasEventListener(string type)
    {
        if(dict.ContainsKey(type)){
            return true;
        }
        return false;
    }
    //发出一个事件，简化操作
    public virtual void dispatchEventWith(string type, object data=null)
    {
        GEvent e = new GEvent(type, data);
        dispatchEvent(e);
    }
    //发出一个事件
    public virtual void dispatchEvent(GEvent e)
    {
        //如果存在这个事件
        if (dict != null && dict.ContainsKey(e.type))
        {
            e.eventTarget = this;
            List<EventCallback> list = (dict[e.type] as List<EventCallback>).ToList();
            callback fn = null;
            for (int i = 0; i < list.Count; i++)
            {
                fn = list[i].cb;
                e.param = list[i].param;
                if (fn != null)
                {
                    fn(e);
                }
            }
            list.Clear();
            list = null;
        }
        e.release();
        e = null;
    }
    public virtual void ClearAllEvent() {
        if (dict == null) return;
        dict.Clear();
    }
    public virtual void Dispose()
    {
        ClearAllEvent();
        dict = null;
    }
}
