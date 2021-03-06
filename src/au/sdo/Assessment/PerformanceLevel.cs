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
using OpenADK.Library.au.Common;

namespace OpenADK.Library.au.Assessment{

/// <summary>A PerformanceLevel</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.4</para>
/// </remarks>
[Serializable]
public class PerformanceLevel : SifKeyedElement
{
	/// <summary>
	/// Creates an instance of a PerformanceLevel
	/// </summary>
	public PerformanceLevel() : base ( AssessmentDTD.PERFORMANCELEVEL ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="levelName">The name of the performance level.</param>
	///
	public PerformanceLevel( string levelName ) : base( AssessmentDTD.PERFORMANCELEVEL )
	{
		this.LevelName = levelName;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected PerformanceLevel( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { AssessmentDTD.PERFORMANCELEVEL_LEVELNAME }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>LevelName</c> attribute.
	/// </summary>
	/// <value> The <c>LevelName</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The name of the performance level."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public string LevelName
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.PERFORMANCELEVEL_LEVELNAME ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.PERFORMANCELEVEL_LEVELNAME, new SifString( value ), value );
		}
	}

	///<summary>Sets the value of the <c>&lt;CutScores&gt;</c> element.</summary>
	/// <param name="ScoreMetric">The metric or scale used to report the scores.</param>
	///<remarks>
	/// <para>This form of <c>setCutScores</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>CutScores</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public void SetCutScores( AUCodeSetsAssessmentReportingMethodType ScoreMetric ) {
		RemoveChild( AssessmentDTD.PERFORMANCELEVEL_CUTSCORES);
		AddChild( AssessmentDTD.PERFORMANCELEVEL_CUTSCORES, new CutScores( ScoreMetric ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;CutScores&gt;</c> element.
	/// </summary>
	/// <value> A CutScores </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "Score bounds for the performance level."</para>
	/// <para>To remove the <c>CutScores</c>, set <c>CutScores</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public CutScores CutScores
	{
		get
		{
			return (CutScores)GetChild( AssessmentDTD.PERFORMANCELEVEL_CUTSCORES);
		}
		set
		{
			RemoveChild( AssessmentDTD.PERFORMANCELEVEL_CUTSCORES);
			if( value != null)
			{
				AddChild( AssessmentDTD.PERFORMANCELEVEL_CUTSCORES, value );
			}
		}
	}

}}
