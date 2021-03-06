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

/// <summary>A Feedback</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.6</para>
/// </remarks>
[Serializable]
public class Feedback : SifKeyedElement
{
	/// <summary>
	/// Creates an instance of a Feedback
	/// </summary>
	public Feedback() : base ( AssessmentDTD.FEEDBACK ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="diagnosticStatement">If this derived score can also provide diagnostic statements to the student or teacher, then provide that information here.</param>
	///
	public Feedback( string diagnosticStatement ) : base( AssessmentDTD.FEEDBACK )
	{
		this.DiagnosticStatement = diagnosticStatement;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected Feedback( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { AssessmentDTD.FEEDBACK_DIAGNOSTICSTATEMENT }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;DiagnosticStatement&gt;</c> element.
	/// </summary>
	/// <value> The <c>DiagnosticStatement</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "If this derived score can also provide diagnostic statements to the student or teacher, then provide that information here."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string DiagnosticStatement
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.FEEDBACK_DIAGNOSTICSTATEMENT ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.FEEDBACK_DIAGNOSTICSTATEMENT, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Description&gt;</c> element.
	/// </summary>
	/// <value> The <c>Description</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "A brief additional information concerning the derived score can be provided here."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string Description
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.FEEDBACK_DESCRIPTION ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.FEEDBACK_DESCRIPTION, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Source&gt;</c> element.
	/// </summary>
	/// <value> The <c>Source</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Indicates the source of this feedback. Values will be determined by the assessment program."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string Source
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.FEEDBACK_SOURCE ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.FEEDBACK_SOURCE, new SifString( value ), value );
		}
	}

}}
