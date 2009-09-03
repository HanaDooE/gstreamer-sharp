// GTypeAttribute.cs
//
// Copyright (c) 2005 Novell, Inc.
//
// This program is free software; you can redistribute it and/or
// modify it under the terms of version 2 of the Lesser GNU General 
// Public License as published by the Free Software Foundation.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public
// License along with this program; if not, write to the
// Free Software Foundation, Inc., 59 Temple Place - Suite 330,
// Boston, MA 02111-1307, USA.


namespace Gst.GLib {

	using System;

	[AttributeUsage (AttributeTargets.Enum)]
	public sealed class GTypeAttribute : Attribute {
		Type wrapper_type;

		public GTypeAttribute (Type wrapper_type)
		{
			this.wrapper_type = wrapper_type;
		}

		public Type WrapperType {
			get {
				return wrapper_type;
			}
			set {
				wrapper_type = value;
			}
		}
	}
}