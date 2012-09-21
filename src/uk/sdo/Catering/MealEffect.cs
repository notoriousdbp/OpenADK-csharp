// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.uk.Catering
{
	///<summary>
	/// Defines the set of values that can be specified whenever a MealEffect
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a MealEffect object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	[Serializable]
	public class MealEffect : SifEnum
	{
	/// <summary>Exclude ("Exclude")</summary>
	public static readonly MealEffect EXCLUDE = new MealEffect("Exclude");

	/// <summary>Include ("Include")</summary>
	public static readonly MealEffect INCLUDE = new MealEffect("Include");

	///<summary>Wrap an arbitrary string value in a MealEffect object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static MealEffect Wrap( String wrappedValue ) {
		return new MealEffect( wrappedValue );
	}

	private MealEffect( string enumDefValue ) : base( enumDefValue ) {}
	}
}