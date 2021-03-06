// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.uk.Common
{
	///<summary>
	/// Defines the set of values that can be specified whenever a SourceOfCode
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a SourceOfCode object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	[Serializable]
	public class SourceOfCode : SifEnum
	{
	/// <summary>Other ("O")</summary>
	public static readonly SourceOfCode OTHER = new SourceOfCode("O");

	/// <summary>Ascribed by a previous school ("T")</summary>
	public static readonly SourceOfCode PREVIOUS_SCHOOL = new SourceOfCode("T");

	/// <summary>Provided by the parent ("P")</summary>
	public static readonly SourceOfCode PARENT = new SourceOfCode("P");

	/// <summary>Ascribed by the current school ("S")</summary>
	public static readonly SourceOfCode CURRENT_SCHOOL = new SourceOfCode("S");

	/// <summary>Provided by the child (ie pupil) ("C")</summary>
	public static readonly SourceOfCode CHILD = new SourceOfCode("C");

	///<summary>Wrap an arbitrary string value in a SourceOfCode object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static SourceOfCode Wrap( String wrappedValue ) {
		return new SourceOfCode( wrappedValue );
	}

	private SourceOfCode( string enumDefValue ) : base( enumDefValue ) {}
	}
}
