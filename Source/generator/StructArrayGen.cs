// GtkSharp.Generation.ArrayStringGen.cs - The String Array type Generatable.
//
// Author: Andoni Morales <amorales@fluendo.com>
//
// Copyright (c) 2022 Fluendo S.A. <contact@fluendo.com.com
// Copyright (c) 2022 Andoni Morales <ylatuya@gmail.com>
//
// This program is free software; you can redistribute it and/or
// modify it under the terms of version 2 of the GNU General Public
// License as published by the Free Software Foundation.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// General Public License for more details.
//
// You should have received a copy of the GNU General Public
// License along with this program; if not, write to the
// Free Software Foundation, Inc., 59 Temple Place - Suite 330,
// Boston, MA 02111-1307, USA.


namespace GtkSharp.Generation
{
    public class StructArrayGen : SimpleBase, IManualMarshaler
    {

        public StructArrayGen(string ctype, string type, int length) : base(ctype, type, "null")
        {
            Length = length;
        }

        public override string MarshalType => "IntPtr";

        public int Length { get; }

        public override string FromNative(string var)
        {
            return $"GLib.Marshaller.StructArrayFromIntPtrStructArray ({var}, {Length}, false)";
        }

        public string AllocNative(string var)
        {
            return $"GLib.Marshaller.StructArrayToIntPtrStructArray({var})";
        }

        public string ReleaseNative(string native_var)
        {
            return "";
        }
    }
}

