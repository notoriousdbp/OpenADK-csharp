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
	/// Defines the set of values that can be specified whenever an EALAcquisition
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  an EALAcquisition object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	[Serializable]
	public class EALAcquisition : SifEnum
	{
	/// <summary>New to English ("A")</summary>
	public static readonly EALAcquisition A_NEW_TO_ENGLISH = new EALAcquisition("A");

	/// <summary>Developing Competence ("C")</summary>
	public static readonly EALAcquisition C_DEVELOPING_COMPETENCE = new EALAcquisition("C");

	/// <summary>Early Acquisition ("B")</summary>
	public static readonly EALAcquisition B_EARLY_ACQUISITION = new EALAcquisition("B");

	/// <summary>Fluent ("E")</summary>
	public static readonly EALAcquisition E_FLUENT = new EALAcquisition("E");

	/// <summary>Not Applicable ("0")</summary>
	public static readonly EALAcquisition C0_NA = new EALAcquisition("0");

	/// <summary>Competent ("D")</summary>
	public static readonly EALAcquisition D_COMPETENT = new EALAcquisition("D");

	///<summary>Wrap an arbitrary string value in an EALAcquisition object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static EALAcquisition Wrap( String wrappedValue ) {
		return new EALAcquisition( wrappedValue );
	}

	private EALAcquisition( string enumDefValue ) : base( enumDefValue ) {}
	}
}
