﻿using NTwain.Data;
using NTwain.Values;
using System;

namespace NTwain.Triplets
{
	public sealed class StatusUtf8 : OpBase
	{
		internal StatusUtf8(ITwainSessionInternal session) : base(session) { }
		/// <summary>
		/// Translate the contents of a TW_STATUS structure received from a Source into a localized UTF-8
		/// encoded string.
		/// </summary>
		/// <param name="status">The status.</param>
		/// <returns></returns>
		public ReturnCode Get(TWStatusUtf8 status)
		{
			Session.VerifyState(3, 7, DataGroups.Control, DataArgumentType.StatusUtf8, Message.Get);
			return PInvoke.DsmEntry(Session.AppId, null, Message.Get, status);
		}
	}
}