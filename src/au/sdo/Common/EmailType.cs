// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.au.Common
{
	///<summary>
	/// Defines the set of values that can be specified whenever an EmailType
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  an EmailType object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	[Serializable]
	public class EmailType : SifEnum
	{
	/// <summary>Primary ("01")</summary>
	public static readonly EmailType PRIMARY = new EmailType("01");

	/// <summary>Work ("06")</summary>
	public static readonly EmailType WORK = new EmailType("06");

	/// <summary>Alternate4 ("05")</summary>
	public static readonly EmailType ALTERNATE4 = new EmailType("05");

	/// <summary>Alternate3 ("04")</summary>
	public static readonly EmailType ALTERNATE3 = new EmailType("04");

	/// <summary>Alternate2 ("03")</summary>
	public static readonly EmailType ALTERNATE2 = new EmailType("03");

	/// <summary>Personal ("07")</summary>
	public static readonly EmailType PERSONAL = new EmailType("07");

	/// <summary>Alternate1 ("02")</summary>
	public static readonly EmailType ALTERNATE1 = new EmailType("02");

	///<summary>Wrap an arbitrary string value in an EmailType object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static EmailType Wrap( String wrappedValue ) {
		return new EmailType( wrappedValue );
	}

	private EmailType( string enumDefValue ) : base( enumDefValue ) {}
	}
}