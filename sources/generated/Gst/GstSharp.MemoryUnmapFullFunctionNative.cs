// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GstSharp {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
	internal delegate void MemoryUnmapFullFunctionNative(IntPtr mem, IntPtr info);

	internal class MemoryUnmapFullFunctionInvoker {

		MemoryUnmapFullFunctionNative native_cb;
		IntPtr __data;
		GLib.DestroyNotify __notify;

		~MemoryUnmapFullFunctionInvoker ()
		{
			if (__notify == null)
				return;
			__notify (__data);
		}

		internal MemoryUnmapFullFunctionInvoker (MemoryUnmapFullFunctionNative native_cb) : this (native_cb, IntPtr.Zero, null) {}

		internal MemoryUnmapFullFunctionInvoker (MemoryUnmapFullFunctionNative native_cb, IntPtr data) : this (native_cb, data, null) {}

		internal MemoryUnmapFullFunctionInvoker (MemoryUnmapFullFunctionNative native_cb, IntPtr data, GLib.DestroyNotify notify)
		{
			this.native_cb = native_cb;
			__data = data;
			__notify = notify;
		}

		internal Gst.MemoryUnmapFullFunction Handler {
			get {
				return new Gst.MemoryUnmapFullFunction(InvokeNative);
			}
		}

		void InvokeNative (Gst.Memory mem, Gst.MapInfo info)
		{
			IntPtr native_info = GLib.Marshaller.StructureToPtrAlloc (info);
			native_cb (mem == null ? IntPtr.Zero : mem.Handle, native_info);
			Marshal.FreeHGlobal (native_info);
		}
	}

	internal class MemoryUnmapFullFunctionWrapper {

		public void NativeCallback (IntPtr mem, IntPtr info)
		{
			try {
				managed (mem == IntPtr.Zero ? null : (Gst.Memory) GLib.Opaque.GetOpaque (mem, typeof (Gst.Memory), false), Gst.MapInfo.New (info));
				if (release_on_call)
					gch.Free ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		bool release_on_call = false;
		GCHandle gch;

		public void PersistUntilCalled ()
		{
			release_on_call = true;
			gch = GCHandle.Alloc (this);
		}

		internal MemoryUnmapFullFunctionNative NativeDelegate;
		Gst.MemoryUnmapFullFunction managed;

		public MemoryUnmapFullFunctionWrapper (Gst.MemoryUnmapFullFunction managed)
		{
			this.managed = managed;
			if (managed != null)
				NativeDelegate = new MemoryUnmapFullFunctionNative (NativeCallback);
		}

		public static Gst.MemoryUnmapFullFunction GetManagedDelegate (MemoryUnmapFullFunctionNative native)
		{
			if (native == null)
				return null;
			MemoryUnmapFullFunctionWrapper wrapper = (MemoryUnmapFullFunctionWrapper) native.Target;
			if (wrapper == null)
				return null;
			return wrapper.managed;
		}
	}
#endregion
}
