// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using System.Text;
using System.Security.Permissions;
using System.Runtime.Serialization;
using OpenADK.Library;
using OpenADK.Library.Global;
using OpenADK.Library.us.Common;

namespace OpenADK.Library.us.Assessment{

/// <summary>A TraitScore</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.6</para>
/// </remarks>
[Serializable]
public class TraitScore : SifElement
{
	/// <summary>
	/// Creates an instance of a TraitScore
	/// </summary>
	public TraitScore() : base ( AssessmentDTD.TRAITSCORE ){}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected TraitScore( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets or sets the value of the <c>&lt;TraitScoreType&gt;</c> element.
	/// </summary>
	/// <value> The <c>TraitScoreType</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "If trait scores are provided, then this identifies the specific trait score that is provided. This value will be program specific (i.e. no standardized list of values available)."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string TraitScoreType
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.TRAITSCORE_TRAITSCORETYPE ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.TRAITSCORE_TRAITSCORETYPE, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;TraitScoreValue&gt;</c> element.
	/// </summary>
	/// <value> The <c>TraitScoreValue</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "This will be the numeric trait score value."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string TraitScoreValue
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.TRAITSCORE_TRAITSCOREVALUE ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.TRAITSCORE_TRAITSCOREVALUE, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;TraitScoreCode&gt;</c> element.
	/// </summary>
	/// <value> The <c>TraitScoreCode</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "If there is a code associated with the trait score, then this will allow for identifying the code."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string TraitScoreCode
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.TRAITSCORE_TRAITSCORECODE ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.TRAITSCORE_TRAITSCORECODE, new SifString( value ), value );
		}
	}

}}