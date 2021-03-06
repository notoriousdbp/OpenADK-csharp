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

/// <summary>An AssessmentSections</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.6</para>
/// </remarks>
[Serializable]
public class AssessmentSections : SifList<AssessmentSection>
{
	/// <summary>
	/// Creates an instance of an AssessmentSections
	/// </summary>
	public AssessmentSections() : base ( AssessmentDTD.ASSESSMENTSECTIONS ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="assessmentSection">A single section</param>
	///
	public AssessmentSections( AssessmentSection assessmentSection ) : base( AssessmentDTD.ASSESSMENTSECTIONS )
	{
		this.SafeAddChild( AssessmentDTD.ASSESSMENTSECTIONS_ASSESSMENTSECTION, assessmentSection );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected AssessmentSections( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public  IElementDef[] KeyFields {
		get { return new IElementDef[] { AssessmentDTD.ASSESSMENTSECTIONS_ASSESSMENTSECTION }; }
	}

	///<summary>Adds the value of the <c>&lt;AssessmentSection&gt;</c> element.</summary>
	/// <param name="AssessmentSectionRefId">The reference to an Assessment Section object.</param>
	/// <param name="AssessmentSectionSequence">A numeric sequence in which the section will be presented to the test taker. This should be a simple integer sequence number (1,2,3, etc.) but may be other values that can be sorted into sequence (e.g., S-A, S-B, S-C, etc).</param>
	///<remarks>
	/// <para>This form of <c>setAssessmentSection</c> is provided as a convenience method
	/// that is functionally equivalent to the method <c>AddAssessmentSection</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public void AddAssessmentSection( string AssessmentSectionRefId, string AssessmentSectionSequence ) {
		AddChild( AssessmentDTD.ASSESSMENTSECTIONS_ASSESSMENTSECTION, new AssessmentSection( AssessmentSectionRefId, AssessmentSectionSequence ) );
	}

}}
