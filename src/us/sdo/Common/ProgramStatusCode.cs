// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.us.Common
{
	///<summary>
	/// Defines the set of values that can be specified whenever a ProgramStatusCode
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a ProgramStatusCode object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	[Serializable]
	public class ProgramStatusCode : SifEnum
	{
	/// <summary>Other ("9999")</summary>
	public static readonly ProgramStatusCode OTHER = new ProgramStatusCode("9999");

	/// <summary>Withdrew/refused ("S006")</summary>
	public static readonly ProgramStatusCode WITHDREW_OR_REFUSED = new ProgramStatusCode("S006");

	/// <summary>Not Eligible ("S003")</summary>
	public static readonly ProgramStatusCode NOT_ELIGIBLE = new ProgramStatusCode("S003");

	/// <summary>Active ("S004")</summary>
	public static readonly ProgramStatusCode ACTIVE = new ProgramStatusCode("S004");

	/// <summary>Referred ("S001")</summary>
	public static readonly ProgramStatusCode REFERRED = new ProgramStatusCode("S001");

	/// <summary>Exited ("S005")</summary>
	public static readonly ProgramStatusCode EXITED = new ProgramStatusCode("S005");

	/// <summary>Eligible ("S002")</summary>
	public static readonly ProgramStatusCode ELIGIBLE = new ProgramStatusCode("S002");

	///<summary>Wrap an arbitrary string value in a ProgramStatusCode object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static ProgramStatusCode Wrap( String wrappedValue ) {
		return new ProgramStatusCode( wrappedValue );
	}

	private ProgramStatusCode( string enumDefValue ) : base( enumDefValue ) {}
	}
}