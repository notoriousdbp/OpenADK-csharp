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

/// <summary>A ScoreSif3</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.6</para>
/// </remarks>
[Serializable]
public class ScoreSif3 : SifKeyedElement
{
	/// <summary>
	/// Creates an instance of a ScoreSif3
	/// </summary>
	public ScoreSif3() : base ( AssessmentDTD.SCORESIF3 ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="assessmentSubTestRefId">References the AssessmentSubTest that defines the score.</param>
	///<param name="scoreValue">Value of the score</param>
	///
	public ScoreSif3( string assessmentSubTestRefId, string scoreValue ) : base( AssessmentDTD.SCORESIF3 )
	{
		this.AssessmentSubTestRefId = assessmentSubTestRefId;
		this.ScoreValue = scoreValue;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected ScoreSif3( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { AssessmentDTD.SCORESIF3_ASSESSMENTSUBTESTREFID }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>AssessmentSubTestRefId</c> attribute.
	/// </summary>
	/// <value> The <c>AssessmentSubTestRefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "References the AssessmentSubTest that defines the score."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string AssessmentSubTestRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.SCORESIF3_ASSESSMENTSUBTESTREFID ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.SCORESIF3_ASSESSMENTSUBTESTREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;PreliminaryIndicator&gt;</c> element.
	/// </summary>
	/// <value> The <c>PreliminaryIndicator</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "If this score is preliminary, then this attribute value should be set. Preliminary scores may be provided for early use by the assessment program or user while final scoring is occurring."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string PreliminaryIndicator
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.SCORESIF3_PRELIMINARYINDICATOR ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.SCORESIF3_PRELIMINARYINDICATOR, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ScoreValue&gt;</c> element.
	/// </summary>
	/// <value> The <c>ScoreValue</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Value of the score"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string ScoreValue
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.SCORESIF3_SCOREVALUE ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.SCORESIF3_SCOREVALUE, new SifString( value ), value );
		}
	}

}}