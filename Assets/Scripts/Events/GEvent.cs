using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class GEvent
{
    public string type = "";
    public object data;
    public object param = null;
    public GEventDispatcher eventTarget;
    public GEvent(string _type, object _data = null)
    {
        type = _type;
        data = _data;
    }
    public void release() {
        data = null;
        param = null;
        eventTarget = null;
    }
}