// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.us.Reporting
{
	///<summary>
	/// Defines the set of values that can be specified whenever a RequestingAgencyIdType
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a RequestingAgencyIdType object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	[Serializable]
	public class RequestingAgencyIdType : SifEnum
	{
	/// <summary>Educational Services Agency ("ESA")</summary>
	public static readonly RequestingAgencyIdType ESA = new RequestingAgencyIdType("ESA");

	/// <summary>School ("School")</summary>
	public static readonly RequestingAgencyIdType SCHOOL = new RequestingAgencyIdType("School");

	/// <summary>Local Educational Agency (District) ("LEA")</summary>
	public static readonly RequestingAgencyIdType LEA = new RequestingAgencyIdType("LEA");

	///<summary>Wrap an arbitrary string value in a RequestingAgencyIdType object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static RequestingAgencyIdType Wrap( String wrappedValue ) {
		return new RequestingAgencyIdType( wrappedValue );
	}

	private RequestingAgencyIdType( string enumDefValue ) : base( enumDefValue ) {}
	}
}
