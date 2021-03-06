﻿using System;
using System.Threading.Tasks;

namespace RtmpSharp.IO.AMF0.AMFWriters
{
    class Amf0DateTimeWriter : IAmfItemWriter
    {
        public void WriteData(AmfWriter writer, object obj)
        {
            writer.WriteMarker(Amf0TypeMarkers.Date);
            writer.WriteAmf0DateTime((DateTime)obj);
        }

        public void WriteDataAsync(AmfWriter writer, object obj)
        {
            writer.WriteMarkerAsync(Amf0TypeMarkers.Date);
            writer.WriteAmf0DateTimeAsync((DateTime)obj);
        }
    }
}
