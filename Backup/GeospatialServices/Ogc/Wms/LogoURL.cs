﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.Xml.Schema;
using System.Runtime.Serialization;
using GeospatialServices.Ogc.Common;

namespace GeospatialServices.Ogc.Wms
{
    [DataContract]
    [XmlType(TypeName = "LogoURL", Namespace = Declarations.WmsNameSpace), Serializable]
    public partial class LogoURL
    {
        [XmlIgnore]
        [DataMember] public bool WidthSpecified = false;
        private int _Width;

        [XmlAttribute(AttributeName = "width", DataType="int")]
        [DataMember] public int Width
        {
            get { return _Width; }
            set { _Width = value; WidthSpecified = true; }
        }

        [XmlIgnore]
        [DataMember] public bool HeightSpecified = false;
        private int _Height;

        [XmlAttribute(AttributeName = "height", DataType="int")]
        [DataMember] public int Height
        {
            get { return _Height; }
            set { _Height = value; HeightSpecified = true; }
        }

        [XmlIgnore]
        [DataMember] public bool FormatSpecified = false;
        private string _Format;

        [XmlAttribute(AttributeName = "format")]
        [DataMember] public string Format
        {
            get { return _Format; }
            set { _Format = value; FormatSpecified = true; }
        }

        private OnlineResource _OnlineResource;

        [XmlElement(Type = typeof(OnlineResource), ElementName = "OnlineResource", IsNullable = false, Form = XmlSchemaForm.Qualified, Namespace = Declarations.WmsNameSpace)]
        [DataMember] public OnlineResource OnlineResource
        {
            get { return _OnlineResource = (_OnlineResource == null) ? new OnlineResource() : _OnlineResource; }
            set { _OnlineResource = value; }
        }
    }
}
