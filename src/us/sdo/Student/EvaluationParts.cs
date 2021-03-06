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

namespace OpenADK.Library.us.Student{

/// <summary>An EvaluationParts</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.6</para>
/// </remarks>
[Serializable]
public class EvaluationParts : SifList<EvaluationPart>
{
	/// <summary>
	/// Creates an instance of an EvaluationParts
	/// </summary>
	public EvaluationParts() : base ( StudentDTD.EVALUATIONPARTS ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="evaluationPart">Container for parts of the evaluation</param>
	///
	public EvaluationParts( EvaluationPart evaluationPart ) : base( StudentDTD.EVALUATIONPARTS )
	{
		this.SafeAddChild( StudentDTD.EVALUATIONPARTS_EVALUATIONPART, evaluationPart );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected EvaluationParts( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public  IElementDef[] KeyFields {
		get { return new IElementDef[] { StudentDTD.EVALUATIONPARTS_EVALUATIONPART }; }
	}

	///<summary>Adds the value of the <c>&lt;EvaluationPart&gt;</c> element.</summary>
	/// <param name="Name">This is the name of a part that could receive a score.</param>
	/// <param name="Score">This is a subscore that is part of the evaluation.</param>
	/// <param name="Scale">This is the scale for the Subscore that is part of the evaluation.</param>
	///<remarks>
	/// <para>This form of <c>setEvaluationPart</c> is provided as a convenience method
	/// that is functionally equivalent to the method <c>AddEvaluationPart</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public void AddEvaluationPart( NameEvaluation Name, ScoreEvaluation Score, ScaleEvaluation Scale ) {
		AddChild( StudentDTD.EVALUATIONPARTS_EVALUATIONPART, new EvaluationPart( Name, Score, Scale ) );
	}

}}
