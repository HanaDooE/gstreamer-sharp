// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst {

	using System;

#region Autogenerated code
	public partial interface ITagSetter : GLib.IWrapper {

		void AddTagValue(Gst.TagMergeMode mode, string tag, GLib.Value value);
		Gst.TagList TagList { 
			get;
		}
		Gst.TagMergeMode TagMergeMode { 
			get; set;
		}
		void MergeTags(Gst.TagList list, Gst.TagMergeMode mode);
		void ResetTags();
	}

	[GLib.GInterface (typeof (TagSetterAdapter))]
	public partial interface ITagSetterImplementor : GLib.IWrapper {

	}
#endregion
}
