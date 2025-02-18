﻿using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;
using System.Xml;

public class DPartnerLevel : DObj<int>
{
    public int   Id;
    public int   Partner;
    public int   Level;
    public int   Exp;

    public override int GetKey()
    {
        return Level;
    }

    public override void Read(XmlElement element)
    {
        this.Id      = element.GetInt32("Id");
        this.Level   = element.GetInt32("Level");
        this.Partner = element.GetInt32("Partner");
        this.Exp     = element.GetInt32("Exp");
    }
}

public class ReadCfgPartnerLevel : DReadBase<int, DPartnerLevel>
{

}