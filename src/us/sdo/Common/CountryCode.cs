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
	/// Defines the set of values that can be specified whenever a CountryCode
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a CountryCode object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	[Serializable]
	public class CountryCode : SifEnum
	{
	/// <summary>Australia ("AU")</summary>
	public static readonly CountryCode AU = new CountryCode("AU");

	/// <summary>Isle of Man ("IM")</summary>
	public static readonly CountryCode IM = new CountryCode("IM");

	/// <summary>Canada ("CA")</summary>
	public static readonly CountryCode CA = new CountryCode("CA");

	/// <summary>United States Minor Outlying Islands ("UM")</summary>
	public static readonly CountryCode UM = new CountryCode("UM");

	/// <summary>United Kingdom ("GB")</summary>
	public static readonly CountryCode GB = new CountryCode("GB");

	/// <summary>United States of America ("US")</summary>
	public static readonly CountryCode US = new CountryCode("US");

	/// <summary>Ireland ("IE")</summary>
	public static readonly CountryCode IE = new CountryCode("IE");

	///<summary>Wrap an arbitrary string value in a CountryCode object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static CountryCode Wrap( String wrappedValue ) {
		return new CountryCode( wrappedValue );
	}

	private CountryCode( string enumDefValue ) : base( enumDefValue ) {}
	}
}
