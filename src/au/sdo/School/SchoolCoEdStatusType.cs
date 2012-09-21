// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.au.School
{
	///<summary>
	/// Defines the set of values that can be specified whenever a SchoolCoEdStatusType
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a SchoolCoEdStatusType object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	[Serializable]
	public class SchoolCoEdStatusType : SifEnum
	{
	/// <summary>Female ("F")</summary>
	public static readonly SchoolCoEdStatusType F_FEMALE = new SchoolCoEdStatusType("F");

	/// <summary>Male ("M")</summary>
	public static readonly SchoolCoEdStatusType M_MALE = new SchoolCoEdStatusType("M");

	/// <summary>Co-Educational ("C")</summary>
	public static readonly SchoolCoEdStatusType C_COEDUCATIONAL = new SchoolCoEdStatusType("C");

	///<summary>Wrap an arbitrary string value in a SchoolCoEdStatusType object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static SchoolCoEdStatusType Wrap( String wrappedValue ) {
		return new SchoolCoEdStatusType( wrappedValue );
	}

	private SchoolCoEdStatusType( string enumDefValue ) : base( enumDefValue ) {}
	}
}